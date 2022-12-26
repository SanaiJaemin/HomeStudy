using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManaer : MonoBehaviour
{
    [SerializeField]
    GameObject EndGame;
    // Start is called before the first frame update
    void Start()
    {
        EndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0)
        {
            EndGame.SetActive(true);
        }
    }
}
