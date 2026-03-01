using UnityEngine;

public class planeHealth : MonoBehaviour
{
    [SerializeField]
    float maxHealth = 100;

    float currHealth = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onHitByObstacle(GameObject obstacle)
    {
        currHealth -= 1.0f;
        Debug.Log("Hit by obstacle, current health: " + currHealth);

        Destroy(obstacle);
    }
}
