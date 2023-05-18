using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce=9;
    public float gravityModifier=1;
    public bool isOnGround=true, isGameOver=false;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtSplatterParticle;
    public AudioClip jumpSound,crashSound;
    private AudioSource playerAudioSource;
    int sayac;
    


    void Start(){
        playerRb= GetComponent<Rigidbody>();
        playerAnim= GetComponent<Animator>();
        playerAudioSource= GetComponent<AudioSource>();
        Physics.gravity*=gravityModifier;
        sayac=0;
        

    }
    void Update(){
       
        if(Input.GetKeyDown(KeyCode.Space) && sayac<2 && !(playerAnim.GetBool("Death_b")))
        {
            playerRb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround=false;
            playerAnim.SetTrigger("Jump_trig");
            playerAudioSource.PlayOneShot(jumpSound,1);
            sayac++;
           
            
        }
        if( !isOnGround && !isGameOver){
           
            dirtSplatterParticle.Play();
           
        }
        
    }
    private void OnCollisionEnter(Collision col){
        if(col.gameObject.CompareTag("Ground"))
        {
            isOnGround=true;
            sayac=0;


        }
        else if(col.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            isGameOver=true;
            playerAnim.SetBool("Death_b",true);
            explosionParticle.Play();
            playerAudioSource.PlayOneShot(crashSound,1);
        }
    }

}
