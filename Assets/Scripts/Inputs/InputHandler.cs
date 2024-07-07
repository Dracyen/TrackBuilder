using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    protected Func<KeyCode>[] keys { get; set; }
    protected IBaseCommand[] commands { get; set; }
    public Func<KeyCode>[] Keys { get => keys; }
    public IBaseCommand[] Commands { get => commands; }

    public virtual void ExecuteCommand(IBaseCommand command, KeyCode keyCode)
    {
        throw new NotImplementedException();
    }
}
