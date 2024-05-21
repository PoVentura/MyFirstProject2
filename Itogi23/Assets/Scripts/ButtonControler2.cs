using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonControler2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        // ���������, ���������� �� ������� 'x'
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // ����� �� ����
            Application.Quit();
        }

        // ���������, ���������� �� ������� 'Z'
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // ��������� ��������� �����
            SceneManager.LoadScene("Start");
        }
    }

}
