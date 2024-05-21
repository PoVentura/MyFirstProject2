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
        // �������� ������� ������
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        // ���������� ��� ������� � Canvas
        foreach (RectTransform child in canvas.transform)
        {
            // ���������, �������� �� ������ �������
            if (child.GetComponent<Button>() == null)
            {
                // ������������� ����� ������� ��� �������
                child.sizeDelta = new Vector2(screenWidth, screenHeight);
            }
        }
    }
}
