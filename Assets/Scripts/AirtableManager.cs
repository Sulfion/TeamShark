using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirtableManager : MonoBehaviour
{
    public CreateRecord createRecord;

    public Button submitButton;

    public string tableName;

    public int sceneOneCorrectAnswers;
    public int sceneOneIncorrectAnswers;
    public float sceneOnePlayTime;
    public int sceneTwoCorrectGuesses;
    public int sceneTwoIncorrectGuesses;
    public string allEggsFound;
    public float examinationDuration;
    public int examCorrectGuesses;
    public int examIncorrectGuesses;
    public int dataCollectionQ1;
    public int dataCollectionQ2;
    public int dataCollectionQ3;



    // Start is called before the first frame update
    void Start()
    {
        Button btn = submitButton.GetComponent<Button>();
        btn.onClick.AddListener(LogRecordOnAirtable);

        sceneOneCorrectAnswers = PlayerPrefs.GetInt("SceneOneCorrectAnswers");
        sceneOneIncorrectAnswers = PlayerPrefs.GetInt("SceneOneIncorrectAnswers");
        sceneOnePlayTime = PlayerPrefs.GetFloat("SceneOnePlayTime");
        sceneTwoCorrectGuesses = PlayerPrefs.GetInt("SceneTwoCorrectGuesses");
        sceneTwoIncorrectGuesses = PlayerPrefs.GetInt("SceneTwoIncorrectGuesses");
        allEggsFound = PlayerPrefs.GetString("AllEggsFound");
        examinationDuration = PlayerPrefs.GetFloat("ExaminationDuration");
        examCorrectGuesses = PlayerPrefs.GetInt("ExamCorrectGuesses");
        examIncorrectGuesses = PlayerPrefs.GetInt("ExamIncorrectGuesses");
        dataCollectionQ1 = PlayerPrefs.GetInt("DataCollectionQ1");
        dataCollectionQ2 = PlayerPrefs.GetInt("DataCollectionQ2");
        dataCollectionQ3 = PlayerPrefs.GetInt("DataCollectionQ3");
    }

    public void UpdateFromPlayerPrefs()
    {
        sceneOneCorrectAnswers = PlayerPrefs.GetInt("SceneOneCorrectAnswers");
        sceneOneIncorrectAnswers = PlayerPrefs.GetInt("SceneOneIncorrectAnswers");
        sceneOnePlayTime = PlayerPrefs.GetFloat("SceneOnePlayTime");
        sceneTwoCorrectGuesses = PlayerPrefs.GetInt("SceneTwoCorrectGuesses");
        sceneTwoIncorrectGuesses = PlayerPrefs.GetInt("SceneTwoIncorrectGuesses");
        allEggsFound = PlayerPrefs.GetString("AllEggsFound");
        examinationDuration = PlayerPrefs.GetFloat("ExaminationDuration");
        examCorrectGuesses = PlayerPrefs.GetInt("ExamCorrectGuesses");
        examIncorrectGuesses = PlayerPrefs.GetInt("ExamIncorrectGuesses");
        dataCollectionQ1 = PlayerPrefs.GetInt("DataCollectionQ1");
        dataCollectionQ2 = PlayerPrefs.GetInt("DataCollectionQ2");
        dataCollectionQ3 = PlayerPrefs.GetInt("DataCollectionQ3");
    }

    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("DataCollectionQ1"));
    }

    public void LogRecordOnAirtable()
    {
        UpdateFromPlayerPrefs();
        createRecord.TableName = tableName;
        createRecord.NewRecordJson = "{\"fields\": {" +
                                     "\"SceneOneCorrectAnswers\":\"" + sceneOneCorrectAnswers + "\", " +
                                     "\"SceneOneIncorrectAnswers\":\"" + sceneOneIncorrectAnswers + "\", " +
                                     "\"SceneOnePlayTime\":\"" + sceneOnePlayTime + "\", " +
                                     "\"SceneTwoCorrectGuesses\":\"" + sceneTwoCorrectGuesses + "\", " +
                                     "\"SceneTwoIncorrectGuesses\":\"" + sceneTwoIncorrectGuesses + "\", " +
                                     "\"AllEggsFound\":\"" + allEggsFound + "\", " +
                                     "\"ExaminationDuration\":\"" + examinationDuration + "\", " +
                                     "\"ExamCorrectGuesses\":\"" + examCorrectGuesses + "\", " +
                                     "\"ExamIncorrectGuesses\":\"" + examIncorrectGuesses + "\", " +
                                     "\"DataCollectionQ1\":\"" + dataCollectionQ1 + "\", " +
                                     "\"DataCollectionQ2\":\"" + dataCollectionQ2 + "\", " +
                                     "\"DataCollectionQ3\":\"" + dataCollectionQ3 + "\"" +
                                     "}}";
        createRecord.CreateAirtableRecord();
    }
}
