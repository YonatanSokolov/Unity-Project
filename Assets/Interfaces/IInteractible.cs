using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 * In this Interaction system - We have 2 objects in each interaction we need to think about:
 * 
 * the Interactor - (Which casts a Ray and searches for something to interact with)
 * this code is written in a script attached to the camera named ""
 * 
 * the Interactee - (Which is hit by the ray, and then its Interact() method is then activated)
 */
interface IInteractable
{
    public void Interact();
}