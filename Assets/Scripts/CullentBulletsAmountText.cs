using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CullentBulletsAmountText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TextMeshProUGUI>().text = string.Format("{0}", fire.instance.CullentBulletsAmount.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = string.Format("{0}", fire.instance.CullentBulletsAmount.ToString());
        if (fire.instance.isReloading == true)
        {
            this.GetComponent<TextMeshProUGUI>().text = string.Format("Reloadin");
        }
    }
}
