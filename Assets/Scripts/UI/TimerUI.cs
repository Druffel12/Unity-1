using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public Text timerLabel;

    public float duration;

    void Update()
    {

        duration -= Time.deltaTime;

        int temp = (int)duration;

        int hours = temp / 60 / 60;
        int minutes = (int) (temp / 60);
        int seconds = temp % 60;

        timerLabel.text = hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" +
            seconds.ToString("D2");
    }

    public void ToggleTimer()
    {
        enabled = !enabled;
    }
}