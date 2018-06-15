using UnityEngine;

namespace CompleteProject
{
    public class GameOverManager : MonoBehaviour
    {
        public PlayerHealth playerHealth; 

        public static int GameMode = 0;
        //0 = エンドレス
        //1 = サドンデス
        //2 = 100体タイムアタック

        Animator anim;

        void Awake ()
        {
            anim = GetComponent <Animator> ();
        }


        void Update ()
        {
            if(playerHealth.currentHealth <= 0)
            {
                anim.SetTrigger ("GameOver");
            }

            if (GameMode == 2)
            {
                if (ScoreManager.score >= 100)
                {
                    anim.SetTrigger("GameOver");
                    TextControl.death = true;
                }
            }
        }
    }
}