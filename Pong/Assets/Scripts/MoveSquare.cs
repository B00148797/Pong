using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{

    public new GameObject gameObject;

    Vector3 direction = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (gameObject.transform.position.y >= 4.5)
        {
            direction = new Vector3(direction.x, Random.Range(-1.0f, 0f), 0);
        }

        if (gameObject.transform.position.y <= -4.5)
        {
            direction = new Vector3(direction.x, Random.Range(-1.0f, 0f), 0);
        }



        if (gameObject.transform.position.x >= 12)
        {
            direction = new Vector3(1, Random.Range(-1.0f, 0f), 0);
        }
        else if (gameObject.transform.position.x <= -12)
        {
            direction = new Vector3(-1, Random.Range(0f, 1.0f), 0);
        }*/

        if (gameObject.transform.position.x >= 11)
        {
            direction = new Vector3(-1, Random.Range(-1.0f, 1.0f), 0);
        }
        if (gameObject.transform.position.x <= -11)
        {
            direction = new Vector3(1, Random.Range(-1.0f, 1.0f), 0);
        }

        if (gameObject.transform.position.y >= 5)
        {
            direction = new Vector3(direction.x, Random.Range(-1.0f, 1.0f), 0);
        }
        if (gameObject.transform.position.y <= -5)
        {
            direction = new Vector3(direction.x, Random.Range(-1.0f, 1.0f), 0);
        }

        gameObject.transform.Translate(direction * 10 * Time.deltaTime);
    }
}
