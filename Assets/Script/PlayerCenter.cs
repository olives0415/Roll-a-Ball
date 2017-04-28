using UnityEngine;
using System.Collections;

public class PlayerCenter : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        GetComponent<Transform>().position = target.position;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.Rotate(0, -2, 0);
        }

        if (Input.GetKey(KeyCode.X))
        {
            this.transform.Rotate(0, 2, 0);
        }
    } 
}