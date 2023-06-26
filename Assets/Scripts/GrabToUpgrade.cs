using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GrabToUpgrade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //コントローラーがこのオブジェクトに触れている状態でトリガーを引くと
        //シーンを切り替える
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger) || OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            //ここにオブジェクトとの衝突判定を追加
            //if

            
        }
    }
}
