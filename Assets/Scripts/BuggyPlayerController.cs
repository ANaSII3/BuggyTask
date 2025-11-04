using UnityEngine; //nie było znaku na końcu 
using static UnityEngine.RuleTile.TilingRuleOutput;



public class BuggyPlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;//nie poprawna nazwa speed, brak znaku na końcu


    private float moveInput;
    public Rigidbody2D rb;//byłi nie poprawnie zapisane
    public Animator anim;//byłi nie poprawnie zapisane
    public SpriteRenderer spriteRenderer;
    public GroundChecker groundChecker;
    private bool IsMove;

    //wszystkie inne funkcji dopisałam samodzielnie żeby kod w pełności dzialał

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        anim = GetComponent<Animator>();

        //byłi nie poprawnie zapisane, spriteRenderer do animacji 
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");//brak znaku na końcu, "HORIZENTAL" :)

        if(moveInput != 0)
        {
            anim.SetBool("IsMove", true);  //brak znaku na końcu
        }
        else
        {
            anim.SetBool("IsMove", false);
        }

        //flip
        if (moveInput < -0.01f)
        {
            spriteRenderer.flipX = true;
        }

        else if (moveInput > 0.01f)

        {
            spriteRenderer.flipX = false;
        }

    }

    void FixedUpdate() //sekcji FixedUpdate w ogółe nie istniało
    {
        if (moveInput > 0)//moveInputS, brak nawiasów klamrowych
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else if (moveInput < 0)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

    }

}












