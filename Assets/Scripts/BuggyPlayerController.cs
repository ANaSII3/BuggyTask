using UnityEngine

public class BuggyPlayerController : MonoBehaviour
{
    private float speed = 5f
                            Rigidbody2D rb
    Animator anim

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
            anim == GetComponent<Animator>()
    }
}
    void Update()
    {
        float moveInput = Input.GetAxis("Horizental")
    
            if (moveInputs > 0)
                                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        else if (moveInput < 0)
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        
                     anim.SetBool("isMoving", moveInput != 0)
    }
}