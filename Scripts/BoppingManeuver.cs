using UnityEngine;
using System.Collections;

namespace Strategy
{
    public class BoppingManeuver : MonoBehaviour, IManeuverBehaviour
    {
        public void Maneuver(Obstacle obstacle)
        {
            StartCoroutine(Bopple(obstacle));
        }

        IEnumerator Bopple(Obstacle obstacle)
        {
            float time;
            bool isReverse = false;
            float speed = obstacle.speed;
            Vector3 startPosition = obstacle.transform.position;
            Vector3 endPosition = startPosition;
            endPosition.y = obstacle.maxHeight;

            while(true)
            {
                time = 0;
                Vector3 start = obstacle.transform.position;
                Vector3 end = (isReverse) ? startPosition : endPosition;

                while(time < speed)
                {
                    obstacle.transform.position = Vector3.Lerp(start, end, time / speed);
                    time += Time.deltaTime;
                    yield return null;
                }
                yield return new WaitForSeconds(1);
                isReverse = !isReverse;
            }
        }
    }
}