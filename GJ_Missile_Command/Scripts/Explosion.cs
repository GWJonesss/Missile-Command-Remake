using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Explosion : MonoBehaviour
{
    public GameObject item;
    // Use this for initialization
    void Start()
    {
        Physics2D.IgnoreLayerCollision(20, 21);
    }

    // Update is called once per frame
    void Update()
    {
        NewMethod();
    }
    private void NewMethod()
    {
        Destroy(gameObject, 1); //you have 1 second before the objects deletes itself
    }
}
