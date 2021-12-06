using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
    private GameObject scoreText;
    private int Score=0;

    // Start is called before the first frame update
    void Start() {

        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "Score: " + Score;
    }

    //ターゲット（大小の星と雲）にボールが衝突した時に得点を加算
    private void OnCollisionEnter(Collision collison ) {

        //ターゲットの種類によって取得できる点数を変え
        if (collison.gameObject.tag == "SmallStarTag") {
            this.Score += 10;
        }
        else if (collison.gameObject.tag == "LargeStarTag") {
            this.Score += 20;
        }
        else if (collison.gameObject.tag == "SmallCloudTag" || collison.gameObject.tag == "LargeCloudTag") {
            this.Score += 30;
        }
        //ScoreTextにスコアを表示
        this.scoreText.GetComponent<Text>().text = "Score: "+Score;
    }
}