using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupWeapon : MonoBehaviour , IInteractable
{ 
    public void Interact()
    {
        Debug.Log("Item Targeting worked!");
    }
}
