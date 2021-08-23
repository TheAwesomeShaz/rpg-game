using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{

    public class Fighter : MonoBehaviour
    {
        [SerializeField] float weaponRange = 2f;
        Transform target;



        private void Update()
        {
            bool isInRange = Vector3.Distance(target.position, this.transform.position) < weaponRange;
            if (target != null && !isInRange)
            {
                GetComponent<Mover>().StartMoveAction(target.position);
            }
            else
            {
                GetComponent<Mover>().Stop();
            }
        }

        public void Attack(CombatTarget combatTarget)
        {
            target = combatTarget.transform;
        }

        public void CancelAttack()
        {
            target = null;
        }
    }
}
