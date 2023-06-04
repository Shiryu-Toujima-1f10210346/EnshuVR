using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update

    public float span = 1f;
    private float currentTime = 0f;
    public GameObject ball;
    
    void Start()
    {
        ball = (GameObject)Resources.Load("ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (WorldManagement.instance.pause == false)
        {

            currentTime += Time.deltaTime;

            if (currentTime > span)
            {
                Debug.Log(ball);
                GameObject obj = Instantiate(ball, transform.position, transform.rotation);

                obj.GetComponent<Rigidbody>().AddForce(transform.forward * Random.Range(100f, 200f));
                obj.GetComponent<Rigidbody>().AddForce(transform.right * Random.Range(-70f, 70f));




                currentTime = 0f;
            }
        }
    }
}