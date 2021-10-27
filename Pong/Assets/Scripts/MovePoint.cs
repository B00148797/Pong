using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePoint : MonoBehaviour
{

    float speed = 10.0f;
    Vector3 direction = Vector3.right;
    int scorePlayer = 0;
    int scoreIA = 0;

    public new GameObject gameObject;
    public new Text textScore;

    void PrintScore()
    {
        Debug.Log("Score de la partie : " + (scoreIA + "  -  " + scorePlayer));
        textScore.text = (scoreIA + "  -  " + scorePlayer);

        direction = Vector3.right;
        gameObject.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.transform.position.x >= 13)
        {
            scoreIA++;
            PrintScore();
        }
        else if (gameObject.transform.position.x <= -13)
        {
            scorePlayer++;
            PrintScore();
        }

        if(gameObject.transform.position.y >= 5.5)
        {
            direction = new Vector3(direction.x, Random.Range(-1.0f, 0f), 0);
        }
        else if (gameObject.transform.position.y <= -5.5)
        {
            direction = new Vector3(direction.x, Random.Range(0f, 1.0f), 0);
        }

        //this.transform.position += (direction * speed * Time.deltaTime);
        this.transform.Translate(direction * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //MODE PLAYER VS IA
        if (collision.gameObject.name == "SquarePlayer")
        {
            direction = new Vector3(1, Random.Range(-1.0f, 1.0f), 0);
        }

        if (collision.gameObject.name == "SquareIA")
        {
            direction = new Vector3(-1, Random.Range(-1.0f, 1.0f), 0);
        }

        //MODE PLAYER VS PLAYER
        if (collision.gameObject.name == "SquarePlayerOne")
        {
            direction = new Vector3(1, Random.Range(-1.0f, 1.0f), 0);
        }

        if (collision.gameObject.name == "SquarePlayerTwo")
        {
            direction = new Vector3(-1, Random.Range(-1.0f, 1.0f), 0);
        }
    }
}
