using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001867 RID: 6247
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetBlueprint")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FKuroGameBudgetBlueprint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016FCC RID: 94156 RVA: 0x0021850B File Offset: 0x0021670B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGameBudgetBlueprint._ScriptStructPtr != 0) ? FKuroGameBudgetBlueprint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.KuroGameBudgetBlueprint", ref FKuroGameBudgetBlueprint._ScriptStructPtr);
		}

		// Token: 0x17005C88 RID: 23688
		// (get) Token: 0x06016FCD RID: 94157 RVA: 0x0021852F File Offset: 0x0021672F
		// (set) Token: 0x06016FCE RID: 94158 RVA: 0x0021853F File Offset: 0x0021673F
		public unsafe EGameBudgetBlueprintGroup GroupType
		{
			get
			{
				return (EGameBudgetBlueprintGroup)(*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_GroupType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_GroupType) = (byte)value;
			}
		}

		// Token: 0x17005C89 RID: 23689
		// (get) Token: 0x06016FCF RID: 94159 RVA: 0x00218550 File Offset: 0x00216750
		// (set) Token: 0x06016FD0 RID: 94160 RVA: 0x00218560 File Offset: 0x00216760
		public unsafe byte SupportedPlatforms
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_SupportedPlatforms);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_SupportedPlatforms) = value;
			}
		}

		// Token: 0x17005C8A RID: 23690
		// (get) Token: 0x06016FD1 RID: 94161 RVA: 0x00218571 File Offset: 0x00216771
		// (set) Token: 0x06016FD2 RID: 94162 RVA: 0x00218581 File Offset: 0x00216781
		public unsafe bool bRegisterGameBudgetTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterGameBudgetTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterGameBudgetTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C8B RID: 23691
		// (get) Token: 0x06016FD3 RID: 94163 RVA: 0x00218592 File Offset: 0x00216792
		// (set) Token: 0x06016FD4 RID: 94164 RVA: 0x002185A2 File Offset: 0x002167A2
		public unsafe bool bRegisterGameBudgetAfterTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterGameBudgetAfterTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterGameBudgetAfterTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C8C RID: 23692
		// (get) Token: 0x06016FD5 RID: 94165 RVA: 0x002185B3 File Offset: 0x002167B3
		// (set) Token: 0x06016FD6 RID: 94166 RVA: 0x002185C3 File Offset: 0x002167C3
		public unsafe bool bRegisterOnEnableChangeEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterOnEnableChangeEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterOnEnableChangeEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C8D RID: 23693
		// (get) Token: 0x06016FD7 RID: 94167 RVA: 0x002185D4 File Offset: 0x002167D4
		// (set) Token: 0x06016FD8 RID: 94168 RVA: 0x002185E4 File Offset: 0x002167E4
		public unsafe bool bRegisterOnVisibilityChangeEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterOnVisibilityChangeEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterOnVisibilityChangeEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C8E RID: 23694
		// (get) Token: 0x06016FD9 RID: 94169 RVA: 0x002185F5 File Offset: 0x002167F5
		// (set) Token: 0x06016FDA RID: 94170 RVA: 0x00218605 File Offset: 0x00216805
		public unsafe bool bRegisterOnEnvInteractChangeEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterOnEnvInteractChangeEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterOnEnvInteractChangeEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C8F RID: 23695
		// (get) Token: 0x06016FDB RID: 94171 RVA: 0x00218616 File Offset: 0x00216816
		// (set) Token: 0x06016FDC RID: 94172 RVA: 0x00218626 File Offset: 0x00216826
		public unsafe bool bRegisterOnApplyWorldOffsetEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterOnApplyWorldOffsetEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bRegisterOnApplyWorldOffsetEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C90 RID: 23696
		// (get) Token: 0x06016FDD RID: 94173 RVA: 0x00218637 File Offset: 0x00216837
		// (set) Token: 0x06016FDE RID: 94174 RVA: 0x00218647 File Offset: 0x00216847
		public unsafe bool bSyncComponentTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bSyncComponentTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bSyncComponentTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C91 RID: 23697
		// (get) Token: 0x06016FDF RID: 94175 RVA: 0x00218658 File Offset: 0x00216858
		// (set) Token: 0x06016FE0 RID: 94176 RVA: 0x00218668 File Offset: 0x00216868
		public unsafe bool bUseBoundsCalculateDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bUseBoundsCalculateDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bUseBoundsCalculateDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C92 RID: 23698
		// (get) Token: 0x06016FE1 RID: 94177 RVA: 0x00218679 File Offset: 0x00216879
		// (set) Token: 0x06016FE2 RID: 94178 RVA: 0x00218689 File Offset: 0x00216889
		public unsafe bool bUseScreenRadiusCalculateTickInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bUseScreenRadiusCalculateTickInterval) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bUseScreenRadiusCalculateTickInterval) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C93 RID: 23699
		// (get) Token: 0x06016FE3 RID: 94179 RVA: 0x0021869A File Offset: 0x0021689A
		// (set) Token: 0x06016FE4 RID: 94180 RVA: 0x002186AA File Offset: 0x002168AA
		public unsafe bool bUseWasRecentlyPassVisibilityTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bUseWasRecentlyPassVisibilityTest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bUseWasRecentlyPassVisibilityTest) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C94 RID: 23700
		// (get) Token: 0x06016FE5 RID: 94181 RVA: 0x002186BB File Offset: 0x002168BB
		// (set) Token: 0x06016FE6 RID: 94182 RVA: 0x002186CB File Offset: 0x002168CB
		public unsafe bool bOverrideLocationProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bOverrideLocationProxy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bOverrideLocationProxy) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C95 RID: 23701
		// (get) Token: 0x06016FE7 RID: 94183 RVA: 0x002186DC File Offset: 0x002168DC
		// (set) Token: 0x06016FE8 RID: 94184 RVA: 0x002186EC File Offset: 0x002168EC
		public unsafe bool bUseCustomPlayerRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bUseCustomPlayerRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_bUseCustomPlayerRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C96 RID: 23702
		// (get) Token: 0x06016FE9 RID: 94185 RVA: 0x002186FD File Offset: 0x002168FD
		// (set) Token: 0x06016FEA RID: 94186 RVA: 0x0021870D File Offset: 0x0021690D
		public unsafe float CustomPlayerEnterRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_CustomPlayerEnterRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_CustomPlayerEnterRange) = value;
			}
		}

		// Token: 0x17005C97 RID: 23703
		// (get) Token: 0x06016FEB RID: 94187 RVA: 0x0021871E File Offset: 0x0021691E
		// (set) Token: 0x06016FEC RID: 94188 RVA: 0x0021872E File Offset: 0x0021692E
		public unsafe float CustomPlayerLeaveRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_CustomPlayerLeaveRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_CustomPlayerLeaveRange) = value;
			}
		}

		// Token: 0x17005C98 RID: 23704
		// (get) Token: 0x06016FED RID: 94189 RVA: 0x00218740 File Offset: 0x00216940
		// (set) Token: 0x06016FEE RID: 94190 RVA: 0x00218783 File Offset: 0x00216983
		public TArray<FCustomPlayerRangeConfig> CustomPlayerRanges
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCustomPlayerRangeConfig> result;
				if ((result = this._CustomPlayerRanges) == null)
				{
					result = (this._CustomPlayerRanges = new TArray<FCustomPlayerRangeConfig>(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_CustomPlayerRanges, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomPlayerRanges.CopyAssign(value);
			}
		}

		// Token: 0x17005C99 RID: 23705
		// (get) Token: 0x06016FEF RID: 94191 RVA: 0x00218794 File Offset: 0x00216994
		// (set) Token: 0x06016FF0 RID: 94192 RVA: 0x002187D7 File Offset: 0x002169D7
		public TMap<FName, FCustomPlayerRangeEventState> CustomPlayerRangeEventsInternal
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FCustomPlayerRangeEventState> result;
				if ((result = this._CustomPlayerRangeEventsInternal) == null)
				{
					result = (this._CustomPlayerRangeEventsInternal = new TMap<FName, FCustomPlayerRangeEventState>(base.NativePtr + (IntPtr)FKuroGameBudgetBlueprint.__PropertyOffset_CustomPlayerRangeEventsInternal, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomPlayerRangeEventsInternal.CopyAssign(value);
			}
		}

		// Token: 0x06016FF1 RID: 94193 RVA: 0x002187E5 File Offset: 0x002169E5
		public FKuroGameBudgetBlueprint()
		{
		}

		// Token: 0x06016FF2 RID: 94194 RVA: 0x002187F0 File Offset: 0x002169F0
		public FKuroGameBudgetBlueprint(EGameBudgetBlueprintGroup GroupType, byte SupportedPlatforms, bool bRegisterGameBudgetTick, bool bRegisterGameBudgetAfterTick, bool bRegisterOnEnableChangeEvent, bool bRegisterOnVisibilityChangeEvent, bool bRegisterOnEnvInteractChangeEvent, bool bRegisterOnApplyWorldOffsetEvent, bool bSyncComponentTick, bool bUseBoundsCalculateDistance, bool bUseScreenRadiusCalculateTickInterval, bool bUseWasRecentlyPassVisibilityTest, bool bOverrideLocationProxy, bool bUseCustomPlayerRange, float CustomPlayerEnterRange, float CustomPlayerLeaveRange, TArray<FCustomPlayerRangeConfig> CustomPlayerRanges, TMap<FName, FCustomPlayerRangeEventState> CustomPlayerRangeEventsInternal)
		{
			this.GroupType = GroupType;
			this.SupportedPlatforms = SupportedPlatforms;
			this.bRegisterGameBudgetTick = bRegisterGameBudgetTick;
			this.bRegisterGameBudgetAfterTick = bRegisterGameBudgetAfterTick;
			this.bRegisterOnEnableChangeEvent = bRegisterOnEnableChangeEvent;
			this.bRegisterOnVisibilityChangeEvent = bRegisterOnVisibilityChangeEvent;
			this.bRegisterOnEnvInteractChangeEvent = bRegisterOnEnvInteractChangeEvent;
			this.bRegisterOnApplyWorldOffsetEvent = bRegisterOnApplyWorldOffsetEvent;
			this.bSyncComponentTick = bSyncComponentTick;
			this.bUseBoundsCalculateDistance = bUseBoundsCalculateDistance;
			this.bUseScreenRadiusCalculateTickInterval = bUseScreenRadiusCalculateTickInterval;
			this.bUseWasRecentlyPassVisibilityTest = bUseWasRecentlyPassVisibilityTest;
			this.bOverrideLocationProxy = bOverrideLocationProxy;
			this.bUseCustomPlayerRange = bUseCustomPlayerRange;
			this.CustomPlayerEnterRange = CustomPlayerEnterRange;
			this.CustomPlayerLeaveRange = CustomPlayerLeaveRange;
			this.CustomPlayerRanges = CustomPlayerRanges;
			this.CustomPlayerRangeEventsInternal = CustomPlayerRangeEventsInternal;
		}

		// Token: 0x06016FF3 RID: 94195 RVA: 0x00218890 File Offset: 0x00216A90
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGameBudgetBlueprint.StaticStruct();
		}

		// Token: 0x06016FF4 RID: 94196 RVA: 0x0021889C File Offset: 0x00216A9C
		[NullableContext(2)]
		public FKuroGameBudgetBlueprint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016FF5 RID: 94197 RVA: 0x002188A6 File Offset: 0x00216AA6
		public FKuroGameBudgetBlueprint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016FF6 RID: 94198 RVA: 0x002188B1 File Offset: 0x00216AB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGameBudgetBlueprint(Pointer, false, true);
		}

		// Token: 0x06016FF7 RID: 94199 RVA: 0x002188BB File Offset: 0x00216ABB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGameBudgetBlueprint(Pointer, MemoryOwner);
		}

		// Token: 0x0400C7C3 RID: 51139
		public const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetBlueprint";

		// Token: 0x0400C7C4 RID: 51140
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C7C5 RID: 51141
		internal static int __PropertyOffset_GroupType;

		// Token: 0x0400C7C6 RID: 51142
		internal static int __PropertyOffset_SupportedPlatforms;

		// Token: 0x0400C7C7 RID: 51143
		internal static int __PropertyOffset_bRegisterGameBudgetTick;

		// Token: 0x0400C7C8 RID: 51144
		internal static int __PropertyOffset_bRegisterGameBudgetAfterTick;

		// Token: 0x0400C7C9 RID: 51145
		internal static int __PropertyOffset_bRegisterOnEnableChangeEvent;

		// Token: 0x0400C7CA RID: 51146
		internal static int __PropertyOffset_bRegisterOnVisibilityChangeEvent;

		// Token: 0x0400C7CB RID: 51147
		internal static int __PropertyOffset_bRegisterOnEnvInteractChangeEvent;

		// Token: 0x0400C7CC RID: 51148
		internal static int __PropertyOffset_bRegisterOnApplyWorldOffsetEvent;

		// Token: 0x0400C7CD RID: 51149
		internal static int __PropertyOffset_bSyncComponentTick;

		// Token: 0x0400C7CE RID: 51150
		internal static int __PropertyOffset_bUseBoundsCalculateDistance;

		// Token: 0x0400C7CF RID: 51151
		internal static int __PropertyOffset_bUseScreenRadiusCalculateTickInterval;

		// Token: 0x0400C7D0 RID: 51152
		internal static int __PropertyOffset_bUseWasRecentlyPassVisibilityTest;

		// Token: 0x0400C7D1 RID: 51153
		internal static int __PropertyOffset_bOverrideLocationProxy;

		// Token: 0x0400C7D2 RID: 51154
		internal static int __PropertyOffset_bUseCustomPlayerRange;

		// Token: 0x0400C7D3 RID: 51155
		internal static int __PropertyOffset_CustomPlayerEnterRange;

		// Token: 0x0400C7D4 RID: 51156
		internal static int __PropertyOffset_CustomPlayerLeaveRange;

		// Token: 0x0400C7D5 RID: 51157
		internal static int __PropertyOffset_CustomPlayerRanges;

		// Token: 0x0400C7D6 RID: 51158
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCustomPlayerRangeConfig> _CustomPlayerRanges;

		// Token: 0x0400C7D7 RID: 51159
		internal static int __PropertyOffset_CustomPlayerRangeEventsInternal;

		// Token: 0x0400C7D8 RID: 51160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FCustomPlayerRangeEventState> _CustomPlayerRangeEventsInternal;
	}
}
