using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClientObserver : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private PlayerCollision _playerCollision;

    void Start()
    {
        _playerMovement = (PlayerMovement)FindObjectOfType(typeof(PlayerMovement));
        _playerCollision = (PlayerCollision)FindObjectOfType(typeof(PlayerCollision));
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 150, 20), "Level " + SceneManager.GetActiveScene().buildIndex);
        if (_playerCollision)
        {
            if(_playerCollision.death == true)
            {
                GUI.Box(new Rect(Screen.width / 2 - 75, 0, 150, 20), "You hit a box and died");
            }
        }
        if(_playerMovement)
        {
            if(_playerMovement.moveDeath == true)
            {
                GUI.Box(new Rect(Screen.width / 2 - 75, 0, 150, 20), "You fell to your death");
            }
            if(_playerMovement.flying == true)
            {
                GUI.Box(new Rect(Screen.width / 2 - 75, 0, 150, 20), "Parkour");
            }
        }
    }
}
