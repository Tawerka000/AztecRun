using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartlvl1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("level1");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
