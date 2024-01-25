using System.Collections;
using UnityEngine;

public class TurnCube : MonoBehaviour
{
    [SerializeField]
    Transform _cubeTransform;

    [SerializeField]
    int _rotationTime;

    Coroutine _coroutine;

    /// <summary>
    /// Starting the coroutine and storing it in a variable.
    /// </summary>
    public void StartTurn()
    {
        _coroutine = StartCoroutine(Turn());
    }

    /// <summary>
    /// Coroutine to rotate the cube 1° every 0.01s, you can choose for how many seconds you want the cube to rotate.
    /// </summary>
    /// <returns></returns>
    IEnumerator Turn()
    {
        for (int i = 0; i < _rotationTime * 100; i++)
        {
            _cubeTransform.Rotate(0, 1, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }

    /// <summary>
    /// Stops the coroutine.
    /// </summary>
    public void Stop()
    {
        StopCoroutine(_coroutine);
    }
}