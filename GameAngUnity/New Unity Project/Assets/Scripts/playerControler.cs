using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {

    //movoment varible
    public float maxSpeed;

	//jumping variables
	bool grounded = false;
	float groundCheckRadious = 0.2f;
	public LayerMask groundLayer;
	public Transform groundCheck;
	public float jumpHeight;
	float nextTimetoJump;

    Rigidbody2D myRB;
    Animator myAnim;
    bool facingRight;

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();

		nextTimetoJump = 1;
        facingRight = true;
	}

	//Update is called once per frame
	void Update(){

		nextTimetoJump -= Time.deltaTime;
		if (nextTimetoJump < 0 && grounded && Input.GetKeyDown(KeyCode.Space)) {
			grounded = false;
			myAnim.SetBool ("isGrounded", grounded);
			myRB.AddForce(new Vector2(0,jumpHeight));
			nextTimetoJump = 1;
		}}

	
	// Update is called once per frame
	void FixedUpdate () {

		//check if we are grounded - if no, then we are falling
		grounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadious,groundLayer);
		myAnim.SetBool("isGrounded", grounded);

		myAnim.SetFloat("verticalSpeed", myRB.velocity.y);

        float move = Input.GetAxis("Horizontal");
        myAnim.SetFloat("speed", Mathf.Abs(move));

        myRB.velocity = new Vector2(move*maxSpeed,myRB.velocity.y);


        if(move>0 && !facingRight)
        {
            flip();
        }else if(move<0 && facingRight)
        {
            flip();
        }

       
	}
    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
