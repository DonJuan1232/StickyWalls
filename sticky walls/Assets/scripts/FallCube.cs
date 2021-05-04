using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallCube : MonoBehaviour
{

    public int powerNumber;

    public ParticleSystem explosionPlayer;

    public MeshRenderer playerMesh;

    public Collider playerCol;

    public Rigidbody rb;

    public bool invins;

    public float waitTime;

    public Material material01;
    public Material material02;
    public Material material03;
    public Material material04;

    public Color invincible01;
    public Color invincible02;
    public Color invincible03;
    public Color invincible04;

    public GameObject deathScreen;

    public GameObject panel;
    public GameObject continueAdd;

    public AudioSource deathsound;
    public AudioSource invissound;

    /*public animator deathAnim; */

    public static int counter = 0;


    public void Start()
    {
        if (counter == 7)
        {
            counter = 0;
            panel.GetComponent<GoogleAds>().ShowInterstitialAd();
            Debug.Log("works1");
        }
        else
        {
            counter += 1;
            
        }
    }

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

        powerNumber = PlayerPrefs.GetInt("powerNumber");
    }

    IEnumerator invisOn()
    {

        if(powerNumber == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = invincible01;
        }
        else if(powerNumber == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = invincible02;
        }
        else if (powerNumber == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = invincible03;
        }
        else if (powerNumber == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = invincible04;
        }





        yield return new WaitForSeconds(waitTime);


        invins = false;

        if (powerNumber == 0)
        {
            gameObject.GetComponent<Renderer>().material = material01;
        }
        else if (powerNumber == 1)
        {
            gameObject.GetComponent<Renderer>().material = material02;
        }
        else if (powerNumber == 2)
        {
            gameObject.GetComponent<Renderer>().material = material03;
        }
        else if (powerNumber == 3)
        {
            gameObject.GetComponent<Renderer>().material = material04;
        }

        

        yield return 0;
    }

    public void undoFreeze()
    {
        rb.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;

        continueAdd.SetActive(false);
    }

    public void continueGame()
    {
        deathScreen.SetActive(false);

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

        if (powerNumber == 0)
        {
            gameObject.GetComponent<Renderer>().material = material01;
        }
        else if (powerNumber == 1)
        {
            gameObject.GetComponent<Renderer>().material = material02;
        }
        else if (powerNumber == 2)
        {
            gameObject.GetComponent<Renderer>().material = material03;
        }
        else if (powerNumber == 3)
        {
            gameObject.GetComponent<Renderer>().material = material04;
        }

        invins = false;
    }

}
