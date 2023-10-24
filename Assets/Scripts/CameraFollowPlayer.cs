using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollowPlayer : MonoBehaviour
{
    private Vector3 _offset;
    [SerializeField] private Transform Target;
    [SerializeField] private float Smoothness;
    private Vector3 _currvelocity = Vector3.zero;
    private float delta;
    // Start is called before the first frame update
    void Awake()
    {
        _offset = transform.position - Target.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 TargetPosition = Target.position +_offset;
        transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref _currvelocity, Smoothness);
    }
}
