using UnityEngine;

public class CarFollow : MonoBehaviour
{
    public Transform target;
    public float SmoothTime;

    private Vector3 posVel;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref posVel, SmoothTime);
        
        transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(Vector3.ProjectOnPlane(target.forward, Vector3.up)).normalized, Time.deltaTime);
        
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(Vector3.ProjectOnPlane(target.forward, Vector3.up)).normalized, 45*Time.deltaTime);
        

    }
}
