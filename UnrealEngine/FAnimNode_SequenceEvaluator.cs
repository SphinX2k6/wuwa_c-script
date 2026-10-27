using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002FC RID: 764
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluator")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FAnimNode_SequenceEvaluator : FAnimNode_AssetPlayerBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002BC5 RID: 11205 RVA: 0x00042CFC File Offset: 0x00040EFC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SequenceEvaluator._ScriptStructPtr != 0) ? FAnimNode_SequenceEvaluator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluator", ref FAnimNode_SequenceEvaluator._ScriptStructPtr);
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x00042D20 File Offset: 0x00040F20
		// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x00042D34 File Offset: 0x00040F34
		[Nullable(2)]
		public unsafe UAnimSequenceBase Sequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequenceBase>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_SequenceEvaluator.__PropertyOffset_Sequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_SequenceEvaluator.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x00042D49 File Offset: 0x00040F49
		// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x00042D59 File Offset: 0x00040F59
		public unsafe float ExplicitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_ExplicitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_ExplicitTime) = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x00042D6A File Offset: 0x00040F6A
		// (set) Token: 0x06002BCB RID: 11211 RVA: 0x00042D7A File Offset: 0x00040F7A
		public unsafe bool bForceLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_bForceLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_bForceLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x00042D8B File Offset: 0x00040F8B
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x00042D9B File Offset: 0x00040F9B
		public unsafe float ForcePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_ForcePlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_ForcePlayRate) = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x00042DAC File Offset: 0x00040FAC
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x00042DBC File Offset: 0x00040FBC
		public unsafe bool bShouldLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_bShouldLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_bShouldLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x00042DCD File Offset: 0x00040FCD
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x00042DDD File Offset: 0x00040FDD
		public unsafe bool bTeleportToExplicitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_bTeleportToExplicitTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_bTeleportToExplicitTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x00042DEE File Offset: 0x00040FEE
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x00042E02 File Offset: 0x00041002
		public unsafe TEnumAsByte<ESequenceEvalReinit> ReinitializationBehavior
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_ReinitializationBehavior);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_ReinitializationBehavior) = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x00042E17 File Offset: 0x00041017
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x00042E27 File Offset: 0x00041027
		public unsafe float StartPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_StartPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequenceEvaluator.__PropertyOffset_StartPosition) = value;
			}
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x00042E38 File Offset: 0x00041038
		public FAnimNode_SequenceEvaluator()
		{
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00042E40 File Offset: 0x00041040
		public FAnimNode_SequenceEvaluator([Nullable(1)] UAnimSequenceBase Sequence, float ExplicitTime, bool bForceLoop, float ForcePlayRate, bool bShouldLoop, bool bTeleportToExplicitTime, TEnumAsByte<ESequenceEvalReinit> ReinitializationBehavior, float StartPosition, FName GroupName, int GroupIndex_DEPRECATED, TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, [Nullable(1)] string AnimationName)
		{
			this.Sequence = Sequence;
			this.ExplicitTime = ExplicitTime;
			this.bForceLoop = bForceLoop;
			this.ForcePlayRate = ForcePlayRate;
			this.bShouldLoop = bShouldLoop;
			this.bTeleportToExplicitTime = bTeleportToExplicitTime;
			this.ReinitializationBehavior = ReinitializationBehavior;
			this.StartPosition = StartPosition;
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

		// Token: 0x06002BD8 RID: 11224 RVA: 0x00042EE0 File Offset: 0x000410E0
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SequenceEvaluator.StaticStruct();
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00042EEC File Offset: 0x000410EC
		[NullableContext(2)]
		public FAnimNode_SequenceEvaluator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x00042EF6 File Offset: 0x000410F6
		public FAnimNode_SequenceEvaluator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00042F01 File Offset: 0x00041101
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SequenceEvaluator(Pointer, false, true);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00042F0B File Offset: 0x0004110B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SequenceEvaluator(Pointer, MemoryOwner);
		}

		// Token: 0x040011DD RID: 4573
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_SequenceEvaluator";

		// Token: 0x040011DE RID: 4574
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040011DF RID: 4575
		internal static int __PropertyOffset_Sequence;

		// Token: 0x040011E0 RID: 4576
		internal static int __PropertyOffset_ExplicitTime;

		// Token: 0x040011E1 RID: 4577
		internal static int __PropertyOffset_bForceLoop;

		// Token: 0x040011E2 RID: 4578
		internal static int __PropertyOffset_ForcePlayRate;

		// Token: 0x040011E3 RID: 4579
		internal static int __PropertyOffset_bShouldLoop;

		// Token: 0x040011E4 RID: 4580
		internal static int __PropertyOffset_bTeleportToExplicitTime;

		// Token: 0x040011E5 RID: 4581
		internal static int __PropertyOffset_ReinitializationBehavior;

		// Token: 0x040011E6 RID: 4582
		internal static int __PropertyOffset_StartPosition;
	}
}
