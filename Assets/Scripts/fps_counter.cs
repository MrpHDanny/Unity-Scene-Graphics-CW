using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fps_counter : MonoBehaviour
{

    public Text fpsDisplay;

    void Start()
    {

    }

    void Update()
    {
        float fps = 1 / Time.unscaledDeltaTime;
        float roundedFPS = Mathf.Round(fps * 100f) / 100f;
        fpsDisplay.text = "" + roundedFPS;
    }
}
