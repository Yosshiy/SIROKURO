using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public interface IGimmick 
{
   public void Action()
   {

   }
   IReactiveProperty <bool> PlayerInfluence { get; }


}
