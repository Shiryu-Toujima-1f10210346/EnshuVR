using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Score.instance.ScoreNum += 1;
            //log
            Debug.Log("Hit!");
            Destroy(collision.gameObject);

            if (AbilityManagement.instance.Multi >= 1)
            {

                GameObject BulletModel = (GameObject)Resources.Load("Bullet");
                
                
                    GameObject bullet = Instantiate(BulletModel, this.transform.position, Quaternion.Euler(90, 0, 0));
                    Rigidbody rb = bullet.GetComponent<Rigidbody>();

                    rb.AddForce(this.transform.forward * fire.instance.BulletSpeed);
                /*float RandamForce = fire.instance.CullentBulletsAmount +1 / fire.instance.MaxBulletsAmount ;
                if (fire.instance.CullentBulletsAmount % 2 == 0)
                {
                    rb.AddForce(this.transform.right * fire.instance.BulletSpeed * RandamForce);
                }
                else
                {
                    rb.AddForce(this.transform.right * fire.instance.BulletSpeed * RandamForce * -1);
                }*/
                if (fire.instance.CullentBulletsAmount % 2 == 0)
                {
                    rb.AddForce(this.transform.right * fire.instance.BulletSpeed);
                }
                else
                {
                    rb.AddForce(this.transform.right * fire.instance.BulletSpeed);
                }



            }


        }

        if  (collision.gameObject.tag == "Ability")
        {
            AbilityManagement.instance.AbilitySelecting = false;
            WorldManagement.instance.pause = false;
            //当たったオブジェクトの名前を取得
            string AbilityName = collision.gameObject.name;
            AbilityManagement.instance.SelectedAbilityList.Add(AbilityName);
            Debug.Log(AbilityName);
        }

        Destroy(this.gameObject);
    }
}
