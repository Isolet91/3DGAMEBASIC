using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMiniMap : MonoBehaviour
{
    [SerializeField]
    private Camera minimapCamera;
    [SerializeField]
    private float zoomMin = 1; //카메라의 오소그래픽 최소 크기 
    [SerializeField]
    private float zoomMax = 30; //카메라의 오소그래픽 최대 크기
    [SerializeField]
    private float zoomOneStep = 1; //1회 줌 할 때 증가/감소되는 수치
    [SerializeField]
    private Text textMapName;
    //SceneManager.GetActiveScene().name; //현재씩의 이름
    //orthographicSize //오소그래픽 카메라의 사이즈

    private void Awake()
    {
        // 맵이름을 현재 씬 이름으로 설정(원하는 이름으로 설정)
        textMapName.text = SceneManager.GetActiveScene().name;
    }
    public void Zoomin()
    {
        //카메라의 오소그래픽 값을 감소시켜 카메라에 보이는 사물 크기 확대
        minimapCamera.orthographicSize =
            Mathf.Min(minimapCamera.orthographicSize + zoomOneStep, zoomMax);
    }

    public void ZoomOut()
    {
        //카메라의 오소그래픽 값을 증가시켜 카메라에 보이는 사물 크기 축소
        minimapCamera.orthographicSize =
            Mathf.Min(minimapCamera.orthographicSize + zoomOneStep, zoomMax);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
