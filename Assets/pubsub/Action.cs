using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : Publiser
{
    private void Awake() {
        base.Awake();
        MessageBus.Damage.AddListener(Damage);
    }

    public void Damage(int damageAmount){}
}
