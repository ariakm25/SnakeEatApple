using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D(Collider2D other)
    {
        MoveApple();
    }

    void MoveApple()
    {
        transform.position = new Vector2(Random.Range(-25, 26), Random.Range(-15, 16));
    }
}
