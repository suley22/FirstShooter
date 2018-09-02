using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int vel;
    Rigidbody RbPlayer;

    // Use this for initialization
    void Start () {
        RbPlayer = GetComponent<Player>().GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Dispara  "+RbPlayer.position.x + "   "+ RbPlayer.position.y);
            var bullet = Resources.Load("Bullet");

            Instantiate(bullet, new Vector3(RbPlayer.position.x - 1, RbPlayer.position.y + 1, RbPlayer.position.z), Quaternion.identity);
        }        
    }

    private void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * vel;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * vel;

        //transform.Rotate(new Vector3(0, x, 0) * Time.deltaTime);
        transform.Translate(x, 0, z);
    }
}
