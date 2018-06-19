using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;               //The Rigidbody2D component attached to this object.
    public float MovementSpeed;

    public Vector2 Facing;

    // Use this for initialization
    void Start ()
    {     
       this.rb2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        var goRight = Input.GetAxisRaw("Horizontal") > float.Epsilon;
        var goLeft = Input.GetAxisRaw("Horizontal") < -float.Epsilon;

        var goUp = Input.GetAxisRaw("Vertical") > float.Epsilon;
        var goDown = Input.GetAxisRaw("Vertical") < -float.Epsilon;

        {
            if (goRight)
            {
                transform.position += Vector3.right * MovementSpeed * Time.deltaTime;
                //spriteRenderer.flipX = false;
                this.Facing = Vector2.right;
            }
            else if (goLeft)
            {
                transform.position += Vector3.left * MovementSpeed * Time.deltaTime;
                //spriteRenderer.flipX = true;
                this.Facing = Vector2.left;
            }
        }

        {
            if (goUp)
            {
                transform.position += Vector3.up * MovementSpeed * Time.deltaTime;
                //spriteRenderer.flipX = false;
                this.Facing = Vector2.up;
            }
            else if (goDown)
            {
                transform.position += Vector3.down * MovementSpeed * Time.deltaTime;
                //spriteRenderer.flipX = true;
                this.Facing = Vector2.down;
            }
        }

    }
}
