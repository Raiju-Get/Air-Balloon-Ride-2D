using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public struct RacerData
{
    public string name;
    public float location;
}
public class PlaceTracker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] textPlace = new TextMeshProUGUI[4];
    [SerializeField] private GameObject[] playerGameObject = new GameObject[4];
    [SerializeField] public RacerData[] racerDataArray = new RacerData[4];
    [SerializeField] public string[] stringArray = new String[4];
    

    public void PlacementTracker()
    {
        for (int i = 0; i < playerGameObject.Length; i++)
        {
            racerDataArray[i].name = playerGameObject[i].GetComponentInChildren<TextMeshPro>().text;
            racerDataArray[i].location = playerGameObject[i].transform.position.y;
        }

       var data = racerDataArray.OrderBy(l => l.location);
       
        int iteration = 0;
        foreach (var racer in data)
        {
            stringArray[iteration] = racer.name;
            iteration++;
        }

        if (iteration >=4)
        {
            iteration = 0;
        }

        for (int i = 0; i < textPlace.Length; i++)
        {
            textPlace[i].text = stringArray[i];
        }
    }
}

    

