using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupWeapon : MonoBehaviour , IInteractable
{
    //private Ray PickupSystemRay;
    public bool PlayerHasWepaon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerHasWepaon == false) 
        {
            _pickup();
        }
        if (Input.GetKeyDown(KeyCode.E) && PlayerHasWepaon == true) 
        {
            _drop();
        }
    }
    void _pickup() 
    {
        //TODO: pickup the wepaon
        PickupSystemRay = new Ray();
        PlayerHasWepaon = true;
    }

    void _drop()
    {
        //TODO: drop the weapon
        PlayerHasWepaon = false;
    }
    */
    public void Interact()
    {
        Debug.Log("Item Targeting worked!");
    }
}
