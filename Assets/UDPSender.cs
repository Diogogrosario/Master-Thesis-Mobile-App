
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

    void Start()
    {
        // Initialize the UDP client and set the remote endpoint to the desktop app's address and port
        remoteEndPoint = new IPEndPoint(IPAddress.Parse("192.168.42.113"), 9000);
        udpClient = new UdpClient();
    }

    public void Send(string message)
    {
        byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
        udpClient.Send(data, data.Length, remoteEndPoint);
    }

}
 
 