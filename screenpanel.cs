using UnityEngine;

public class ScreenPanel : MonoBehaviour
{
    private bool open = false;

    public void ToggleScreen()
    {
        if (open)
        {
            transform.position += new Vector3(0, -2, 0);
        }
        else
        {
            transform.position += new Vector3(0, 2, 0);
        }

        open = !open;
    }
}
