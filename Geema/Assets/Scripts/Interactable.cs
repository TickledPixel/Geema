using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{

    public string promptMessage;
    
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //No code will be written is this function
        //this is a template function to be overrideden by subclasses
    }
}
