using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Camera cam;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        //cam = GetComponent<Camera>();

        switch (SceneManager.GetActiveScene().name){
            case "Home":
                cam.backgroundColor = color;
                break;
            case "OnePlayer":
                cam.backgroundColor = color;
                break;
            case "TwoPlayers":
                cam.backgroundColor = color;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
