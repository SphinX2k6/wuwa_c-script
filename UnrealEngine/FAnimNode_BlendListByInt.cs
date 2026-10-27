using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002D5 RID: 725
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_BlendListByInt")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FAnimNode_BlendListByInt : FAnimNode_BlendListBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002892 RID: 10386 RVA: 0x0003D198 File Offset: 0x0003B398
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BlendListByInt._ScriptStructPtr != 0) ? FAnimNode_BlendListByInt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_BlendListByInt", ref FAnimNode_BlendListByInt._ScriptStructPtr);
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x0003D1BC File Offset: 0x0003B3BC
		// (set) Token: 0x06002894 RID: 10388 RVA: 0x0003D1CC File Offset: 0x0003B3CC
		public unsafe int ActiveChildIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendListByInt.__PropertyOffset_ActiveChildIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendListByInt.__PropertyOffset_ActiveChildIndex) = value;
			}
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0003D1DD File Offset: 0x0003B3DD
		public FAnimNode_BlendListByInt()
		{
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x0003D1E8 File Offset: 0x0003B3E8
		[NullableContext(1)]
		public FAnimNode_BlendListByInt(int ActiveChildIndex, TArray<FPoseLink> BlendPose, TArray<float> BlendTime, EBlendListTransitionType TransitionType, EAlphaBlendOption BlendType, bool bResetChildOnActivation, UCurveFloat CustomBlendCurve, UBlendProfile BlendProfile)
		{
			this.ActiveChildIndex = ActiveChildIndex;
			base.BlendPose = BlendPose;
			base.BlendTime = BlendTime;
			base.TransitionType = TransitionType;
			base.BlendType = BlendType;
			base.bResetChildOnActivation = bResetChildOnActivation;
			base.CustomBlendCurve = CustomBlendCurve;
			base.BlendProfile = BlendProfile;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0003D238 File Offset: 0x0003B438
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BlendListByInt.StaticStruct();
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x0003D244 File Offset: 0x0003B444
		[NullableContext(2)]
		public FAnimNode_BlendListByInt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x0003D24E File Offset: 0x0003B44E
		public FAnimNode_BlendListByInt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0003D259 File Offset: 0x0003B459
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BlendListByInt(Pointer, false, true);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0003D263 File Offset: 0x0003B463
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BlendListByInt(Pointer, MemoryOwner);
		}

		// Token: 0x0400102A RID: 4138
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_BlendListByInt";

		// Token: 0x0400102B RID: 4139
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400102C RID: 4140
		internal static int __PropertyOffset_ActiveChildIndex;
	}
}
