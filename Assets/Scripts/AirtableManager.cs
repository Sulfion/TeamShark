using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirtableManager : MonoBehaviour
{
    public CreateRecord createRecord;

    public string tableName;

    public string dummyStringOne;
    public string dummyStringTwo;
    public string dummyStringThree;
    public string dummyStringFour;
    public string dummyStringFive;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetString("AllEggsFound", "AllEggsFound");
        //Debug.Log(PlayerPrefs.GetString("AllEggsFound"));
        //PlayerPrefs.DeleteAll();
        dummyStringOne = PlayerPrefs.GetString("AllEggsFound");
    }

    public void LogRecordOnAirtable()
    {
        createRecord.TableName = tableName;
        createRecord.NewRecordJson = "{\"fields\": {" +
                                     "\"FieldOne\":\"" + dummyStringOne + "\", " +
                                     "\"FieldTwo\":\"" + dummyStringTwo + "\", " +
                                     "\"FieldThree\":\"" + dummyStringTwo + "\", " +
                                     "\"FieldFour\":\"" + dummyStringTwo + "\", " +
                                     "\"FieldFive\":\"" + dummyStringThree + "\"" +
                                     "}}";
        createRecord.CreateAirtableRecord();



    }
}
