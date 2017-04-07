日本語版のREADMEは[こちら](README.ja.md)

# <img src ="./images/AppLogo.png" />FlexibleLogAnalyzingTool (FLAT)

*Convert various log files to unified log format. And it has some useful analyzing functions.*

<p align="center"><img src ="./images/FLAT.png" /></p>

## Features

プロダクトの開発やシステム開発を行っていると、様々な形式のログファイルを解析しなければならない事があります。  
FlexibleLogAnalyzingTool (FLAT)は、それらサーバやアプリケーションが出力する様々な形式のログファイルを解析し、統一のログ形式に変換します。
また、ログの抽出や検索、CSVやExcel形式でのエクスポート機能を有しており、フレキシブルにログを解析することが可能になります。

当ツールの大きな特徴として、ログの抽出結果や検索結果を保存し、次回ツールを開いた際に以前開いた状態から復元することが可能になっています。
これにより、「前にログを解析した時のキーワードが分からない・・・」「他の人が解析した結果と違う・・・」といった事を防ぐ事が可能です。

## Getting Started

This section will guide prerequisites, installing and usage.

### Requirements

This application is developed on Windows environment. And it needs [.NET Framework 4.5](https://www.microsoft.com/download/details.aspx?id=30653) later.

### Installing

Unpack the product zip file to your arbitary directory. And run "FlexibleLogAnalyzingTool.exe" file.

** Note **  
This application creates several setting files and directorys to application running directory.  
If you deploy this application to "Program Files" or "Program Files (x86)" directory then please add "full control" privilege to file system security.

### Usage

Please see [Usage page](../../wiki/usage.ja).

## Built With

* [SQLite](https://www.sqlite.org/) - Internal database
* [NPOI](https://npoi.codeplex.com/) - Export Excel function
* [Application Icon](http://gentleface.com/free_icon_set.html) - Used to Application icons

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Miura Acoustic** - *Initial work* - [S1 Products](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
