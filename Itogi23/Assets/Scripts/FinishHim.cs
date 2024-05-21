using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishHim : MonoBehaviour
{
    
    public string menuSceneName = "Start";

    
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            // Загружаем сцену меню
            //SceneManager.LoadScene("Start");
            Debug.Log("Загрузка");
        }
    }

}
