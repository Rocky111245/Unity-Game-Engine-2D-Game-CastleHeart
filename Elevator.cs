using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform player;
    public Transform elevatorswitch;
    public Transform downpos;
    public Transform upperpos;
    public SpriteRenderer elevator;
[SerializeField] private AudioSource elevatorsound;
    public float speed;
    bool iselevatordown;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartElevator();
        
        DisplayColor();
    }
    void StartElevator(){
        if(Vector2.Distance(player.position,elevatorswitch.position)<0.5f && Input.GetKeyDown("e"))
        {
            if (transform.position.y<=downpos.position.y){
                iselevatordown = true;
                elevatorsound.Play();
            }
            else if(transform.position.y>=upperpos.position.y){
                iselevatordown = false;
            }
        }
        if(iselevatordown){
            transform.position= Vector2.MoveTowards(transform.position,upperpos.position,speed*Time.deltaTime);
           

        }
        else{
            transform.position= Vector2.MoveTowards(transform.position,downpos.position,speed*Time.deltaTime);
        }


        
    }
    void DisplayColor()
        {

           if(transform.position.y <= downpos.position.y || transform.position.y>= upperpos.position.y) {
            elevator.color = Color.red;
           }
           else{
            elevator.color = Color.green;
           
           }
        }
    
}
