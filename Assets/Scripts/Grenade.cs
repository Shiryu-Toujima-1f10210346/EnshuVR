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
        //B�{�^�������ꂽ�� & �c�e����1�ȏ�Ȃ�
        //�O���̃��f�����o��������

        //���f���ɃR���g���[�����G��Ă��Ԃ� �g���K�[�������ꂽ�玝��

        //�g���K�[�����ꂽ�琔�b��ɔ��j
        //�G�t�F�N�g��\��
    }
}
