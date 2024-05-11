using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    RectTransform rect;
    void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    public void PauseGames()
    {
        rect.localScale = Vector3.one;
        GameManager.instance.Stop();
        AudioManager.instance.EffectBgm(true);
    }

    public void ResumeGame()
    {
        rect.localScale = Vector3.zero;
        GameManager.instance.Resume();
        AudioManager.instance.EffectBgm(false);
    }
}
