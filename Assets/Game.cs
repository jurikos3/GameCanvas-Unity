#nullable enable
using GameCanvas;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// ゲームクラス。
/// 学生が編集すべきソースコードです。
/// </summary>
public sealed class Game : GameBase
{
    int time = 600;
    int score = o;
    int sec = 0;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public override void InitGame()
    {
        gc.ChangeCanvasSize(360, 640);
        gc.ChangeCanvasSize(720, 1280);
    }

    /// <summary>
    /// 動きなどの更新処理
    /// </summary>
    public override void UpdateGame()
    time -= 1;
    if (time >=0)
    {
        score += gc.PointerBeginCount;
    }
    if (gc.GetPointerDuration(0) >= 2)
    {
        time = 600+
        score = 0;
    }
    
    /// <summary>
    /// 描画の処理
    /// </summary>
    public override void DrawGame()
    {
        // 画面を白で塗りつぶします
        gc.ClearScreen();
        
        if(time >= 0 ){
          gc.DrawString("time:"+time,60,0);
        }
        else {
          gc.DrawString("finished!!",60,0);
        }
        
        gc.DrawString("score:"+score,60,60);
        
        gc.DrawImage(GcImage.BlueSky, 0, 0)
        // 黒の文字を描画します
        gc.SetColor(0, 0, 0);
        gc.SetFontSize(48);
        gc.SetStringAnchor(GcAnchor.UpperLeft);
        gc.DrawString("この文字と青空の画像が", 40, 160);
        gc.DrawString("見えていれば成功です", 40, 270);
        gc.SetStringAnchor(GcAnchor.UpperRight);
        gc.DrawString($"{sec}s", 630, 10);
    }
}
