using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] GameObject Animation;
     [SerializeField] GameObject Sound;
     [SerializeField] GameObject NextObject;
    private void OnMouseEnter()
    {
        // Replace this with the action you want to perform upon clicking
        Debug.Log("Object Clicked: " + gameObject.name);
        if (Animation != null)
            Animation.SetActive(true);
                    if (Sound != null)
            Sound.SetActive(true);

        // Add your custom actions or logic here
    }
    private void OnMouseExit()
    {
               if (Animation != null)
            Animation.SetActive(false); 
            if (Sound != null)
            Sound.SetActive(false);
                    if (NextObject != null)
            NextObject.SetActive(true);
    }
}
