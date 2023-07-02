using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    //Turretを定義
    public GameObject Turret1;
    public GameObject Turret2;
    public GameObject Turret3;
    public GameObject Turret4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    if (AbilityManagement.instance != null && AbilityManagement.instance.TurretNum != null)
    {
        switch (AbilityManagement.instance.TurretNum)
        {
            case 1:
                //オブジェクトの取得
                Turret1.SetActive(true);
                break;
            case 2:
                Turret2.SetActive(true);
                break;
            case 3:
                Turret3.SetActive(true);
                break;
            case 4:
                Turret4.SetActive(true);
                break;
        }
    }
}

    void OncollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Damage!");
            
        }
    }

}
