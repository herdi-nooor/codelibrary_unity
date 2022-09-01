using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publiser : MonoBehaviour
{
    void OnAction()
    {
        /// MessageBus == connector.cs
        MessageBus.OnAction?.Invoke(this);
    }
}
