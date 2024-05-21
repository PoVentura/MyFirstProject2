using UnityEngine;
using Vector3 = UnityEngine.Vector3;
public class ObjectInteraction : MonoBehaviour
{
    public Camera mainCamera;
    public float distance = 3f;
    private bool isPulling = false;
    private Vector3 targetPosition;
   
    private void Update()
    {
      if(Input.GetKeyDown(KeyCode.F))
        {
            isPulling = true;
            targetPosition = mainCamera.transform.position + mainCamera.transform.forward * distance;
        }    
      if(isPulling ) 
        {
         transform.position = Vector3.Lerp(transform.position, targetPosition,Time.deltaTime * 5f);
        }
      if(Input.GetKeyUp(KeyCode.F))
        { 
        isPulling=false; 
            transform.position= mainCamera.transform.position +mainCamera.transform.forward * distance;
        }
    }
}