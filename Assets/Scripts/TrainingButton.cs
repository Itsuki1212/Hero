using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public struct TrainingButtonData
{
    public HeroColor heroColor;
    public TrainingType trainingType;
}

[System.Serializable]
public class EventTrainingButtonData : UnityEvent<TrainingButtonData>
{
    public EventTrainingButtonData() { }
}

public class TrainingButton : MonoBehaviour
{
    public TrainingButtonData data;
    public EventTrainingButtonData eventTrainingButtonData = new EventTrainingButtonData();


    private void Awake()
    {
        Button button = GetComponent<Button>();
        if (null != button)
        {
            button.onClick.AddListener(() =>{
                eventTrainingButtonData.Invoke(data);
            });
        }
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
