using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    public int type;
    
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        var text = GetComponent<Text>();
        if (CompleteProject.PlayerShooting.GunType == type)
        {
            text.color = new Color(0f / 255f, 255f / 255f, 0f / 255f);
        }
        else {
            text.color = new Color(255f / 255f, 255f / 255f, 255f / 255f);
        }
    }
}
