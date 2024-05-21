using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextHider : MonoBehaviour
{
    // Ссылка на компонент TextMeshPro
    private TextMeshProUGUI textMeshPro;

    // Изначальный размер компонента TextMeshPro
    private float originalFontSize;

    // Коэффициент увеличения размера
    private float scaleFactor = 1.5f;

    // Интервал времени для изменения размера
    private float changeInterval = 2f;

    private void Start()
    {
        // Получаем ссылку на компонент TextMeshPro
        textMeshPro = GetComponent<TextMeshProUGUI>();

        // Сохраняем изначальный размер шрифта
        originalFontSize = textMeshPro.fontSize;

        // Запускаем повторяющийся вызов метода ChangeFontSize с интервалом changeInterval
        InvokeRepeating("ChangeFontSize", changeInterval, changeInterval);
    }

    private void ChangeFontSize()
    {
        // Проверяем текущий размер шрифта
        if (textMeshPro.fontSize == originalFontSize)
        {
            // Увеличиваем размер шрифта
            textMeshPro.fontSize *= scaleFactor;
        }
        else
        {
            // Возвращаем оригинальный размер шрифта
            textMeshPro.fontSize = originalFontSize;
        }
    }
}

