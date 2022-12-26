using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public Transform Target;
    public float BulletDamage { get; set; }
    private float bulletSpeed = .1f;
    public string Myteam { get; set; }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dir = Target.position - transform.position;
        transform.Translate(dir.normalized * bulletSpeed, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != null)
        {
            if (other.tag != Myteam)
            {
                if (other.gameObject.GetComponent<PlayerStats>() != null)
                {
                    other.gameObject.GetComponent<PlayerStats>().TakeDamage(BulletDamage);
                    Destroy(gameObject);

                }
            }

        }



    }
}
