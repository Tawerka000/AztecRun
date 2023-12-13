using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    bool alive = true;
    public float speed = 15;
    public Rigidbody rb;
    [SerializeField] float jumpForce = 400f;
    [SerializeField] LayerMask groundMask;
    bool jumpisClicked = false;
    private Animator animator;
    public GameObject anim;
    public GameObject jump_button;
    public GameObject slide;
    public GameObject restart;
    public GameObject Death;
    public GameObject jb;
    public GameObject sb;
    public BoxCollider skelet;
    bool isGrounded;
    bool isSlide;

    private void Start()
    {
        animator = anim.GetComponent<Animator>();
        jump_button.SetActive(true);
        slide.SetActive(true);
        restart.SetActive(false);
        Death.SetActive(false);
    }
    private void Update()
    {
        if (jumpisClicked)
        {
            Jump();
        }
    }

    private void FixedUpdate ()
    {
        if (!alive) return;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove);
    }
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Trap")
            Die();
        if (collision.gameObject.tag == "Ground")
            isGrounded = true;
    }
    public void RestarTask()
    {
        PlayerPrefs.SetInt("Deaths", PlayerPrefs.GetInt("Deaths") + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void JumpTask()
    {
        jumpisClicked = true;
    }
    public void Die()
    {
        skelet.size = new Vector3(0.4488232f, 0.6757976f, 0.2537452f);
        animator.SetTrigger("death");
        alive = false;
        speed = 0;
        jump_button.SetActive(false);
        jb.SetActive(false);
        sb.SetActive(false);
        slide.SetActive(false);
        restart.SetActive(true);
        Death.SetActive(true);
    }
    public void slide_button()
    {
        if (isGrounded)
            animator.SetTrigger("isSlide");
    }
    private void slide_start()
    {
        isSlide = true;
        skelet.size = new Vector3(1f, 0.7183732f, 0.3759459f);
        skelet.center = new Vector3(7.932525e-16f, 0.3447194f, 0.07251333f);
        speed = 22;
    }
    private void slide_stop_pos()
    {
        speed = 10;
    }
    private void slide_stop()
    {
        isSlide = false;
        skelet.center = new Vector3(7.932525e-16f, 0.8729069f, 0.07251333f);
        skelet.size = new Vector3(1f, 1.774748f, 0.3759459f);
        speed = 15;
        animator.SetBool("isSlide", false);
    }
    void Jump()
    {
        if (isGrounded == true && isSlide != true)
        {
            speed = 15;
            animator.SetTrigger("jump");
            rb.AddForce(Vector3.up * jumpForce);
            isGrounded = false;
        }
        jumpisClicked = false;
    }
    
}

