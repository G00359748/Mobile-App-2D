using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start ()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.tag == "coin")
        {
            ScoreNum += 50;
            Destroy(coin.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }
        else if (coin.tag == "Enemy")
        {
            ScoreNum -= 100;
            Destroy(coin.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }

    }

}
