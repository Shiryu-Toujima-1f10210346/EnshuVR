using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public static Grenade instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public int GrenadeCount = 1;
    public int GrenadeDamage = 10;
    public int ExplodeRange = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bボタン押されたら & 残弾数が1以上なら
        //グレのモデルを出現させる

        //モデルにコントローラが触れてる状態で トリガーが引かれたら持つ

        //トリガーが離れたら数秒後に爆破
        //エフェクトを表示
    }
}
