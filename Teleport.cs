using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject portal;
    private GameObject player;
    [SerializeField] private AudioSource portalsound;
    void Start()
{
    player = GameObject.FindWithTag("Player");

}
private void OnTriggerEnter2D(Collider2D collision)
{
if (collision.tag == "Player"){
    portalsound.Play();

player.transform.position = new Vector2 (portal.transform.position.x,portal.transform.position.y);


}



}




}
    

