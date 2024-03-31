using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allows for easy timescale changes in the inspector which will revert to original settings when finished playing
/// </summary>
public class TimescaleSetter : MonoBehaviour
{
    [SerializeField][Range(0,1)] float newTimescale = 1.0f;
    float originalTimescale = 1.0f;

    void Start()
    {
        originalTimescale = Time.timeScale;
        Time.timeScale = newTimescale;
    }

    /// <summary>
    /// Updates timescale when value is changed in the inspector
    /// </summary>
    void OnValidate()
    {
        Time.timeScale = newTimescale;
    }

    void OnDisable()
    {
        Time.timeScale = originalTimescale;
    }
}
