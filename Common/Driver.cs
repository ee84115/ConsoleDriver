using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Common
{
    class Driver
    {
        public string Start(string command)
        {
            //System.Diagnostics.Processクラスオブジェクトを作って実行するコマンドをセットします。
            using (Process p = new Process())
            {
                // コマンドプロンプトと同じように実行します
                p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
                p.StartInfo.Arguments = "/c " + command; // 実行するファイル名（コマンド）

                // コマンドプロンプト（コンソール・ウィンドウ）が表示されないようにします。
                //次行にある”UseShellExecute = false;”ですが、これも実行しないと、標準出力のリダイレクト時にInvalidOperationException例外が発生してしまいます。
                p.StartInfo.CreateNoWindow = true; // コンソール・ウィンドウは開かない
                p.StartInfo.UseShellExecute = false; // シェル機能を使用しない

                //「標準入力」と「標準出力」をリダイレクトする
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                
                // コマンドを実行する
                p.Start();
                p.StandardInput.WriteLine("1 16");
                p.StandardInput.WriteLine("1");
                string output = p.StandardOutput.ReadToEnd();
                return output;
            }
        }
    }
}
