using System.Collections;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private SpriteRenderer rend;
    private Animator anim;
    private bool activated;
    private bool triggered;
    [SerializeField] private AudioSource trapsound;

    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        anim.SetBool("activated", activated);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            trapsound.Play();
            if (!activated && !triggered)
                StartCoroutine(ActivateTrap());
                
            else
                collision.GetComponent<PlayerHealth>().TakeDamage(80);
        }
    }
    private IEnumerator ActivateTrap()
    {
        rend.color = Color.red;
        triggered = true;
        yield return new WaitForSeconds(1);
        rend.color = Color.white;
        activated = true;
        yield return new WaitForSeconds(2);
        activated = false;
        triggered = false;
    }
}



