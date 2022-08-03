using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallEnemy : MonoBehaviour
{


    //Assign Target
    [SerializeField] private GameObject building1;
    [SerializeField] private GameObject building2;
    [SerializeField] private GameObject building3;
    [SerializeField] private GameObject building4;
    [SerializeField] private GameObject building5;
    [SerializeField] private GameObject building6;
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private GameObject explosionPrefab;
    
    
    public int randomNumber;
    public bool pause = false;


    void Start()
    {

        

    }


    void Awake()
    {
        // up random number for targeting
        randomNumber = Random.Range(0, 7);
        
    }


    // set up method to target with random number from AWAKE method
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (pause == false)
            {
                pause = true;
            }
            else
            {
                pause = false;
            }

        }
        if (pause == true)
        {
            speed = 0;
        }
        else
        {
            speed = 1.5f;

        }
        LevelOne();

    }

    /////////////////////////////////////////////// LEVEL 1 BEHAVIOR


    public int i = 0;
    void LevelOne()
    {
        
        

        if (randomNumber == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, building1.transform.position, speed * Time.deltaTime);
            Vector3 difference1 = building1.transform.position - transform.position;
            float rotationZ1 = Mathf.Atan2(difference1.y, difference1.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ1);
        }
        else if (randomNumber == 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, building2.transform.position, speed * Time.deltaTime);
            Vector3 difference2 = building2.transform.position - transform.position;
            float rotationZ2 = Mathf.Atan2(difference2.y, difference2.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ2);
        }
        else if (randomNumber == 3)
        {
            transform.position = Vector2.MoveTowards(transform.position, building3.transform.position, speed * Time.deltaTime);
            Vector3 difference3 = building3.transform.position - transform.position;
            float rotationZ3 = Mathf.Atan2(difference3.y, difference3.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ3);
        }
        else if (randomNumber == 4)
        {
            transform.position = Vector2.MoveTowards(transform.position, building4.transform.position, speed * Time.deltaTime);
            Vector3 difference4 = building4.transform.position - transform.position;
            float rotationZ4 = Mathf.Atan2(difference4.y, difference4.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ4);
        }
        else if (randomNumber == 5)
        {
            transform.position = Vector2.MoveTowards(transform.position, building5.transform.position, speed * Time.deltaTime);
            Vector3 difference5 = building5.transform.position - transform.position;
            float rotationZ5 = Mathf.Atan2(difference5.y, difference5.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ5);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, building6.transform.position, speed * Time.deltaTime);
            Vector3 difference6 = building6.transform.position - transform.position;
            float rotationZ6 = Mathf.Atan2(difference6.y, difference6.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ6);
        }
        
    }
    // method to decide if points should be added
    private void OnTriggerEnter2D(Collider2D col)
    {
        //makes sure points dont get added if its a building that is hit
        if (col.tag == "Defenders")
        {
            Explode();
            FindObjectOfType<GameControler>().AddMissileDestDestroyedScore();
            Destroy(gameObject);
        }
        else
        {

            Explode();
            Destroy(gameObject);
        }




    }

    //method to spawn explosion gameobject
    void Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }


}
