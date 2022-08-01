using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingDestroy : MonoBehaviour
{
    [SerializeField] private GameObject FirePrefab;
    [SerializeField] private GameObject FireSpotPrefab;

    void Start()
    {
        Physics2D.IgnoreLayerCollision(21, 22);


    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Defenders")
        {    
           
        }
        else
        {
            FindObjectOfType<GameControler>().BuildingKilled();
            Explode();
            Destroy(gameObject);
        }
    }
    void Explode()
    {
        Instantiate(FirePrefab, FireSpotPrefab.transform.position, Quaternion.identity);
    }








}
