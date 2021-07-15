using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EnemySta")]
public class EnemyStatus : ScriptableObject
{
    [Header("名前")]
    public string e_name;
    [Header("ザコ体力")]
    public int e_HP;
    [Header("こうげき")]
    public int e_atk;
    [Header("ぼうぎょ")]
    public int e_def;
    [Header("すばやさ")]
    public int e_spd;
}