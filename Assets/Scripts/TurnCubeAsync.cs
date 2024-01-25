using System.Threading.Tasks;
using UnityEngine;

public class TurnCubeAsync : MonoBehaviour
{
    [SerializeField]
    Transform _cubeTransform;

    [SerializeField]
    int _rotationTime;

    bool _isCanceled;

    /// <summary>
    /// Starts the async task.
    /// </summary>
    public void StartTask()
    {
        RotateCube();
    }

    /// <summary>
    /// Same thing as the coroutine unless this time, if a bool is true, the task is stoped.
    /// </summary>
    /// <returns></returns>
    async Task RotateCube()
    {
        for (int i = 0; i < _rotationTime * 100; i++)
        {
            _cubeTransform.Rotate(0, 1, 0);
            await Task.Delay(10);

            if (_isCanceled)
            {
                break;
            }
        }
    }

    /// <summary>
    /// Setting a bool to stop the task.
    /// </summary>
    public void StopTask()
    {
        _isCanceled = true;
    }
}