using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : Observer
{
    private PlayerCollision _playerCollision;

    private PlayerMovement _playerMovement;

    public override void Notify(Subject subject)
    {
        if(!_playerCollision)
        {
            _playerCollision = subject.GetComponent<PlayerCollision>();
        }
        if(!_playerMovement)
        {
            _playerMovement = subject.GetComponent<PlayerMovement>();
        }
    }
}
