using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoarderScript : MonoBehaviour
{
    public LogicManager logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Border")
            logic.gameOver();
        // birdAlive = false;
    }
}
