using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    IEnumerator CoroutineCounting(float waitTime)
    {
        int number = 0;
        while(number < 10)
        {
            yield return new WaitForSeconds(waitTime);
            Debug.Log(number);
            number++;
        }
    }
	// Use this for initialization
	void Start ()
    {
		
	}

    public int max = 15;
    public int curNumber = 0;
	// Update is called once per frame
	void Update ()
    {
        if (curNumber < max)
        {
            Debug.Log(curNumber);
            curNumber++;
        }
    }
}
