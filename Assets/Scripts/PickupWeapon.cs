using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupWeapon : MonoBehaviour
{
    public bool PlayerHasWepaon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        PlayerHasWepaon = true;
    }

    void _drop()
    {
        //TODO: drop the weapon
        PlayerHasWepaon = false;
    }
}
