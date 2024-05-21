using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
   private bool IsPaused = false;
    [SerializeField] private GameObject _pausaPanel;

    // Update is called once per frame
    void Update()
    {
        if (IsPaused)
        {
            Time.timeScale = 0f;
            _pausaPanel.SetActive(IsPaused);
        }
        else
        {
            Time.timeScale = 1f;
            _pausaPanel.SetActive(IsPaused);
        }
    }
    public void PausaButton()
    {
        IsPaused =!IsPaused;
    }
}
