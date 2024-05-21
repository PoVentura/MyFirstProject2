using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneInteraction : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "plane")
        {
            audioSource.Play();
            StartCoroutine(LoadMenuScene());
        }
    }

    private IEnumerator LoadMenuScene()
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        SceneManager.LoadScene("Menu");
    }
}