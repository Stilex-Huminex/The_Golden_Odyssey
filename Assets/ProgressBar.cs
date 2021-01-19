using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
    public GameObject panel;
    public GameObject slider1;

    public Slider slider;
    public Text progressText;
    public float FillSpeed = 0.5f;

    private float targetProgress = 0;
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    void Start()
    {
        
    }
    void Update()
    {
       if (slider.value < targetProgress)
        {
            slider.value += FillSpeed * Time.deltaTime;
            progressText.text = Mathf.Floor(slider.value * 100f) + "%";
            
        }
       if (slider.value == 1f)
        {
            panel.SetActive(false);
            slider1.SetActive(false);
            FindObjectOfType<MainVaisseau>().enabled = true;
            slider.value = 0f;
        }
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
        progressText.text =  slider.value * 100f + "%";
    }
}
