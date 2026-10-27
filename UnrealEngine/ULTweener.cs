using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200223F RID: 8767
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LTween.LTweener")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public abstract class ULTweener : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060215EA RID: 136682 RVA: 0x00312D12 File Offset: 0x00310F12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweener._ClassPtr;
		}

		// Token: 0x17008213 RID: 33299
		// (get) Token: 0x060215EB RID: 136683 RVA: 0x00312D20 File Offset: 0x00310F20
		// (set) Token: 0x060215EC RID: 136684 RVA: 0x00312D59 File Offset: 0x00310F59
		[Nullable(1)]
		public FLTweenerDynamicDelegate OnStartCallBack
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLTweenerDynamicDelegate result;
				if ((result = this._OnStartCallBack) == null)
				{
					result = (this._OnStartCallBack = new FLTweenerDynamicDelegate(base.NativePtr + (IntPtr)ULTweener.__PropertyOffset_OnStartCallBack, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULTweener.__PropertyOffset_OnStartCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008214 RID: 33300
		// (get) Token: 0x060215ED RID: 136685 RVA: 0x00312D7C File Offset: 0x00310F7C
		// (set) Token: 0x060215EE RID: 136686 RVA: 0x00312DB5 File Offset: 0x00310FB5
		[Nullable(1)]
		public FLTweenerDynamicDelegate OnUpdateCallBack
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLTweenerDynamicDelegate result;
				if ((result = this._OnUpdateCallBack) == null)
				{
					result = (this._OnUpdateCallBack = new FLTweenerDynamicDelegate(base.NativePtr + (IntPtr)ULTweener.__PropertyOffset_OnUpdateCallBack, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULTweener.__PropertyOffset_OnUpdateCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008215 RID: 33301
		// (get) Token: 0x060215EF RID: 136687 RVA: 0x00312DD8 File Offset: 0x00310FD8
		// (set) Token: 0x060215F0 RID: 136688 RVA: 0x00312E11 File Offset: 0x00311011
		[Nullable(1)]
		public FLTweenerDynamicDelegate OnCompleteCallBack
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLTweenerDynamicDelegate result;
				if ((result = this._OnCompleteCallBack) == null)
				{
					result = (this._OnCompleteCallBack = new FLTweenerDynamicDelegate(base.NativePtr + (IntPtr)ULTweener.__PropertyOffset_OnCompleteCallBack, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULTweener.__PropertyOffset_OnCompleteCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060215F1 RID: 136689 RVA: 0x00312E32 File Offset: 0x00311032
		public ULTweener SetSpeed(float newSpeed)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetSpeed_Internal(base.NativePtr, newSpeed));
		}

		// Token: 0x060215F2 RID: 136690 RVA: 0x00312E45 File Offset: 0x00311045
		public ULTweener SetLoopType(LTweenLoop newLoopType)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetLoopType_Internal(base.NativePtr, newLoopType));
		}

		// Token: 0x060215F3 RID: 136691 RVA: 0x00312E58 File Offset: 0x00311058
		public ULTweener SetLoop(LTweenLoop newLoopType, int newLoopCount)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetLoop_Internal(base.NativePtr, newLoopType, newLoopCount));
		}

		// Token: 0x060215F4 RID: 136692 RVA: 0x00312E6C File Offset: 0x0031106C
		public ULTweener SetEaseCurve(UCurveFloat newCurve)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetEaseCurve_Internal(base.NativePtr, (newCurve != null) ? newCurve.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060215F5 RID: 136693 RVA: 0x00312E8E File Offset: 0x0031108E
		public ULTweener SetEase(LTweenEase easetype)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetEase_Internal(base.NativePtr, easetype));
		}

		// Token: 0x060215F6 RID: 136694 RVA: 0x00312EA1 File Offset: 0x003110A1
		public void SetDuration(float newDuration)
		{
			ULTweener.__SetDuration_Internal(base.NativePtr, newDuration);
		}

		// Token: 0x060215F7 RID: 136695 RVA: 0x00312EAF File Offset: 0x003110AF
		public ULTweener SetDelay(float newDelay)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetDelay_Internal(base.NativePtr, newDelay));
		}

		// Token: 0x060215F8 RID: 136696 RVA: 0x00312EC2 File Offset: 0x003110C2
		public ULTweener SetCurveFloat(UCurveFloat newCurveFloat)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetCurveFloat_Internal(base.NativePtr, (newCurveFloat != null) ? newCurveFloat.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060215F9 RID: 136697 RVA: 0x00312EE4 File Offset: 0x003110E4
		public void Resume()
		{
			ULTweener.__Resume_Internal(base.NativePtr);
		}

		// Token: 0x060215FA RID: 136698 RVA: 0x00312EF1 File Offset: 0x003110F1
		public void Pause()
		{
			ULTweener.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x060215FB RID: 136699 RVA: 0x00312EFE File Offset: 0x003110FE
		public ULTweener OnUpdate(in FTweenerFloatDynamicDelegate newUpdate)
		{
			IntPtr nativePtr = base.NativePtr;
			FTweenerFloatDynamicDelegate ftweenerFloatDynamicDelegate = newUpdate;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__OnUpdate_Internal(nativePtr, (ftweenerFloatDynamicDelegate != null) ? ftweenerFloatDynamicDelegate.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x060215FC RID: 136700 RVA: 0x00312F1F File Offset: 0x0031111F
		public ULTweener OnStart(in FTweenerSimpleDynamicDelegate newStart)
		{
			IntPtr nativePtr = base.NativePtr;
			FTweenerSimpleDynamicDelegate ftweenerSimpleDynamicDelegate = newStart;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__OnStart_Internal(nativePtr, (ftweenerSimpleDynamicDelegate != null) ? ftweenerSimpleDynamicDelegate.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x060215FD RID: 136701 RVA: 0x00312F40 File Offset: 0x00311140
		public ULTweener OnCycleComplete(in FTweenerSimpleDynamicDelegate newCycleComplete)
		{
			IntPtr nativePtr = base.NativePtr;
			FTweenerSimpleDynamicDelegate ftweenerSimpleDynamicDelegate = newCycleComplete;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__OnCycleComplete_Internal(nativePtr, (ftweenerSimpleDynamicDelegate != null) ? ftweenerSimpleDynamicDelegate.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x060215FE RID: 136702 RVA: 0x00312F61 File Offset: 0x00311161
		public ULTweener OnComplete(in FTweenerSimpleDynamicDelegate newComplete)
		{
			IntPtr nativePtr = base.NativePtr;
			FTweenerSimpleDynamicDelegate ftweenerSimpleDynamicDelegate = newComplete;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__OnComplete_Internal(nativePtr, (ftweenerSimpleDynamicDelegate != null) ? ftweenerSimpleDynamicDelegate.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x060215FF RID: 136703 RVA: 0x00312F82 File Offset: 0x00311182
		public void KillWithCompleteCallback()
		{
			ULTweener.__KillWithCompleteCallback_Internal(base.NativePtr);
		}

		// Token: 0x06021600 RID: 136704 RVA: 0x00312F8F File Offset: 0x0031118F
		public void Kill(bool callComplete = false)
		{
			ULTweener.__Kill_Internal(base.NativePtr, callComplete);
		}

		// Token: 0x06021601 RID: 136705 RVA: 0x00312F9D File Offset: 0x0031119D
		public float GetSpeed()
		{
			return ULTweener.__GetSpeed_Internal(base.NativePtr);
		}

		// Token: 0x06021602 RID: 136706 RVA: 0x00312FAA File Offset: 0x003111AA
		public int GetLoopCycleCount()
		{
			return ULTweener.__GetLoopCycleCount_Internal(base.NativePtr);
		}

		// Token: 0x06021603 RID: 136707 RVA: 0x00312FB7 File Offset: 0x003111B7
		public int GetLoopCount()
		{
			return ULTweener.__GetLoopCount_Internal(base.NativePtr);
		}

		// Token: 0x06021604 RID: 136708 RVA: 0x00312FC4 File Offset: 0x003111C4
		public void ForceComplete()
		{
			ULTweener.__ForceComplete_Internal(base.NativePtr);
		}

		// Token: 0x06021605 RID: 136709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetSpeed_Internal(IntPtr @this, float newSpeed);

		// Token: 0x06021606 RID: 136710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetLoopType_Internal(IntPtr @this, LTweenLoop newLoopType);

		// Token: 0x06021607 RID: 136711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetLoop_Internal(IntPtr @this, LTweenLoop newLoopType, int newLoopCount);

		// Token: 0x06021608 RID: 136712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetEaseCurve_Internal(IntPtr @this, IntPtr newCurve);

		// Token: 0x06021609 RID: 136713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetEase_Internal(IntPtr @this, LTweenEase easetype);

		// Token: 0x0602160A RID: 136714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDuration_Internal(IntPtr @this, float newDuration);

		// Token: 0x0602160B RID: 136715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetDelay_Internal(IntPtr @this, float newDelay);

		// Token: 0x0602160C RID: 136716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetCurveFloat_Internal(IntPtr @this, IntPtr newCurveFloat);

		// Token: 0x0602160D RID: 136717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Resume_Internal(IntPtr @this);

		// Token: 0x0602160E RID: 136718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x0602160F RID: 136719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnUpdate_Internal(IntPtr @this, IntPtr newUpdate);

		// Token: 0x06021610 RID: 136720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnStart_Internal(IntPtr @this, IntPtr newStart);

		// Token: 0x06021611 RID: 136721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnCycleComplete_Internal(IntPtr @this, IntPtr newCycleComplete);

		// Token: 0x06021612 RID: 136722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnComplete_Internal(IntPtr @this, IntPtr newComplete);

		// Token: 0x06021613 RID: 136723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KillWithCompleteCallback_Internal(IntPtr @this);

		// Token: 0x06021614 RID: 136724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kill_Internal(IntPtr @this, bool callComplete);

		// Token: 0x06021615 RID: 136725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSpeed_Internal(IntPtr @this);

		// Token: 0x06021616 RID: 136726
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLoopCycleCount_Internal(IntPtr @this);

		// Token: 0x06021617 RID: 136727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLoopCount_Internal(IntPtr @this);

		// Token: 0x06021618 RID: 136728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceComplete_Internal(IntPtr @this);

		// Token: 0x06021619 RID: 136729 RVA: 0x00312FD1 File Offset: 0x003111D1
		static ULTweener()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweener");
		}

		// Token: 0x0602161A RID: 136730 RVA: 0x00312FE0 File Offset: 0x003111E0
		protected ULTweener() : this(BuiltinUtils.AllocNativeUObject(ULTweener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602161B RID: 136731 RVA: 0x00313008 File Offset: 0x00311208
		protected ULTweener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C9C RID: 72860
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweener";

		// Token: 0x04011C9D RID: 72861
		private static IntPtr _ClassPtr;

		// Token: 0x04011C9E RID: 72862
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C9F RID: 72863
		internal static int __PropertyOffset_OnStartCallBack;

		// Token: 0x04011CA0 RID: 72864
		private FLTweenerDynamicDelegate _OnStartCallBack;

		// Token: 0x04011CA1 RID: 72865
		internal static int __PropertyOffset_OnUpdateCallBack;

		// Token: 0x04011CA2 RID: 72866
		private FLTweenerDynamicDelegate _OnUpdateCallBack;

		// Token: 0x04011CA3 RID: 72867
		internal static int __PropertyOffset_OnCompleteCallBack;

		// Token: 0x04011CA4 RID: 72868
		private FLTweenerDynamicDelegate _OnCompleteCallBack;
	}
}
