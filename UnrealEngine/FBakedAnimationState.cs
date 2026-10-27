using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000877 RID: 2167
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedAnimationState")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FBakedAnimationState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060075E6 RID: 30182 RVA: 0x000A920A File Offset: 0x000A740A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedAnimationState._ScriptStructPtr != 0) ? FBakedAnimationState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedAnimationState", ref FBakedAnimationState._ScriptStructPtr);
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x060075E7 RID: 30183 RVA: 0x000A922E File Offset: 0x000A742E
		// (set) Token: 0x060075E8 RID: 30184 RVA: 0x000A923E File Offset: 0x000A743E
		public unsafe bool AllowSimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_AllowSimulate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_AllowSimulate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x060075E9 RID: 30185 RVA: 0x000A924F File Offset: 0x000A744F
		// (set) Token: 0x060075EA RID: 30186 RVA: 0x000A9263 File Offset: 0x000A7463
		public unsafe FName StateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_StateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_StateName) = value;
			}
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x060075EB RID: 30187 RVA: 0x000A9278 File Offset: 0x000A7478
		// (set) Token: 0x060075EC RID: 30188 RVA: 0x000A92BB File Offset: 0x000A74BB
		public TArray<FBakedStateExitTransition> Transitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedStateExitTransition> result;
				if ((result = this._Transitions) == null)
				{
					result = (this._Transitions = new TArray<FBakedStateExitTransition>(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_Transitions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transitions.CopyAssign(value);
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x060075ED RID: 30189 RVA: 0x000A92C9 File Offset: 0x000A74C9
		// (set) Token: 0x060075EE RID: 30190 RVA: 0x000A92D9 File Offset: 0x000A74D9
		public unsafe int StateRootNodeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_StateRootNodeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_StateRootNodeIndex) = value;
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x060075EF RID: 30191 RVA: 0x000A92EA File Offset: 0x000A74EA
		// (set) Token: 0x060075F0 RID: 30192 RVA: 0x000A92FA File Offset: 0x000A74FA
		public unsafe int StartNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_StartNotify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_StartNotify) = value;
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x060075F1 RID: 30193 RVA: 0x000A930B File Offset: 0x000A750B
		// (set) Token: 0x060075F2 RID: 30194 RVA: 0x000A931B File Offset: 0x000A751B
		public unsafe int EndNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_EndNotify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_EndNotify) = value;
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x000A932C File Offset: 0x000A752C
		// (set) Token: 0x060075F4 RID: 30196 RVA: 0x000A933C File Offset: 0x000A753C
		public unsafe int FullyBlendedNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_FullyBlendedNotify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_FullyBlendedNotify) = value;
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x060075F5 RID: 30197 RVA: 0x000A934D File Offset: 0x000A754D
		// (set) Token: 0x060075F6 RID: 30198 RVA: 0x000A935D File Offset: 0x000A755D
		public unsafe bool bIsAConduit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_bIsAConduit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_bIsAConduit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x060075F7 RID: 30199 RVA: 0x000A936E File Offset: 0x000A756E
		// (set) Token: 0x060075F8 RID: 30200 RVA: 0x000A937E File Offset: 0x000A757E
		public unsafe int EntryRuleNodeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_EntryRuleNodeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_EntryRuleNodeIndex) = value;
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x060075F9 RID: 30201 RVA: 0x000A9390 File Offset: 0x000A7590
		// (set) Token: 0x060075FA RID: 30202 RVA: 0x000A93D3 File Offset: 0x000A75D3
		public TArray<int> PlayerNodeIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PlayerNodeIndices) == null)
				{
					result = (this._PlayerNodeIndices = new TArray<int>(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_PlayerNodeIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlayerNodeIndices.CopyAssign(value);
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x060075FB RID: 30203 RVA: 0x000A93E4 File Offset: 0x000A75E4
		// (set) Token: 0x060075FC RID: 30204 RVA: 0x000A9427 File Offset: 0x000A7627
		public TArray<int> LayerNodeIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._LayerNodeIndices) == null)
				{
					result = (this._LayerNodeIndices = new TArray<int>(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_LayerNodeIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerNodeIndices.CopyAssign(value);
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x060075FD RID: 30205 RVA: 0x000A9435 File Offset: 0x000A7635
		// (set) Token: 0x060075FE RID: 30206 RVA: 0x000A9445 File Offset: 0x000A7645
		public unsafe bool bAlwaysResetOnEntry
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_bAlwaysResetOnEntry) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_bAlwaysResetOnEntry) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x060075FF RID: 30207 RVA: 0x000A9458 File Offset: 0x000A7658
		// (set) Token: 0x06007600 RID: 30208 RVA: 0x000A949B File Offset: 0x000A769B
		public TArray<FKuroBakedTransitionCondition> NativeConditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroBakedTransitionCondition> result;
				if ((result = this._NativeConditions) == null)
				{
					result = (this._NativeConditions = new TArray<FKuroBakedTransitionCondition>(base.NativePtr + (IntPtr)FBakedAnimationState.__PropertyOffset_NativeConditions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NativeConditions.CopyAssign(value);
			}
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x000A94A9 File Offset: 0x000A76A9
		public FBakedAnimationState()
		{
		}

		// Token: 0x06007602 RID: 30210 RVA: 0x000A94B4 File Offset: 0x000A76B4
		public FBakedAnimationState(bool AllowSimulate, FName StateName, TArray<FBakedStateExitTransition> Transitions, int StateRootNodeIndex, int StartNotify, int EndNotify, int FullyBlendedNotify, bool bIsAConduit, int EntryRuleNodeIndex, TArray<int> PlayerNodeIndices, TArray<int> LayerNodeIndices, bool bAlwaysResetOnEntry, TArray<FKuroBakedTransitionCondition> NativeConditions)
		{
			this.AllowSimulate = AllowSimulate;
			this.StateName = StateName;
			this.Transitions = Transitions;
			this.StateRootNodeIndex = StateRootNodeIndex;
			this.StartNotify = StartNotify;
			this.EndNotify = EndNotify;
			this.FullyBlendedNotify = FullyBlendedNotify;
			this.bIsAConduit = bIsAConduit;
			this.EntryRuleNodeIndex = EntryRuleNodeIndex;
			this.PlayerNodeIndices = PlayerNodeIndices;
			this.LayerNodeIndices = LayerNodeIndices;
			this.bAlwaysResetOnEntry = bAlwaysResetOnEntry;
			this.NativeConditions = NativeConditions;
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x000A952C File Offset: 0x000A772C
		protected override IntPtr GetUStructPtr()
		{
			return FBakedAnimationState.StaticStruct();
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x000A9538 File Offset: 0x000A7738
		[NullableContext(2)]
		public FBakedAnimationState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x000A9542 File Offset: 0x000A7742
		public FBakedAnimationState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x000A954D File Offset: 0x000A774D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedAnimationState(Pointer, false, true);
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x000A9557 File Offset: 0x000A7757
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedAnimationState(Pointer, MemoryOwner);
		}

		// Token: 0x040038C3 RID: 14531
		public const string __ObjectPath = "/Script/Engine.BakedAnimationState";

		// Token: 0x040038C4 RID: 14532
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040038C5 RID: 14533
		internal static int __PropertyOffset_AllowSimulate;

		// Token: 0x040038C6 RID: 14534
		internal static int __PropertyOffset_StateName;

		// Token: 0x040038C7 RID: 14535
		internal static int __PropertyOffset_Transitions;

		// Token: 0x040038C8 RID: 14536
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedStateExitTransition> _Transitions;

		// Token: 0x040038C9 RID: 14537
		internal static int __PropertyOffset_StateRootNodeIndex;

		// Token: 0x040038CA RID: 14538
		internal static int __PropertyOffset_StartNotify;

		// Token: 0x040038CB RID: 14539
		internal static int __PropertyOffset_EndNotify;

		// Token: 0x040038CC RID: 14540
		internal static int __PropertyOffset_FullyBlendedNotify;

		// Token: 0x040038CD RID: 14541
		internal static int __PropertyOffset_bIsAConduit;

		// Token: 0x040038CE RID: 14542
		internal static int __PropertyOffset_EntryRuleNodeIndex;

		// Token: 0x040038CF RID: 14543
		internal static int __PropertyOffset_PlayerNodeIndices;

		// Token: 0x040038D0 RID: 14544
		[Nullable(2)]
		private TArray<int> _PlayerNodeIndices;

		// Token: 0x040038D1 RID: 14545
		internal static int __PropertyOffset_LayerNodeIndices;

		// Token: 0x040038D2 RID: 14546
		[Nullable(2)]
		private TArray<int> _LayerNodeIndices;

		// Token: 0x040038D3 RID: 14547
		internal static int __PropertyOffset_bAlwaysResetOnEntry;

		// Token: 0x040038D4 RID: 14548
		internal static int __PropertyOffset_NativeConditions;

		// Token: 0x040038D5 RID: 14549
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroBakedTransitionCondition> _NativeConditions;
	}
}
