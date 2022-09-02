using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publiser : MonoBehaviour
{
    Connector _connectorBus;
        public Connector ConnectorBus
        {
            get
            {
                return _connectorBus;
            }
        }

        public virtual void Awake()
        {
            //resolve MessageBus before we do anything else:
            _connectorBus = GetComponent<Connector>();

            if (_connectorBus == null)
            {
                //we couldn't find a message bus -- we'll have to
                //create one
                _connectorBus = gameObject.AddComponent<Connector>();
            }
        }
    void OnAction()
    {
        /// ConnectorBus == connector.cs
        ConnectorBus.OnAction?.Invoke(this);
    }
}
