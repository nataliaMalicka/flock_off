using UnityEngine;

public class planeCollider : MonoBehaviour
{
    [SerializeField]
    planeHealth healthComponent = null;

    private void OnTriggerEnter(Collider obstacle)
    {
        Debug.Log("Something eneterd the trigger");

        if (healthComponent)
        {
            healthComponent.onHitByObstacle(obstacle.transform.parent.gameObject);
        }
        
    }
}
