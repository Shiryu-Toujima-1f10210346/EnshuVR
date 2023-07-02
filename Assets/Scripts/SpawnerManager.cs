using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    //Spawnerを定義
    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject Spawner3;
    /*
    public GameObject Spawner4;
    public GameObject Spawner5;
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    if (AbilityManagement.instance != null && AbilityManagement.instance.SpawnerNum != null)
    {
        switch (AbilityManagement.instance.SpawnerNum)
        {
            case 1:
                //オブジェクトの取得
                Spawner1.SetActive(true);
                break;
            case 2:
                Spawner2.SetActive(true);
                break;
            case 3:
                Spawner3.SetActive(true);
                break;
            /*
            case 4:
                Spawner4.SetActive(true);
                break;
            case 5:
                Spawner5.SetActive(true);
                break;
                */
        }
    }
}

}
