using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �÷��̾� ������ ���
/// </summary>
[CreateAssetMenu(fileName ="player",menuName ="player/charater")]
public class Player : ScriptableObject
{
    public float walk_Speed;
    //������ ����
    //���� ��ź ����, �ܰŸ� ����
    //���ݷ�, ü��, �ӵ� �ٸ� == ��������


    public string name;
    public int hp;
    [Header("������ = �Ӽ�_�ش�����")]
    public int atkPower_Bomb;
    public int atkPower_short;
    public float speed_walk;
    public float speed_BombAtk;
    public float speed_ShortAtk;

    [Header("��������Ʈ,���ϸ��̼�")]
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
                Debug.LogError("�߸����� �Է��̶� NULL�� ����");
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
                Debug.Log("���� �߸� ����");
                return "";
        }
    }

}
