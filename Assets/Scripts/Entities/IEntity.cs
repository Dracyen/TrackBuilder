using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntity
{
    //public KeyCode[] Keys { get; }
    //public IBaseCommand[] Commands { get; }

    bool CanShoot();
    void Shoot();

    bool CanJump();
    void Jump();
}
