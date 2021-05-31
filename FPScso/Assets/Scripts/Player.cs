using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject[] gun;

    // Start is called before the first frame update
    void Start()
    {
        gun[1] = transform.Find("Handgun_01_FPSController").gameObject;
        gun[2]= transform.Find("Assault_Rifle_01_FPSController").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            gun[1].SetActive(true);
            gun[2].SetActive(false);
        }
        else if(Input.GetKey(KeyCode.Alpha2))
        {
            gun[1].SetActive(false);
            gun[2].SetActive(true);
        }
    }
}
