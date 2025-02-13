using UnityEngine;

public class MinimapCar : MonoBehaviour
{
    public Transform CarTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(CarTransform.position.x, 0.1f, CarTransform.position.z);
        transform.forward = Vector3.ProjectOnPlane(CarTransform.forward, Vector3.up);
    }
}
