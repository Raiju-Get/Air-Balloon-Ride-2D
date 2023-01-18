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
    [SerializeField] private TextMeshProUGUI[] options = new TextMeshProUGUI[4];
    [SerializeField] private GameManager gameManager;
   

    public void GetQuestion(Questions dataSet)
    {
        questionText.text = dataSet.question;
        string correctAnswer = dataSet.options[0];
        List<string> answerList = ShuffleList.ShuffleListItems<string>(dataSet.options.ToList());
       
        for (int i = 0; i < options.Length; i++)
        {
            options[i].text = answerList[i];
        }
        if (gameManager.isTutorial)
        {
            for (int i = 0; i < options.Length; i++)
            {
                if (options[i].text != correctAnswer)
                {
                    options[i].GetComponentInParent<Button>().interactable = false;
                }
                else
                {
                    gameManager.CorrectAnswerPointer.SetActive(true);
                    gameManager.CorrectAnswerPointer.GetComponent<RectTransform>().position =
                        new Vector3(options[i].GetComponentInParent<RectTransform>().position.x+1f,options[i].GetComponentInParent<RectTransform>().position.y-0.2f,options[i].GetComponentInParent<RectTransform>().position.z);
                }
                
            }
            
        }
       
    }
}
