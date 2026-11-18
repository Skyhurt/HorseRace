using UnityEngine;



public class PlayerInput : MonoBehaviour
{ 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputPlayer;
        float speedPlayer = 20;
        inputPlayer = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * inputPlayer * speedPlayer * Time.deltaTime);
    }
}
