using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*************************************************
 * @class プレイヤークラス
 *************************************************/
public class Player : MonoBehaviour {

	private bool		is_attack_;				//! 攻撃フラグ
	private bool		is_damage_;				//! ダメージフラグ
	private	Animator	anim_ctrl_;				//! アニメーションコントローラー

	/*************************************************
     * @brief コンストラクタ
     *************************************************/
 	Player()
	{
		is_attack_ = false;
		is_damage_ = false;
	}

	/*************************************************
     * @brief デストラクタ
     *************************************************/
	~Player()
	{
	}

	/*************************************************
     * @brief 初期化
     *************************************************/
    void Start()
    {
        // アニメーションコントローラーの取得
		anim_ctrl_ = GetComponent<Animator>();
    }

	/*************************************************
     * @brief 更新
     *************************************************/
	void Update()
    {
		// 入力判定
		// 攻撃
		if (Input.GetKeyDown(KeyCode.A) && !is_attack_)
		{
			is_attack_ = true;
			anim_ctrl_.SetFloat("AttackScale", 0.0f);
			anim_ctrl_.SetBool("Attack", true);
		}
	}

	/*************************************************
	 * @brief アニメーションイベント：Attackフラグ　ON
	*************************************************/
	public void AnimEvent_AttackOn()
	{
		anim_ctrl_.SetBool("Attack", true);
	}

	/*************************************************
	 * @brief アニメーションイベント：Attackフラグ　OFF
	*************************************************/
	public void AnimEvent_AttackOff()
	{
		is_attack_ = false;
		anim_ctrl_.SetBool("Attack", false);
	}

	/*************************************************
	 * @brief アニメーションイベント：Damageフラグ　ON
	*************************************************/
	public void AnimEvent_DamageOn()
	{
		anim_ctrl_.SetBool("Damage", true);
	}

	/*************************************************
	 * @brief アニメーションイベント：Damageフラグ　OfF
	*************************************************/
	public void AnimEvent_DamageOff()
	{
		anim_ctrl_.SetBool("Damage", false);
	}
}
