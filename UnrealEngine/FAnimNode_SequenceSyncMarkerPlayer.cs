using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200161D RID: 5661
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_SequenceSyncMarkerPlayer")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FAnimNode_SequenceSyncMarkerPlayer : FAnimNode_SequencePlayer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014762 RID: 83810 RVA: 0x001E17FC File Offset: 0x001DF9FC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SequenceSyncMarkerPlayer._ScriptStructPtr != 0) ? FAnimNode_SequenceSyncMarkerPlayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_SequenceSyncMarkerPlayer", ref FAnimNode_SequenceSyncMarkerPlayer._ScriptStructPtr);
		}

		// Token: 0x1700507F RID: 20607
		// (get) Token: 0x06014763 RID: 83811 RVA: 0x001E1820 File Offset: 0x001DFA20
		// (set) Token: 0x06014764 RID: 83812 RVA: 0x001E1863 File Offset: 0x001DFA63
		public TArray<FSequenceSyncMarkerMapRule> MapRules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSequenceSyncMarkerMapRule> result;
				if ((result = this._MapRules) == null)
				{
					result = (this._MapRules = new TArray<FSequenceSyncMarkerMapRule>(base.NativePtr + (IntPtr)FAnimNode_SequenceSyncMarkerPlayer.__PropertyOffset_MapRules, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MapRules.CopyAssign(value);
			}
		}

		// Token: 0x17005080 RID: 20608
		// (get) Token: 0x06014765 RID: 83813 RVA: 0x001E1871 File Offset: 0x001DFA71
		// (set) Token: 0x06014766 RID: 83814 RVA: 0x001E1881 File Offset: 0x001DFA81
		public unsafe bool bAutoMapStartOnEntry
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequenceSyncMarkerPlayer.__PropertyOffset_bAutoMapStartOnEntry) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequenceSyncMarkerPlayer.__PropertyOffset_bAutoMapStartOnEntry) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005081 RID: 20609
		// (get) Token: 0x06014767 RID: 83815 RVA: 0x001E1892 File Offset: 0x001DFA92
		// (set) Token: 0x06014768 RID: 83816 RVA: 0x001E18A2 File Offset: 0x001DFAA2
		public unsafe float MappedStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequenceSyncMarkerPlayer.__PropertyOffset_MappedStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequenceSyncMarkerPlayer.__PropertyOffset_MappedStartTime) = value;
			}
		}

		// Token: 0x06014769 RID: 83817 RVA: 0x001E18B3 File Offset: 0x001DFAB3
		public FAnimNode_SequenceSyncMarkerPlayer()
		{
		}

		// Token: 0x0601476A RID: 83818 RVA: 0x001E18BC File Offset: 0x001DFABC
		public FAnimNode_SequenceSyncMarkerPlayer(TArray<FSequenceSyncMarkerMapRule> MapRules, bool bAutoMapStartOnEntry, float MappedStartTime, UAnimSequenceBase Sequence, TSoftObjectPtr<UAnimSequenceBase> SequenceSoft, float PlayRateBasis, float PlayRate, FInputScaleBiasClamp PlayRateScaleBiasClamp, float StartPosition, bool bLoopAnimation, int CachedNumOfFrames, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.MapRules = MapRules;
			this.bAutoMapStartOnEntry = bAutoMapStartOnEntry;
			this.MappedStartTime = MappedStartTime;
			base.Sequence = Sequence;
			base.SequenceSoft = SequenceSoft;
			base.PlayRateBasis = PlayRateBasis;
			base.PlayRate = PlayRate;
			base.PlayRateScaleBiasClamp = PlayRateScaleBiasClamp;
			base.StartPosition = StartPosition;
			base.bLoopAnimation = bLoopAnimation;
			base.CachedNumOfFrames = CachedNumOfFrames;
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

		// Token: 0x0601476B RID: 83819 RVA: 0x001E1974 File Offset: 0x001DFB74
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SequenceSyncMarkerPlayer.StaticStruct();
		}

		// Token: 0x0601476C RID: 83820 RVA: 0x001E1980 File Offset: 0x001DFB80
		[NullableContext(2)]
		public FAnimNode_SequenceSyncMarkerPlayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601476D RID: 83821 RVA: 0x001E198A File Offset: 0x001DFB8A
		public FAnimNode_SequenceSyncMarkerPlayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601476E RID: 83822 RVA: 0x001E1995 File Offset: 0x001DFB95
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SequenceSyncMarkerPlayer(Pointer, false, true);
		}

		// Token: 0x0601476F RID: 83823 RVA: 0x001E199F File Offset: 0x001DFB9F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SequenceSyncMarkerPlayer(Pointer, MemoryOwner);
		}

		// Token: 0x0400B216 RID: 45590
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_SequenceSyncMarkerPlayer";

		// Token: 0x0400B217 RID: 45591
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B218 RID: 45592
		internal static int __PropertyOffset_MapRules;

		// Token: 0x0400B219 RID: 45593
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSequenceSyncMarkerMapRule> _MapRules;

		// Token: 0x0400B21A RID: 45594
		internal static int __PropertyOffset_bAutoMapStartOnEntry;

		// Token: 0x0400B21B RID: 45595
		internal static int __PropertyOffset_MappedStartTime;
	}
}
