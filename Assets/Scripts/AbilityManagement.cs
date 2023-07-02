using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AbilityManagement : MonoBehaviour
{
    public static AbilityManagement instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //AbilityList

    public int Multi = 10;
    public int TurretNum = 0;
    public int SpawnerNum = 1;
    public int AbilityCount = 30;
    public GameObject SelectedAbilityListObject;

    public GameObject AbilityOrb;
    public bool AbilitySelecting = false;
    public List<string> AbilityList = new List<string>();
    public List<string> RandomAbilityList = new List<string>();
    public List<string> SelectedAbilityList = new List<string>();
    public string AbilityName = "SampleText";
    // Start is called before the first frame update
    void Start()
    {

        AbilityList.Add("Multi");
        AbilityList.Add("Turret");
        AbilityList.Add("TurretMissileRateUp");
        AbilityList.Add("Hogehoge");
        AbilityList.Add("INIAD");

        AbilityOrb = (GameObject)Resources.Load("AbilityOrb");
    }

    // Update is called once per frame
    void Update()
    {
        //SelectedAbilityListが0じゃなかったら
        if (SelectedAbilityList.Count != 0)
        {
            Debug.Log(SelectedAbilityList);
            SelectedAbilityListObject.GetComponent<TextMeshProUGUI>().text = string.Format("{0}", SelectedAbilityList.ToString());
        }
        if (Score.instance.ScoreNum % AbilityCount == 0 && Score.instance.ScoreNum != 0 && AbilitySelecting == false)
        {
            AbilitySelecting = true;
            //vector3のlocを定義 transform.position
            Vector3 loc = new(transform.position.x - 1.0f, transform.position.y + 0.5f, transform.position.z + 1.0f);
            //AbilityListからランダムに3つ取得しRandomAbilityListに格納

            for (int i = 0; i < 3; i++)
            {
                int index = Random.Range(0, AbilityList.Count);
                RandomAbilityList.Add(AbilityList[index]);
                AbilityList.RemoveAt(index);
                AbilityName = RandomAbilityList[i];
                Debug.Log(AbilityName);
                GameObject orbInstance = Instantiate(AbilityOrb, loc, transform.rotation);
                orbInstance.GetComponentInChildren<AbilityText>().abilityName = AbilityName;
                loc += new Vector3(1.0f, 0, 0);
                orbInstance.name = AbilityName;
            }
            AbilitySelect();
        }
    }

    void AbilitySelect()
    {
        WorldManagement.instance.pause = true;
    }
    void TurretMissileRateUp()
{
    TurretAI.instance.shootCoolDown -= (float)0.2;
}
    
    
    void UpgradeAbiluty(string AbilityName)
    {
        switch (AbilityName)
        {
            case "Turret":
                TurretNum += 1;
                break;
            case "TurretRateUp":
                TurretMissileRateUp();
                break;
        }
    }
}

