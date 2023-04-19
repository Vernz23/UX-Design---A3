using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] GameObject[] images;
    public float currentTime = 0;
    float startingTime = 8;
    int index = 0;
 
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        index = 1;
        images[0].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

        }
        else
        {
            if (index < images.Length)
            {
                images[index].SetActive(true);
                if (index > 0)
                {
                    images[index - 1].SetActive(false);
                }

                currentTime += 8;
                index += 1;
            }
            else
            {
                for (int i = 0; i < images.Length; i++)
                {
                    images[i].SetActive(false);
                    index = 0;
                }
            }

        }

    }


}
