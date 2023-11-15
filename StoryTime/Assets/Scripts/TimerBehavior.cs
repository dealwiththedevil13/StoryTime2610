using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;

public class TimerBehavior : MonoBehaviour
{
    public UnityEvent CountdownStart, onCountdownEnd;
    public FloatData countdown;
    private float timeRemaining;

    public void StartCount()
    {
        timeRemaining = countdown.data;
        StartCoroutine(Runtimer());
    }

    IEnumerator Runtimer()
    {
        while (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                onCountdownEnd.Invoke();
                yield break;
            }

            yield return null;
        }
    }
}
