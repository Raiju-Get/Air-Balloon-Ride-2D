
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    [SerializeField] private CameraController cameraController;
    [SerializeField] private GameObject[] resetUI = new GameObject[2];
 

    public void Restart()
    {
        cameraController.enabled = false;
        foreach (var t in resetUI)
        {
            t.SetActive(false);
        }
        Time.timeScale = 1;
        
    }

 

 

}
