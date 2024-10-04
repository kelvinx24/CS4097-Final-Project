using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ObjectSelected : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnDrop);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        PlayerManager.SetItemHeld(true);
    }

    private void OnDrop(SelectExitEventArgs args)
    {
        PlayerManager.SetItemHeld(false);

    }
}
