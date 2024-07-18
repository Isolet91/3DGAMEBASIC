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
    private float zoomMin = 1; //ī�޶��� ���ұ׷��� �ּ� ũ�� 
    [SerializeField]
    private float zoomMax = 30; //ī�޶��� ���ұ׷��� �ִ� ũ��
    [SerializeField]
    private float zoomOneStep = 1; //1ȸ �� �� �� ����/���ҵǴ� ��ġ
    [SerializeField]
    private Text textMapName;
    //SceneManager.GetActiveScene().name; //���羿�� �̸�
    //orthographicSize //���ұ׷��� ī�޶��� ������

    private void Awake()
    {
        // ���̸��� ���� �� �̸����� ����(���ϴ� �̸����� ����)
        textMapName.text = SceneManager.GetActiveScene().name;
    }
    public void Zoomin()
    {
        //ī�޶��� ���ұ׷��� ���� ���ҽ��� ī�޶� ���̴� �繰 ũ�� Ȯ��
        minimapCamera.orthographicSize =
            Mathf.Min(minimapCamera.orthographicSize + zoomOneStep, zoomMax);
    }

    public void ZoomOut()
    {
        //ī�޶��� ���ұ׷��� ���� �������� ī�޶� ���̴� �繰 ũ�� ���
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
