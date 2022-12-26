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
    [SerializeField]
    GameObject End;
    

    PlayerStats playerStats;
    PlayerAttack playerAttack;
    float elaspedTime;
   

    private void Awake()
    {
        playerStats = GetComponent<PlayerStats>();
        playerAttack = GetComponent<PlayerAttack>();
    }
    void Start()
    {
        attackbar.value = 0;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
       
        elaspedTime += Time.deltaTime;
        attackbar.value = Mathf.Lerp(0, 1,elaspedTime * playerStats.Speed);
        if (attackbar.value >= 0.95f)
        {
            elaspedTime = 0f;
            attackbar.value = 0f;
            playerAttack.BulletShot();

        }
        Hpbar.value = Mathf.Lerp(Hpbar.value, playerStats.CurrentHp / playerStats.MaxHp, Time.deltaTime); //선형보간함수 이쁘게 보임
        
        
    }
}
