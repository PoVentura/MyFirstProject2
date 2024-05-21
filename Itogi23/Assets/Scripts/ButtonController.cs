using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    // Метод для кнопки настройки
    public void OpenSettings()
    {
        SceneManager.LoadScene("MenuSettings");
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }

    // Метод для кнопки выход
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Готово");
    }
}
