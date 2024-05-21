using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CanvasObjectFitter : MonoBehaviour
{
    private Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        FitObjectsToScreen();
    }

    void FitObjectsToScreen()
    {
        // Получаем размеры экрана
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        // Перебираем все объекты в Canvas
        foreach (RectTransform child in canvas.transform)
        {
            // Проверяем, является ли объект кнопкой
            if (child.GetComponent<Button>() == null)
            {
                // Устанавливаем новые размеры для объекта
                child.sizeDelta = new Vector2(screenWidth, screenHeight);
            }
        }
    }
}
