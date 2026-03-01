using UnityEngine;

public class goose : MonoBehaviour
{

    public Transform target;
    public float speed = 5f;
    public float bobAmount = 0.8f;
    public float bobSpeed = 5f;
    private bool passedTarget = false;
    private Vector3 flyDirection;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Add a collider
        if (!GetComponent<Collider>())
        {
            SphereCollider col = gameObject.AddComponent<SphereCollider>();
            col.isTrigger = true;
            col.radius = 0.5f;
        }

        // Add a rigidbody for collision detection
        if (!GetComponent<Rigidbody>())
        {
            Rigidbody rb = gameObject.AddComponent<Rigidbody>();
            rb.useGravity = false;
            rb.isKinematic = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (target == null) return;

        if (!passedTarget)
        {
            flyDirection = (target.position - transform.position).normalized;

            if (Vector3.Distance(transform.position, target.position) < 2f)
            {
                passedTarget = true;
            }
        }

        transform.position += flyDirection * speed * Time.deltaTime;
        Quaternion lookRotation = Quaternion.LookRotation(flyDirection);
        transform.rotation = lookRotation * Quaternion.Euler(0, -90, 0);
        transform.position += Vector3.up * Mathf.Sin(Time.time * bobSpeed) * bobAmount * Time.deltaTime;

        if (passedTarget && Vector3.Distance(transform.position, target.position) > 500f)
        {
            Destroy(gameObject);
        }*/
    }
}
