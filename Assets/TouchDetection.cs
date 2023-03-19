using UnityEngine;

public class TouchDetection : MonoBehaviour
{
    void Update()
    {
        // Check if the screen is being touched
        if (Input.touchCount > 0)
        {
            UDPSender udpSender = GameObject.Find("UDPSender").GetComponent<UDPSender>();
            // Loop through all touch events
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);
                if (touch.phase == TouchPhase.Began)
                {
                    
                    udpSender.Send("ID: " + touch.fingerId + ";Begin-" + touch.position);
                }
                else if (touch.phase == TouchPhase.Moved)
                {
                    udpSender.Send("ID: " + touch.fingerId + ";Moved-" + touch.position);
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    udpSender.Send("ID: " + touch.fingerId + ";End");
                }
            }
        }
    }
}
