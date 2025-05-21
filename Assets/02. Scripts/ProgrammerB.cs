using UnityEngine;
using DevA;
public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA pA; // 유니티 에디터에서 할당해서 써야 함
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pA.number1 = 10;  
        pA.number2 = 10;
        //pA.number3 = 10;
        //pA.number4 = 10;
        //pA.number5 = 10;  주석처리된것은 private이기 때문에 접근 불가
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
