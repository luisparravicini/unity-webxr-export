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
        public float dropVelocityFactor = 1;
        public UnityEvent OnPickupEvent;
        public UnityEvent OnDropEvent;
        public UnityEvent<Transform> OnBeforePickupEvent;

        public Vector3 BeforePickup(Transform controller, Vector3 newPosition)
        {
            if (OnBeforePickupEvent != null)
                OnBeforePickupEvent.Invoke(controller);

            return newPosition;
        }


        public void OnPickup(Rigidbody rigidbody)
        {
            Debug.Log("pickup up " + gameObject.name);

            if (OnPickupEvent != null)
                OnPickupEvent.Invoke();
        }
        public void OnDrop(Rigidbody rigidbody)
        {
            Debug.Log("drop " + gameObject.name);

            rigidbody.velocity = rigidbody.velocity * dropVelocityFactor;

            if (OnDropEvent != null)
                OnDropEvent.Invoke();
        }
    }

}