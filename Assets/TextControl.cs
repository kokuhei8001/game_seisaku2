using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    [SerializeField]
    public int type;
    private int[] GunEP;
    
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        GunEP = new int[] { GunLv.AR, GunLv.LMG, GunLv.SG, GunLv.SR };



        var text = GetComponent<Text>();
        if (CompleteProject.PlayerShooting.GunType == type)
        {
            text.color = new Color(0f / 255f, 255f / 255f, 0f / 255f);
        }
        else {
            text.color = new Color(255f / 255f, 255f / 255f, 255f / 255f);
        }


        //経験値
        if (type == 11)
        {
            text.text = GunEP[0].ToString() ;
        }
        if (type == 22)
        {
            text.text = GunEP[1].ToString();
        }
        if (type == 33)
        {
            text.text = GunEP[2].ToString();
        }
        if (type == 44)
        {
            text.text = GunEP[3].ToString();
        }

        if (type == 111)
        {
            if (GunLv.ARLV == 10)
            {
                text.text = "MAX";
            }
            else {
                text.text = "Lv." + GunLv.ARLV.ToString();
            }
        }
        if (type == 222)
        {
            if (GunLv.LMGLV == 10)
            {
                text.text = "MAX";
            }
            else
            {
                text.text = "Lv." + GunLv.LMGLV.ToString();
            }
        }



    }
}
