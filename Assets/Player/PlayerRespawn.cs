using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerPrefab;
    int maxplayerCount = 2;
    // Start is called before the first frame update

    void OnEnable()
    {
        
        for(int i = 0; i < maxplayerCount; i++ )
        {
            Vector3 Randompos = new Vector3(0, 1,0 + i* 5);
            GameObject Player = Instantiate(PlayerPrefab, Randompos, transform.rotation);
            string text = i.ToString();
            Player.gameObject.tag = text;
            if(Player.gameObject.tag == "0")
            {
                Player.gameObject.GetComponent<Player1Skill>().enabled = true;
                Player.gameObject.GetComponent<Player2Skill>().enabled = false;
            }
            else if (Player.gameObject.tag == "1")
            {
                Player.gameObject.GetComponent<Player1Skill>().enabled = false;
                Player.gameObject.GetComponent<Player2Skill>().enabled = true;
            }
            Player.GetComponent<PlayerStats>().Speed = Random.Range(1, 3);
        }
      
    }


}
