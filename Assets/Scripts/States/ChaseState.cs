using UnityEngine;

namespace States
{
    public class ChaseState : MonoBehaviour
    {
        public GameObject playerObject;
        public float speed = 2;
        public GameObject EnemyTransform;
        
        public void Enter()
        {
        }

        public void Update()
        {
            var position = playerObject.transform.position;
            var heightlessPosition = new Vector3(position.x, 0, position.z);
        
            EnemyTransform.transform.LookAt(heightlessPosition);

            var heightlessTransform = new Vector3(EnemyTransform.transform.position.x, 0, EnemyTransform.transform.position.z);
            var diffPosition = heightlessPosition - heightlessTransform;
            
            EnemyTransform.transform.position += diffPosition.normalized * (speed * Time.deltaTime);
        }

        public void Exit()
        {

        }
    }
}
