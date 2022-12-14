using UnityEngine;


public class RivalScript : MonoBehaviour
{

    [SerializeField] private BalloonController balloonController;
    [SerializeField] private Rigidbody2D rivalPhysic2D;
    [SerializeField] private float jumpForce;
    [SerializeField] private AnswerRate answerPercentage;
    [SerializeField] private float maxVelocity;
    [SerializeField] private float sqrMaxVelocity;
    [SerializeField] private Animator _animator;

    enum AnswerRate
    {
        Hundred,
        Ninety,
        Eighty,
        Seventy,
        Sixty,
        Fifty
    }
    private void Awake()
    {
        SetMaxVelocity(maxVelocity);
    }
    

    void SetMaxVelocity(float maxVelocity)
    {
        this.maxVelocity = maxVelocity;
        sqrMaxVelocity = maxVelocity * maxVelocity;
    }
    private void FixedUpdate()
    {
        var velocity = rivalPhysic2D.velocity;
        if (velocity.sqrMagnitude>sqrMaxVelocity)
        {
            rivalPhysic2D.velocity = velocity.normalized * maxVelocity;
        }
    }
    void RivalController()
    {
        balloonController.BalloonFloat(rivalPhysic2D,jumpForce);
        balloonController.SquishBallon(_animator);
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
            case AnswerRate.Sixty:
                if (odds <=5)
                {
                    RivalController();
                }
                break;
            case  AnswerRate.Fifty:
                if (odds<=4)
                {
                    RivalController();
                }
                break;
        }
      
    }

}
