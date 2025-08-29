using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameFlow : MonoBehaviour
{
    public static int orderValue = 1450;
    public static int plateValue = 0000;
    public static float orderTimer = 30;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        orderTimer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        orderTimer -= Time.deltaTime;

        if (orderTimer <=0)
        {
            SceneManager.LoadScene("GameOverScreen");
        }

        timerText.text = "Time: " + Mathf.CeilToInt(orderTimer).ToString();
    }
}