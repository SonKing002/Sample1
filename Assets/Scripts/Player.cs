using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 플래이어 여러명 고려
/// </summary>
[CreateAssetMenu(fileName ="player",menuName ="player/charater")]
public class Player : ScriptableObject
{
    public float walk_Speed;
    //움직임 같음
    //같은 폭탄 공격, 단거리 공격
    //공격력, 체력, 속도 다름 == 변수정보


    public string name;
    public int hp;
    [Header("변수명 = 속성_해당종류")]
    public int atkPower_Bomb;
    public int atkPower_short;
    public float speed_walk;
    public float speed_BombAtk;
    public float speed_ShortAtk;

    [Header("스프라이트,에니메이션")]
    public Sprite sprite_ren;
    public Animator animCtrl;

    public enum InformNumber
    { 
        NULL,
        name,
        atkPower_Bomb,
        atkPower_short,
        speed_walk,
        speed_BombAtk,
        speed_ShortAtk
    }
    public static InformNumber ip_InformIndex = new InformNumber();


    public void Set_Player(string nameParam, int hpParam, int shrtPower ,int bombPower ,
        float walkSpdParam , float bombSpdParam, float shrtSpdParam)
    {
        name = nameParam; 
        hp = hpParam; 
        atkPower_Bomb = bombPower; 
        atkPower_short = shrtPower; 
        speed_walk = walkSpdParam; 
        speed_BombAtk = bombSpdParam; 
        speed_ShortAtk = shrtSpdParam; 
    }

    public void SetIndex(int index)
    {
        switch (index)
        { 
            case 0:
                ip_InformIndex = InformNumber.NULL;
                break;
            case 1:
                ip_InformIndex = InformNumber.name;
                break;
            case 2:
                ip_InformIndex = InformNumber.atkPower_Bomb;
                break;
            case 3:
                ip_InformIndex = InformNumber.atkPower_short;
                break;
            case 4:
                ip_InformIndex = InformNumber.speed_walk;
                break;
            case 5:
                ip_InformIndex = InformNumber.speed_BombAtk;
                break;
            case 6:
                ip_InformIndex = InformNumber.speed_ShortAtk;
                break;
            default:
                Debug.LogError("잘못받은 입력이라 NULL로 연결");
                ip_InformIndex = InformNumber.NULL;
                break;
        }
    }

    public string Get_Player()
    {
        switch (ip_InformIndex) 
        {
            case InformNumber.NULL:
                return "";
            case InformNumber.name:
                return name;
            case InformNumber.atkPower_Bomb:
                return atkPower_Bomb.ToString();
            case InformNumber.atkPower_short:
                return atkPower_short.ToString();
            case InformNumber.speed_walk:
                return speed_walk.ToString();
            case InformNumber.speed_BombAtk:
                return speed_BombAtk.ToString();
            case InformNumber.speed_ShortAtk:
                return speed_ShortAtk.ToString();
            default:
                Debug.Log("값이 잘못 들어옴");
                return "";
        }
    }

}
