using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Globals;

public class CannibalScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public SoundManagerScript sm;
   




    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        bool result = Helper.DoRayCollisionCheck(gameObject);

        DoJump();
        DoMove();
        DoThrow();
        




    }

    void DoJump()
    {

        bool result = Helper.DoRayCollisionCheck(gameObject);
        Vector2 velocity = rb.velocity;

        // check for jump
        if (Input.GetKey("w") && (result == true))
        {
            if (velocity.y < 0.01f)
            {
                velocity.y = 11f;
               
            }


        }
        if (result == false)
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }

        Helper.SetVelocity(velocity.x, velocity.y, gameObject);

        if (velocity.x < -0.5)
        {
            Helper.FlipSprite(gameObject, Left);
        }
        if (velocity.x > 0.5f)
        {
            Helper.FlipSprite(gameObject, Right);
        }

    }

    void DoMove()
    {
        Vector2 velocity = rb.velocity;

        // stop player sliding when not pressing left or right
        velocity.x = 0;

        // check for moving left
        if (Input.GetKey("a"))
        {
            velocity.x = -5;
        }

        // check for moving right
        if (Input.GetKey("d"))
        {
            velocity.x = 5;
        }

        if (velocity.x > 0 || velocity.x < 0)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }


        Helper.SetVelocity(velocity.x, velocity.y, gameObject);



        if (velocity.x < -0.5)
        {
            Helper.FlipSprite(gameObject, Left);
        }
        if (velocity.x > 0.5f)
        {
            Helper.FlipSprite(gameObject, Right);
        }


    }
    void DoThrow()
    {
        if (Input.GetKey("z"))
        {
            anim.SetBool("Throw", true);
        }
        else
        {
            anim.SetBool("Throw", false);
        }




    }


    void PlaySoundEffect()
    {
        sm.Play(0);
    }
    void PlaySoundEffect2()
    {
        sm.Play(2);
    }
    void PlaySoundEffect3()
    {
        sm.Play(1);
    }




}
