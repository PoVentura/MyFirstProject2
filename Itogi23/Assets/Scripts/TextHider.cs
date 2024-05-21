using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextHider : MonoBehaviour
{
    // ������ �� ��������� TextMeshPro
    private TextMeshProUGUI textMeshPro;

    // ����������� ������ ���������� TextMeshPro
    private float originalFontSize;

    // ����������� ���������� �������
    private float scaleFactor = 1.5f;

    // �������� ������� ��� ��������� �������
    private float changeInterval = 2f;

    private void Start()
    {
        // �������� ������ �� ��������� TextMeshPro
        textMeshPro = GetComponent<TextMeshProUGUI>();

        // ��������� ����������� ������ ������
        originalFontSize = textMeshPro.fontSize;

        // ��������� ������������� ����� ������ ChangeFontSize � ���������� changeInterval
        InvokeRepeating("ChangeFontSize", changeInterval, changeInterval);
    }

    private void ChangeFontSize()
    {
        // ��������� ������� ������ ������
        if (textMeshPro.fontSize == originalFontSize)
        {
            // ����������� ������ ������
            textMeshPro.fontSize *= scaleFactor;
        }
        else
        {
            // ���������� ������������ ������ ������
            textMeshPro.fontSize = originalFontSize;
        }
    }
}

