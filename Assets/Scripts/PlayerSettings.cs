using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerSettings
{
    ////PRIVATE
    //BASIC CONTROLS
    private static KeyCode basePause = KeyCode.Escape;
    private static KeyCode baseConfirm = KeyCode.Return;
    private static KeyCode baseCancel = KeyCode.Escape;
    private static KeyCode baseDirectionUp = KeyCode.W;
    private static KeyCode baseDirectionDown = KeyCode.S;
    private static KeyCode baseDirectionLeft = KeyCode.A;
    private static KeyCode baseDirectionRight = KeyCode.D;

    //CAR CONTROLS
    private static KeyCode carAccelerate = KeyCode.W;
    private static KeyCode carDecelerate = KeyCode.S;
    private static KeyCode carTurnLeft = KeyCode.A;
    private static KeyCode carTurnRight = KeyCode.D;
    private static KeyCode carReset = KeyCode.R;
    private static KeyCode carBrake = KeyCode.Space;

    ////PUBLIC
    //BASIC CONTROLS
    public static KeyCode BasePause { get => basePause; set => basePause = value; }
    public static KeyCode BaseConfirm { get => baseConfirm; set => baseConfirm = value; }
    public static KeyCode BaseCancel { get => baseCancel; set => baseCancel = value; }
    public static KeyCode BaseDirectionUp { get => baseDirectionUp; set => baseDirectionUp = value; }
    public static KeyCode BaseDirectionDown { get => baseDirectionDown; set => baseDirectionDown = value; }
    public static KeyCode BaseDirectionLeft { get => baseDirectionLeft; set => baseDirectionLeft = value; }
    public static KeyCode BaseDirectionRight { get => baseDirectionRight; set => baseDirectionRight = value; }

    //CAR CONTROLS
    public static KeyCode CarAccelerate { get => carAccelerate; set => carAccelerate = value; }
    public static KeyCode CarDecelerate { get => carDecelerate; set => carDecelerate = value; }
    public static KeyCode CarTurnLeft { get => carTurnLeft; set => carTurnLeft = value; }
    public static KeyCode CarTurnRight { get => carTurnRight; set => carTurnRight = value; }
    public static KeyCode CarReset { get => carReset; set => carReset = value; }
    public static KeyCode CarBrake { get => carBrake; set => carBrake = value; }
}
