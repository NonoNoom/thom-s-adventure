using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reviewtest : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundEffect;


    public Animator anim; // Add declaration of Animator variable
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        
        // Check if player is in range and "E" is pressed
        if (Physics.Raycast(ray, out hit))
        {
            GameObject objectHitByRaycast = hit.transform.gameObject;

            if (objectHitByRaycast.GetComponent<Button>())
            {
                Debug.Log("Button selected");
                if(ButtonBoolManager.IsButtonPressed == false)
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        anim.SetTrigger("ButtonPress");
                    
                       ButtonBoolManager.IsButtonPressed = true;
                       
                    }
                }
            }
            
        }
    }
}



