using UnityEngine;

public class gooseEnemy : MonoBehaviour
{
    [SerializeField]
    private float approachVelocity = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var currPos = GetComponent<Transform>().position;
        var movementPerFrame = approachVelocity * Time.deltaTime;

        currPos.z -= movementPerFrame;
        GetComponent<Transform>().position = currPos;

    }
}
