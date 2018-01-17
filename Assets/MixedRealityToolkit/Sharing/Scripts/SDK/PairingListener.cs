//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using MixedRealityToolkit.Common.Extensions;

namespace HoloToolkit.Sharing {

public class PairingListener : Listener {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PairingListener(global::System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.PairingListener_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PairingListener obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PairingListener() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_PairingListener(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void PairingConnectionSucceeded() {
    if (SwigDerivedClassHasMethod("PairingConnectionSucceeded", swigMethodTypes0)) SharingClientPINVOKE.PairingListener_PairingConnectionSucceededSwigExplicitPairingListener(swigCPtr); else SharingClientPINVOKE.PairingListener_PairingConnectionSucceeded(swigCPtr);
  }

  public virtual void PairingConnectionFailed(PairingResult reason) {
    if (SwigDerivedClassHasMethod("PairingConnectionFailed", swigMethodTypes1)) SharingClientPINVOKE.PairingListener_PairingConnectionFailedSwigExplicitPairingListener(swigCPtr, (int)reason); else SharingClientPINVOKE.PairingListener_PairingConnectionFailed(swigCPtr, (int)reason);
  }

  public PairingListener() : this(SharingClientPINVOKE.new_PairingListener(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("PairingConnectionSucceeded", swigMethodTypes0))
      swigDelegate0 = new SwigDelegatePairingListener_0(SwigDirectorPairingConnectionSucceeded);
    if (SwigDerivedClassHasMethod("PairingConnectionFailed", swigMethodTypes1))
      swigDelegate1 = new SwigDelegatePairingListener_1(SwigDirectorPairingConnectionFailed);
    SharingClientPINVOKE.PairingListener_director_connect(swigCPtr, swigDelegate0, swigDelegate1);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(PairingListener));
    return hasDerivedMethod;
  }

  private void SwigDirectorPairingConnectionSucceeded() {
    PairingConnectionSucceeded();
  }

  private void SwigDirectorPairingConnectionFailed(int reason) {
    PairingConnectionFailed((PairingResult)reason);
  }

  public delegate void SwigDelegatePairingListener_0();
  public delegate void SwigDelegatePairingListener_1(int reason);

  private SwigDelegatePairingListener_0 swigDelegate0;
  private SwigDelegatePairingListener_1 swigDelegate1;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(PairingResult) };
}

}
