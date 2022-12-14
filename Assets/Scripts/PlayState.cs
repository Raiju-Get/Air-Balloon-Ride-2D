
using UnityEngine;

public class PlayState : GameStateMachine
{
  public override void EnterState(GameManager manager)
  {
    manager.AnswerSet.GetData();
    Time.timeScale = 1;
  }

  public override void RefreshState(GameManager manager, bool correct)
  {
    if (correct)
    {
      manager.AnswerSet.GetData();
      manager.PlayerController.FlightController();
    }
    else
    {
      manager.AnswerSet.GetData();
    }
 
  }

  public override void UpdateGameState(GameManager manager)
  {
    
   // manager.PlaceTracker.PlacementTracker();
    manager.Timer -= Time.deltaTime;
    if (manager.Timer <= 0 && manager.CurrentState == manager.PlayState)
    {
      
      foreach (var t in manager.RivalScript)
      {
        t.AiFunction();
      }
      manager.Timer = manager.TempTimer;
    
    }
    
  }

  public override void TransitionState(GameManager manager)
  {
   
    Time.timeScale = 1;
  }

  public override void EndState(GameManager manager)
  {
    
  }
}
