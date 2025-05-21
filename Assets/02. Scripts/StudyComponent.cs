using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public string changeName; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.Find("Main Camera");
        obj.name = changeName;
    }
}
