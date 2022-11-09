using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        CreateEnemy();
    }

    void Update()
    {
        UpdateUI();
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

    [HeaderAttribute("¥Í¦¨¼Ä¤H")]
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
