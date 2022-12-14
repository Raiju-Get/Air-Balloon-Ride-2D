using Script;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class InputManager : MonoBehaviour
{

  [SerializeField] private string correctAnswer;
  [SerializeField] private GameManager gameManager;
  [SerializeField] private AudioPlayer audioPlayer;
  [FormerlySerializedAs("_audioClipCorrect")] [SerializeField] private AudioClip audioClipCorrect;
  [FormerlySerializedAs("_audioClipIncorrect")] [SerializeField] private AudioClip audioClipIncorrect;

  public void GetAnswer(TextMeshProUGUI answer)
  {
    if (answer.text == correctAnswer)
    { 
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
