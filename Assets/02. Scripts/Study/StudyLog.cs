using UnityEngine;
using UnityEngine.Rendering.Universal;

/// <summary>
/// Console View Log Test Script
/// </summary>
public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start Function");
        Debug.LogWarning("Start Function");
        Debug.LogError("Start Function");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Function");
    }
}
