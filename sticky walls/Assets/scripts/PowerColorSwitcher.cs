using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerColorSwitcher : MonoBehaviour
{
    public Material material01;
    public Material material02;
    public Material material03;
    public Material material04;


    public int powerNumber;


    // Start is called before the first frame update
    void Start()
    {
        powerNumber = PlayerPrefs.GetInt("powerNumber");


        if (powerNumber == 0)
        {
            TrailRenderer myTrailRenderer = GetComponent<TrailRenderer>();
            myTrailRenderer.material = material01;

            gameObject.GetComponent<ParticleSystemRenderer>().material = material01;
        }
        else if (powerNumber == 1)
        {
            TrailRenderer myTrailRenderer = GetComponent<TrailRenderer>();
            myTrailRenderer.material = material02;

            gameObject.GetComponent<ParticleSystemRenderer>().material = material02;
        }
        else if (powerNumber == 2)
        {
            TrailRenderer myTrailRenderer = GetComponent<TrailRenderer>();
            myTrailRenderer.material = material03;

            gameObject.GetComponent<ParticleSystemRenderer>().material = material03;
        }
        else if (powerNumber == 3)
        {
            TrailRenderer myTrailRenderer = GetComponent<TrailRenderer>();
            myTrailRenderer.material = material04;

            gameObject.GetComponent<ParticleSystemRenderer>().material = material04;
        }
    }

}
