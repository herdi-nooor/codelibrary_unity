using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pubsubcode
{
    // declare unity Event
    public class FloatEvent : UnityEvent<Float> {}
    public class IntEvent : UnityEvent<Int> {}
    public class GameObjectEvent : UnityEvent<GameObject> {}
    public class NoArgEvent : UnityEvent {}
    public class VectoreEvent : UnityEvent<Vector2> {}
}
