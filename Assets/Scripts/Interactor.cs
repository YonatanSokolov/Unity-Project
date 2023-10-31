using UnityEngine;


/*
 * TODO:
 * when casting for interaction we should check the distase to the object using the line:
 * 
 * hit.distance;
 * 
 * this should be added later
 */



public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange = 2000;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))  //This is the key to interact with objects.
        {
            Debug.Log("e was pressed");
            Ray ray = new Ray(InteractorSource.position, InteractorSource.forward);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                //Debug.Log("hit!");
                //Debug.Log("distance: " + hit.distance.ToString());

                if (hit.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
            
        }
    }
}