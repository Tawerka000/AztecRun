using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spear : MonoBehaviour
{
    private int i;
    public Animator animator1;
    public Animator animator2;
    public AudioClip spears;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
            i = Random.Range(0, 100);
        if (i < 50)
            animator1.SetTrigger("Active");
        if (i >= 50)
            animator2.SetTrigger("Active");
        _audioSource.PlayOneShot(spears);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
