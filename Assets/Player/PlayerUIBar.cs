using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerUIBar : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Slider Hpbar;
    [SerializeField]
    Slider attackbar;


    PlayerStats playerStats;
    PlayerAttack playerAttack;
    float elaspedTime;
    Player1Skill player1Skill;
    Player2Skill player2Skill;

    private void Awake()
    {
        
            player1Skill = GetComponent<Player1Skill>();
            player2Skill = GetComponent<Player2Skill>();
        
        playerStats = GetComponent<PlayerStats>();
        playerAttack = GetComponent<PlayerAttack>();
    }
    void Start()
    {
        attackbar.value = 0;

    }

    // Update is called once per frame
    void LateUpdate()
    {

        elaspedTime += Time.deltaTime;
        attackbar.value = Mathf.Lerp(0, 1, elaspedTime * playerStats.Speed); // 행동게이지
        if (attackbar.value >= 0.95f)
        {
            if (playerStats.SkillTurn == 0)
            {

                if (gameObject.tag == "0")
                {   
                        player1Skill.PlayerSkillOne();


                }
                else if (gameObject.tag == "1")
                {
                   
                        player2Skill.PlayerTwoSkillOne();
                        
                    
                }
            }

            elaspedTime = 0f;
            attackbar.value = 0f;
            playerAttack.BulletShot();

        }
        Hpbar.value = Mathf.Lerp(Hpbar.value, playerStats.CurrentHp / playerStats.MaxHp, Time.deltaTime); //선형보간함수 이쁘게 보임


    }
}
