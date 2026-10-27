using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F1 RID: 753
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_PoseHandler")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FAnimNode_PoseHandler : FAnimNode_AssetPlayerBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002AF7 RID: 10999 RVA: 0x00041670 File Offset: 0x0003F870
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_PoseHandler._ScriptStructPtr != 0) ? FAnimNode_PoseHandler._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_PoseHandler", ref FAnimNode_PoseHandler._ScriptStructPtr);
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x00041694 File Offset: 0x0003F894
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x000416A8 File Offset: 0x0003F8A8
		[Nullable(2)]
		public unsafe UPoseAsset PoseAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPoseAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_PoseHandler.__PropertyOffset_PoseAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_PoseHandler.__PropertyOffset_PoseAsset, value);
			}
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000416BD File Offset: 0x0003F8BD
		public FAnimNode_PoseHandler()
		{
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000416C8 File Offset: 0x0003F8C8
		[NullableContext(1)]
		public FAnimNode_PoseHandler(UPoseAsset PoseAsset, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.PoseAsset = PoseAsset;
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

		// Token: 0x06002AFC RID: 11004 RVA: 0x00041731 File Offset: 0x0003F931
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_PoseHandler.StaticStruct();
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x0004173D File Offset: 0x0003F93D
		[NullableContext(2)]
		public FAnimNode_PoseHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00041747 File Offset: 0x0003F947
		public FAnimNode_PoseHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00041752 File Offset: 0x0003F952
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_PoseHandler(Pointer, false, true);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x0004175C File Offset: 0x0003F95C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_PoseHandler(Pointer, MemoryOwner);
		}

		// Token: 0x04001174 RID: 4468
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_PoseHandler";

		// Token: 0x04001175 RID: 4469
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001176 RID: 4470
		internal static int __PropertyOffset_PoseAsset;
	}
}
