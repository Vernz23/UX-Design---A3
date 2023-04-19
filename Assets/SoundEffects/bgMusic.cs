using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMusic : MonoBehaviour
{
    public void Awake()
    {
        GameObject[] bgMusic = GameObject.FindGameObjectsWithTag("BackgroundMusic");
        if (bgMusic.Length > 1) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
