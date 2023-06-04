using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score instance;
    public int ScoreNum = 0;
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
        this.GetComponent<TextMeshProUGUI>().text = string.Format("Score:{0}", ScoreNum.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = string.Format("Score:{0}", ScoreNum.ToString());
    }
}
