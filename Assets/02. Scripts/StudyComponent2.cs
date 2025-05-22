using UnityEngine;

public class StudyComponent2 : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;

    public Material mat;
    
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); // Create Unity Primitive Object in Code
        
        CreateCube();            // Default Parameter value
        CreateCube("Hello World");      // Function Call
    }

    public void CreateCube(string name = "Cube")         // Create Cube Object Function
    {
        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;
        
        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;
        
        obj.AddComponent<BoxCollider>();
    }
}
