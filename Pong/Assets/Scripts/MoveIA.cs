using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIA : MonoBehaviour
{
    public new GameObject gameObject;
    public new GameObject objectASuivre;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(8, objectASuivre.transform.position.y, 0);
    }
}
