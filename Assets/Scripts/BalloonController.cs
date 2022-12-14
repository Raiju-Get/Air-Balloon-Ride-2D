using UnityEngine;

public class BalloonController : MonoBehaviour
{
    [SerializeField] private float yMax;
    [SerializeField] private float floatTimer;

    

    public void BalloonFloat(Rigidbody2D balloon, float jumpSpeed )
    {
        if (balloon.position.y >= yMax)
        {
            balloon.gravityScale = 0;
            balloon.velocity = Vector2.zero;
        }
        else
        {
             balloon.AddForce(new Vector2(balloon.velocity.x,jumpSpeed),ForceMode2D.Impulse);
        }
    }

    public void SquishBallon(Animator animator)
    {
        animator.SetTrigger("Squish");
    }


}
