using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSizeInPixels : MonoBehaviour
{    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public static float RoundToNearestPixel(float unityUnits, Camera viewingCamera)
    {
        float valueInPixels = (Screen.height / (viewingCamera.orthographicSize * 2)) * unityUnits;
        valueInPixels = Mathf.Round(valueInPixels);
        float adjustedUnityUnits = valueInPixels / (Screen.height / (viewingCamera.orthographicSize * 2));
        return adjustedUnityUnits;
    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = GetComponent<Camera>();

        Vector3 roundPos = new Vector3(RoundToNearestPixel(newPos.x, camera), RoundToNearestPixel(newPos.y, camera), newPos.z);
        transform.position = roundPos;
    }
}
