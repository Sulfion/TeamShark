using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SebPref : MonoBehaviour
{
    public AirtableManager airtableManager;
    //public QuestionOne questionOne;



    public void PlayerPrefsTest()
    {
        PlayerPrefs.SetInt("DataCollectionQ1", 5);
        PlayerPrefs.SetInt("DataCollectionQ2", 7);
        PlayerPrefs.SetInt("DataCollectionQ3", 6);

        airtableManager.UpdateFromPlayerPrefs();

        airtableManager.LogRecordOnAirtable();

    }
}
