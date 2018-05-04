using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class StartGameScript : MonoBehaviour {

    [SerializeField]
    Button playButton;
    [SerializeField]
    Button exitButton;

    void Start()
    {
        playButton.onClick.AddListener(delegate { Play(); });
        exitButton.onClick.AddListener(delegate { Exit(); });
    }

    private void Play()
    {
        SceneManager.LoadScene(1);
    }

    private void Exit()
    {
        Application.Quit();
    }


}
