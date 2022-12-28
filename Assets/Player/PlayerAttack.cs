using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : PlayerStats
{
    // Start is called before the first frame update
    [SerializeField]
    Transform target;
    [SerializeField]
    Transform GunPivot;
    [SerializeField]
    GameObject BulletPrefabs;
    private string mytag;

    public bool Skillshot {get;set;}

    void Start()
    { 
        target = null;
        mytag = gameObject.tag;
        InvokeRepeating(nameof(TargetSencer), 0, 0.3f);
    }

    // Update is called once per frame

   
    void TargetSencer() // 타켓탐지
    {
        
        
        Collider[] Sencer = Physics.OverlapSphere(transform.position, 6f);
        foreach(Collider col in Sencer)
        {
            if(col.gameObject.tag == mytag || col.gameObject.tag == "Bullet" || col.gameObject.tag == "Untagged")
            {
                continue;
            }
            target = col.gameObject.transform;
          
        }
    }

    public void BulletShot() // 평타
    {
        
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        if(Skillshot == false)
        {
        attack = Random.Range(10, 15);
        }
        GameObject bullet = Instantiate(BulletPrefabs, GunPivot.position, Quaternion.identity);
        bullet.GetComponent<BulletMove>().Target = target;
        bullet.GetComponent<BulletMove>().BulletDamage = attack;
        bullet.GetComponent<BulletMove>().Myteam = gameObject.tag;
        TurnDown(1);
        Skillshot = false;

       
    }

    // 플레이어 1 스킬 


   

}
