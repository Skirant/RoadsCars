using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider _slider;
    //private ParticleSystem _particleSys;

    public float FillSpeed = 0.5f;
    private float targetProgress = 0;

    private void Awake()
    {
        _slider = gameObject.GetComponent<Slider>();
        //_particleSys = GameObject.Find("PB Particles").GetComponent<ParticleSystem>();
    }

    private void Start()
    {
        IncrementProgress(1f);
    }

    private void Update()
    {
       if(_slider.value < targetProgress)
        {
            _slider.value += FillSpeed * Time.deltaTime;
            /*if (!_particleSys.isPlaying)
            {
                _particleSys.Play();
            }
            else
            {
                _particleSys.Stop();
            }*/
        }
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = _slider.value + newProgress;
    }
}
