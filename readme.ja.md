# FlexibleLogAnalyzingTool (FLAT)
*様々な形式のログファイルを統一したフォーマットに変換し、ログを解析する為の各種機能を提供*

## はじめに
プロダクトの開発やシステム開発を行っていると、様々な形式のログファイルを解析しなければならない事があります。  
FlexibleLogAnalyzingTool (FLAT)は、それらサーバやアプリケーションが出力する様々な形式のログファイルを解析し、統一のログ形式に変換します。
また、ログの抽出や検索、CSVやExcel形式でのエクスポート機能を有しており、フレキシブルにログを解析することが可能になります。

当ツールの大きな特徴として、ログの抽出結果や検索結果を保存し、次回ツールを開いた際に以前開いた状態から復元することが可能になっています。
これにより、「前にログを解析した時のキーワードが分からない・・・」「他の人が解析した結果と違う・・・」といった事を防ぐ事が可能です。

## 主な機能
* ログ形式の変換機能
* 特定ログの抽出機能
* キーワードのハイライト機能
* ログのクリップボードへのコピー機能
* ログ項目の非表示機能
* 複数ログの結合機能
等・・・

### Prerequisites

What things you need to install the software and how to install them

```
Give examples
```

### Installing

A step by step series of examples that tell you have to get a development env running

Say what the step will be

```
Give the example
```

And repeat

```
until finished
```

End with an example of getting some data out of the system or using it for a little demo

## 使用ライブラリ

* [SQLite](https://www.sqlite.org/) - Internal database
* [NPOI](https://npoi.codeplex.com/) - Export Excel function
* [Application Icon](http://gentleface.com/free_icon_set.html) - Used to Application icons

## バージョン管理体系
バージョン管理体系には、[SemVer](http://semver.org/) を用いています。
利用可能なバージョンを確認する場合は、当ページ内の[タグ](https://github.com/S1Products/FlexibleLogAnalyzingTool/tags)を参照してください。

## 著者

* **Miura Acoustic** - *Initial work* - [S1 Products Home page](http://s1products.info)

その他のコントリビュータを参照する場合は、[contributors](https://github.com/S1Products/FlexibleLogAnalyzingTool/contributors)を参照してください。

## ライセンス

当プロジェクトは「Apache v2」ライセンスを適用しています。 ライセンスの詳細は[LICENSE.md](LICENSE.md)を参照してください。
