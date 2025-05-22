using UnityEngine; //UnityEngine 네임스페이스 사용

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;
    public Transform objTf;

    //public string changeName; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // obj = GameObject.Find("Main Camera"); Find를 활용한 사례
        //obj.name = changeName;
        
        obj = GameObject.FindGameObjectWithTag("Player"); //Tag를 활용한 사례 
        objTf = GameObject.FindGameObjectWithTag("Player").transform; 
        // Debug.Log($"<color=#FF0000>GameObject Name: {obj.name}</color>");   //Log에 뜨는 글씨 색 바뀜
        // Debug.Log($"GameObject Tag: {obj.tag}"); 
        // Debug.Log($"GameObjecct Position: {obj.transform.position}");
        // Debug.Log($"GameObject Rotation: {obj.transform.rotation}");
        // Debug.Log($"GameObject Scale: {obj.transform.localScale}");
        
        // Debug.Log($"Mesh Data : {obj.GetComponent<MeshFilter>().mesh}");
        // Debug.Log($"Material Data: {obj.GetComponent<MeshRenderer>().material}");

        obj.GetComponent<MeshRenderer>().enabled = false; // Object Disabled
        obj.SetActive(false);
        obj.gameObject.SetActive(false);  //obj = objTf.gameobject
    }
}
