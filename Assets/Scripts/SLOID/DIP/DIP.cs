using NUnit.Framework;
using UnityEngine;

public interface ISwitchable
{
    public bool isActivated {get; set;}
    public void Toggle();
}

public class Switch : MonoBehaviour
{
    public ISwitchable client; 
    public void Toggle()
    {
        client.Toggle();
    }
}


public class Door : MonoBehaviour, ISwitchable
{
    public bool isActivated { get; set; } = false;

    public void Open()
    {
        Debug.Log("The door is open.");
    }

    public void Close()
    {
        Debug.Log("The door is closed.");
    }

    public void Toggle()
    {
        if (isActivated)
        {
            Close();
            isActivated = false;
        }
        else
        {
            Open();
            isActivated = true;
        }
    }
}
