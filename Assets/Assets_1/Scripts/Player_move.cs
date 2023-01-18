using UnityEngine;
using System.Collections;

public class Player_move : MonoBehaviour {

	Animator Main_Animator;
	Transform Player;
	public bool Move, Jump;
	public float MoveSpeed;

	void Start () {
		//取得玩家物件本身
		Player = gameObject.transform;
		//取得動畫控制元件
		Main_Animator = Player.GetComponent<Animator>();
		//設定移動速度值為10
		MoveSpeed = 5f;
	}

	void Update () {
		//跟動畫控制器的變數做連結
		Main_Animator.SetBool("Move", Move);
		Main_Animator.SetBool("Jump", Jump);

		//按鍵控制(左)
		if(Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.eulerAngles = Vector3.zero;
			this.transform.Translate (MoveSpeed * Time.deltaTime, 0, 0);
			//開啟移動動畫
			Move = true;

		}
		//按鍵控制(右)
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			//物件旋轉值180
			this.transform.eulerAngles = new Vector3(0,180,0);
			//物件左邊方向移動
			this.transform.Translate (MoveSpeed * Time.deltaTime, 0, 0);
			//開啟移動動畫
			Move = true;

		}
		if(Input.GetKeyUp(KeyCode.RightArrow )|| Input.GetKeyUp(KeyCode.LeftArrow))
		{
			//向左跟向右的動畫都是走路,兩個任一個放開按鍵後都會關閉動畫
			Move = false;
			//每次時間的絕對值除以2等於0時執行
		}
		//按鍵控制(空白键)
		if(Input.GetKeyDown(KeyCode.Space))
		{
			//先判斷有沒有跳躍過,防止連續跳躍
			if(Jump == false)
			{
				//使用Rigidbody增加力的函式,向上
				transform.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 500);
				//開啟跳躍動畫
				Jump = true;
			}
		}

	}


	void OnCollisionEnter2D(Collision2D c)
	{
		//判斷有沒有碰到地板
		if(c.gameObject.name == "Floor")
		{
			//跳躍條件關閉,就可以再進行跳躍
			Jump = false;
		}
		if(c.gameObject.name == "Floor2")
		{
			Jump = false;
		}
	}

	void OnCollisionExit2D()
	{
	}
}
