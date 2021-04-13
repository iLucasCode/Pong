using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOperation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.Tab))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            ScoreCountBlue.scoreValue = 0;
            ScoreCountRed.scoreValue = 0;
        }
    }
}
