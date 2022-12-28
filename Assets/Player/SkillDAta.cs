using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "SkillDAta", menuName = "SkillData/Create New SkillData")]
public class SkillDAta : ScriptableObject
{
    [SerializeField]
    private int id;
    public int Id { get { return id; } }

    [SerializeField]
    private int turn;
    public int Turn { get { return turn; } }

    [SerializeField]
    private float coolTime;
    public float CoolTime { get { return coolTime; } }



}
