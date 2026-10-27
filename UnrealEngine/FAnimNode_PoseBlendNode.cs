using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002EE RID: 750
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_PoseBlendNode")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FAnimNode_PoseBlendNode : FAnimNode_PoseHandler, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002ABF RID: 10943 RVA: 0x00040FA8 File Offset: 0x0003F1A8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_PoseBlendNode._ScriptStructPtr != 0) ? FAnimNode_PoseBlendNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_PoseBlendNode", ref FAnimNode_PoseBlendNode._ScriptStructPtr);
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x00040FCC File Offset: 0x0003F1CC
		// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x0004100F File Offset: 0x0003F20F
		public FPoseLink SourcePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._SourcePose) == null)
				{
					result = (this._SourcePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_PoseBlendNode.__PropertyOffset_SourcePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_PoseBlendNode.__PropertyOffset_SourcePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x00041030 File Offset: 0x0003F230
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x00041040 File Offset: 0x0003F240
		public unsafe EAlphaBlendOption BlendOption
		{
			get
			{
				return (EAlphaBlendOption)(*(base.NativePtr + (IntPtr)FAnimNode_PoseBlendNode.__PropertyOffset_BlendOption));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PoseBlendNode.__PropertyOffset_BlendOption) = (byte)value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x00041051 File Offset: 0x0003F251
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x00041065 File Offset: 0x0003F265
		[Nullable(2)]
		public unsafe UCurveFloat CustomCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_PoseBlendNode.__PropertyOffset_CustomCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_PoseBlendNode.__PropertyOffset_CustomCurve, value);
			}
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x0004107A File Offset: 0x0003F27A
		public FAnimNode_PoseBlendNode()
		{
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x00041084 File Offset: 0x0003F284
		public FAnimNode_PoseBlendNode(FPoseLink SourcePose, EAlphaBlendOption BlendOption, UCurveFloat CustomCurve, UPoseAsset PoseAsset, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.SourcePose = SourcePose;
			this.BlendOption = BlendOption;
			this.CustomCurve = CustomCurve;
			base.PoseAsset = PoseAsset;
			base.GroupName = GroupName;
			base.GroupRole = GroupRole;
			base.GroupScope = GroupScope;
			base.bIgnoreForRelevancyTest = bIgnoreForRelevancyTest;
			base.BlendWeight = BlendWeight;
			base.InternalTimeAccumulator = InternalTimeAccumulator;
			base.CachedSequenceLength = CachedSequenceLength;
			base.CachedRateScale = CachedRateScale;
			base.bUseSoftRef = bUseSoftRef;
			base.AnimationName = AnimationName;
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x00041104 File Offset: 0x0003F304
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_PoseBlendNode.StaticStruct();
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x00041110 File Offset: 0x0003F310
		[NullableContext(2)]
		public FAnimNode_PoseBlendNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x0004111A File Offset: 0x0003F31A
		public FAnimNode_PoseBlendNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x00041125 File Offset: 0x0003F325
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_PoseBlendNode(Pointer, false, true);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x0004112F File Offset: 0x0003F32F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_PoseBlendNode(Pointer, MemoryOwner);
		}

		// Token: 0x04001156 RID: 4438
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_PoseBlendNode";

		// Token: 0x04001157 RID: 4439
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001158 RID: 4440
		internal static int __PropertyOffset_SourcePose;

		// Token: 0x04001159 RID: 4441
		[Nullable(2)]
		private FPoseLink _SourcePose;

		// Token: 0x0400115A RID: 4442
		internal static int __PropertyOffset_BlendOption;

		// Token: 0x0400115B RID: 4443
		internal static int __PropertyOffset_CustomCurve;
	}
}
