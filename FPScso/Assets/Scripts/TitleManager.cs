using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneRifleRange()
    {
        SceneManager.LoadScene("RifleRange");
    }
    public void SceneGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
