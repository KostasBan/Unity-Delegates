using System;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    public delegate void OnChangeColor(Color _clr);
    public OnChangeColor onChangeColor;

    private delegate void OnTaskEnd();
    private OnTaskEnd onTaskEnd;
    void Start()
    {
        onChangeColor = ColorChanger;
        onChangeColor(Color.green);

        onTaskEnd += Task1;
        onTaskEnd += Task2;

        try
        {
            onTaskEnd();
        }
        catch(NullReferenceException e)
        {
            Debug.Log(e.Message);
        }

        if (onTaskEnd != null)
            onTaskEnd();

        onTaskEnd?.Invoke();
    }

    private void Task1()
    {
        Debug.Log("task 1 completed");
    }
    public void Task2()
    {
        Debug.Log("task 2 completed");
    }

    private void ColorChanger(Color _color)
    {
        Debug.Log(_color);
    }

}
