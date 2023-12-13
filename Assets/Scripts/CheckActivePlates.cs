using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckActivePlates : MonoBehaviour
{
    public List<GameObject> plate;
    [SerializeField] private Animator _animator;
    private int ans;
    private bool Active;
    private AudioSource _audioSource;
    public AudioClip OpenTheGate;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        ans = 0;
    }
    public void start_sound()
    {
        _audioSource.PlayOneShot(OpenTheGate);
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < plate.Count; i++)
        {
            Active = plate[i].GetComponent<PlateActivated>().isActivated;
            if (Active == true)
            {    ans = ans + 1; }
            else if(Active == false)
            {    ans = ans + 0; }
        }
        if (ans == plate.Count)
        {
            _animator.SetBool("Active", true);
        }
        if(ans != plate.Count)
        {
            _animator.SetBool("Active", false);
        }
        ans = 0;
    }
}
