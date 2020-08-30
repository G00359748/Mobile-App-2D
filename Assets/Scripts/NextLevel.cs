using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
    }

}
