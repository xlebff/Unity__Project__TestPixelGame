using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class NewMove : MonoBehaviour
{
    [SerializeField] Stamina st;
    [SerializeField] AnimManager am;
    public Rigidbody2D rb;
    public Vector2 moveVector;

    public int normalSpeed;
    public int fastSpeed;
    public int jerkSpeed;
    public int battleSpeed;
    public int speed;

    public bool run;
    public bool jerk;
    public bool battle;

    public void Stop()
    {
        am.AnimStop();
        am.enabled = false;
    }
    public void Work()
    {
        am.enabled = true;
    }

    private void Walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        if (!run && !jerk) speed = normalSpeed;
        run = false;
        rb.MovePosition(rb.position + moveVector * speed * Time.smoothDeltaTime);
    }

    private void Run()
    {
        if (moveVector.x != 0 || moveVector.y != 0)
        {
            speed = fastSpeed;
            run = true;
        }
    }

    private void BattleRun()
    {
        if (st.RunCheck())
        {
            if (moveVector.x != 0 || moveVector.y != 0)
            {
                speed = battleSpeed;
                run = true;
            }
        }
    }

    async private void Jerk()
    {
        if (st.JerkCheck())
        {
            if (moveVector.x != 0 || moveVector.y != 0)
            {
                st.stamina -= st.jerkStamina;
                jerk = true;
                speed = jerkSpeed;
                am.Jerk();
                await Task.Delay(500);
                jerk = false;
            }
        }
    }

    private void ShiftCheck() 
    {
        if (!battle)
        {
            if (st.RunCheck()) Run();
        }
        else if (battle)
        {
            if (!jerk && st.RunCheck() || !st.JerkCheck() && st.RunCheck()) BattleRun();
        }
    }

    private void FixedUpdate()
    {
        Walk();
        if (Input.GetKey(KeyCode.LeftShift)) ShiftCheck();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && battle) Jerk();
    }
}
