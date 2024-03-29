using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    //public Rigidbody2D myrigidbody; // making script aware of rigidbody component
    // Start is called before the first frame update
    
    private Rigidbody2D rigidbody2d;
    private Animator anime;
   public float jumpforce;
    public SpriteRenderer sp;
    private bool canjump=false;
    public float moveforce;
    public AudioSource Audiovolume;
    public AudioSource jumpsound;
    private bool yes;
   
   
    // public inspector backgroundVisiblity;

    // Update is called once per frame
    private void Start()
    {

      //  Audiovolume.pitch = 0.5f;

    }
    void Update()
    {
        anime = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        //GetComponent <Rigidbody2D>().velocity = Vector2.up * jumpforce; with out refrence
        if ((Input.GetKeyDown(KeyCode.Space)) || (Input.GetKeyDown(KeyCode.W)))
        {
            // if (getsomething == "ShouldJumpFromThis")
           if (canjump == true)
           {
                yes = true;
            }
        }
        /*  if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
          {
              transform.Translate(Vector2.left * moveforce * Time.deltaTime);
              sp.flipX = true;
              anime.SetBool("run", true);
          }
          else
          {
              anime.SetBool("run", false);
          }
          sp.flipX = false;

          if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
          {
              transform.Translate(Vector2.right * moveforce * Time.deltaTime);
              anime.SetBool("run", true);
          }
          else
          {
              anime.SetBool("run", false);
          }*/
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * moveforce * Time.deltaTime);//translate is function of transform
            sp.flipX = true;
            anime.SetBool("run", true);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * moveforce * Time.deltaTime);
            sp.flipX = false;
            anime.SetBool("run", true);
        }
        //  else if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        //  {
        //        transform.Translate(Vector2.down * 20 * Time.deltaTime);
        // }
        else
        {
            anime.SetBool("run", false);
        }

        if (rigidbody2d.velocity.y == 0)
        {
            anime.SetBool("jump", false);
            jumpsound.enabled = false;

        }

    }

    private void FixedUpdate()
    {if (yes==true)//called for every physic update
        { rigidbody2d.velocity = Vector2.up * jumpforce;
            //  Debug.Log("Space is pressed");
            anime.SetBool("jump", true);
            jumpsound.enabled = true;
            yes = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ShouldJumpFromThis")
        {
            //  getsomething = collision.gameObject.tag;
           // Debug.Log(collision.gameObject.name);
            canjump = true;
            Debug.Log(" Ground is touched");

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ShouldJumpFromThis")//checks the is collision is ended with that game object
        {
             anime.SetBool("jump", false);
            canjump = false;
           // Debug.Log("I am not on Ground");
        }
    }

 
    // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
