using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{

    public float CurrentHp { get; set; }
    public float MaxHp { get; set; }
    public float Speed { get; set; }
    public float attack { get; set; }
    public float Defense { get; set; }

    public bool SkillOn { get; set; }

    public int SkillTurn { get; set; }
    [SerializeField]
    TextMeshProUGUI Text;
    void Awake()
    {
        MaxHp = 100f;
        CurrentHp = MaxHp;
        Defense = 2f;
        SkillTurn = 3;
        
    }
    void FixedUpdate()
    {
        if (CurrentHp <= 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
    // Update is called once per frame

    public void TakeDamage(float Damage)
    {
        float totalDamage = Damage - Defense;
        CurrentHp -= totalDamage;
        string DamageUi = "-" + totalDamage.ToString();
        Text.text = DamageUi;
    }

    public void TurnDown(int Count)
    {
        SkillTurn -= Count;
    }

    public void TurnUp(int Count)
    {
        if (SkillTurn == 0)
        {

            SkillTurn += Count;
        }
    }

    public void HpRegenation()
    {
        CurrentHp += (MaxHp*0.2f);
    }

    

}
