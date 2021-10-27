using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer1 : MonoBehaviour
{

    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if(this.transform.position.y >= 4.5)
        {
            this.transform.position = new Vector3(-8f, 4.5f, 0f);
        }

        if (this.transform.position.y <= -4.5)
        {
            this.transform.position = new Vector3(-8f, -4.5f, 0f);
        }

        if(Input.GetKey(KeyCode.Escape)) SceneManager.LoadScene("Home");
    }
}
