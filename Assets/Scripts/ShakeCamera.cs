using UnityEngine;
using Cinemachine;
using System.Collections;


public class ShakeCamera : MonoBehaviour
{
    private CinemachineVirtualCamera _virtualCamera; 
    private CinemachineBasicMultiChannelPerlin _basicMultiChannelPerlin;
    
    private void Start()
    {
        _virtualCamera = GetComponent<CinemachineVirtualCamera>(); 
        _basicMultiChannelPerlin = _virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    public IEnumerator StartShake()
    {
        _basicMultiChannelPerlin.m_AmplitudeGain = 2; 
        _basicMultiChannelPerlin.m_FrequencyGain = 1;
        yield return new WaitForSeconds(0f);
    }
    
    public IEnumerator EndShake()
    {
        _basicMultiChannelPerlin.m_AmplitudeGain = 0;
        _basicMultiChannelPerlin.m_FrequencyGain = 0;
        yield return new WaitForSeconds(0f);
    }
}
