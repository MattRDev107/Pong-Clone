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
            PlayerMovement(PlayerSelectionToNum(this.playerSelected));
        }else if (playerSelected == PlayerSelection.AIPlayer) {
            AIMovement();
        }
    }

    private void PlayerMovement(int playerNum) {
        float moveY = Input.GetAxis("Vertical"+ playerNum);
        rb.velocity = new Vector2(0, moveY * speed);
    }

    private void AIMovement() {

    }

    private int PlayerSelectionToNum(PlayerSelection playerSelected) {
        int playerNum = (int)playerSelected;
        return playerNum++;
    }
}
