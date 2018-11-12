using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ===== Custom Classes =====

    public class Inputs
    {
        public Vector2 movement = Vector2.zero;
        public bool isGrounded = false;

        public enum Skill
        {
            NULL = 0,

            A = 10,
            A_Up = 11,
            A_Down = 12,
            A_Left = 13,
            A_Right = 14,

            B = 20,
            B_Up = 21,
            B_Down = 22,
            B_LeftRight = 23,

            X_Y = 30,

            L_R = 40
        }
        public Skill skill = Skill.NULL;
    }
    public Inputs inputs;

    public class Stats
    {
        public int speed = 1;
        public int wound = 0;
    }
    public Stats stats;

    // ===== Unity Functions =====

    void Start()
    {

    }

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
        Attack();
    }

    // ===== Custom Functions =====

    void ProcessInputs () {
        inputs.movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		
	}

    void Move()
    {
        transform.Translate(inputs.movement * stats.speed);
    }

    void Attack()
    {
        Do(inputs.skill);
    }

    public virtual void Do(Inputs.Skill s)
    {

    }
}