using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002D4 RID: 724
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_BlendListByEnum")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FAnimNode_BlendListByEnum : FAnimNode_BlendListBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002886 RID: 10374 RVA: 0x0003D06C File Offset: 0x0003B26C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BlendListByEnum._ScriptStructPtr != 0) ? FAnimNode_BlendListByEnum._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_BlendListByEnum", ref FAnimNode_BlendListByEnum._ScriptStructPtr);
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x0003D090 File Offset: 0x0003B290
		// (set) Token: 0x06002888 RID: 10376 RVA: 0x0003D0D3 File Offset: 0x0003B2D3
		public TArray<int> EnumToPoseIndex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._EnumToPoseIndex) == null)
				{
					result = (this._EnumToPoseIndex = new TArray<int>(base.NativePtr + (IntPtr)FAnimNode_BlendListByEnum.__PropertyOffset_EnumToPoseIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumToPoseIndex.CopyAssign(value);
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x0003D0E1 File Offset: 0x0003B2E1
		// (set) Token: 0x0600288A RID: 10378 RVA: 0x0003D0F1 File Offset: 0x0003B2F1
		public unsafe byte ActiveEnumValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendListByEnum.__PropertyOffset_ActiveEnumValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendListByEnum.__PropertyOffset_ActiveEnumValue) = value;
			}
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0003D102 File Offset: 0x0003B302
		public FAnimNode_BlendListByEnum()
		{
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0003D10C File Offset: 0x0003B30C
		public FAnimNode_BlendListByEnum(TArray<int> EnumToPoseIndex, byte ActiveEnumValue, TArray<FPoseLink> BlendPose, TArray<float> BlendTime, EBlendListTransitionType TransitionType, EAlphaBlendOption BlendType, bool bResetChildOnActivation, UCurveFloat CustomBlendCurve, UBlendProfile BlendProfile)
		{
			this.EnumToPoseIndex = EnumToPoseIndex;
			this.ActiveEnumValue = ActiveEnumValue;
			base.BlendPose = BlendPose;
			base.BlendTime = BlendTime;
			base.TransitionType = TransitionType;
			base.BlendType = BlendType;
			base.bResetChildOnActivation = bResetChildOnActivation;
			base.CustomBlendCurve = CustomBlendCurve;
			base.BlendProfile = BlendProfile;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0003D164 File Offset: 0x0003B364
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BlendListByEnum.StaticStruct();
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0003D170 File Offset: 0x0003B370
		[NullableContext(2)]
		public FAnimNode_BlendListByEnum(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0003D17A File Offset: 0x0003B37A
		public FAnimNode_BlendListByEnum(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x0003D185 File Offset: 0x0003B385
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BlendListByEnum(Pointer, false, true);
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x0003D18F File Offset: 0x0003B38F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BlendListByEnum(Pointer, MemoryOwner);
		}

		// Token: 0x04001025 RID: 4133
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_BlendListByEnum";

		// Token: 0x04001026 RID: 4134
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001027 RID: 4135
		internal static int __PropertyOffset_EnumToPoseIndex;

		// Token: 0x04001028 RID: 4136
		[Nullable(2)]
		private TArray<int> _EnumToPoseIndex;

		// Token: 0x04001029 RID: 4137
		internal static int __PropertyOffset_ActiveEnumValue;
	}
}
