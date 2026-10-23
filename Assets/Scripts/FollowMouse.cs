using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
public class FollowMouse : MonoBehaviour
{
    private Vector3 originalScale;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("FollowMouse script has started.");
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        worldPosition.z = 0;
        transform.position = worldPosition;


         // Detect click
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            StartCoroutine(Grow());
        }

    }

    IEnumerator Grow()
    {
        // Make object bigger
        transform.localScale = originalScale * 1.5f;
        

        // Wait 0.2 seconds
        yield return new WaitForSeconds(0.2f);

        // Return to original size
        transform.localScale = originalScale;
    }
}
