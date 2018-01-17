using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public int scoreAdded;
    public float healthDecreased;
    public float rotationSpeed;
    public float grow;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(rotationSpeed, 0, rotationSpeed / 3);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var playerController = other.GetComponent<BallControl>();
            if(playerController != null)
            {
                playerController.score += scoreAdded;
                playerController.health += healthDecreased;
                playerController.grow += grow;
                Destroy(gameObject);
            }
        }
    }
}
