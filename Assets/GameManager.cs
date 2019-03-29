using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject DoorAnimation;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void DoorOpen()
    {
        DoorAnimation.SetActive(true);
    }
}
