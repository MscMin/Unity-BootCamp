using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed; 원본
        // this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime; 프레임 보정

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
        }
    }
    
    
}
