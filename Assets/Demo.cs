using UnityEngine ;

public class Demo : MonoBehaviour {

   void Start () {
      Debug.Log ("message 1") ;
      this.Wait (2f, () => {
         Debug.Log ("message 2") ;
         this.Wait (2f, () => {
            Debug.Log ("message 3") ;
            this.Wait (2f, () => {
               Debug.Log ("The last message") ;
               Camera.main.backgroundColor = Color.magenta ;
            }) ;
         }) ;
      }) ;
   }

}
