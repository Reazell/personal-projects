﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
        {
        if(other.CompareTag("Boundary"))
            return;

        Instantiate(explosion, transform.position, transform.rotation);
        if (other.CompareTag("Player"))
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            GameController.playerHealth--;
        }
        GameController.scoreValue= GameController.scoreValue + 10;
        Destroy(other.gameObject);
        Destroy(gameObject);
  
    }
}
