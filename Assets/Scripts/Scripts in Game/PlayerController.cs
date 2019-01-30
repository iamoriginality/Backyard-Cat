using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed;
    float horiz;
    float vert;
    public Transform character;
    public Rigidbody2D body;
    public Animator animator;
    
    
    void Start () {
        
    }
	
	void Update () {
        horiz = Input.GetAxis("Horizontal") * speed;
        vert = Input.GetAxis("Vertical") * speed;
        if (body.velocity.magnitude > 0)
        {
            animator.SetBool("Move", true);
        }
        else
        {
            animator.SetBool("Move", false);
        }
        if (horiz < 0)
        {
            character.localEulerAngles = new Vector3(0f, 180f, 0f);
        }
        else if (horiz > 0)
        {
            character.localEulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Dog"))
        {
            SceneManager.LoadScene("LoseGame");
        }
    }
    private void FixedUpdate()
    {
        body.velocity = new Vector2(horiz * speed, vert * speed);
    }

}
