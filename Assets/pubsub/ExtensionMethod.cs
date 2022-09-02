using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensionMethod : MonoBehaviour
{
    public static Connector GetMessageBus(this gameObject go) 
    {
         var connectorBus = go.GetComponent<BehaviourMessageBus>();

            if (messageBus == null)
            {
                //no message bus yet -- make one!
                messageBus = go.AddComponent<BehaviourMessageBus>();
            }

            return messageBus;
    }
    public static BehaviourMessageBus GetMessageBus(this Component comp)
    {
        return comp.gameObject.GetMessageBus();
    }
}
