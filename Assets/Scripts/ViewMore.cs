using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewMore : MonoBehaviour
{
    public PlayerStatus playerstatus2;
    public TextMeshProUGUI txt_name;
    public TextMeshProUGUI txt_HP;
    public TextMeshProUGUI txt_BP;
    public TextMeshProUGUI txt_atk2;
    public TextMeshProUGUI txt_def2;
    public TextMeshProUGUI txt_cop2;
    public TextMeshProUGUI txt_spd2;

    public void Refresh()
    {
        txt_name.text = playerstatus2.p_name;
        txt_HP.text = "HP\n " + playerstatus2.p_HP.ToString();
        txt_BP.text = "BP\n " + playerstatus2.p_BP.ToString();
        txt_atk2.text = "こうげき\n " + playerstatus2.p_atk.ToString();
        txt_def2.text = "ぼうぎょ\n " + playerstatus2.p_def.ToString();
        txt_cop2.text = "れんけい\n " + playerstatus2.p_cop.ToString();
        txt_spd2.text = "すばやさ\n " + playerstatus2.p_spd.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
