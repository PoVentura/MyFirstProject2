using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Time_5minets : MonoBehaviour
{
    public float remainingTime = 180f;
    public TextMeshProUGUI timeText;
    public string winSceneName;

    void Start()
    {

    }

    void Update()
    {
        remainingTime -= Time.deltaTime;
        if (remainingTime <= 0f)
        {
            remainingTime = 0f;
            SceneManager.LoadScene(winSceneName);
        }
        int seconds = Mathf.FloorToInt(remainingTime);
        string timeString = "Осталось времени: " + seconds.ToString() + " секунд";
        timeText.SetText(timeString);

    }
}
