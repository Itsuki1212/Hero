using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BossSta")]
public class BossStatus : ScriptableObject
{
    [Header("名前")]
    public string b_name;
    [Header("体力")]
    public int b_HP;
    [Header("スキル")]
    public int b_BP;
    [Header("こうげき")]
    public int b_atk;
    [Header("ぼうぎょ")]
    public int b_def;
    [Header("すばやさ")]
    public int b_spd;
}
