using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActionsTest : MonoBehaviour
{
    public static Action onTaskEnd;

    public static Action<Color> changeColor;

    private void Start()
    {
        onTaskEnd += Task;
        onTaskEnd?.Invoke();

        changeColor += ColorChanger;
        changeColor?.Invoke(Color.green);
    }

    public void Task()
    {
        Debug.Log("task completed");
    }

    private void ColorChanger(Color _color)
    {
        Debug.Log(_color);
    }
}
