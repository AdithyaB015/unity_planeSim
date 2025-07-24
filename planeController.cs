using UnityEngine;

public class planeController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 30f;
    public float upInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        upInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward *Time.deltaTime*speed);
        transform.Rotate(Vector3.right* Time.deltaTime * turnSpeed * -upInput);
    }
}
