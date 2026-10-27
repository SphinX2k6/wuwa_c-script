using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200083E RID: 2110
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSingleNodeInstance")]
	[UnrealStructLayout(2224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2224)]
	public class UAnimSingleNodeInstance : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060071A3 RID: 29091 RVA: 0x000A2DF0 File Offset: 0x000A0FF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimSingleNodeInstance._ClassPtr;
		}

		// Token: 0x060071A4 RID: 29092 RVA: 0x000A2DFC File Offset: 0x000A0FFC
		public UAnimSingleNodeInstance() : this(BuiltinUtils.AllocNativeUObject(UAnimSingleNodeInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060071A5 RID: 29093 RVA: 0x000A2E24 File Offset: 0x000A1024
		[NullableContext(1)]
		public UAnimSingleNodeInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimSingleNodeInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x060071A6 RID: 29094 RVA: 0x000A2E57 File Offset: 0x000A1057
		// (set) Token: 0x060071A7 RID: 29095 RVA: 0x000A2E6B File Offset: 0x000A106B
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

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x060071A8 RID: 29096 RVA: 0x000A2E80 File Offset: 0x000A1080
		// (set) Token: 0x060071A9 RID: 29097 RVA: 0x000A2E94 File Offset: 0x000A1094
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

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x060071AA RID: 29098 RVA: 0x000A2EAC File Offset: 0x000A10AC
		// (set) Token: 0x060071AB RID: 29099 RVA: 0x000A2EE5 File Offset: 0x000A10E5
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

		// Token: 0x060071AC RID: 29100 RVA: 0x000A2F06 File Offset: 0x000A1106
		public void StopAnim()
		{
			UAnimSingleNodeInstance.__StopAnim_Internal(base.NativePtr);
		}

		// Token: 0x060071AD RID: 29101 RVA: 0x000A2F13 File Offset: 0x000A1113
		public void SetReverse(bool bInReverse)
		{
			UAnimSingleNodeInstance.__SetReverse_Internal(base.NativePtr, bInReverse);
		}

		// Token: 0x060071AE RID: 29102 RVA: 0x000A2F24 File Offset: 0x000A1124
		public unsafe void SetPreviewCurveOverride(in FName PoseName, float Value, bool bRemoveIfZero)
		{
			fixed (FName* ptr = &PoseName)
			{
				void* ptr2 = (void*)ptr;
				UAnimSingleNodeInstance.__SetPreviewCurveOverride_Internal(base.NativePtr, PoseName, Value, bRemoveIfZero);
			}
		}

		// Token: 0x060071AF RID: 29103 RVA: 0x000A2F47 File Offset: 0x000A1147
		public void SetPositionWithPreviousTime(float InPosition, float InPreviousTime, bool bFireNotifies = true)
		{
			UAnimSingleNodeInstance.__SetPositionWithPreviousTime_Internal(base.NativePtr, InPosition, InPreviousTime, bFireNotifies);
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x000A2F57 File Offset: 0x000A1157
		public void SetPosition(float InPosition, bool bFireNotifies = true)
		{
			UAnimSingleNodeInstance.__SetPosition_Internal(base.NativePtr, InPosition, bFireNotifies);
		}

		// Token: 0x060071B1 RID: 29105 RVA: 0x000A2F66 File Offset: 0x000A1166
		public void SetPlayRate(float InPlayRate)
		{
			UAnimSingleNodeInstance.__SetPlayRate_Internal(base.NativePtr, InPlayRate);
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x000A2F74 File Offset: 0x000A1174
		public void SetPlaying(bool bIsPlaying)
		{
			UAnimSingleNodeInstance.__SetPlaying_Internal(base.NativePtr, bIsPlaying);
		}

		// Token: 0x060071B3 RID: 29107 RVA: 0x000A2F82 File Offset: 0x000A1182
		public void SetLooping(bool bIsLooping)
		{
			UAnimSingleNodeInstance.__SetLooping_Internal(base.NativePtr, bIsLooping);
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x000A2F90 File Offset: 0x000A1190
		public void SetBlendSpaceInput(in FVector InBlendInput)
		{
			UAnimSingleNodeInstance.__SetBlendSpaceInput_Internal(base.NativePtr, InBlendInput);
		}

		// Token: 0x060071B5 RID: 29109 RVA: 0x000A2F9E File Offset: 0x000A119E
		public void SetAnimationRibbonAsset(UAnimationAsset NewAsset)
		{
			UAnimSingleNodeInstance.__SetAnimationRibbonAsset_Internal(base.NativePtr, (NewAsset != null) ? NewAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x000A2FBB File Offset: 0x000A11BB
		public void SetAnimationAsset(UAnimationAsset NewAsset, bool bIsLooping = true, float InPlayRate = 1f)
		{
			UAnimSingleNodeInstance.__SetAnimationAsset_Internal(base.NativePtr, (NewAsset != null) ? NewAsset.NativePtr : IntPtr.Zero, bIsLooping, InPlayRate);
		}

		// Token: 0x060071B7 RID: 29111 RVA: 0x000A2FDA File Offset: 0x000A11DA
		public void PlayAnim(bool bIsLooping = false, float InPlayRate = 1f, float InStartPosition = 0f)
		{
			UAnimSingleNodeInstance.__PlayAnim_Internal(base.NativePtr, bIsLooping, InPlayRate, InStartPosition);
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x000A2FEA File Offset: 0x000A11EA
		public float GetLength()
		{
			return UAnimSingleNodeInstance.__GetLength_Internal(base.NativePtr);
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x000A2FF7 File Offset: 0x000A11F7
		public UAnimationAsset GetAnimationAsset()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimationAsset>(UAnimSingleNodeInstance.__GetAnimationAsset_Internal(base.NativePtr));
		}

		// Token: 0x060071BA RID: 29114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnim_Internal(IntPtr @this);

		// Token: 0x060071BB RID: 29115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReverse_Internal(IntPtr @this, bool bInReverse);

		// Token: 0x060071BC RID: 29116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPreviewCurveOverride_Internal(IntPtr @this, in FName PoseName, float Value, bool bRemoveIfZero);

		// Token: 0x060071BD RID: 29117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPositionWithPreviousTime_Internal(IntPtr @this, float InPosition, float InPreviousTime, bool bFireNotifies);

		// Token: 0x060071BE RID: 29118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPosition_Internal(IntPtr @this, float InPosition, bool bFireNotifies);

		// Token: 0x060071BF RID: 29119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRate_Internal(IntPtr @this, float InPlayRate);

		// Token: 0x060071C0 RID: 29120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaying_Internal(IntPtr @this, bool bIsPlaying);

		// Token: 0x060071C1 RID: 29121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLooping_Internal(IntPtr @this, bool bIsLooping);

		// Token: 0x060071C2 RID: 29122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlendSpaceInput_Internal(IntPtr @this, in FVector InBlendInput);

		// Token: 0x060071C3 RID: 29123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationRibbonAsset_Internal(IntPtr @this, IntPtr NewAsset);

		// Token: 0x060071C4 RID: 29124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationAsset_Internal(IntPtr @this, IntPtr NewAsset, bool bIsLooping, float InPlayRate);

		// Token: 0x060071C5 RID: 29125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnim_Internal(IntPtr @this, bool bIsLooping, float InPlayRate, float InStartPosition);

		// Token: 0x060071C6 RID: 29126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLength_Internal(IntPtr @this);

		// Token: 0x060071C7 RID: 29127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnimationAsset_Internal(IntPtr @this);

		// Token: 0x060071C8 RID: 29128 RVA: 0x000A3009 File Offset: 0x000A1209
		static UAnimSingleNodeInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimSingleNodeInstance");
		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x000A3017 File Offset: 0x000A1217
		protected UAnimSingleNodeInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036A2 RID: 13986
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimSingleNodeInstance";

		// Token: 0x040036A3 RID: 13987
		private static IntPtr _ClassPtr;

		// Token: 0x040036A4 RID: 13988
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040036A5 RID: 13989
		internal static int __PropertyOffset_CurrentAsset;

		// Token: 0x040036A6 RID: 13990
		internal static int __PropertyOffset_CurrentRibbonAsset;

		// Token: 0x040036A7 RID: 13991
		internal static int __PropertyOffset_PostEvaluateAnimEvent;

		// Token: 0x040036A8 RID: 13992
		private FPostEvaluateAnimEvent _PostEvaluateAnimEvent;
	}
}
