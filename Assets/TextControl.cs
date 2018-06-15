using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    [SerializeField]
    public int type;
    private int[] GunEP;
    public static bool death = false;

    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    //　前のUpdateの時の秒数
    private float oldSeconds;


    private void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
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
            if (GunLv.ARLV == 10)
            {
                text.text = "∞";
            }
            else { text.text = GunEP[0].ToString(); }
        }
        if (type == 22)
        {
            if (GunLv.LMGLV == 10)
            {
                text.text = "∞";
            }
            else
            {
                text.text = GunEP[1].ToString();
            }
        }
        if (type == 33)
        {
            if (GunLv.SGLV == 10)
            {
                text.text = "∞";
            }
            else
            {
                text.text = GunEP[2].ToString();
            }
        }
        if (type == 44)
        {
            if (GunLv.SRLV == 10)
            {
                text.text = "∞";
            }
            else
            {
                text.text = GunEP[3].ToString();
            }
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

        if (type == 999)
        {
            if (death)
            {
                text.text = "Clear Time : " + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
            }
            else
            {
                seconds += Time.deltaTime;
                if (seconds >= 60f)
                {
                    minute++;
                    seconds = seconds - 60;
                }
                oldSeconds = seconds;
            }

        }



    }
}
