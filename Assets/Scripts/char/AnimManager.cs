using UnityEngine;

public class AnimManager : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] NewMove move;

    private bool left, right, front, back;

    public void AnimStop()
    {
        if (right) anim.Play("right_idle");
        if (left) anim.Play("left_idle");
        if (front) anim.Play("front_idle");
        if (back) anim.Play("back_idle");
    }

    private void Starter()
    {
        if (move.moveVector.y == 0)
        {
            switch (move.moveVector.x)
            {
                case > 0:
                    if (move.run)
                    {
                        anim.Play("right_run");
                    }
                    else if (!move.run)
                    {
                        anim.Play("right_walk");
                    }
                    break;
                case < 0:
                    if (move.run)
                    {
                        anim.Play("left_run");
                    }
                    else if (!move.run)
                    {
                        anim.Play("left_walk");
                    }
                    break;
            }
        }
        switch (move.moveVector.y)
        {
            case > 0:
                if (move.run)
                {
                    anim.Play("back_run");
                }
                else if (!move.run)
                {
                    anim.Play("back_walk");
                }
                break;
            case < 0:
                if (move.run)
                {
                    anim.Play("front_run");
                }
                else if (!move.run)
                {
                    anim.Play("front_walk");
                }
                break;
        }
    }

    public void RightStop()
    {
        right = true;
        left = false;
        front = false;
        back = false;
        if (move.moveVector.y == 0 && move.moveVector.x == 0)
            anim.Play("right_idle");
    }

    public void LeftStop()
    {
        right = false;
        left = true;
        front = false;
        back = false;
        if (move.moveVector.y == 0 && move.moveVector.x == 0)
            anim.Play("left_idle");
    }

    public void FrontStop()
    {
        right = false;
        left = false;
        front = true;
        back = false;
        if (move.moveVector.y == 0 && move.moveVector.x == 0)
            anim.Play("front_idle");
    }

    public void BackStop()
    {
        right = false;
        left = false;
        front = false;
        back = true;
        if (move.moveVector.y == 0 && move.moveVector.x == 0)
            anim.Play("back_idle");
    }

    public void Jerk()
    {
        if (move.moveVector.x != 0)
        {
            if (move.moveVector.x > 0)
            {
                anim.Play("right_jerk");
            }
            if (move.moveVector.x < 0)
            {
                anim.Play("left_jerk");
            }
        }
        if (move.moveVector.y != 0)
        {
            if (move.moveVector.y > 0)
            {
                anim.Play("back_jerk");
            }
            if (move.moveVector.y < 0)
            {
                anim.Play("front_jerk");
            }
        }
    }

    private void Update()
    {
        if (!move.jerk) Starter();
    }
}
