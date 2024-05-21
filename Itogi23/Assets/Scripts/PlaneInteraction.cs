using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundAndTeleport : MonoBehaviour
{
    public AudioClip planeHitSound;
    public string targetSceneName = "Menu";

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("plane2.0"))
        {
            PlayPlaneHitSound();
            TeleportPlayerToMenuScene();
        }
    }

    void PlayPlaneHitSound()
    {
        if (audioSource != null)
        {
            audioSource.PlayOneShot(planeHitSound);
        }
    }

    void TeleportPlayerToMenuScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}