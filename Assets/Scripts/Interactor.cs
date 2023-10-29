using UnityEngine;

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    void Start()
    {

    }
    void Update()
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