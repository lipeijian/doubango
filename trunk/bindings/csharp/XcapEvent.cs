/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class XcapEvent : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XcapEvent(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XcapEvent obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XcapEvent() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_XcapEvent(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public thttp_event_type_t getType() {
    thttp_event_type_t ret = (thttp_event_type_t)tinyWRAPPINVOKE.XcapEvent_getType(swigCPtr);
    return ret;
  }

  public XcapMessage getXcapMessage() {
    IntPtr cPtr = tinyWRAPPINVOKE.XcapEvent_getXcapMessage(swigCPtr);
    XcapMessage ret = (cPtr == IntPtr.Zero) ? null : new XcapMessage(cPtr, false);
    return ret;
  }

}

}
