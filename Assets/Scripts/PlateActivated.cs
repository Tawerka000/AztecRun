using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateActivated : MonoBehaviour
{
    [SerializeField] private GameObject plate;
    [SerializeField] private Animator _animator;
    public AudioClip PlateClick;
    private AudioSource _audioSource;
    public bool isActivated;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        isActivated = false;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Box")
            {
                _audioSource.PlayOneShot(PlateClick);
                plate.transform.position = plate.transform.position - new Vector3(0, 0.1f, 0);
                isActivated = true;    
            }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            _audioSource.PlayOneShot(PlateClick);
            isActivated = false;
            plate.transform.position = plate.transform.position + new Vector3(0, 0.1f, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
