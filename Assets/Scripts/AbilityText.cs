using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class AbilityText : MonoBehaviour
{
    public static AbilityText instance;
    
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TextMeshProUGUI>().text = string.Format(AbilityManagement.instance.AbilityName);
    }

    // Update is called once per frame
    void Update()
    {
        //this.GetComponent<TextMeshProUGUI>().text = string.Format(AbilityName);
    }
}
