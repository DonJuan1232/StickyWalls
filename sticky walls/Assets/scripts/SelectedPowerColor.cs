using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedPowerColor : MonoBehaviour
{
    public Material material01;
    public Material material02;
    public Material material03;
    public Material material04;


    public int powerNumber;


    // Start is called before the first frame update
    void Update()
    {
        powerNumber = PlayerPrefs.GetInt("powerNumber");


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
    }
}
