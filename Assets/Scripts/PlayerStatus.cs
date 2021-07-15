using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerSta")]
public class PlayerStatus : ScriptableObject
{
    [Header("ID")]
    public int heroid;
    [Header("なまえ")]
    public string p_name;
    [Header("体力")]
    public int p_HP;
    [Header("スキル")]
    public int p_BP;
    [Header("こうげき")]
    public int p_atk;
    [Header("ぼうぎょ")]
    public int p_def;
    [Header("すばやさ")]
    public int p_spd;
    [Header("れんけい")]
    public int p_cop;
}