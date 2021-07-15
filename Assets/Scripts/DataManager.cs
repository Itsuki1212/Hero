using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using anogamelib;

public class DataManager : Singleton<DataManager>
{
    public TextAsset taMasterItem;
    public MasterItem masterItem;
    public DataHero dataHero;
    public List<PlayerStatus> playerStatusList;
    private string savePath = "data";
    public List<StatusView> statusViews;

    public override void Initialize()
    {
        base.Initialize();
        masterItem = new MasterItem();
        masterItem.Load(taMasterItem);
        foreach(MasterItemParam p in masterItem.list)
        {
            Debug.Log(p.itemName);

        }
        
        dataHero = new DataHero();
        dataHero.SetSaveFilename($"{savePath}/dataHero");
        if(dataHero.Load() == false)
        {
            dataHero.Save();
        }
        UpdateHeroScriptableObject();
    }

    public void UpdateHeroScriptableObject()
    {
        foreach (PlayerStatus status in playerStatusList)
        {
            DataHeroParam data = dataHero.list.Find(p => p.heroId == status.heroid);
            if (data != null)
            {
                status.p_HP = data.hp;
                status.p_atk = data.atk;
                status.p_def = data.def;
                status.p_cop = data.cop;
                status.p_spd = data.spd;

            }
        }
        RefreshStatusView();
    }

    public void RefreshStatusView()
    {
        foreach(StatusView view in statusViews)
        {
            view.Refresh();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
