using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002EF RID: 751
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_PoseByName")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FAnimNode_PoseByName : FAnimNode_PoseHandler, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002ACD RID: 10957 RVA: 0x00041138 File Offset: 0x0003F338
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_PoseByName._ScriptStructPtr != 0) ? FAnimNode_PoseByName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_PoseByName", ref FAnimNode_PoseByName._ScriptStructPtr);
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x0004115C File Offset: 0x0003F35C
		// (set) Token: 0x06002ACF RID: 10959 RVA: 0x00041170 File Offset: 0x0003F370
		public unsafe FName PoseName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PoseByName.__PropertyOffset_PoseName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PoseByName.__PropertyOffset_PoseName) = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x00041185 File Offset: 0x0003F385
		// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x00041195 File Offset: 0x0003F395
		public unsafe float PoseWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PoseByName.__PropertyOffset_PoseWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PoseByName.__PropertyOffset_PoseWeight) = value;
			}
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000411A6 File Offset: 0x0003F3A6
		public FAnimNode_PoseByName()
		{
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x000411B0 File Offset: 0x0003F3B0
		[NullableContext(1)]
		public FAnimNode_PoseByName(FName PoseName, float PoseWeight, UPoseAsset PoseAsset, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.PoseName = PoseName;
			this.PoseWeight = PoseWeight;
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

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00041228 File Offset: 0x0003F428
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_PoseByName.StaticStruct();
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00041234 File Offset: 0x0003F434
		[NullableContext(2)]
		public FAnimNode_PoseByName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0004123E File Offset: 0x0003F43E
		public FAnimNode_PoseByName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00041249 File Offset: 0x0003F449
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_PoseByName(Pointer, false, true);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00041253 File Offset: 0x0003F453
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_PoseByName(Pointer, MemoryOwner);
		}

		// Token: 0x0400115C RID: 4444
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_PoseByName";

		// Token: 0x0400115D RID: 4445
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400115E RID: 4446
		internal static int __PropertyOffset_PoseName;

		// Token: 0x0400115F RID: 4447
		internal static int __PropertyOffset_PoseWeight;
	}
}
