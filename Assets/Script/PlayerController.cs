using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Transform front;
    public Transform right;
    public Transform left;
    public Transform back;

    public Vector3 movepoint;

	// speed1を制御する
	public float speed = 10;


	void FixedUpdate ()
	{
		//入力をxとzに代入
		//float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis ("Vertical");
        float x = Input.GetAxis("Horizontal");
         
        if (z > 0)
        {
            movepoint = z * ( front.position - GetComponent<Transform>().position);
        }
        if (z < 0)
        {
            movepoint = -z * (back.position - GetComponent<Transform>().position);
        }
        if (x > 0)
        {
            movepoint = x * (right.position - GetComponent<Transform>().position);
        }
        if (x < 0)
        {
            movepoint = -x * (left.position - GetComponent<Transform>().position);
        }
        if (x == 0 && z == 0)
        {
            movepoint = 0 * movepoint;
        }

        Rigidbody rigidbody = GetComponent<Rigidbody> ();

        // 同一のGameObjectが持つRigidbodyコンポーネントを取得
        rigidbody.AddForce(movepoint.x*speed, 0, movepoint.z*speed);
	}
}
