using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WallText : MonoBehaviour
{
    public TextMeshProUGUI WallHPText;

    // Start is called before the first frame update
    void Start()
    {
        WallHPText = GetComponent<TextMeshProUGUI>();
        WallHPText.text = "Wall HP: " + Wall.instance.WallHP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        WallHPText.text = "Wall HP: " + Wall.instance.WallHP.ToString();
    }
}