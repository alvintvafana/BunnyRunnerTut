using UnityEngine;
using System.Collections;

public class BunnyController : MonoBehaviour {

	// Use this for initialization
    private Rigidbody2D myRigidBody2D;
    public float bunnyJumpForce = 500f;
	void Start () {
        myRigidBody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetButtonUp("Jump"))
    {
        myRigidBody2D.AddForce(transform.up * bunnyJumpForce);
        //System.IO.File.WriteAllText(@"c:\musvo\unity.txt", "test");
    }
	}
}
