using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    
    public float rotationPeriod = 0.3f;     // 隣に移動するのにかかる時間
    public float sideLength = 1f;           // Cubeの辺の長さ

    bool isRotate = false;                  // Cubeが回転中かどうかを検出するフラグ
    float directionX = 0;                   // 回転方向フラグ
    float directionZ = 0;                   // 回転方向フラグ

    Vector3 startPos;                       // 回転前のCubeの位置
    float rotationTime = 0;                 // 回転中の時間経過
    float radius;                           // 重心の軌道半径
    Quaternion fromRotation;                // 回転前のCubeのクォータニオン
    Quaternion toRotation;                  // 回転後のCubeのクォータニオン

    public bool left = true;
    public bool right = true;
    public bool up = true;
    public bool down = true;

    public int maxMov;
    public int moves = 0;
    Vector3 inicio;
    Quaternion inicioRot;

    public AudioSource giro;

    // Use this for initialization
    void Start()
    {
        inicio = this.transform.position;
        inicioRot = transform.rotation ;
        // 重心の回転軌道半径を計算
        radius = sideLength * Mathf.Sqrt(2f) / 2f;
        giro = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        float x = 0;
        float y = 0;



        // キー入力を拾う。
        if (Input.GetKey(KeyCode.A) && left == true) x = -1; 
        if (Input.GetKey(KeyCode.D) && right == true) x = +1; 
        if (Input.GetKey(KeyCode.W) && up == true) y = 1; 
        if (Input.GetKey(KeyCode.S) && down == true) y = -1;

        //  x = Input.GetAxisRaw("Horizontal");

        //if (x == 0)
        //{
        //  y = Input.GetAxisRaw("Vertical");
        //}


        // キー入力がある　かつ　Cubeが回転中でない場合、Cubeを回転する。
        if ((x != 0 || y != 0) && !isRotate)
        {
            giro.volume = Random.Range(0.1f, 0.2f);
            giro.Play();
            directionX = y;                                                             // 回転方向セット (x,yどちらかは必ず0)
            directionZ = x;                                                             // 回転方向セット (x,yどちらかは必ず0)
            startPos = transform.position;                                              // 回転前の座標を保持
            fromRotation = transform.rotation;                                          // 回転前のクォータニオンを保持
            transform.Rotate(directionZ * 90, 0, directionX * 90, Space.World);     // 回転方向に90度回転させる
            toRotation = transform.rotation;                                            // 回転後のクォータニオンを保持
            transform.rotation = fromRotation;                                          // CubeのRotationを回転前に戻す。（transformのシャローコピーとかできないんだろうか…。）
            rotationTime = 0;                                                           // 回転中の経過時間を0に。
            isRotate = true;
            moves += 1;
            // 回転中フラグをたてる。
        }

        if(moves >= maxMov)
        {
            StartCoroutine("ParaMoves", 1.0f);

        }

    }

    void FixedUpdate()
    {

        if (isRotate)
        {

            rotationTime += Time.fixedDeltaTime;                                    // 経過時間を増やす
            float ratio = Mathf.Lerp(0, 1, rotationTime / rotationPeriod);          // 回転の時間に対する今の経過時間の割合

            // 移動
            float thetaRad = Mathf.Lerp(0, Mathf.PI / 2f, ratio);                   // 回転角をラジアンで。
            float distanceX = -directionX * radius * (Mathf.Cos(45f * Mathf.Deg2Rad) - Mathf.Cos(45f * Mathf.Deg2Rad + thetaRad));      // X軸の移動距離。 -の符号はキーと移動の向きを合わせるため。
            float distanceY = radius * (Mathf.Sin(45f * Mathf.Deg2Rad + thetaRad) - Mathf.Sin(45f * Mathf.Deg2Rad));                        // Y軸の移動距離
            float distanceZ = directionZ * radius * (Mathf.Cos(45f * Mathf.Deg2Rad) - Mathf.Cos(45f * Mathf.Deg2Rad + thetaRad));           // Z軸の移動距離
            transform.position = new Vector3(startPos.x + distanceX, startPos.y + distanceY, startPos.z + distanceZ);                       // 現在の位置をセット

            // 回転
            transform.rotation = Quaternion.Lerp(fromRotation, toRotation, ratio);      // Quaternion.Lerpで現在の回転角をセット（なんて便利な関数）

            // 移動・回転終了時に各パラメータを初期化。isRotateフラグを下ろす。
            if (ratio == 1)
            {
                isRotate = false;
                directionX = 0;
                directionZ = 0;
                rotationTime = 0;
                
            }
        }
    }


     void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Left"))
        {
            left = false;
        }

        if (other.gameObject.CompareTag("Right"))
        {
            right = false;
        }

        if (other.gameObject.CompareTag("Up"))
        {
            up = false;
        }

        if (other.gameObject.CompareTag("Down"))
        {
            down = false;
        }

        if (other.gameObject.CompareTag("Inicio") && moves == maxMov)
        {
            moves = 0;
            
        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Left"))
        {
            left = true;
        }

        if (other.gameObject.CompareTag("Right"))
        {
            right = true;
        }

        if (other.gameObject.CompareTag("Up"))
        {
            up = true;
        }

        if (other.gameObject.CompareTag("Down"))
        {
            down = true;
        }

    }



    IEnumerator ParaMoves()
    {
        if (moves >= maxMov)
        {
            left = false;
            right = false;
            up = false;
            down = false;
            this.transform.rotation = inicioRot;
            this.transform.position = inicio;
            yield return new WaitForSeconds(3);
        }


        left = true;
        right = true;
        up = true;
        down = true;

        StopAllCoroutines();

    }


}