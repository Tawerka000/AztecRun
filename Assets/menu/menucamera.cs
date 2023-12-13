using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menucamera : MonoBehaviour
{
    public GameObject nextchar;
    [SerializeField] private GameObject thiscamera;
    public GameObject nextcamera;
    public GameObject thiscanvas;
    public GameObject nextcanvas; 
    private Animator animator;
    public GameObject anim;
    public Rigidbody rb;
    private AudioSource _audioSource;
    public  GameObject audio;
    public Text DeathT;
    private int DeathScore;
    // Start is called before the first frame update
    void Start()
    {
        DeathScore = PlayerPrefs.GetInt("Deaths");
        DeathT.text = DeathScore.ToString();
        _audioSource = audio.GetComponent<AudioSource>();
        nextchar.SetActive(false);
        animator = anim.GetComponent<Animator>();
        nextcamera.SetActive(false);
        thiscanvas.SetActive(true);
    }
    public void startgame()
    {
        _audioSource.spatialBlend = 1.0f;
        _audioSource.volume = 0.6f;
        nextchar.SetActive(true);
        rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        animator.SetBool("GameStarted", true);
        thiscanvas.SetActive(false);
    }
    public void menucanceled()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        _audioSource.spatialBlend = 0.0f;
        _audioSource.volume = 0.21f;

        nextcanvas.SetActive(true);
        nextcamera.SetActive(true);
        nextchar.SetActive(true);


        thiscamera.SetActive(false);
    }
    // Update is called once per frame
}
