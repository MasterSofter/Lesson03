using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using View.Components;

namespace Decorators
{
    public class SlowSpellDecorator : MonoBehaviour, ICellOfSpellDecorator
    {
        private float timeExitst = 3f;
        private float saveSpeed;
        private float valueOfSpell = 1.2f;

        private IEnumerator Exits() {
            PlayerController playerController = gameObject.GetComponent<PlayerController>();
            if(playerController != null)
            {
                saveSpeed = playerController.Speed;
                playerController.Speed = valueOfSpell;
            }
                
            yield return new WaitForSeconds(timeExitst);
            playerController.Speed = saveSpeed;
            this.enabled = false;
        }
        private void OnEnable() => StartCoroutine(Exits());
    }
}

