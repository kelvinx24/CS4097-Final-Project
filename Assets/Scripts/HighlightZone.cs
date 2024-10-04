using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightZone : MonoBehaviour
{


    public void HighlightMe()
    {
        if (PlayerManager.IsItemHeld())
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
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
