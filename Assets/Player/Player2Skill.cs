using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Skill : MonoBehaviour
{
    PlayerAttack playerAttack;
    public bool bigSkillOff { get; set; }
    float elaspedTime;
    IEnumerator Cooltime;
    // Start is called before the first frame update
    void Start()
    {
        playerAttack = GetComponent<PlayerAttack>();
        
    }

    // Update is called once per frame
    public void PlayerTwoSkillOne()
    {
        if(bigSkillOff)
        {
            PlayerTwoSkillTwo();
            return;
        }
        playerAttack.attack = (float)Math.Truncate(((playerAttack.attack * 1.3f) * 10) / 10);
        playerAttack.TurnUp(2);
        playerAttack.BulletShot();
        playerAttack.Skillshot = true;
    }

    public void PlayerTwoSkillTwo()
    {
        playerAttack.attack = (float)Math.Truncate(((playerAttack.attack * 0.9f) * 10) / 10);
        playerAttack.BulletShot();
        playerAttack.BulletShot();
        playerAttack.TurnUp(4);
        playerAttack.Skillshot = true;
        bigSkillOff = true;
        Cooltime = CoolTimeSkill();
        StartCoroutine(Cooltime);
    }

    IEnumerator CoolTimeSkill()
    {
        while(bigSkillOff)
        {
            elaspedTime += Time.deltaTime;
            if(elaspedTime >= 6f)
            {
                elaspedTime = 0f;
                bigSkillOff = false;
                yield  break;
            }
            yield return null;
        }
    }

 
}
