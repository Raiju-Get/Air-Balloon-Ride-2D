using Script;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class InputManager : MonoBehaviour
{

  [SerializeField] private string correctAnswer;
  [SerializeField] private GameManager gameManager;
  [SerializeField] private AudioPlayer audioPlayer;
  [SerializeField] private AudioClip audioClipCorrect;
  [SerializeField] private AudioClip audioClipIncorrect;
  [SerializeField] private ButtonDeactivator buttonDeactivator;

  public void GetAnswer(TextMeshProUGUI answer)
  {
     IExample child = new ChildClass();
     child.run();

     IExample ssecondClid = new SecondChild();
     ssecondClid.run();
    if (answer.text == correctAnswer)
    { 
      if (gameManager.isTutorial)
      {
     
        gameManager.CorrectAnswerPointer.SetActive(false);
        buttonDeactivator.ActivateButtons();
        gameManager.TutorialText.gameObject.SetActive(false);
        gameManager.isTutorial = false;
        
      }
      gameManager.PlayState.RefreshState(gameManager, true);
      audioPlayer.Play(audioClipCorrect);
    
    }
    else
    {
      gameManager.PlayState.RefreshState(gameManager, false);
      audioPlayer.Play(audioClipIncorrect
      );
    }
    
  }
  public void GetAnswerString(string answer)
  {
    correctAnswer = answer;
  }
}
