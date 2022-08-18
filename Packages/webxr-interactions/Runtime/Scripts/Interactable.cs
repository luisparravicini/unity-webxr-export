using UnityEngine;

namespace WebXR.Interactions
{
    // <summary>
    // Optional component an object can have to adjust it's position / rotation when
    // being pickup / dropped.
    // </summary> 
    public class Interactable : MonoBehaviour
    {
        public Vector3 AdjustPickupPosition(Vector3 newPosition)
        {
            return newPosition;
        }

        public void AdjustRotation()
        {
        }
    }

}