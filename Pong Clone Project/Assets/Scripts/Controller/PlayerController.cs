using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 10.0f;
    public enum PlayerSelection { PlayerOne, PlayerTwo, AIPlayer };
    public PlayerSelection playerSelected;

    private Rigidbody2D rb;
    private GameObject ball;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        ball = GameObject.FindGameObjectWithTag("ball");
    }

    private void Update() {
        if(playerSelected != PlayerSelection.AIPlayer) {
            PlayerMovement();
        }else if (playerSelected == PlayerSelection.AIPlayer) {
            AIMovement();
        }
    }
}
