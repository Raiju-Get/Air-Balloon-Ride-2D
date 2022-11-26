using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionGenerator : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private TextMeshProUGUI[] options = new TextMeshProUGUI[2];

    public void GetQuestion(DataSet dataSet)
    {
        questionText.text = dataSet.question;
        List<string> answerList = ShuffleList.ShuffleListItems<string>(dataSet.answer.ToList());
        for (int i = 0; i < options.Length; i++)
        {
            options[i].text = answerList[i];
        }
    }
}
