using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using View.Components;

namespace Spells {
    public class SlowSpell : MonoBehaviour
    {
        private void OnTriggerEnter(Collider colliderOther)
        {
            if (colliderOther.gameObject.layer == LayerMask.NameToLayer("Character"))
            {
                var playerController = colliderOther.gameObject.GetComponentInParent<PlayerController>();
                if (playerController != null)
                    playerController.SetSpellDecorator(Decorators.EnumSpellDecorator.SlowSpell);
            }
        }
    }
}


