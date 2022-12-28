using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Skill : MonoBehaviour
{
    PlayerAttack playerAttack;
    public bool BigSkillOff { get; set; }
    float elaspedTime;
    IEnumerator Cooltime;
    // Start is called before the first frame update
    void Start()
    {
        playerAttack = GetComponent<PlayerAttack>();
    }

    public void PlayerSkillOne()
    {
        if(BigSkillOff)
        {
            PlayerSkillTwo();
            return;
        }

        playerAttack.HpRegenation();
        playerAttack.TurnUp(3);
    }
    public void PlayerSkillTwo()
    {
        playerAttack.attack = 50;
        playerAttack.attack += (float)Math.Truncate(((playerAttack.Defense * 0.1f)*10)/10);
        playerAttack.TurnUp(3);
        playerAttack.BulletShot();
        playerAttack.Skillshot = true;
        BigSkillOff = true;
        Cooltime = CoolTimeSkill();
        StartCoroutine(Cooltime);


    }

    IEnumerator CoolTimeSkill()
    {
        while (BigSkillOff)
        {
            elaspedTime += Time.deltaTime;
            if (elaspedTime >= 3f)
            {
                elaspedTime = 0f;
                BigSkillOff = false;
                yield break;
            }
            yield return null;
        }
    }
}
