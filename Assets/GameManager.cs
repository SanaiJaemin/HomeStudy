using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerPrefab;
    int num; 
    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i < 2; i ++)
        {
            Vector3 Randompos = new Vector3(Random.Range(0, 3), 1, Random.Range(0, 3));
            GameObject Player = Instantiate(PlayerPrefab, Randompos, Quaternion.identity);
            string text = i.ToString();
            Player.gameObject.tag = text;
            Player.GetComponent<PlayerStats>().Speed = Random.Range(0, 3);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
