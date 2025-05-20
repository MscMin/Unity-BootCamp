using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1,number2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(AddMethod());
        Debug.Log(MinusMethod());
    }

    // Update is called once per frame
    int AddMethod()
    {
        int result = number1 + number2;

        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;

        return result;
    }
    
}
