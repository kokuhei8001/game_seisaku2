using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLv : MonoBehaviour {

    struct GunLevel {
        int Lv;
        float keikenti;
        float attck;
        float rate;
        float cool_time;
    };

    private int[] LV = new int[] { 100,200,300,400,500,600,700,800,900,1000 };

    [SerializeField]
    public static int AR = 0;
    public static int LMG = 0;
    public static int SG = 0;
    public static int SR = 0;
    
    public static int ARLV = 1;
    public static int LMGLV = 1;
    public static int SGLV = 1;
    public static int SRLV = 1;
    
    void Start () {
	}
	
	void Update () {

        if (AR > LV[ARLV - 1])
        {
            AR = 0;
            ARLV += 1;
        }
        if (LMG > LV[LMGLV - 1])
        {
            LMG = 0;
            LMGLV += 1;
        }
        if (SG > LV[SGLV - 1])
        {   
            SG = 0;
            SGLV += 1;
        }
        if (SR > LV[SRLV - 1])
        {   
            SR = 0;
            SRLV += 1;
        }


    }
}
