using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class EnemySpawner : MonoBehaviour
{

    
    public GameObject enemyPrefab;
    public GameObject buttonImage;
    
    public bool spawn = true;
    public float minX;
    public float maxX;
    public bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        buttonImage.gameObject.SetActive(false);
    }

   
    

    float elapsed = 0f;
    float level = 3f;
    public void Update()
    {


        if (Input.GetKeyDown(KeyCode.M))
        {
            if (pause == false)
            {
                pause = true;
                buttonImage.gameObject.SetActive(true);
            }
            else
            {
                pause = false;
                buttonImage.gameObject.SetActive(false);
            }

        }

        if (pause == false)
        {
            elapsed += Time.deltaTime;
            if (elapsed >= level)
            {

                elapsed = elapsed % 1f;
                level = level - .05f;
                if (level < .99f)
                {
                    level = level + .05f;
                }

                Spawn();

            }
        }
        else
        {

        }
    }   


    /////////////////////////////SPAWN FUNCTION
    public void Spawn()
    {
        minX = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).x;
        maxX = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)).x;

        float randomX = Random.Range(minX, maxX);
        float yValue = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        Instantiate(enemyPrefab, new Vector3(randomX, yValue , 0), Quaternion.identity);
        
    }

  
    
}
