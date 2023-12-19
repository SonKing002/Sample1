using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class NewBehaviourScript : MonoBehaviour
{

    public int my_Price;
    [Range(0,99)]public int count; //ex 오디오
    // <- 갯수 제한 필요: 사용자 런타임 버그 방지

    public string my_Name;  
    [TextArea]public string my_Description;// 여러줄 묘사
    //[TextArea]

    public float gauge;
    public GameObject my_Item;
    // 하이어라키에 올라온 게임오브젝트형식
    // 유니티 컴포넌트도 변수에 올릴 수 있다
    //ex 외부 자료 : 사운드 
    public AudioClip ex_Aidio;

    //시작 1프레임에 한번 , 실행 진입점
    void Start()
    {
        my_Price = 1_000; // 
        my_Name = "가그린";
        my_Description = "시원하고 상쾌한 사용감";

        //명령어코드
        Debug.Log($"가격 : {my_Price}");
        // Log a Message to the Unity
        Debug.Log("이름 : " + my_Name);
        Debug.Log(string.Format("{0}",my_Description));
    }

    //매 프레임마다 호출됨
    void Update()
    {
        
    }
}
/* 유니티엔진_ C# 
 
using  : 해당 코드에서 이 기능을 사용하겠다.

ex. using Sytem.Collections;
    System 네임스페이스 Collection 을 연결해주는 키워드



public class : 

ex public class NewBehaviorScript : MonoBehavior
public class A : B
 
B 기능을 상속받은 class A 
B를 A에서 재 작성하지 않아도 사용 가능

 */

/* 기호 정리

    . 맴버 객체 접근
    ; 명령문의 마지막 마침표

    () 소괄호
메서드(=함수) 뒤에 붙음, //변수랑 구분
파라미터(매개변수)를 넣을 떄 사용 // 없으면 비워둠

    {} 중괄호(블록,body)
코드블록 내용작성하는 단위 공간범위, 작업범위

    [] 대괄호
프로그램에서 데이터의 묶음,배열을 표현시 사용기호

    // 주석처리
기능을 설명하는 프로그래머를 위한 기호 : 컴파일시 읽히지 않음

    = 할당 대입 (같다 의미 x)
Left Value = Right Value; Lv에 Rv 값을 넣는다. 

    $ 
문장 안에서 데이터를 확인할 수 있는 포매팅(formating)기능을
가지고 있는 문자 
//format : 양식 서식

    C# 지원 : + 
더하기가 문자열 뒤 연결해주는 기능으로 사용 가능
   
 */

/* 키워드 정리
 
 class : 맴버 변수와 메서드 정보를 가지고 있는 집합

기본 기능

 Start() 메서드 {}  
프로그램 실행시 반드시 한번 실행되는 진입점

 Update() 메서드{} 
반복적으로 실행되는 메서드

[Range(float,float)] public 자료형 변수명; //인스펙터 범위 설정
[TextAria] public string 변수명; //인스펙터에서 여러줄

 Debug.Log(); 메서드 : console창에 출력 메세지를 보내는 기능
표현방식_
1. Debug.Log($"{변수명}");
2. Debug.Log("내용 "+변수명);
3. Debug.Log(string.Format("{0}",변수명));

//0부터 시작하는 첨자, 첨자 요소에 들어가는 변수명
//첨자 갯수 만큼, 데이터를 넣어준다.

포맷 == 양식 서식
포매팅 : 형식을 바꿔주는 것

 string.Format()메서드
 */

/*Unity 스크립트 팁
 
 * 파랑색 : 기능 함수 색
 * 초록색 : 클래스 덩어리 색
 //녹색 밑줄 : 이미 같은 변수명 존재
 */

/* 정의
 
변수 (Variable)
     유니티 내 스크립트에서 객체의 속성을 표현할 때 사용합니다.
     하나의 데이터의 이름을 붙여서 저장하는 공간

     선언 : 자료형 만큼의 데이터 공간만 할당함
     선언방법 : 접근제어지시자 + 자료형식 + 변수명; 

초기화 (Initialize)
     변수를 선언 시, 값을 해당 변수에 대입함

자료형식 : 컴퓨터가 데이터를 판단하는 데이터형식 
ex. int float string...

    int == integral 부호있는 정수 표현
    string == 문자들을 나열한 문자배열 (문자열)
    float ==  부호있는 실수 표현
    GameObject == (유니티 Hierachy창에 올라온 오브젝트 대상)

    유니티 컴포넌트도 변수에 올릴 수 있다
    ex 외부 자료 : 사운드 
    public AudioClip ex_Aidio;
 */

/* 규칙
 
변수의 규칙 >>

    1. 선언해서 사용 (이름만 적는다)  
        유니티 에디터에서 (사용자가) 값을 넣을 수 있기 때문
 *네이티브 C# 에서는 값 없이 사용 불가능* 
 *Nullable 방법이 존재함 : int? a;

    1_1. 할당/대입 (ex. 변수명 = 값;)
        선언 후, 변수 명만 사용한다.
 
    2. 선언 + 할당 == 초기화 (ex. 자료형 + 변수명 = 값;)
        이름과 값을 적는다


    변수 명의 길이 제한이 있는가 : x 
    이름은 지관적 + 간단명료하게 작성할 것
ex item001? < sword
    이름 첫번째로 숫자 사용 가능하는가 : x
ex 정수로 해석하기 떄문
//다른 자리에서 숫자 사용가능 : 문자열로 해석함

    이름에 특수문자 사용 가능하는가 : O (일부분만 가능)
ex 특수문자의 기능이 있기 때문 일부만 가능 _(언더스코어)
*파이썬은 쉘언어이기때문에 특수문자 불가능*

    변수의 이름으로 키워드를 사용 할 수 없다.
ex string string;

*/
