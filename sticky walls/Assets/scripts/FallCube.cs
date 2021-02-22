using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallCube : MonoBehaviour
{

    public ParticleSystem explosionPlayer;

    public MeshRenderer playerMesh;

    public Collider playerCol;

    public Rigidbody rb;

    public bool invins;

    public float waitTime;

    public Color invincible;

    public Color original;

    public GameObject deathScreen;

    public AudioSource deathsound;
    public AudioSource invissound;

    /*public animator deathAnim; */


    private void OnCollisionEnter(Collision collision)
    {




       

        if (collision.gameObject.tag == "Enemy" && invins == false) 
        {

            StartCoroutine(killPlayer());
            
            
        }



        if (collision.gameObject.tag == "Enemy" && invins == true)
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Enemy" && invins == true)
        {
            enableScript();
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "invis" && invins == false)
        {
            invissound.Play();
            invins = true;
            Destroy(other.gameObject);
            StartCoroutine(invisOn());
        }


        if(other.gameObject.tag == "invins" && invins == true)
        {
            invissound.Play();
            StopCoroutine(invisOn());
            StartCoroutine(invisOn());
            invins = true;
        }
    }

    public void Update()
    {
        waitTime = PlayerPrefs.GetFloat("WaitTime2");
    }

    IEnumerator invisOn()
    {

        gameObject.GetComponent<Renderer>().material.color = invincible;



        yield return new WaitForSeconds(waitTime);


        invins = false;

        gameObject.GetComponent<Renderer>().material.color = original;

        yield return 0;
    }


    IEnumerator killPlayer()
    {
        deathsound.Play();

        playerMesh.enabled = false;

        playerCol.enabled = false;

        rb.constraints = RigidbodyConstraints.FreezeAll;

        explosionPlayer.Play();


        yield return new WaitForSeconds(0.75f);

        Time.timeScale = 0;

        deathScreen.SetActive(true);



        yield return 0;
    }


    public void enableScript()
    {
        StopCoroutine(invisOn());

        gameObject.GetComponent<Renderer>().material.color = original;

        invins = false;
    }

}
