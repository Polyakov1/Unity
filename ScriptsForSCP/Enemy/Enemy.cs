using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Player;
namespace EnemySCP
{
    public class Enemy : MonoBehaviour
    {

        private Transform target;
        private NavMeshAgent agent;


        [Header("Specifications")]
        public float radius;
        [SerializeField]
        private int damage;

        private void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            target = EnemyManager.instance.player.transform;
        }

        private void Update()
        {
            float distance = Vector3.Distance(target.position, transform.position);
            if (distance <= radius)
            {
                agent.SetDestination(target.position);
                if (distance <= agent.stoppingDistance)
                {
                    LookTarget();
                }
            }
        }

        private void LookTarget()
        {
            Vector3 direction = (target.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, radius);
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Health.TakeDamage(damage);
            }
        }
    }
}