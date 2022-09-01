using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class receiver : MonoBehaviour
{
    targetBus.Damage.Invoke(this.damageAmount);

    private void OnCollisionEnter2D(Collision2D other) {
        collision.gameObject.GetMessageBus().Damage?.Invoke(this.damageAmount);
    }
}
