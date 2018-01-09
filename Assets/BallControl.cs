using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public int score;

    public float health;
    public float jump;
    bool isGrouned;

    public float sprintMultiplier = 1.5f;
    public float stamina = 100.0f;
    public float sprintMinimum = 10.0f;

	// Use this for initialization
	void Start ()
    {
        isGrouned = true;
        health = 100;
        score = 0;
        rb = GetComponent<Rigidbody>();
	}
	
    void OnCollisionEnter(Collision other)
    {
        isGrouned = true;
    }

	// Update is called once per frame
	void Update ()
    {
        float sprintVal = Input.GetAxis("Sprint");

        float finalSpeed = speed;
        bool isSprint = sprintVal != 0.0f && stamina > sprintMinimum;
        if (isSprint)
        {
            finalSpeed *= sprintMultiplier;
            stamina -= 10.0f * Time.deltaTime;
        }
        else
        {
            stamina += 8.0f * Time.deltaTime;
        }
        stamina = Mathf.Clamp(stamina, 0, 100);

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, 0, vertical);
        rb.AddForce(move * speed * Time.deltaTime);
        rb.AddForce(move * finalSpeed * Time.deltaTime);
        if (health == 0)
        {
            Destroy(gameObject);
        }
       
            if (Input.GetKeyDown(KeyCode.Space) && isGrouned)
            {
            isGrouned = false;
                rb.AddForce(0, jump, 0, ForceMode.Impulse);
            }
        
	}   
}
