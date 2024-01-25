using System.Threading.Tasks;
using UnityEngine;

public class TurnCubeAsync : MonoBehaviour
{
    [SerializeField]
    Transform _cubeTransform;

    [SerializeField]
    int _rotationTime;

    bool _isCanceled;

    public void StartTask()
    {
        RotateCube();
    }

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

    public void StopTask()
    {
        _isCanceled = true;
    }
}