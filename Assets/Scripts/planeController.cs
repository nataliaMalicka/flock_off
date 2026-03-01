using UnityEngine;
using UnityEngine.InputSystem;

public class plane : MonoBehaviour
{   
    
    [SerializeField] // tweakable
    private float maxHorizontalBound = 2.0f;
    [SerializeField]
    private float horizontalVelocity = 2.0f;

    Vector3 startingPos = Vector3.zero; // untweakable
    float totalSideMovement = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingPos = GetComponent<Transform>().position;
    }

    


    // Update is called once per frame
    void Update()
    {
        float currMovement = 0.0f;
        float deltaTime = Time.deltaTime;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            currMovement = deltaTime * (-horizontalVelocity);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            currMovement = deltaTime * (horizontalVelocity);
        }

        totalSideMovement += currMovement;
        if (totalSideMovement > maxHorizontalBound)
        {
            totalSideMovement = maxHorizontalBound;
        }
        if (totalSideMovement < -maxHorizontalBound)
        {
            totalSideMovement = -maxHorizontalBound;
        }

        var finalPosition = startingPos + new Vector3 (totalSideMovement, 0.0f, 0.0f);
        GetComponent<Transform>().position = finalPosition;
    }
}
