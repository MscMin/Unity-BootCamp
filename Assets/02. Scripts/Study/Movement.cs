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

        ///Input System ( Old - Legacy)
        /// Promised System about Input Value
        /// Move - WASD
        /// Jump - Space
        /// Shoot - Mouse left Click
         
        // if (Input.GetKey(KeyCode.W))
        // {
        //     this.transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     this.transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.A))
        // {
        //     this.transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     this.transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
        // }
        
        // Value: 0 ~ 1, -1 ~ 0
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        // Value: -1 or 0 or 1 
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normalDir = dir.normalized; // Nomalized - 크기를 1로 만드는 과정 
        Debug.Log($"Input: {normalDir}");
        
        /// Move
        transform.position += normalDir * (moveSpeed * Time.deltaTime);
        transform.LookAt(transform.position + normalDir);
    }
    
    
}
