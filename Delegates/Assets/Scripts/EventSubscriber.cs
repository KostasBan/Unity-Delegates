using UnityEngine;

public class EventSubscriber : MonoBehaviour
{
    void Start()
    {
        EventTest.onClick += OnClick;
    }

    public void OnClick()
    {
        //do something
    }
}
