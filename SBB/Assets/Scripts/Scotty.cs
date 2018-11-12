using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scotty : Player {
    // ===== Virtual Inherited Functions =====
    public override void Do(Inputs.Skill s)
    {
        Debug.Log("Scotty Do");
    }

    // ===== Unity Functions =====
    private void Start()
    {
        Do(inputs.skill);
    }

    private void Update()
    {
        
    }
}
