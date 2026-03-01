using UnityEngine;
using UnityEngine.InputSystem;

public class Myszkatest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log("Myszka Test Started");
        Debug.LogWarning("Myszka Test Started - warn");
        // Debug.LogError("Myszka Test Started - err");

    }

    [SerializeField]
    public float angularVelocity = 10.0f;

    [SerializeField]
    bool clockwise = true;

    // Update is called once per frame
    void Update()
    {
        updateInputs();
        updateRotation();
    }

    void updateInputs()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            clockwise = !clockwise;
        }
    }

    void updateRotation()
    {
        // Debug.LogError("Myszka Test Started - err");
        float deltaTime = Time.deltaTime;

        // get curr rotation
        var currRot = GetComponent<Transform>().rotation.eulerAngles;
        Debug.Log("Original Rot: " + currRot);

        // add the val of rotation per frame
        // float angularVelocity = 10.0f;
        // delta time 0.2s from the last update fn,rot by 2 deg if angular vel is 10, 2 deg/10s
        float rotChange = angularVelocity * deltaTime;
        if (clockwise)
        {
            rotChange *= -1;
        }


        // update the rot of the obj
        currRot.y = currRot.y + rotChange;
        Quaternion newRotation = Quaternion.Euler(currRot);

        GetComponent<Transform>().rotation = newRotation;
    }


}
