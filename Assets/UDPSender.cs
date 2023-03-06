
using UnityEngine;
using System.Collections;
 
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
 
public class UDPSender : MonoBehaviour
{
    // Client code (running on mobile device)
    private UdpClient udpClient;
    private IPEndPoint remoteEndPoint;
    [SerializeField] private string ip;
    [SerializeField] private int port;
	

    void Start()
    {
        // Initialize the UDP client and set the remote endpoint to the desktop app's address and port
        remoteEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
        udpClient = new UdpClient();
        Send("Size:(" + Screen.width + "," + Screen.height + ")");
    }

    public void Send(string message)
    {
        byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
        udpClient.Send(data, data.Length, remoteEndPoint);
    }

}
 
 