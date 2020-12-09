using System.Collections;
using UnityEngine;

namespace Mirror.Cloud.Core
{
    public interface ICoroutineRunner : IUnityEqualCheck
    {
        Coroutine StartCoroutine(IEnumerator routine);
        void StopCoroutine(IEnumerator routine);
        void StopCoroutine(Coroutine routine);
    }
}
