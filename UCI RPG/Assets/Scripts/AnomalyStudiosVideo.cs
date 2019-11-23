using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class AnomalyStudiosVideo : MonoBehaviour
{
    double currentTime;
    [SerializeField] double videoTime = .4f;
    VideoPlayer video;

    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();
        videoTime = video.clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(!(currentTime < videoTime))
        {
        	Debug.Log("Ending");
            SceneManager.LoadScene("Main Menu");
        }
        
    }
}