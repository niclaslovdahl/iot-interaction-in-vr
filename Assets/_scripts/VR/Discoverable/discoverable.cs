using UnityEngine;
using System.Collections;

/// <summary>
/// This class represents the skeleton for discover device. 
/// </summary>

public abstract class discoverable : MonoBehaviour
{
    // Init
    public abstract void Start();
    // Discovered state active
    public abstract void active();
    // Discovered state inactive
    public abstract void inactive();
}
