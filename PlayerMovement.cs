using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;
	[SerializeField] private AudioSource jumpsound;

	

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	

	// Update is called once per frame

	
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			jumpsound.Play();
			animator.SetBool("IsJumping", true);
			
		}

	

	}

	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
		
	}

	
	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}

	 


    }
	
   

