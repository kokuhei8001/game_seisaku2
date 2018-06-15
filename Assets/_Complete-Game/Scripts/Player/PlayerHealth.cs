using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

namespace CompleteProject
{
    public class PlayerHealth : MonoBehaviour
    {
        public int startingHealth;                                 
        public int currentHealth;                                  
        public Slider healthSlider;                                
        public Image damageImage;                                  
        public AudioClip deathClip;                                
        public float flashSpeed = 5f;                              
        public Color flashColour = new Color(1f, 0f, 0f, 0.1f);    


        Animator anim;                                             
        AudioSource playerAudio;                                   
        PlayerMovement playerMovement;                             
        PlayerShooting playerShooting;                             
        bool isDead;                                               
        bool damaged;                                                                        


        void Awake ()
        {
            anim = GetComponent <Animator> ();
            playerAudio = GetComponent <AudioSource> ();
            playerMovement = GetComponent <PlayerMovement> ();
            playerShooting = GetComponentInChildren <PlayerShooting> ();

            //ゲームモードでHPを決める
            if (GameOverManager.GameMode == 1)
            {
                startingHealth = 1;
            }
            else { startingHealth = 100; }
            currentHealth = startingHealth;
        }


        void Update ()
        {
            if(damaged)
            {
                damageImage.color = flashColour;
            }
            else
            {
                damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
            }

            // Reset the damaged flag.
            damaged = false;
        }


        public void TakeDamage (int amount)
        {
            damaged = true;
            
            currentHealth -= amount;
            
            healthSlider.value = currentHealth;
            
            playerAudio.Play ();
            
            if(currentHealth <= 0 && !isDead)
            {
                Death ();
            }
        }


        void Death ()
        {
            // Set the death flag so this function won't be called again.
            isDead = true;

            // Turn off any remaining shooting effects.
            playerShooting.DisableEffects ();

            // Tell the animator that the player is dead.
            anim.SetTrigger ("Die");

            // Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
            playerAudio.clip = deathClip;
            playerAudio.Play ();

            // Turn off the movement and shooting scripts.
            playerMovement.enabled = false;
            playerShooting.enabled = false;
        }


        public void RestartLevel ()
        {
            // Reload the level that is currently loaded.
            SceneManager.LoadScene (0);
        }

    }
}