using UnityEngine;

public class TouchDetection : MonoBehaviour
{
    void Update()
    {
        // Check if the screen is being touched
        if (Input.touchCount > 0)
        {
            // Loop through all touch events
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                if (touch.phase == TouchPhase.Began)
                {
                    UDPSender udpSender = GameObject.Find("UDPSender").GetComponent<UDPSender>();
                    udpSender.Send("Touch:" + touch.position);
                }
            }
        }
    }
}
