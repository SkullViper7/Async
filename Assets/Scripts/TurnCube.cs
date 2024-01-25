using System.Collections;
using UnityEngine;

public class TurnCube : MonoBehaviour
{
    [SerializeField]
    Transform _cubeTransform;

    [SerializeField]
    int _rotationTime;

    Coroutine _coroutine;

    public void StartTurn()
    {
        _coroutine = StartCoroutine(Turn());
    }

    IEnumerator Turn()
    {
        for (int i = 0; i < _rotationTime * 100; i++)
        {
            _cubeTransform.Rotate(0, 1, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }

    public void Stop()
    {
        StopCoroutine(_coroutine);
    }
}