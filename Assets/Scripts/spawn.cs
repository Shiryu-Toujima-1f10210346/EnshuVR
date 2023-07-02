using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float span = 1f;
    private float currentTime = 0f;
    public GameObject[] enemies;

    void Start()
    {
        enemies = new GameObject[5];
        for (int i = 0; i < 5; i++)
        {
            enemies[i] = (GameObject)Resources.Load("Enemy" + (i + 1));
        }
    }

    void Update()
    {
        if (WorldManagement.instance.pause == false)
        {
            currentTime += Time.deltaTime;

            if (currentTime > span)
            {
                int index = Random.Range(0, 5);
                GameObject obj = Instantiate(enemies[index], transform.position, transform.rotation);

                obj.GetComponent<Rigidbody>().AddForce(transform.forward * Random.Range(100f, 200f));
                obj.GetComponent<Rigidbody>().AddForce(transform.right * Random.Range(-70f, 70f));

                currentTime = 0f;
            }
        }
    }
}