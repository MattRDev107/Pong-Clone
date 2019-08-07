using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour{

    GameObject ball;

    // Start is called before the first frame update
    private void Start(){
        SpawnBall();
    }

    private void SpawnBall() {
        ball = GameObject.Instantiate((GameObject)Resources.Load("Prefabs/Ball", typeof(GameObject)));
        ball.transform.position = Vector2.zero;
    }
}
