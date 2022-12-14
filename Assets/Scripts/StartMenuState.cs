using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuState : GameStateMachine
{
    public override void EnterState(GameManager manager)
    {
      
    }


    public override void RefreshState(GameManager manager,bool correct)
    {
        
    }

    public override void UpdateGameState(GameManager manager)
    {
        manager.StartTimer -= Time.deltaTime;
        if (manager.StartTimer > 0)
        {
            if (manager.StartTimer >= 3)
            {
                manager.StartTimerImage.sprite = manager.NewSprite[0];
            }
            else if (manager.StartTimer is >= 2 and <= 3)
            {
                manager.StartTimerImage.sprite = manager.NewSprite[1];
            }
            else if (manager.StartTimer is >= 1 and <= 2)
            {
                manager.StartTimerImage.sprite = manager.NewSprite[2];
            }
            else if(manager.StartTimer is >= 0 and <= 1)
            {
                manager.StartTimerImage.sprite = manager.NewSprite[3];
            }
        }
        else
        {
            manager.StartTimerImage.gameObject.SetActive(false);
            manager.StartTimerPanel.gameObject.SetActive(false);
            manager.SwitchState(manager.PlayState);
            manager.PlayerUI.SetActive(true);
        }

    }

    public override void TransitionState(GameManager manager)
    {
        
    }

    public override void EndState(GameManager manager)
    {
     
    }



}
