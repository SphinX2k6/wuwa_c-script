using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000181 RID: 385
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSingleNodeInstance")]
	[UnrealStructLayout(2224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2224)]
	public class UAnimSingleNodeInstance : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060018A9 RID: 6313 RVA: 0x00025799 File Offset: 0x00023999
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimSingleNodeInstance._ClassPtr;
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x000257A8 File Offset: 0x000239A8
		public UAnimSingleNodeInstance() : this(BuiltinUtils.AllocNativeUObject(UAnimSingleNodeInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x000257D0 File Offset: 0x000239D0
		[NullableContext(1)]
		public UAnimSingleNodeInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimSingleNodeInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x00025803 File Offset: 0x00023A03
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x00025817 File Offset: 0x00023A17
		public unsafe UAnimationAsset CurrentAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSingleNodeInstance.__PropertyOffset_CurrentAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSingleNodeInstance.__PropertyOffset_CurrentAsset, value);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x0002582C File Offset: 0x00023A2C
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x00025840 File Offset: 0x00023A40
		public unsafe UAnimationAsset CurrentRibbonAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSingleNodeInstance.__PropertyOffset_CurrentRibbonAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSingleNodeInstance.__PropertyOffset_CurrentRibbonAsset, value);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00025858 File Offset: 0x00023A58
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x00025891 File Offset: 0x00023A91
		[Nullable(1)]
		public FPostEvaluateAnimEvent PostEvaluateAnimEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPostEvaluateAnimEvent result;
				if ((result = this._PostEvaluateAnimEvent) == null)
				{
					result = (this._PostEvaluateAnimEvent = new FPostEvaluateAnimEvent(base.NativePtr + (IntPtr)UAnimSingleNodeInstance.__PropertyOffset_PostEvaluateAnimEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAnimSingleNodeInstance.__PropertyOffset_PostEvaluateAnimEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000258B2 File Offset: 0x00023AB2
		public void StopAnim()
		{
			UAnimSingleNodeInstance.__StopAnim_Internal(base.NativePtr);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000258BF File Offset: 0x00023ABF
		public void SetReverse(bool bInReverse)
		{
			UAnimSingleNodeInstance.__SetReverse_Internal(base.NativePtr, bInReverse);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000258D0 File Offset: 0x00023AD0
		public unsafe void SetPreviewCurveOverride(in FName PoseName, float Value, bool bRemoveIfZero)
		{
			fixed (FName* ptr = &PoseName)
			{
				void* ptr2 = (void*)ptr;
				UAnimSingleNodeInstance.__SetPreviewCurveOverride_Internal(base.NativePtr, PoseName, Value, bRemoveIfZero);
			}
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000258F3 File Offset: 0x00023AF3
		public void SetPositionWithPreviousTime(float InPosition, float InPreviousTime, bool bFireNotifies = true)
		{
			UAnimSingleNodeInstance.__SetPositionWithPreviousTime_Internal(base.NativePtr, InPosition, InPreviousTime, bFireNotifies);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00025903 File Offset: 0x00023B03
		public void SetPosition(float InPosition, bool bFireNotifies = true)
		{
			UAnimSingleNodeInstance.__SetPosition_Internal(base.NativePtr, InPosition, bFireNotifies);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00025912 File Offset: 0x00023B12
		public void SetPlayRate(float InPlayRate)
		{
			UAnimSingleNodeInstance.__SetPlayRate_Internal(base.NativePtr, InPlayRate);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00025920 File Offset: 0x00023B20
		public void SetPlaying(bool bIsPlaying)
		{
			UAnimSingleNodeInstance.__SetPlaying_Internal(base.NativePtr, bIsPlaying);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0002592E File Offset: 0x00023B2E
		public void SetLooping(bool bIsLooping)
		{
			UAnimSingleNodeInstance.__SetLooping_Internal(base.NativePtr, bIsLooping);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0002593C File Offset: 0x00023B3C
		public void SetBlendSpaceInput(in FVector InBlendInput)
		{
			UAnimSingleNodeInstance.__SetBlendSpaceInput_Internal(base.NativePtr, InBlendInput);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0002594A File Offset: 0x00023B4A
		public void SetAnimationRibbonAsset(UAnimationAsset NewAsset)
		{
			UAnimSingleNodeInstance.__SetAnimationRibbonAsset_Internal(base.NativePtr, (NewAsset != null) ? NewAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00025967 File Offset: 0x00023B67
		public void SetAnimationAsset(UAnimationAsset NewAsset, bool bIsLooping = true, float InPlayRate = 1f)
		{
			UAnimSingleNodeInstance.__SetAnimationAsset_Internal(base.NativePtr, (NewAsset != null) ? NewAsset.NativePtr : IntPtr.Zero, bIsLooping, InPlayRate);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00025986 File Offset: 0x00023B86
		public void PlayAnim(bool bIsLooping = false, float InPlayRate = 1f, float InStartPosition = 0f)
		{
			UAnimSingleNodeInstance.__PlayAnim_Internal(base.NativePtr, bIsLooping, InPlayRate, InStartPosition);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00025996 File Offset: 0x00023B96
		public float GetLength()
		{
			return UAnimSingleNodeInstance.__GetLength_Internal(base.NativePtr);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x000259A3 File Offset: 0x00023BA3
		public UAnimationAsset GetAnimationAsset()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimationAsset>(UAnimSingleNodeInstance.__GetAnimationAsset_Internal(base.NativePtr));
		}

		// Token: 0x060018C0 RID: 6336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnim_Internal(IntPtr @this);

		// Token: 0x060018C1 RID: 6337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReverse_Internal(IntPtr @this, bool bInReverse);

		// Token: 0x060018C2 RID: 6338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPreviewCurveOverride_Internal(IntPtr @this, in FName PoseName, float Value, bool bRemoveIfZero);

		// Token: 0x060018C3 RID: 6339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPositionWithPreviousTime_Internal(IntPtr @this, float InPosition, float InPreviousTime, bool bFireNotifies);

		// Token: 0x060018C4 RID: 6340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPosition_Internal(IntPtr @this, float InPosition, bool bFireNotifies);

		// Token: 0x060018C5 RID: 6341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRate_Internal(IntPtr @this, float InPlayRate);

		// Token: 0x060018C6 RID: 6342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaying_Internal(IntPtr @this, bool bIsPlaying);

		// Token: 0x060018C7 RID: 6343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLooping_Internal(IntPtr @this, bool bIsLooping);

		// Token: 0x060018C8 RID: 6344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlendSpaceInput_Internal(IntPtr @this, in FVector InBlendInput);

		// Token: 0x060018C9 RID: 6345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationRibbonAsset_Internal(IntPtr @this, IntPtr NewAsset);

		// Token: 0x060018CA RID: 6346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationAsset_Internal(IntPtr @this, IntPtr NewAsset, bool bIsLooping, float InPlayRate);

		// Token: 0x060018CB RID: 6347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnim_Internal(IntPtr @this, bool bIsLooping, float InPlayRate, float InStartPosition);

		// Token: 0x060018CC RID: 6348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLength_Internal(IntPtr @this);

		// Token: 0x060018CD RID: 6349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnimationAsset_Internal(IntPtr @this);

		// Token: 0x060018CE RID: 6350 RVA: 0x000259B5 File Offset: 0x00023BB5
		static UAnimSingleNodeInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimSingleNodeInstance");
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x000259C3 File Offset: 0x00023BC3
		protected UAnimSingleNodeInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007D9 RID: 2009
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimSingleNodeInstance";

		// Token: 0x040007DA RID: 2010
		private static IntPtr _ClassPtr;

		// Token: 0x040007DB RID: 2011
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007DC RID: 2012
		internal static int __PropertyOffset_CurrentAsset;

		// Token: 0x040007DD RID: 2013
		internal static int __PropertyOffset_CurrentRibbonAsset;

		// Token: 0x040007DE RID: 2014
		internal static int __PropertyOffset_PostEvaluateAnimEvent;

		// Token: 0x040007DF RID: 2015
		private FPostEvaluateAnimEvent _PostEvaluateAnimEvent;
	}
}
