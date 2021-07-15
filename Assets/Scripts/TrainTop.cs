using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TrainTop : MonoBehaviour
{
    public Button startButton;
    public TextMeshProUGUI pointtext;
    private int point;


   

     public void PushedTrainingButton(TrainingButtonData data)
    {
        Debug.Log(data.heroColor);

        if (point > 0)
        {
            point -= 1;
            ShowPointText(point);
           
        }

        startButton.interactable = true;
    }

    private void ShowPointText(int num)
    {
       
        TrainingButton[] buttons = transform.GetComponentsInChildren<TrainingButton>();
        foreach (TrainingButton btn in buttons)
        {
            btn.GetComponent<Button>().interactable = 0<num;
        }

    }


    private void OnEnable()
    {
        /*ResetUI();
        foreach(DataHeroParam p in DataManager.Instance.dataHero.list)
        {
            p.hp += 1;
        }*/
        DataManager.Instance.dataHero.Save();
    }
}
