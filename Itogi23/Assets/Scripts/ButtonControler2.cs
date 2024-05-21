using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonControler2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        // проверяют, нажимается ли клавиша 'x'
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // выйти из игры
            Application.Quit();
        }

        // Проверьте, нажимается ли клавиша 'Z'
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // загрузить начальную сцену
            SceneManager.LoadScene("Start");
        }
    }

}
