using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SkillManager skillManager;
    private void Start()
    {
        skillManager = GameObject.FindGameObjectWithTag("SkillTable").gameObject.GetComponent<SkillManager>();
        
        
    }
}
