using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    public int[] arrayNumber = new int[5];

    List<int> ListNumber = new List<int>();

    /// Access Modifiers
    public int number1 = 1;
    private int number2 = 2;
    public int number3 = 3;
    [SerializeField] private int number4 = 4;
    [SerializeField] private int number5 = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /// Array
        Debug.Log($"Value of arrayNumber0: {arrayNumber[0]}");
        Debug.Log($"Value of arrayNumber2: {arrayNumber[2]}");
        // Debug.Log($"Value of arrayNumber5: {arrayNumber[5]}"); index out of range Error
        
        /// List
        ListNumber.Add(50);
        ListNumber.Add(30);
        ListNumber.Add(20);
        ListNumber.Add(10);
        ListNumber.Add(40);
        Debug.Log($"$Count of ListNumber: {ListNumber.Count}"); //count = length of array
        Debug.Log($"Last item of ListNumber: {ListNumber[ListNumber.Count-1]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
