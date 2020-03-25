using UnityEngine;

public class EventTest : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

    public void ButtonClicked()
    {
        onClick?.Invoke();
    }
}
