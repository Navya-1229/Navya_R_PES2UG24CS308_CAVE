using UnityEngine;

public class ObjectHighlight : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;
    private bool highlighted = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    void OnMouseDown()
    {
        highlighted = !highlighted;

        if (highlighted)
            rend.material.color = Color.yellow;
        else
            rend.material.color = originalColor;
    }
}
