using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Camera cmr;
    void Start()
    {
        CreateEnemy();
        cmr = Camera.main;
    }

    void Update()
    {
        UpdateUI();
        CameraControl();
    }
    [HeaderAttribute("相機")]
    public GameObject obj;
    public Vector3 position;
    void CameraControl()
    {
        cmr.transform.position = obj.transform.position + position;
    }
    [HeaderAttribute("UI")]
    public Text hp;
    public Text mp;
    private static int nowHp = 0;
    private static int nowMp = 0;
    public static void AddHp(int n)
    {
        nowHp += n;
    }
    public static void AddMp(int n)
    {
        nowMp += n;
    }
    private void UpdateUI()
    {
        hp.text = "HP:" + nowHp.ToString();
        mp.text = "MP:" + nowMp.ToString();
    }

    [HeaderAttribute("生成敵人")]
    public GameObject Enemy;
    private void CreateEnemy()
    {
        for (int i = 0; i < 20; i++)
        {
            var position = new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50));
            Instantiate(Enemy, position, transform.rotation);
        }
    }


}
