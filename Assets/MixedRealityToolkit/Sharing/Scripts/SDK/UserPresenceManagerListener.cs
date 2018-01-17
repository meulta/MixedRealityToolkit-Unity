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

public class UserPresenceManagerListener : Listener {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UserPresenceManagerListener(global::System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.UserPresenceManagerListener_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UserPresenceManagerListener obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UserPresenceManagerListener() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_UserPresenceManagerListener(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void OnUserPresenceChanged(User user) {
    if (SwigDerivedClassHasMethod("OnUserPresenceChanged", swigMethodTypes0)) SharingClientPINVOKE.UserPresenceManagerListener_OnUserPresenceChangedSwigExplicitUserPresenceManagerListener(swigCPtr, User.getCPtr(user)); else SharingClientPINVOKE.UserPresenceManagerListener_OnUserPresenceChanged(swigCPtr, User.getCPtr(user));
  }

  public UserPresenceManagerListener() : this(SharingClientPINVOKE.new_UserPresenceManagerListener(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnUserPresenceChanged", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateUserPresenceManagerListener_0(SwigDirectorOnUserPresenceChanged);
    SharingClientPINVOKE.UserPresenceManagerListener_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(UserPresenceManagerListener));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnUserPresenceChanged(global::System.IntPtr user) {
    OnUserPresenceChanged((user == global::System.IntPtr.Zero) ? null : new User(user, true));
  }

  public delegate void SwigDelegateUserPresenceManagerListener_0(global::System.IntPtr user);

  private SwigDelegateUserPresenceManagerListener_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(User) };
}

}
