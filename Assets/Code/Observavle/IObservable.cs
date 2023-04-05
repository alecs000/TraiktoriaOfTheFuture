using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Observavle
{
    public interface IObservable<T> where T : Delegate
    {
        public void AddObserver(T @delegate);
        public void RemoveObserver(T @delegate);

    }
}