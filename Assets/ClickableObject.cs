using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] GameObject Animation;
    private void OnMouseEnter()
    {
        // Replace this with the action you want to perform upon clicking
        Debug.Log("Object Clicked: " + gameObject.name);
        if (Animation != null)
            Animation.SetActive(true);
        // Add your custom actions or logic here
    }
    private void OnMouseExit()
    {
               if (Animation != null)
            Animation.SetActive(false); 
    }
}
