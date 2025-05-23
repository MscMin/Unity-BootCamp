using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;
    void Awake()
    {
        CreateAmongUs();
    }

    private void OnDestroy()
    {
        Debug.Log("Destroy");
    }

    public void CreateAmongUs()
    {
        GameObject obj = Instantiate(prefab, pos, rot);    // Function to create GameObject
        obj.name = "Amongus Character";
        Transform objTf = obj.transform;
        int count = objTf.childCount;
        
        Debug.Log($"Child Object Count of Character: {count}");
        Debug.Log($"First Child Object name of Character: {objTf.GetChild(0).name}");       //Searching Child
        Debug.Log($"Last Child Object name of Character: {objTf.GetChild(count-1).name}");
        
        
        //Destroy(destroyObj, 3f);  //Destroy destroyObj after 3sec
    }
    
}
