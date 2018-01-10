using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{

    public float scaleFactor = 2.0f;
    public float timeToGrow = 3.0f;

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            var playerController = other.GetComponent<BallControl>();
            Vector3 initialScale = playerController.transform.localScale;
            Vector3 finalScale = Vector3.one * scaleFactor;
            float elapsedTime = 0.0f;

            while (elapsedTime < timeToGrow)
            {
                elapsedTime += Time.deltaTime;
                float lerpTime = elapsedTime / timeToGrow;
                playerController.transform.localScale = Vector3.Lerp(initialScale,
                      finalScale, lerpTime);
                yield return null;
            }
        }
    }






    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
