using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRate : MonoBehaviour
{
    public int fps = 90;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = fps; // 30fpsに設定

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
