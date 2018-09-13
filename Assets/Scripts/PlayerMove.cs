using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    public float playerMoveSpeedKeyboard = 0.7f;

    public float playerMoveSpeedController = 1.0f;

    public float playerBoundary = 1.0f;

    bool joystickIsConnected;

    void Start()
    {

        string[] joystickNames;
        joystickNames = Input.GetJoystickNames();
            if (joystickNames.Length >= 1 && joystickNames[0].Length > 0)
            {
                joystickIsConnected = true;
            }
    }

  

    // Update is called once per frame
    void Update ()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            Debug.Log(Input.acceleration.x);
            transform.Translate(playerMoveSpeedKeyboard * Input.acceleration.x * Time.deltaTime, 0, 0);
        }
       
        else if (joystickIsConnected && (Input.GetAxis("Horizontal") > 0 && transform.position.x < playerBoundary) || (Input.GetAxis("Horizontal") < 0 && transform.position.x > -playerBoundary))
        {
            transform.Translate(playerMoveSpeedController * Time.deltaTime * Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        }

        else
        {
          
            // Move character left/right on a/d keypress  --  move by speed.Variable
            if ((Input.GetKey(KeyCode.D)/* || Input.GetAxis("Horizontal") > 0.5f*/) && transform.position.x < playerBoundary)
            {
                transform.Translate(playerMoveSpeedKeyboard * Time.deltaTime, 0.0f, 0.0f);
            }
            if ((Input.GetKey(KeyCode.A)/* || Input.GetAxis("Horizontal") < -0.5f*/) && transform.position.x > -playerBoundary)
            {
                transform.Translate(-playerMoveSpeedKeyboard * Time.deltaTime, 0.0f, 0.0f);

            }

      }
   }
}
