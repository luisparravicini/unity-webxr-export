using UnityEngine;
using UnityEngine.Events;

namespace WebXR.Interactions
{
    // <summary>
    // Optional component an object can have to adjust it's position / rotation when
    // being pickup / dropped.
    // </summary>
    public class Interactable : MonoBehaviour
    {
        public UnityEvent OnPickupEvent;
        public UnityEvent OnDropEvent;

        public Vector3 BeforePickup(Vector3 newPosition)
        {
            transform.rotation = Quaternion.Euler(45, 45, 45);
            return newPosition;
        }


        public void OnPickup()
        {
            Debug.Log("pickup up " + gameObject.name);

            if (OnPickupEvent != null)
                OnPickupEvent.Invoke();
        }
        public void OnDrop()
        {
            Debug.Log("drop " + gameObject.name);

            if (OnDropEvent != null)
                OnDropEvent.Invoke();
        }
    }

}