using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogInteractions : MonoBehaviour
{
    public void LogHoverEnter(HoverEnterEventArgs args)
    {
        Debug.Log(gameObject.name + " Hover Enter by: " + args.interactorObject);
    }

    public void LogSelect(SelectEnterEventArgs args) {
        Debug.Log(gameObject.name + " Selected Enter by: " + args.interactorObject);
    }

    public void LogActivate(ActivateEventArgs args)
    {
        Debug.Log(gameObject.name + " Selected Enter by: " + args.interactorObject);
    }
}