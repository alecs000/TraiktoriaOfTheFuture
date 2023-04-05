using UnityEngine;
using UnityEngine.Events;


public class PCInputService : MonoBehaviour, IInputService
{
    public event UnityAction<Vector2> Direction;

    private void FixedUpdate()
    {
        Vector2 direction = new();
        if (Input.GetKey(KeyCode.Space))
        {
            direction = new Vector2(direction.x, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = new Vector2(-1, direction.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = new Vector2(1, direction.y);
        }
        else
        {
            direction = new Vector2(0, direction.y);
        }
        if (direction != Vector2.zero)
        {
            Direction.Invoke(direction);
        }
    }

    public void AddObserver(UnityAction<Vector2> @delegate)
    {
        Direction += @delegate;
    }

    public void RemoveObserver(UnityAction<Vector2> @delegate)
    {
        Direction -= @delegate;
    }
}
