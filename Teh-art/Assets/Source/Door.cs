using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator myDoor;
    [SerializeField] private bool isOpen;

    public void Use()
    {
        if (isOpen)
        {
            myDoor.SetTrigger("Close");
        }
        else if (!isOpen)
        {
            myDoor.SetTrigger("Open");
        }
            
        isOpen = !isOpen;
    }
}
