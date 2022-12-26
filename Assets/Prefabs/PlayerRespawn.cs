using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerPrefab;
    int maxplayerCount = 2;
    float maxRange = 5;

    // Start is called before the first frame update

    void OnEnable()
    {
        
        for(int i = 0; i < maxplayerCount; i++ )
        {
            Vector3 Randompos = new Vector3(0, 1,0 + i* 5);
            GameObject Player = Instantiate(PlayerPrefab, Randompos, transform.rotation);
            string text = i.ToString();
            Player.gameObject.tag = text;
            Player.GetComponent<PlayerStats>().Speed = Random.Range(1, 3);
        }
      
    }


}
