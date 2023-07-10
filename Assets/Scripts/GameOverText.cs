using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverText : MonoBehaviour
{
    public TextMeshProUGUI WallHPText;

    // Start is called before the first frame update
    void Start()
    {
        WallHPText = GetComponent<TextMeshProUGUI>();
        WallHPText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Wall.instance.isGameOver == true)
        {
            WallHPText.text = "GameOver";
        }
        else
        {
            WallHPText.text = "";
        }
    }
}