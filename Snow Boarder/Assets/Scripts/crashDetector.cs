using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashDetector : MonoBehaviour
{

    [SerializeField] float crashDelay;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", crashDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
