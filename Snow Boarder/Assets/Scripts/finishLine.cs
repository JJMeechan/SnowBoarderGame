using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{

    [SerializeField] float winDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", winDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
