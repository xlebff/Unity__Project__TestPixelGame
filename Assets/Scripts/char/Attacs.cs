using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacs : MonoBehaviour
{
    [SerializeField] SkillTree skills;

    public void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.E) && skills.Check(0))
        {
            //Action(transform.position, 15, 4, 20, true);
        }
    }

    void Try()
    {
        
    }

    /*static GameObject NearTarget(Vector3 position, Collider2D[] array)
    {
        Collider2D current = null;
        float dist = Mathf.Infinity;

        foreach (Collider2D coll in array)
        {
            float curDist = Vector3.Distance(position, coll.transform.position);

            if (curDist < dist)
            {
                current = coll;
                dist = curDist;
            }
        }

        return (current != null) ? current.gameObject : null;
    }

    // point - точка контакта
    // radius - радиус поражения
    // layerMask - номер слоя, с которым будет взаимодействие
    // damage - наносимый урон
    // allTargets - должны-ли получить урон все цели, попавшие в зону поражения
    public static void Action(Vector2 point, float radius, int layerMask, int damage, bool allTargets)
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(point, radius, 1 << layerMask);
        Debug.Log("g");
        if (!allTargets)
        {
            GameObject obj = NearTarget(point, colliders);
            if (obj != null && obj.GetComponent<EnemyProfile>())
            {
                obj.GetComponent<EnemyProfile>().health -= damage;
            }
            return;
        }

        foreach (Collider2D hit in colliders)
        {
            if (hit.GetComponent<EnemyProfile>())
            {
                hit.GetComponent<EnemyProfile>().health -= damage;
            }
        }
    } */
}

