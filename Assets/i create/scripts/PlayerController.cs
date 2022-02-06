using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class PlayerController : MonoBehaviourPunCallbacks
{
    public Transform teleport;
    public float speed;
    public float jumpForse;
    public float tut;
    private float moveInput;

    private Rigidbody2D rb;
    public bool FacingRight = true;

    public Joystick Joystick;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Animator anim;
    private PhotonView photonview;

    private void Start()
    {
        photonview = GetComponent<PhotonView>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (!photonview.IsMine) return;
        {
 moveInput = Joystick.Horizontal;
        rb.velocity = new Vector3(moveInput * speed, rb.velocity.y);
        if (FacingRight == false && moveInput > 0)
        {
             Flip();
        }
        else if (FacingRight == true && moveInput < 0)
        {
           Flip(); 
        }
        }
       
    }
    

    private void Update()
    {
        if (!photonview.IsMine) return;
        {
 float verticalMove = Joystick.Vertical;

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (!photonview.IsMine) return;
        {
        if (isGrounded == true && verticalMove >= .4f)
        {
            rb.velocity = Vector2.up * jumpForse;
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
            
            if (!photonview.IsMine) return;
            {
    if (moveInput == 0)
        {
            anim.SetBool("isGo", false);
        }
        else
        {
            anim.SetBool("isGo", true);
        }


        }
            }
        }
       
        
        
        
        
    }

    private void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
  
}