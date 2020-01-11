using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame() {
        gameOver.SetActive(true);
        Time.timeScale = 0; //pause game.
    }

    public void Replay() {
        SceneManager.LoadScene(0);
    }
}
