using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void ButtonPress()
    {
        GameManager.Instance.ResetGame();
    }
}
