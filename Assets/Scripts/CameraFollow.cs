using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    public float ypos = 0.8f;
    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 targetPos = player.position + offset;
        targetPos.y = ypos;
        transform.position = targetPos;
    }
}

