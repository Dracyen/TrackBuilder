using System.Windows.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBaseCommand
{
    bool CanExecute();
    void Execute();
}

public interface IEntityCommand : IBaseCommand
{
    IEntity target { get; }
}

public class CommandShoot : IEntityCommand
{
    public IEntity target { get; private set; }

    public CommandShoot(IEntity entity)
    {
        target = entity;
    }

    public bool CanExecute()
    {
        return target.CanShoot();
    }

    public void Execute()
    {
        target.Shoot();
    }
}

public class CommandJump : IEntityCommand
{
    public IEntity target { get; private set; }

    public CommandJump(IEntity entity)
    {
        target = entity;
    }

    public bool CanExecute()
    {
        return target.CanJump();
    }

    public void Execute()
    {
        target.Jump();
    }
}
