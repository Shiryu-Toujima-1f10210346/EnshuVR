using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GrabToStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�R���g���[���[�����̃I�u�W�F�N�g�ɐG��Ă����ԂŃg���K�[��������
        //�V�[����؂�ւ���
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger) || OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            Debug.Log("Trigger!");
            //�t�F�[�h�A�E�g
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }
    }
}
