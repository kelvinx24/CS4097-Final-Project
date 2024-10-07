using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ChangeObjectLayer : MonoBehaviour
{
    public string newInteractionLayer = "Snapped";

    private XRSocketInteractor socketInteractor;
    private int originalLayer;

    void Start()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();
//        socketInteractor.selectEntered.AddListener(OnSnapped);

    }


    public void OnSnapped(SelectEnterEventArgs args)
    {
        XRGrabInteractable grabbedObject = args.interactableObject as XRGrabInteractable;

        if (grabbedObject != null)
        {
            originalLayer = grabbedObject.interactionLayers;
            grabbedObject.interactionLayers = InteractionLayerMask.GetMask(newInteractionLayer);
        }

    }

    public void OnUnsnap(SelectExitEventArgs args)
    {
        XRGrabInteractable grabbedObject = args.interactableObject as XRGrabInteractable;

        grabbedObject.interactionLayers = originalLayer;
    }
}
