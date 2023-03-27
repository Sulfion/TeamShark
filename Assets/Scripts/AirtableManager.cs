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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LogRecordOnAirtable()
    {
        createRecord.TableName = tableName;
        createRecord.NewRecordJson = "{\"fields\": {" +
                                     "\"Dummy1\":\"" + dummyStringOne + "\", " +
                                     "\"Dummy2\":\"" + dummyStringTwo + "\", " +
                                     "\"Dummy3\":\"" + dummyStringThree + "\"" +
                                     "}}";
        createRecord.CreateAirtableRecord();

    }
}
