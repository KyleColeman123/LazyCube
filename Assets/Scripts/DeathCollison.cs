using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

public class DeathCollison : MonoBehaviour
{


    public AudioSource deathSound;
    public Canvas deathCanvas;
    public AudioSource song;
    public Rigidbody player;
    public Rigidbody hitter;


    void Update()
    {
    }

    public void OnCollisionEnter(Collision collisionInfo)
    {

        

        /*if (collisionInfo.collider.name == "CubePlayer")
        {
            //SceneManager.LoadScene("MainSceneLazyCube");

            Time.timeScale = 0;
            AudioListener.volume = 0;
            PlayerPrefs.SetInt("DeathCounter", PlayerPrefs.GetInt("DeathCounter") + 1);
            
        }*/
        if (hitter.position.z >= player.position.z - 8.6)
        {
            Time.timeScale = 0;
            AudioListener.volume = 0;
            PlayerPrefs.SetInt("DeathCounter", PlayerPrefs.GetInt("DeathCounter") + 1);
        }
        deathCanvas.gameObject.SetActive(!deathCanvas.gameObject.activeSelf);
    }


    public void OnCollisionEnter2()
    {
        deathSound.Play();
    }


}
