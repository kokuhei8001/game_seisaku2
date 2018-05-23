using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public int num = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 1, 0, Space.World);
    }


    private void OnCollisionEnter(Collision collision)
    {
        var player = GetComponent<PlayerHealth>();
        if (player != null)
        {
            if (num == 1)
            {
                //player.PlayerHealth.startingHealth += 50;
            }
        }
    }
}
