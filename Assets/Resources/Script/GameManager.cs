using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        CreateEnemy();
        CreateMortal();
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

    [HeaderAttribute("生成敵人")]
    public GameObject enemy;
    public int enemyNumber = 20;
    private void CreateEnemy()
    {
        for (int i = 0; i < enemyNumber; i++)
        {
            var position = new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50));
            Instantiate(enemy, position, transform.rotation);
        }
    }

    [HeaderAttribute("生成戒指")]
    public GameObject mortal;
    public int mortalNumber = 20;
    private void CreateMortal()
    {
        for (int i = 0; i < mortalNumber; i++)
        {
            var position = new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50));
            Instantiate(mortal, position, transform.rotation);
        }
    }

}
