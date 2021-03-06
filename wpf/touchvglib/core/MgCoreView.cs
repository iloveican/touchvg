/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class MgCoreView : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgCoreView(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgCoreView obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCoreView() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCoreView(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static MgCoreView fromHandle(int h) {
    IntPtr cPtr = touchvgPINVOKE.MgCoreView_fromHandle(h);
    MgCoreView ret = (cPtr == IntPtr.Zero) ? null : new MgCoreView(cPtr, false);
    return ret;
  }

  public int toHandle() {
    int ret = touchvgPINVOKE.MgCoreView_toHandle(swigCPtr);
    return ret;
  }

  public virtual MgView viewAdapter() {
    IntPtr cPtr = touchvgPINVOKE.MgCoreView_viewAdapter(swigCPtr);
    MgView ret = (cPtr == IntPtr.Zero) ? null : new MgView(cPtr, false);
    return ret;
  }

  public virtual int viewAdapterHandle() {
    int ret = touchvgPINVOKE.MgCoreView_viewAdapterHandle(swigCPtr);
    return ret;
  }

  public virtual int docHandle() {
    int ret = touchvgPINVOKE.MgCoreView_docHandle(swigCPtr);
    return ret;
  }

  public virtual int shapesHandle() {
    int ret = touchvgPINVOKE.MgCoreView_shapesHandle(swigCPtr);
    return ret;
  }

  public virtual bool isPressDragging() {
    bool ret = touchvgPINVOKE.MgCoreView_isPressDragging(swigCPtr);
    return ret;
  }

  public virtual string getCommand() {
    string ret = touchvgPINVOKE.MgCoreView_getCommand(swigCPtr);
    return ret;
  }

  public virtual bool setCommand(string name, string arg1) {
    bool ret = touchvgPINVOKE.MgCoreView_setCommand__SWIG_0(swigCPtr, name, arg1);
    return ret;
  }

  public virtual bool setCommand(string name) {
    bool ret = touchvgPINVOKE.MgCoreView_setCommand__SWIG_1(swigCPtr, name);
    return ret;
  }

  public virtual bool doContextAction(int action) {
    bool ret = touchvgPINVOKE.MgCoreView_doContextAction(swigCPtr, action);
    return ret;
  }

  public virtual void clearCachedData() {
    touchvgPINVOKE.MgCoreView_clearCachedData(swigCPtr);
  }

  public virtual int addShapesForTest() {
    int ret = touchvgPINVOKE.MgCoreView_addShapesForTest(swigCPtr);
    return ret;
  }

  public virtual int getShapeCount() {
    int ret = touchvgPINVOKE.MgCoreView_getShapeCount(swigCPtr);
    return ret;
  }

  public virtual int getChangeCount() {
    int ret = touchvgPINVOKE.MgCoreView_getChangeCount(swigCPtr);
    return ret;
  }

  public virtual int getDrawCount() {
    int ret = touchvgPINVOKE.MgCoreView_getDrawCount(swigCPtr);
    return ret;
  }

  public virtual int getSelectedShapeCount() {
    int ret = touchvgPINVOKE.MgCoreView_getSelectedShapeCount(swigCPtr);
    return ret;
  }

  public virtual int getSelectedShapeType() {
    int ret = touchvgPINVOKE.MgCoreView_getSelectedShapeType(swigCPtr);
    return ret;
  }

  public virtual int getSelectedShapeID() {
    int ret = touchvgPINVOKE.MgCoreView_getSelectedShapeID(swigCPtr);
    return ret;
  }

  public virtual void clear() {
    touchvgPINVOKE.MgCoreView_clear(swigCPtr);
  }

  public virtual bool loadFromFile(string vgfile, bool readOnly, bool needLock) {
    bool ret = touchvgPINVOKE.MgCoreView_loadFromFile__SWIG_0(swigCPtr, vgfile, readOnly, needLock);
    return ret;
  }

  public virtual bool loadFromFile(string vgfile, bool readOnly) {
    bool ret = touchvgPINVOKE.MgCoreView_loadFromFile__SWIG_1(swigCPtr, vgfile, readOnly);
    return ret;
  }

  public virtual bool loadFromFile(string vgfile) {
    bool ret = touchvgPINVOKE.MgCoreView_loadFromFile__SWIG_2(swigCPtr, vgfile);
    return ret;
  }

  public virtual bool saveToFile(string vgfile, bool pretty) {
    bool ret = touchvgPINVOKE.MgCoreView_saveToFile__SWIG_0(swigCPtr, vgfile, pretty);
    return ret;
  }

  public virtual bool saveToFile(string vgfile) {
    bool ret = touchvgPINVOKE.MgCoreView_saveToFile__SWIG_1(swigCPtr, vgfile);
    return ret;
  }

  public virtual bool loadShapes(MgStorage s, bool readOnly, bool needLock) {
    bool ret = touchvgPINVOKE.MgCoreView_loadShapes__SWIG_0(swigCPtr, MgStorage.getCPtr(s), readOnly, needLock);
    return ret;
  }

  public virtual bool loadShapes(MgStorage s, bool readOnly) {
    bool ret = touchvgPINVOKE.MgCoreView_loadShapes__SWIG_1(swigCPtr, MgStorage.getCPtr(s), readOnly);
    return ret;
  }

  public virtual bool loadShapes(MgStorage s) {
    bool ret = touchvgPINVOKE.MgCoreView_loadShapes__SWIG_2(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public virtual bool saveShapes(MgStorage s) {
    bool ret = touchvgPINVOKE.MgCoreView_saveShapes(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public virtual bool loadDynamicShapes(MgStorage s) {
    bool ret = touchvgPINVOKE.MgCoreView_loadDynamicShapes(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public virtual string getContent() {
    string ret = touchvgPINVOKE.MgCoreView_getContent(swigCPtr);
    return ret;
  }

  public virtual void freeContent() {
    touchvgPINVOKE.MgCoreView_freeContent(swigCPtr);
  }

  public virtual bool setContent(string content) {
    bool ret = touchvgPINVOKE.MgCoreView_setContent(swigCPtr, content);
    return ret;
  }

  public virtual bool exportSVG(string filename) {
    bool ret = touchvgPINVOKE.MgCoreView_exportSVG(swigCPtr, filename);
    return ret;
  }

  public virtual bool zoomToExtent() {
    bool ret = touchvgPINVOKE.MgCoreView_zoomToExtent(swigCPtr);
    return ret;
  }

  public virtual bool zoomToModel(float x, float y, float w, float h) {
    bool ret = touchvgPINVOKE.MgCoreView_zoomToModel(swigCPtr, x, y, w, h);
    return ret;
  }

  public virtual float calcPenWidth(float lineWidth) {
    float ret = touchvgPINVOKE.MgCoreView_calcPenWidth(swigCPtr, lineWidth);
    return ret;
  }

  public virtual GiContext getContext(bool forChange) {
    GiContext ret = new GiContext(touchvgPINVOKE.MgCoreView_getContext(swigCPtr, forChange), false);
    return ret;
  }

  public virtual void setContext(GiContext ctx, int mask, int apply) {
    touchvgPINVOKE.MgCoreView_setContext__SWIG_0(swigCPtr, GiContext.getCPtr(ctx), mask, apply);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setContext(int mask) {
    touchvgPINVOKE.MgCoreView_setContext__SWIG_1(swigCPtr, mask);
  }

  public virtual void setContextEditing(bool editing) {
    touchvgPINVOKE.MgCoreView_setContextEditing(swigCPtr, editing);
  }

  public virtual int addImageShape(string name, float width, float height) {
    int ret = touchvgPINVOKE.MgCoreView_addImageShape__SWIG_0(swigCPtr, name, width, height);
    return ret;
  }

  public virtual int addImageShape(string name, float xc, float yc, float w, float h) {
    int ret = touchvgPINVOKE.MgCoreView_addImageShape__SWIG_1(swigCPtr, name, xc, yc, w, h);
    return ret;
  }

  public virtual bool getBoundingBox(Floats box) {
    bool ret = touchvgPINVOKE.MgCoreView_getBoundingBox__SWIG_0(swigCPtr, Floats.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getBoundingBox(Floats box, int shapeId) {
    bool ret = touchvgPINVOKE.MgCoreView_getBoundingBox__SWIG_1(swigCPtr, Floats.getCPtr(box), shapeId);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
