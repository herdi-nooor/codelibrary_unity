using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector : MonoBehaviour
{
    // memanggilnya dengan getcommponent dari connector.cs

    IntEvent _damage = new IntEvent();
    public IntEvent Damage { get {return _damage;}}
    ActionEvent _onAction = new ActionEvent();
    public ActionEvent OnAction { get { return _onAction; }}

    //other event can go here, usung the above as a template
    //their argument are simply determined by their type

    
}
