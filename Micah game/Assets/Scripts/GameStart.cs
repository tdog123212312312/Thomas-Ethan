using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
     
public class GameStart : MonoBehaviour
{
    public GameObject TitleScreen;
    public AudioSource StartSound;
    public void StartGame() 
    {
        StartSound.Play();
       SceneManager.LoadScene(5);
    }

}

