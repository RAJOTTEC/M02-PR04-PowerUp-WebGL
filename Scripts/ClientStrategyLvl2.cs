using UnityEngine;
using System.Collections.Generic;

namespace Strategy
{
    public class ClientStrategyLvl2 : MonoBehaviour
    {
        private GameObject _obstacle;
        private List<IManeuverBehaviour> _components = new List<IManeuverBehaviour>();

        private void SpawnObstacle()
        {
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(0, 1, 40);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-3, 1, 80);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(3, 1, 80);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-3, 1, 100);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-1, 1, 100);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(3, 1, 100);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-6, 1, 140);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(0, 1, 140);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(6, 1, 140);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-6, 1, 180);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(6, 1, 180);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(0, 1, 220);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-3, 1, 240);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(3, 1, 240);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-3, 1, 280);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-1, 1, 280);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(3, 1, 280);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-6, 1, 300);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(0, 1, 300);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(6, 1, 300);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-6, 1, 340);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(6, 1, 340);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(0, 1, 360);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(-3, 1, 380);
            ApplyRandomStrategies();
            _obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _obstacle.tag = "Obstacle";
            _obstacle.AddComponent<Obstacle>();
            _obstacle.transform.position = new Vector3(3, 1, 380);
            ApplyRandomStrategies();
        }

        private void ApplyRandomStrategies()
        {
            _components.Add(_obstacle.AddComponent<WeavingManeuver>());
            _components.Add(_obstacle.AddComponent<BoppingManeuver>());

            int index = Random.Range(0, _components.Count);

            _obstacle.GetComponent<Obstacle>().ApplyStrategy(_components[index]);
        }

        void Awake()
        {
            SpawnObstacle();
        }
    }
}