using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusView : MonoBehaviour
{
    public PlayerStatus playerstatus;
    public TextMeshProUGUI txt_atk;
    public TextMeshProUGUI txt_def;
    public TextMeshProUGUI txt_cop;
    public TextMeshProUGUI txt_spd;

    public void Refresh()
    {
        txt_atk.text = playerstatus.p_atk.ToString();
        txt_def.text = playerstatus.p_def.ToString();
        txt_cop.text = playerstatus.p_cop.ToString();
        txt_spd.text = playerstatus.p_spd.ToString();
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
