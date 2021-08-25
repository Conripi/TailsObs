# TailsOBSとは
OBSを指定周期で録画するソフトです。また、緊急地震速報(以下EEW)が発令されたときに録画を延長する機能が備わっています。
手動で録画を開始停止する手間を減らし、編集する時間を短縮するのが目的です。

## 導入
このソフトは[obs-websocket](https://github.com/Palakis/obs-websocket/releases)を使用しているため、OBSにそれを導入する必要があります。
現在(2020/08/17)最新バージョンはobs-websocket 4.8です。<br>
Install instructionsから使用してるOSに対応したものをダウンロードしてください。

インストールが完了したらOBSのツール > Websockets server settingsを選択してください。
"WebSocketsサーバーを有効にする"にチェックをつけて、"認証を有効にする"にもチェックをつけます。
そして、パスワードを設定してください。このパスワードは後で使います。

TailsOBSを起動します。左上側の欄は無視で構いません。その右側に先程設定したパスワードを入力してください。
OBSが起動している状態で接続が成功すると通知がでます。(WebSockets設定のシステムトレイ通知を有効にするにチェックを付けている場合)
録画周期には、再生停止させたい時間(分単位)を入力してください。
延長時間には、停止時にEEWが発令されていたときに延長する時間(分単位)を入力してください。

あとは、録画開始ボタンを押すと周期録画が開始します。
