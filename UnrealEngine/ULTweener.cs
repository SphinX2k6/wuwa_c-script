using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000744 RID: 1860
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LTween.LTweener")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public abstract class ULTweener : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A27A RID: 41594 RVA: 0x000F0026 File Offset: 0x000EE226
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweener._ClassPtr;
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x0600A27B RID: 41595 RVA: 0x000F0034 File Offset: 0x000EE234
		// (set) Token: 0x0600A27C RID: 41596 RVA: 0x000F006D File Offset: 0x000EE26D
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

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x0600A27D RID: 41597 RVA: 0x000F0090 File Offset: 0x000EE290
		// (set) Token: 0x0600A27E RID: 41598 RVA: 0x000F00C9 File Offset: 0x000EE2C9
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

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x0600A27F RID: 41599 RVA: 0x000F00EC File Offset: 0x000EE2EC
		// (set) Token: 0x0600A280 RID: 41600 RVA: 0x000F0125 File Offset: 0x000EE325
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

		// Token: 0x0600A281 RID: 41601 RVA: 0x000F0146 File Offset: 0x000EE346
		public ULTweener SetSpeed(float newSpeed)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetSpeed_Internal(base.NativePtr, newSpeed));
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x000F0159 File Offset: 0x000EE359
		public ULTweener SetEaseCurve(UCurveFloat newCurve)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetEaseCurve_Internal(base.NativePtr, (newCurve != null) ? newCurve.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x000F017B File Offset: 0x000EE37B
		public ULTweener SetEase(LTweenEase easetype)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetEase_Internal(base.NativePtr, easetype));
		}

		// Token: 0x0600A284 RID: 41604 RVA: 0x000F018E File Offset: 0x000EE38E
		public void SetDuration(float newDuration)
		{
			ULTweener.__SetDuration_Internal(base.NativePtr, newDuration);
		}

		// Token: 0x0600A285 RID: 41605 RVA: 0x000F019C File Offset: 0x000EE39C
		public ULTweener SetDelay(float newDelay)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetDelay_Internal(base.NativePtr, newDelay));
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x000F01AF File Offset: 0x000EE3AF
		public ULTweener SetCurveFloat(UCurveFloat newCurveFloat)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__SetCurveFloat_Internal(base.NativePtr, (newCurveFloat != null) ? newCurveFloat.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x000F01D1 File Offset: 0x000EE3D1
		public void Resume()
		{
			ULTweener.__Resume_Internal(base.NativePtr);
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x000F01DE File Offset: 0x000EE3DE
		public void Pause()
		{
			ULTweener.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x000F01EB File Offset: 0x000EE3EB
		public ULTweener OnUpdate(in FTweenerFloatDynamicDelegate newUpdate)
		{
			IntPtr nativePtr = base.NativePtr;
			FTweenerFloatDynamicDelegate ftweenerFloatDynamicDelegate = newUpdate;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__OnUpdate_Internal(nativePtr, (ftweenerFloatDynamicDelegate != null) ? ftweenerFloatDynamicDelegate.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x000F020C File Offset: 0x000EE40C
		public ULTweener OnStart(in FTweenerSimpleDynamicDelegate newStart)
		{
			IntPtr nativePtr = base.NativePtr;
			FTweenerSimpleDynamicDelegate ftweenerSimpleDynamicDelegate = newStart;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__OnStart_Internal(nativePtr, (ftweenerSimpleDynamicDelegate != null) ? ftweenerSimpleDynamicDelegate.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x000F022D File Offset: 0x000EE42D
		public ULTweener OnCycleComplete(in FTweenerSimpleDynamicDelegate newCycleComplete)
		{
			IntPtr nativePtr = base.NativePtr;
			FTweenerSimpleDynamicDelegate ftweenerSimpleDynamicDelegate = newCycleComplete;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__OnCycleComplete_Internal(nativePtr, (ftweenerSimpleDynamicDelegate != null) ? ftweenerSimpleDynamicDelegate.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x000F024E File Offset: 0x000EE44E
		public ULTweener OnComplete(in FTweenerSimpleDynamicDelegate newComplete)
		{
			IntPtr nativePtr = base.NativePtr;
			FTweenerSimpleDynamicDelegate ftweenerSimpleDynamicDelegate = newComplete;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweener.__OnComplete_Internal(nativePtr, (ftweenerSimpleDynamicDelegate != null) ? ftweenerSimpleDynamicDelegate.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x000F026F File Offset: 0x000EE46F
		public void KillWithCompleteCallback()
		{
			ULTweener.__KillWithCompleteCallback_Internal(base.NativePtr);
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x000F027C File Offset: 0x000EE47C
		public void Kill(bool callComplete = false)
		{
			ULTweener.__Kill_Internal(base.NativePtr, callComplete);
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x000F028A File Offset: 0x000EE48A
		public float GetSpeed()
		{
			return ULTweener.__GetSpeed_Internal(base.NativePtr);
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x000F0297 File Offset: 0x000EE497
		public int GetLoopCycleCount()
		{
			return ULTweener.__GetLoopCycleCount_Internal(base.NativePtr);
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x000F02A4 File Offset: 0x000EE4A4
		public int GetLoopCount()
		{
			return ULTweener.__GetLoopCount_Internal(base.NativePtr);
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x000F02B1 File Offset: 0x000EE4B1
		public void ForceComplete()
		{
			ULTweener.__ForceComplete_Internal(base.NativePtr);
		}

		// Token: 0x0600A293 RID: 41619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetSpeed_Internal(IntPtr @this, float newSpeed);

		// Token: 0x0600A294 RID: 41620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetEaseCurve_Internal(IntPtr @this, IntPtr newCurve);

		// Token: 0x0600A295 RID: 41621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetEase_Internal(IntPtr @this, LTweenEase easetype);

		// Token: 0x0600A296 RID: 41622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDuration_Internal(IntPtr @this, float newDuration);

		// Token: 0x0600A297 RID: 41623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetDelay_Internal(IntPtr @this, float newDelay);

		// Token: 0x0600A298 RID: 41624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetCurveFloat_Internal(IntPtr @this, IntPtr newCurveFloat);

		// Token: 0x0600A299 RID: 41625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Resume_Internal(IntPtr @this);

		// Token: 0x0600A29A RID: 41626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x0600A29B RID: 41627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnUpdate_Internal(IntPtr @this, IntPtr newUpdate);

		// Token: 0x0600A29C RID: 41628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnStart_Internal(IntPtr @this, IntPtr newStart);

		// Token: 0x0600A29D RID: 41629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnCycleComplete_Internal(IntPtr @this, IntPtr newCycleComplete);

		// Token: 0x0600A29E RID: 41630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnComplete_Internal(IntPtr @this, IntPtr newComplete);

		// Token: 0x0600A29F RID: 41631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KillWithCompleteCallback_Internal(IntPtr @this);

		// Token: 0x0600A2A0 RID: 41632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kill_Internal(IntPtr @this, bool callComplete);

		// Token: 0x0600A2A1 RID: 41633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSpeed_Internal(IntPtr @this);

		// Token: 0x0600A2A2 RID: 41634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLoopCycleCount_Internal(IntPtr @this);

		// Token: 0x0600A2A3 RID: 41635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLoopCount_Internal(IntPtr @this);

		// Token: 0x0600A2A4 RID: 41636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceComplete_Internal(IntPtr @this);

		// Token: 0x0600A2A5 RID: 41637 RVA: 0x000F02BE File Offset: 0x000EE4BE
		static ULTweener()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweener");
		}

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x000F02CC File Offset: 0x000EE4CC
		protected ULTweener() : this(BuiltinUtils.AllocNativeUObject(ULTweener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x000F02F4 File Offset: 0x000EE4F4
		protected ULTweener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400458B RID: 17803
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweener";

		// Token: 0x0400458C RID: 17804
		private static IntPtr _ClassPtr;

		// Token: 0x0400458D RID: 17805
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400458E RID: 17806
		internal static int __PropertyOffset_OnStartCallBack;

		// Token: 0x0400458F RID: 17807
		private FLTweenerDynamicDelegate _OnStartCallBack;

		// Token: 0x04004590 RID: 17808
		internal static int __PropertyOffset_OnUpdateCallBack;

		// Token: 0x04004591 RID: 17809
		private FLTweenerDynamicDelegate _OnUpdateCallBack;

		// Token: 0x04004592 RID: 17810
		internal static int __PropertyOffset_OnCompleteCallBack;

		// Token: 0x04004593 RID: 17811
		private FLTweenerDynamicDelegate _OnCompleteCallBack;
	}
}
