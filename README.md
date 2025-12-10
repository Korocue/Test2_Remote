# Test2_Remote

Codex 練習用の超小型 C# リポジトリです。最小限のコードで pull request 作成やレビューの手順を手早く確認できます。

## 目的
- リモートリポジトリを前提にした Git フローの練習
- シンプルな C# コードを使ったテスト追加・ドキュメント整備の練習
- 短時間でセットアップ〜動作確認までを体験するためのハンズオン素材

## リポジトリ構成
- `src/Calculator.cs` : 単一の `Calculator` クラスを持つ C# ファイル。`Add` など最小限のユーティリティを提供
- `README.md` : 本ドキュメント

## クイックスタート (3 分で把握)
1. .NET SDK が手元にあれば `dotnet script` や小さなコンソールアプリから `Calculator` を参照できます。
2. コードは `Test2Remote` 名前空間直下にあり、特別な依存ライブラリはありません。
3. 以下のように `Add` を呼び出すだけで動作を確認できます。

```csharp
using Test2Remote;

// 2 + 3 = 5
var result = Calculator.Add(2, 3);
Console.WriteLine(result);
```

この README だけで概要と使い方を把握できるよう最小限にまとめています。詳細な実装変更は不要で、すぐに実験に着手できます。
