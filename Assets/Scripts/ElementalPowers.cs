using UnityEngine;
using UnityEngine.UI; // Add this to use the UI components

public class ElementalPowers : MonoBehaviour
{
    public enum Element { None, Earth, Air }
    public Element currentElement = Element.None;

    public float powerCooldown = 2f;
    private float lastUsedTime;

    public Text elementText; // Drag the UI Text component in the Unity Inspector

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchElement();
        }

        UpdateElementText();

        if (Input.GetKeyDown(KeyCode.F) && Time.time >= lastUsedTime + powerCooldown)
        {
            UsePower();
            lastUsedTime = Time.time;
        }
    }

    void SwitchElement()
    {
        if (currentElement == Element.Earth)
        {
            currentElement = Element.Air;
        }
        else if (currentElement == Element.Air)
        {
            currentElement = Element.None;
        }
        else
        {
            currentElement = Element.Earth;
        }

        Debug.Log("Switched to: " + currentElement);
    }

    void UsePower()
    {
        switch (currentElement)
        {
            case Element.Earth:
                Debug.Log("Using Earth Power!");
                // Implement Earth power (e.g., shield)
                break;
            case Element.Air:
                Debug.Log("Using Air Power!");
                // Implement Air power (e.g., high jump)
                GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
                break;
            default:
                Debug.Log("No power selected.");
                break;
        }
    }

    void UpdateElementText()
    {
        if (elementText != null)
        {
            elementText.text = "Current Element: " + currentElement.ToString();
        }
    }
}
