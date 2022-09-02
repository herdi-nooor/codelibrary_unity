using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : Publiser
{
    int _point;

    public int maxPOint;
    
    public int Point
    {
        get
        {
            return _point;
        }
    }
    
    private void Awake() {
        base.Awake();
        ConnectorBus.Damage.AddListener(Damage);
    }
    
    public override void Start()
    {
        _point = maxPoint;
    }

    public void Damage(int damageAmount)
    {
        _point -= damageAmount;

            if (_point <= 0)
            {
                Destroy(this.gameObject);
            }
    }
}
