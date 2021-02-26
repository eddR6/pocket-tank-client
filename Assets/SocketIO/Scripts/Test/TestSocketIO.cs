using System.Collections;using System.Collections.Generic;using UnityEngine;using SocketIO;using System;

public class TestSocketIO : MonoBehaviour{    public SocketIOComponent socket;
    void Start()    {
        try
        {
            socket.Connect();
            socket.On("connection", OnConnected);
            socket.On("error", OnError);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
           }    void OnConnected(SocketIOEvent evt)    {        Debug.Log("connected to server" + evt);    }    void OnError(SocketIOEvent evt)    {        Debug.Log("server connection error: " + evt);    }}
