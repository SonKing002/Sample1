using System.Collections;
using System.Collections.Generic;
using UnityEditor.TerrainTools;
using UnityEngine;

namespace std
{
    [CreateAssetMenu(fileName ="my",menuName = "file/my1")]
    
    ///<summary>
    /// �ڽ� ����
    /// </summary>
    public class Std : ScriptableObject 
    {
        [SerializeField][Range(0,100)] private int study;
        [SerializeField][TextArea] private string description;
        [Header("___��ũ��Ʈ ��ü ������ ����___")]
        public static string share_name;
        public static int share_MyAblity;


        public void SetInt(int nParam)
        {
            share_MyAblity = nParam;
        }

        public int GetInt()
        {
            return share_MyAblity;
        }
    }
}

