using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DangerZone : MonoBehaviour
{
    public Slider slider;


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            slider.value = slider.value - 1;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
