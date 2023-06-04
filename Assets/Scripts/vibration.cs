using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vibration : MonoBehaviour
{
    public OVRInput.Controller controller = OVRInput.Controller.RTouch;
    public float vibrationDuration = 0.1f;
    public float vibrationStrength = 0.05f;
    public float returnSpeed = 50f;

    private Vector3 initialPosition;
    private float vibrationTimer = 0f;

    void Start()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            vibrationTimer = vibrationDuration;
        }

        if (vibrationTimer > 0f && fire.instance.CullentBulletsAmount > 0 && fire.instance.isReloading == false)
        {
            // Apply Perlin noise to create vibration effect
            Vector3 noise = new Vector3(Mathf.PerlinNoise(Time.time * 100f, 0f),
                                        Mathf.PerlinNoise(0f, Time.time * 100f),
                                        Mathf.PerlinNoise(Time.time * 100f, Time.time * 100f));
            Vector3 targetPosition = initialPosition + (noise * vibrationStrength);
            transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * returnSpeed);
            vibrationTimer -= Time.deltaTime;
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, initialPosition, Time.deltaTime * returnSpeed);
        }
    }
}
