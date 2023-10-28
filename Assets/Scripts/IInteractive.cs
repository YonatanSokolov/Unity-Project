using UnityEngine;
using System.Collections;

/*
 * In this Interaction system - We have 2 objects in each interaction we need to think about:
 * 
 * the Interactor - (Which casts a Ray and searches for something to interact with)
 * 
 * the Interactee - (Which is hit by the ray, and then its Interact() method is then activated)
 */
public interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))  //This is the key to interact with objects.
        {
            Ray ray = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, InteractRange))
            {
                if (hit.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }
    }
}