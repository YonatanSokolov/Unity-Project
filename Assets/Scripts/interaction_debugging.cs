using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction_debugging : MonoBehaviour , IInteractable
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        Debug.Log("Item Targeting worked! (with this huge box)");
    }
}
