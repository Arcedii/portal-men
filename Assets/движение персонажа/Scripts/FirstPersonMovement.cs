using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public static bool EnableMove = true;
    public float speed = 5;
    Vector2 velocity;
    public Transform mainCamera;
    public FixedJoystick jb;
    private float h;
    private float v;
    string s = "fkdsfdkf";
  
    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 9;
    public KeyCode runningKey = KeyCode.LeftShift;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();
    

    private void Update() {
        // Устанавливаем поворот персонажа когда камера поворачивается 
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,mainCamera.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
      
      
    }

    void FixedUpdate()
    {
        Movement();

    }

    private void Movement()
    {
       
        h = jb.Horizontal;
        v = jb.Vertical;

        // Move.
        IsRunning = canRun && Input.GetKey(runningKey);
        float movingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
            movingSpeed = speedOverrides[speedOverrides.Count - 1]();
        velocity.y = v * movingSpeed * Time.deltaTime;
        velocity.x = h * movingSpeed * Time.deltaTime;

        transform.Translate(velocity.x, 0, velocity.y);
    }

   
}