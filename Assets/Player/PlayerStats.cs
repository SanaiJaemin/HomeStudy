using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField]
    //public float CurrentHp { get; set; }
    //[SerializeField]
    //public float MaxHp { get; set; }
    public float CurrentHp;
    public float MaxHp;
    public float Speed { get; set; }
    protected float attack;
    [SerializeField]
    TextMeshProUGUI Text;
    void Awake()
    {
        MaxHp = 100f;
        CurrentHp = MaxHp;
        
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
        CurrentHp -= Damage;
        string DamageUi = "-" + Damage.ToString();
        Text.text = DamageUi;
    }

    

}
