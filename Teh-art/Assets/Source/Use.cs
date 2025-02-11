using UnityEngine;

public class Use : MonoBehaviour
{
    [SerializeField] private Door door;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            door.Use();
        }
    }
}
