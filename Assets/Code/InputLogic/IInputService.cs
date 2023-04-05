using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.Code.Observavle;

public interface IInputService : Assets.Code.Observavle.IObservable<UnityAction<Vector2>>
{ 
    public event UnityAction<Vector2> Direction;

}
