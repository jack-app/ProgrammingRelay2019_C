using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using VRM;
using UnityChan;

public class InportModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //VRMファイルのパスを指定します
        var path = "D:/program関係/ユニティちゃん関連/3D_avater/kuma_chan_v0.3.1.2.vrm";

        //ファイルをByte配列に読み込みます
        var bytes = File.ReadAllBytes(path);

        //VRMImporterContextがVRMを読み込む機能を提供します
        var context = new VRMImporterContext();

        // GLB形式でJSONを取得しParseします
        context.ParseGlb(bytes);

        // VRMのメタデータを取得
        var meta = context.ReadMeta(false); //引数をTrueに変えるとサムネイルも読み込みます

        //読み込めたかどうかログにモデル名を出力してみる
        Debug.LogFormat("meta: title:{0}", meta.Title);

        //同期処理で読み込みます
        context.Load();
        
        //読込が完了するとcontext.RootにモデルのGameObjectが入っています
        var root = context.Root ;
        transform.position += new Vector3(0, 0.5f, 0);
        //モデルをワールド上に配置します
        root.transform.SetParent(transform,false);

        root.AddComponent<UnityChanControlScriptWithRgidBody>();


        //メッシュを表示します
        context.ShowMeshes();
    }

    
}
