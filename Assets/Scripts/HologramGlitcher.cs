using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HologramGlitcher : MonoBehaviour
{

    public float glitchChance = 0.4f;

    private Renderer holoRenderer;
    private WaitForSeconds glitchLoopWait = new WaitForSeconds(.5f);
    private WaitForSeconds glitchDuration = new WaitForSeconds(1f);

    void Awake()
    {
        holoRenderer = GetComponent<Renderer>();
    }

    IEnumerator Start()
    {
        while (true)
        {
            float glitchTest = Random.Range(0f, 1f);

            if (glitchTest <= glitchChance)
            {
                StartCoroutine(Glitch());
            }
            yield return glitchLoopWait;
        }
    }

    IEnumerator Glitch()
    {
        glitchDuration = new WaitForSeconds(Random.Range(0.1f, 0.2f));
        holoRenderer.material.SetFloat("_Amount", 1f);
        //holoRenderer.material.SetFloat("_CutoutThresh", .29f);
        holoRenderer.material.SetFloat("_Amplitude", Random.Range(100, 250));
        holoRenderer.material.SetFloat("_Speed", Random.Range(100, 200));
        yield return glitchDuration;
        holoRenderer.material.SetFloat("_Amount", 0f);
        holoRenderer.material.SetFloat("_CutoutThresh", 0f);
    }
}
