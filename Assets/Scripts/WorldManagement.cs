using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManagement : MonoBehaviour
{
    public int PlayerHP = 10;
    public static WorldManagement instance;
    public bool pause = false;
    public void Awake()

    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if ( PlayerHP <= 0)
        {
            Debug.Log("GameOver");
        }
    }

}
