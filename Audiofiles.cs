using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiofiles : MonoBehaviour
{
   private void OnTriggerEnter2D (Collider2D col){

     if (col.tag == "Player")
    FindObjectOfType<AudioManager>().Play("Collectcoins");
   }}
