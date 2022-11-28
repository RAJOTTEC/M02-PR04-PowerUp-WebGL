using UnityEngine;
using System.Collections;

namespace Strategy
{
    public class FallbackManeuver : MonoBehaviour, IManeuverBehaviour
    {
        public void Maneuver(Obstacle obstacle)
        {
            StartCoroutine(Fallback(obstacle));
        }

        IEnumerator Fallback(Obstacle obstacle)
        {
            float time = 0;
            float speed = obstacle.speed;
            Vector3 startPosition = obstacle.transform.position;
            Vector3 endPosition = startPosition;
            endPosition.z = obstacle.fallbackDistance;

            while (time < speed)
            {
                obstacle.transform.position = Vector3.Lerp(startPosition, endPosition, time / speed);

                time += Time.deltaTime;

                yield return null;
            }
        }
    }
}