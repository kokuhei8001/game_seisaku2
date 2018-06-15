using UnityEngine;

namespace CompleteProject
{
    public class GameOverManager : MonoBehaviour
    {
        public PlayerHealth playerHealth;       // Reference to the player's health.


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

            //if (ScoreManager.score > 100)
            //{
            //    anim.SetTrigger("GameOver");
            //}
        }
    }
}