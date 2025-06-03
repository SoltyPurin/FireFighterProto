using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class ViblationOfController : MonoBehaviour
{
    private float _waitForSeconds = default;
    public float WaitForSeconds
    {
        set { _waitForSeconds = value; }
    }
    public IEnumerator BreakWallViblation()
    {
        Gamepad gamepad = Gamepad.current;
        if (gamepad != null)
        {
            gamepad.SetMotorSpeeds(2.0f, 2.0f);
            yield return new WaitForSeconds(_waitForSeconds *2);
            gamepad.SetMotorSpeeds(0.0f, 0.0f);
        }
    }
}
