using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Melanchall.DryWetMidi.Smf;
using Melanchall.DryWetMidi.Smf.Interaction;
using System.Linq;
using System;
using UnityEngine.SceneManagement;

public class SaikaEasyBehaviour : MonoBehaviour
{
    // Use this for initialization
    public List<NoteObject> noteList;
    public List<float> noteBeatList;
    int bpm = 123;
    public float secPerBeat;
    public float songpositionbeats;
    public float songpositionbeats2;
    public float dsptimesong;
    public float songposition;
    public float beatsShownInAdvance;
    public int index;
    public AudioSource audioS;
    Note notes;
    public GameObject notePrefab;

    public class NoteObject
    {
        private float noteTime;
        private int noteLength;
        private String noteToPress;

        public NoteObject(float pos, int length, String press)
        {
            noteTime = pos;
            noteLength = length;
            noteToPress = press;
        }

        public float getNoteTime()
        {
            return noteTime;
        }

        public int getNoteLength()
        {
            return noteLength;
        }

        public String getNoteToPress()
        {
            return noteToPress;
        }
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey("Saika High Score"))
        {
            PlayerPrefs.SetInt("Saika High Score", 0);
        }
        Application.targetFrameRate = 300;
        secPerBeat = 60f / bpm;
        String path = Application.dataPath + "/StreamingAssets";
        MidiFile midiFile = MidiFile.Read(path + "/SaikaD.mid");
        TempoMap tempoMap = midiFile.GetTempoMap();
        noteList = new List<NoteObject>();
        noteBeatList = new List<float>();
        var notes = midiFile.GetNotes();
        beatsShownInAdvance = 8f;

        foreach (var note in notes)
        {
            noteList.Add(new NoteObject(
                ((float)note.TimeAs<MetricTimeSpan>(tempoMap).TotalMicroseconds / 1000000),
                0,
                note.NoteName.ToString()));
        }
        for (int i = 0; i < noteList.Count; i++)
        {
            noteBeatList.Add(noteList[i].getNoteTime() / secPerBeat);
        }
        audioS.Play();
        dsptimesong = (float)AudioSettings.dspTime;
    }

    // Update is called once per frame
    void Update()
    {
        songposition = (float)(AudioSettings.dspTime - dsptimesong);
        songpositionbeats = songposition / secPerBeat;
        if (index <= noteBeatList.Count && noteBeatList[index] <= songpositionbeats + beatsShownInAdvance && index < noteBeatList.Count - 1 && Time.timeScale == 1)
        {
            Instantiate(notePrefab, new Vector3(50f, noteBeatList[index], 0f), Quaternion.identity);
            index++;
        }
        if (songposition >= 130)
        {
            PlayerPrefs.SetInt("Saika Current Score", GameManager.instance.score);
            PlayerPrefs.SetInt("Saika Max Combo", GameManager.instance.maxCombo);
            PlayerPrefs.SetInt("Saika Notes Hit", GameManager.instance.notesHit);
            if (PlayerPrefs.GetInt("Saika High Score") < GameManager.instance.score)
            {
                PlayerPrefs.SetInt("Saika HighScore", GameManager.instance.score);
            }
            SceneManager.LoadScene("Saika ScoreScene");
        }
    }
}


