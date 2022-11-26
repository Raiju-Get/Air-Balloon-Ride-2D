using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnswerSet : MonoBehaviour
{
    [SerializeField] private DataSet[] questionSet = new DataSet[10];
    [SerializeField] private QuestionGenerator questionGenerator;
    [SerializeField] private InputManager inputManager;
    
    public void GetData()
    {
        int randomQuestion = Random.Range(0, (questionSet.Length));
        questionGenerator.GetQuestion(questionSet[randomQuestion]);
        inputManager.GetAnswerString(questionSet[randomQuestion].answer[questionSet[randomQuestion].correctIndex]);
    }
}
[Serializable]
public struct DataSet
{
    [Range(0,1)]
    public int correctIndex;
    public string question;
    public string[] answer;

}