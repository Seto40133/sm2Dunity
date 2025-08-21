using UnityEngine;
using TMPro; // TextMeshProを使ってUIテキストを表示するための名前空間
 
// スコアの管理とUI表示を担当するクラス
public class ScoreManager : MonoBehaviour
{
    // シングルトンパターン：他のスクリプトから簡単にアクセスできるようにする
    // static変数にインスタンスを保持することで、どこからでも呼び出せるようになる
    public static ScoreManager Instance;
 
    // 現在のスコア（初期値は0）
    public int score = 0;
 
    // スコアを表示するTextMeshProのUI要素（Inspectorで割り当てる）
    public TextMeshProUGUI scoreText;
 
    // AwakeはStartよりも早く呼ばれる初期化関数
    // シングルトンの初期化処理を行う
    void Awake()
    {
        // まだインスタンスが存在しない場合は自分を登録
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            // すでに別のインスタンスが存在する場合は重複を防ぐために自分を破棄
            Destroy(gameObject);
        }
    }
 
    // スコアを加算する関数（他のスクリプトから呼び出される）
    public void AddScore(int amount)
    {
        score += amount; // スコアに加算
        UpdateScoreUI(); // UIを更新
    }
 
    // スコア表示用のUIテキストを更新する処理
    void UpdateScoreUI()
    {
        // UI要素が割り当てられている場合のみ更新
        if (scoreText != null)
        {
            // TextMeshProのtextプロパティにスコアを文字列として表示
            scoreText.text = "Score : " + score.ToString();
        }
    }
}
 