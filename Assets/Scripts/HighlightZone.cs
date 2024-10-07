using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// An area that objects will snap into place into when placed
public class HighlightZone : MonoBehaviour
{


    public void HighlightMe()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }

    public void DehighlightMe()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    public void DehighlightAll()
    {
        foreach (GameObject zone in GameObject.FindGameObjectsWithTag("Snap Zone"))
        {
            Debug.Log("Dehighlighting all");
            zone.GetComponent<Renderer>().enabled = false;
        }
    }
}
