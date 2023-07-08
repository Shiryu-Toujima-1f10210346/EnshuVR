using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Wall : MonoBehaviour
{
    public AudioClip WallDamageSE;
    AudioSource WallDamageSESource;
    public int WallHP = 10;
    public static Wall instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
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
            Debug.Log("Damage!");
            PlaySE();//小さめにね
            WallHP -= 1;
            if (WallHP <= 0)
            {
                Debug.Log("GameOver!");
                //GameOver
            }
            Destroy(collision.gameObject);
        }
    }

    void PlaySE()
    {
        WallDamageSESource = GetComponent<AudioSource>();
        WallDamageSESource.PlayOneShot(WallDamageSE);
    }

}
