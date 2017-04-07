# FlexibleLogAnalyzingTool (FLAT)
*様々な形式のログファイルを統一フォーマットに変換し、ログを解析する為の各種機能を提供*

## はじめに
プロダクトの開発やシステム開発を行っていると、様々な形式のログファイルを解析しなければならない事があります。  
FlexibleLogAnalyzingTool (FLAT)は、それらサーバやアプリケーションが出力する様々な形式のログファイルを解析し、統一のログ形式に変換します。
また、ログの抽出や検索、CSVやExcel形式でのエクスポート機能を有しており、フレキシブルにログを解析することが可能になります。

当ツールの大きな特徴として、ログの抽出結果や検索結果を保存し、次回ツールを開いた際に以前開いた状態から復元することが可能になっています。
これにより、「前にログを解析した時のキーワードが分からない・・・」「他の人が解析した結果と違う・・・」といった事を防ぐ事が可能です。

### 必須条件

当アプリケーションはWindows上で動作することを前提に作成されています。  
また、アプリケーションの実行には[.NET Framework 4.5](https://www.microsoft.com/download/details.aspx?id=30653)以上が必須です。

### インストール方法

Zipファイルを任意のフォルダへ解凍し、「FlexibleLogAnalyzingTool.exe」を実行してください。

※注：当アプリケーションは、アプリケーションの配置フォルダ内に各種設定ファイルを生成します。
Program Filesフォルダに配置する場合、配置先のフォルダへWindowsのUsersグループの「フル コントロール」権限を設定してください。

## 使用方法

アプリケーションの使用方法については、[Wiki 使用方法](wiki/usage.ja)を参照してください。

## 使用ライブラリ

* [SQLite](https://www.sqlite.org/) - Internal database
* [NPOI](https://npoi.codeplex.com/) - Export Excel function
* [Application Icon](http://gentleface.com/free_icon_set.html) - Used to Application icons

## バージョン管理体系
バージョン管理体系には、[SemVer](http://semver.org/) を用いています。
利用可能なバージョンを確認する場合は、当ページ内の[タグ](https://github.com/S1Products/FlexibleLogAnalyzingTool/tags)を参照してください。

## 著者

* **Miura Acoustic** - *初期バージョンの開発者* - [S1 Products Home page](http://s1products.info)

その他のコントリビュータを参照する場合は、[コントリビュータ](https://github.com/S1Products/FlexibleLogAnalyzingTool/contributors)を参照してください。

## ライセンス

当プロジェクトは「Apache v2」ライセンスを適用しています。 ライセンスの詳細は[LICENSE.md](LICENSE.md)を参照してください。
