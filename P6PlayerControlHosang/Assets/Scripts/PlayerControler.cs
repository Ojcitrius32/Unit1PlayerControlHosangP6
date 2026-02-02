using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move  the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
