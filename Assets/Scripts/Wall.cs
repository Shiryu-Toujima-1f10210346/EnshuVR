using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public AudioClip WallDamageSE;
    AudioSource WallDamageSESource;
    public int WallHP = 10;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OncollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Damage!");
            PlaySE();//小さめにね
        }
    }

    void PlaySE()
    {
        WallDamageSESource = GetComponent<AudioSource>();
        WallDamageSESource.PlayOneShot(WallDamageSE);
    }

}
