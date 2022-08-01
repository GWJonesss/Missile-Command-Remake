using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    [SerializeField] private GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        


    }
    void Awake()
    {
        
        //to amke sure not to crowd game with objects, destroy self after 20 seconds
        Destroy(gameObject, 20.0f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

    void Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        
    }

    




}
