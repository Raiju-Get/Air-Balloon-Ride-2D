using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{

  [SerializeField] private string correctAnswer;
  [SerializeField] private GameManager gameManager;

  public void GetAnswer(TextMeshProUGUI answer)
  {
    if (gameManager.Lives >=0)
    {
      if (answer.text == correctAnswer)
      { 
        gameManager.PlayState.RefreshState(gameManager);
      }
      else
      {
        gameManager.Lives--;
      }
    }
  }
  public void GetAnswerString(string answer)
  {
    correctAnswer = answer;
  }
}
