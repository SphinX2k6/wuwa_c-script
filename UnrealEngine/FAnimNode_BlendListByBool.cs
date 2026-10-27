using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002D3 RID: 723
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_BlendListByBool")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FAnimNode_BlendListByBool : FAnimNode_BlendListBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600287C RID: 10364 RVA: 0x0003CF9B File Offset: 0x0003B19B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BlendListByBool._ScriptStructPtr != 0) ? FAnimNode_BlendListByBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_BlendListByBool", ref FAnimNode_BlendListByBool._ScriptStructPtr);
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x0003CFBF File Offset: 0x0003B1BF
		// (set) Token: 0x0600287E RID: 10366 RVA: 0x0003CFCF File Offset: 0x0003B1CF
		public unsafe bool bActiveValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendListByBool.__PropertyOffset_bActiveValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendListByBool.__PropertyOffset_bActiveValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0003CFE0 File Offset: 0x0003B1E0
		public FAnimNode_BlendListByBool()
		{
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x0003CFE8 File Offset: 0x0003B1E8
		[NullableContext(1)]
		public FAnimNode_BlendListByBool(bool bActiveValue, TArray<FPoseLink> BlendPose, TArray<float> BlendTime, EBlendListTransitionType TransitionType, EAlphaBlendOption BlendType, bool bResetChildOnActivation, UCurveFloat CustomBlendCurve, UBlendProfile BlendProfile)
		{
			this.bActiveValue = bActiveValue;
			base.BlendPose = BlendPose;
			base.BlendTime = BlendTime;
			base.TransitionType = TransitionType;
			base.BlendType = BlendType;
			base.bResetChildOnActivation = bResetChildOnActivation;
			base.CustomBlendCurve = CustomBlendCurve;
			base.BlendProfile = BlendProfile;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x0003D038 File Offset: 0x0003B238
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BlendListByBool.StaticStruct();
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0003D044 File Offset: 0x0003B244
		[NullableContext(2)]
		public FAnimNode_BlendListByBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0003D04E File Offset: 0x0003B24E
		public FAnimNode_BlendListByBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0003D059 File Offset: 0x0003B259
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BlendListByBool(Pointer, false, true);
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0003D063 File Offset: 0x0003B263
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BlendListByBool(Pointer, MemoryOwner);
		}

		// Token: 0x04001022 RID: 4130
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_BlendListByBool";

		// Token: 0x04001023 RID: 4131
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001024 RID: 4132
		internal static int __PropertyOffset_bActiveValue;
	}
}
