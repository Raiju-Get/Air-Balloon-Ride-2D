using UnityEngine;


public class RivalScript : MonoBehaviour
{

    [SerializeField] private BalloonController balloonController;
    [SerializeField] private Rigidbody2D rivalPhysic2D;
    [SerializeField] private float jumpForce;
    [SerializeField] private AnswerRate answerPercentage;

    enum AnswerRate
    {
        Hundred,
        Ninety,
        Eighty,
        Seventy
    }
    

    void RivalController()
    {
        balloonController.BalloonFloat(rivalPhysic2D,jumpForce);
    }

    public void StopVelocity()
    {
        rivalPhysic2D.velocity = Vector2.zero;
    }

    public void AiFunction()
    {
        int odds = Random.Range(0, 10);
        switch (answerPercentage)
        {
            case AnswerRate.Hundred:
                RivalController();
                break;
            case AnswerRate.Ninety:
                if (odds <= 8)
                {
                    RivalController();
                }
                break;
            case AnswerRate.Eighty:
                if (odds <= 7)
                {
                    RivalController();
                }
                break;
            case AnswerRate.Seventy:
                if (odds <= 6)
                {
                    RivalController();
                }
                break;
           
        }
      
    }

}
