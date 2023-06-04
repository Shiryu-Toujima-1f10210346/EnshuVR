using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class fire : MonoBehaviour
{
    //右コントローラーのトリガーを引いたらBulletを前方に射出

    public float BulletSpeed = 3000f;
    public float BulletLifeTime = 3f;
    public int BulletsPerSecond = 5;
    private float BulletInterval = 0f;
    private float BulletTimer = 0f;
    public GameObject BulletSpawn;
    public AudioClip FiringSE;
    public AudioClip ReloadingSE;
    public int MaxBulletsAmount = 100;
    public int CullentBulletsAmount;

    AudioSource FiringSESource;
    AudioSource ReloadingSESource;
    public bool isReloading = false;
    
    public static fire instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        CullentBulletsAmount = MaxBulletsAmount;
        FiringSESource = GetComponent<AudioSource>();
        ReloadingSESource = GetComponent<AudioSource>();
        BulletInterval = 1f / BulletsPerSecond;
    }

    void Update()
    {
        BulletTimer += Time.deltaTime;
        if (BulletTimer >= BulletInterval && isReloading == false && CullentBulletsAmount > 0)
        {
            if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger) || Input.GetKey(KeyCode.Tab))
            {
                CullentBulletsAmount -= 1;
                GameObject BulletModel = (GameObject)Resources.Load("Bullet");
                GameObject bullet = Instantiate(BulletModel, BulletSpawn.transform.position, Quaternion.Euler(90, 0, 0));
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.AddForce(BulletSpawn.transform.forward * BulletSpeed);
                PlaySE();
                Destroy(bullet, BulletLifeTime);
                BulletTimer = 0f;
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.Two) || Input.GetKeyDown(KeyCode.LeftShift))
        {
            Reload();
            
        }
    }

    void PlaySE()
    {
        FiringSESource.PlayOneShot(FiringSE);
    }
    
    void Reload()
    {
        if (isReloading == false)
        {
                isReloading = true;
                ReloadingSESource.PlayOneShot(ReloadingSE);
                CullentBulletsAmount = MaxBulletsAmount;
                Task.Delay(1000).ContinueWith(_ => isReloading = false);
        }
    }

}
