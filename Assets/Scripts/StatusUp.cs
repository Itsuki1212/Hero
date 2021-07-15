using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusUp : MonoBehaviour
{

    int selectedTrainType = 0;
    public Button btnA;
    public Button btnD;
    public Button btnC;
    public Button btnS;
    public Button start;

    private void OnEnable()
    {
        TrainingButtonClear();
        start.interactable = false;
    }

    private void TrainingButtonClear()
    {
        btnA.interactable = true;
        btnD.interactable = true;
        btnC.interactable = true;
        btnS.interactable = true;
        start.interactable = true;
    }
    public void OnClickAttack()
    {
        TrainingButtonClear();
        btnA.interactable = false;
        selectedTrainType = 1;
    }
    public void OnClickDiffense()
    {
        TrainingButtonClear();
        selectedTrainType = 2;


        btnD.interactable = false;
    }
    public void OnClickCoop()
    {
        TrainingButtonClear();

        btnC.interactable = false;
        selectedTrainType = 3;

    }
    public void OnClickSpd()
    {
        TrainingButtonClear();
        btnS.interactable = false;
        selectedTrainType = 4;

    }

    public void OnClickStart()
    {
        Debug.Log(selectedTrainType);

        if (selectedTrainType == 1)
        {
            foreach (DataHeroParam param in DataManager.Instance.dataHero.list)
            {
          if(param.heroId == 1)
                {
                    param.atk += Random.Range(3, 6);
                }
                else
                {
                    param.atk += Random.Range(1, 4);
                }
            }
        }else if(selectedTrainType == 2)
        {
            foreach (DataHeroParam param in DataManager.Instance.dataHero.list)
            {
                param.def += 3;
            }
        }else if(selectedTrainType == 3)
        {
            foreach (DataHeroParam param in DataManager.Instance.dataHero.list)
            {
                param.cop += 3;
            }
        }else if(selectedTrainType == 4)
        {
            foreach (DataHeroParam param in DataManager.Instance.dataHero.list)
            {
                param.spd += 3;
            }
        }

        DataManager.Instance.UpdateHeroScriptableObject();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
