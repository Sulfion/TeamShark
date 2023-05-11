using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RemainingEggsUpdater : MonoBehaviour
{
    public TextMeshProUGUI remainingEggs;

    public EggCollector eggCollector;

    // Start is called before the first frame update
    void Start()
    {
        remainingEggs = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        remainingEggs.text = (eggCollector.totalEggsCollected + "/8").ToString();
    }
}
