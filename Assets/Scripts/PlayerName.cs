using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    private Transform player;
    [SerializeField] private Vector2 offset;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }
    private void FixedUpdate()
    {
        transform.position = new Vector2(player.position.x, player.position.y + offset.y);
    }
}
