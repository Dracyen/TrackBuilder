using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityInputHandler : InputHandler
{
    //Func<KeyCode> stuff;

    public EntityInputHandler(IEntity entity)
    {
        //stuff = () => PlayerSettings.CarTurnLeft;

        //Debug.Log(stuff());

        keys = new Func<KeyCode>[]
        {
            () => PlayerSettings.BasePause,
            () => PlayerSettings.BaseConfirm,
            () => PlayerSettings.BaseCancel,
            () => PlayerSettings.CarAccelerate,
            () => PlayerSettings.CarDecelerate,
            () => PlayerSettings.CarTurnLeft,
            () => PlayerSettings.CarTurnRight,
            () => PlayerSettings.CarReset,
            () => PlayerSettings.CarBrake
        };

        commands = new IBaseCommand[]
        {
            null,
            null,
            null,
            null,
            null,
            new CommandJump(entity),
            new CommandShoot(entity),
            null,
            null
        };
    }

    public override void ExecuteCommand(IBaseCommand command, KeyCode keyCode)
    {
        if (command != null && command.CanExecute() && Input.GetKeyDown(keyCode))
            command.Execute();
    }
}