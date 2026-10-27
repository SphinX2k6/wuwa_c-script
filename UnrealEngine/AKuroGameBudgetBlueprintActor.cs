using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001868 RID: 6248
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetBlueprintActor")]
	[UnrealStructLayout(1424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1424)]
	public class AKuroGameBudgetBlueprintActor : AActor, IUnrealUObject, IUnrealObject, IInterface_KuroGameBudgetBlueprint, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06016FF8 RID: 94200 RVA: 0x002188C4 File Offset: 0x00216AC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroGameBudgetBlueprintActor._ClassPtr;
		}

		// Token: 0x06016FF9 RID: 94201 RVA: 0x002188D0 File Offset: 0x00216AD0
		int IInterface_KuroGameBudgetBlueprint.InterfaceOffset()
		{
			return AKuroGameBudgetBlueprintActor.__InterfaceOffset_IInterface_KuroGameBudgetBlueprint;
		}

		// Token: 0x06016FFA RID: 94202 RVA: 0x002188D8 File Offset: 0x00216AD8
		public AKuroGameBudgetBlueprintActor() : this(BuiltinUtils.AllocNativeUObject(AKuroGameBudgetBlueprintActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016FFB RID: 94203 RVA: 0x00218900 File Offset: 0x00216B00
		[NullableContext(1)]
		public AKuroGameBudgetBlueprintActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroGameBudgetBlueprintActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C9A RID: 23706
		// (get) Token: 0x06016FFC RID: 94204 RVA: 0x00218934 File Offset: 0x00216B34
		// (set) Token: 0x06016FFD RID: 94205 RVA: 0x0021896D File Offset: 0x00216B6D
		[Nullable(1)]
		public TSet<UActorComponent> TickActorComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<UActorComponent> result;
				if ((result = this._TickActorComponents) == null)
				{
					result = (this._TickActorComponents = new TSet<UActorComponent>(base.NativePtr + (IntPtr)AKuroGameBudgetBlueprintActor.__PropertyOffset_TickActorComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TickActorComponents.CopyAssign(value);
			}
		}

		// Token: 0x17005C9B RID: 23707
		// (get) Token: 0x06016FFE RID: 94206 RVA: 0x0021897B File Offset: 0x00216B7B
		// (set) Token: 0x06016FFF RID: 94207 RVA: 0x0021898F File Offset: 0x00216B8F
		[Nullable(2)]
		public unsafe UKuroGameBudgetBoundsComponent GameBudgetBoundsComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetBoundsComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGameBudgetBlueprintActor.__PropertyOffset_GameBudgetBoundsComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGameBudgetBlueprintActor.__PropertyOffset_GameBudgetBoundsComponent, value);
			}
		}

		// Token: 0x17005C9C RID: 23708
		// (get) Token: 0x06017000 RID: 94208 RVA: 0x002189A4 File Offset: 0x00216BA4
		// (set) Token: 0x06017001 RID: 94209 RVA: 0x002189DD File Offset: 0x00216BDD
		[Nullable(1)]
		public FKuroGameBudgetBlueprint GameBudgetBlueprint
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroGameBudgetBlueprint result;
				if ((result = this._GameBudgetBlueprint) == null)
				{
					result = (this._GameBudgetBlueprint = new FKuroGameBudgetBlueprint(base.NativePtr + (IntPtr)AKuroGameBudgetBlueprintActor.__PropertyOffset_GameBudgetBlueprint, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGameBudgetBlueprint.StaticStruct(), base.NativePtr + (IntPtr)AKuroGameBudgetBlueprintActor.__PropertyOffset_GameBudgetBlueprint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005C9D RID: 23709
		// (get) Token: 0x06017002 RID: 94210 RVA: 0x002189FE File Offset: 0x00216BFE
		// (set) Token: 0x06017003 RID: 94211 RVA: 0x00218A0E File Offset: 0x00216C0E
		public unsafe EGameBudgetBlueprintEnvironment GameBudgetBlueprintEnvironment
		{
			get
			{
				return (EGameBudgetBlueprintEnvironment)(*(base.NativePtr + (IntPtr)AKuroGameBudgetBlueprintActor.__PropertyOffset_GameBudgetBlueprintEnvironment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGameBudgetBlueprintActor.__PropertyOffset_GameBudgetBlueprintEnvironment) = (byte)value;
			}
		}

		// Token: 0x06017004 RID: 94212 RVA: 0x00218A1F File Offset: 0x00216C1F
		public void UpdateSimpleCustomPlayerRangeDistance(float EnterRange, float LeaveRange)
		{
			AKuroGameBudgetBlueprintActor.__UpdateSimpleCustomPlayerRangeDistance_Internal(base.NativePtr, EnterRange, LeaveRange);
		}

		// Token: 0x06017005 RID: 94213 RVA: 0x00218A2E File Offset: 0x00216C2E
		public void UpdateOverrideBoundsFromSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<AActor> InActors)
		{
			AKuroGameBudgetBlueprintActor.__UpdateOverrideBoundsFromSet_Internal(base.NativePtr, (InActors ?? new TSet<AActor>()).NativeSetPtr);
		}

		// Token: 0x06017006 RID: 94214 RVA: 0x00218A4A File Offset: 0x00216C4A
		public void UpdateOverrideBounds([Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> InActors)
		{
			AKuroGameBudgetBlueprintActor.__UpdateOverrideBounds_Internal(base.NativePtr, (InActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06017007 RID: 94215 RVA: 0x00218A66 File Offset: 0x00216C66
		public void UpdateCustomPlayerRangeDistance(FName RangeName, float EnterRange, float LeaveRange)
		{
			AKuroGameBudgetBlueprintActor.__UpdateCustomPlayerRangeDistance_Internal(base.NativePtr, RangeName, EnterRange, LeaveRange);
		}

		// Token: 0x06017008 RID: 94216 RVA: 0x00218A76 File Offset: 0x00216C76
		public void UnregisterCustomPlayerRangeEvent(FName RangeName)
		{
			AKuroGameBudgetBlueprintActor.__UnregisterCustomPlayerRangeEvent_Internal(base.NativePtr, RangeName);
		}

		// Token: 0x06017009 RID: 94217 RVA: 0x00218A84 File Offset: 0x00216C84
		public void SetCustomPlayerRangeEnabled(bool bEnabled)
		{
			AKuroGameBudgetBlueprintActor.__SetCustomPlayerRangeEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x0601700A RID: 94218 RVA: 0x00218A92 File Offset: 0x00216C92
		public void ResumeGameBudget()
		{
			AKuroGameBudgetBlueprintActor.__ResumeGameBudget_Internal(base.NativePtr);
		}

		// Token: 0x0601700B RID: 94219 RVA: 0x00218A9F File Offset: 0x00216C9F
		public void RegisterOnceTickWithPaused()
		{
			AKuroGameBudgetBlueprintActor.__RegisterOnceTickWithPaused_Internal(base.NativePtr);
		}

		// Token: 0x0601700C RID: 94220 RVA: 0x00218AAC File Offset: 0x00216CAC
		[NullableContext(2)]
		public void RegisterCustomPlayerRangeEvent(FName RangeName, FCustomPlayerRangeEnterEvent OnEnter, FCustomPlayerRangeLeaveEvent OnLeave)
		{
			AKuroGameBudgetBlueprintActor.__RegisterCustomPlayerRangeEvent_Internal(base.NativePtr, RangeName, (OnEnter != null) ? OnEnter.NativePtr : ((IntPtr)0), (OnLeave != null) ? OnLeave.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601700D RID: 94221 RVA: 0x00218AD4 File Offset: 0x00216CD4
		public void PauseGameBudget()
		{
			AKuroGameBudgetBlueprintActor.__PauseGameBudget_Internal(base.NativePtr);
		}

		// Token: 0x0601700E RID: 94222 RVA: 0x00218AE1 File Offset: 0x00216CE1
		public void OverrideUseWasRecentlyPassVisibilityTest(bool bUseWasRecentlyPassVisibilityTest)
		{
			AKuroGameBudgetBlueprintActor.__OverrideUseWasRecentlyPassVisibilityTest_Internal(base.NativePtr, bUseWasRecentlyPassVisibilityTest);
		}

		// Token: 0x0601700F RID: 94223 RVA: 0x00218AEF File Offset: 0x00216CEF
		public void OverrideTickWithPaused(bool bTickWithPaused)
		{
			AKuroGameBudgetBlueprintActor.__OverrideTickWithPaused_Internal(base.NativePtr, bTickWithPaused);
		}

		// Token: 0x06017010 RID: 94224 RVA: 0x00218AFD File Offset: 0x00216CFD
		public void OverrideLocationProxy(bool bInOverrideLocationProxy)
		{
			AKuroGameBudgetBlueprintActor.__OverrideLocationProxy_Internal(base.NativePtr, bInOverrideLocationProxy);
		}

		// Token: 0x06017011 RID: 94225 RVA: 0x00218B0B File Offset: 0x00216D0B
		public void OverrideGameBudgetGroupType(EGameBudgetBlueprintGroup InOverrideGroupType)
		{
			AKuroGameBudgetBlueprintActor.__OverrideGameBudgetGroupType_Internal(base.NativePtr, InOverrideGroupType);
		}

		// Token: 0x06017012 RID: 94226 RVA: 0x00218B19 File Offset: 0x00216D19
		public virtual void OnVisible()
		{
			AKuroGameBudgetBlueprintActor.__OnVisible_Internal(base.NativePtr);
		}

		// Token: 0x06017013 RID: 94227 RVA: 0x00218B26 File Offset: 0x00216D26
		public virtual void OnLogicEnable()
		{
			AKuroGameBudgetBlueprintActor.__OnLogicEnable_Internal(base.NativePtr);
		}

		// Token: 0x06017014 RID: 94228 RVA: 0x00218B33 File Offset: 0x00216D33
		public virtual void OnLogicDisable()
		{
			AKuroGameBudgetBlueprintActor.__OnLogicDisable_Internal(base.NativePtr);
		}

		// Token: 0x06017015 RID: 94229 RVA: 0x00218B40 File Offset: 0x00216D40
		public virtual void OnInvisible()
		{
			AKuroGameBudgetBlueprintActor.__OnInvisible_Internal(base.NativePtr);
		}

		// Token: 0x06017016 RID: 94230 RVA: 0x00218B4D File Offset: 0x00216D4D
		public virtual void OnEnvInteractChanged(bool bEnableEnvInteract)
		{
			AKuroGameBudgetBlueprintActor.__OnEnvInteractChanged_Internal(base.NativePtr, bEnableEnvInteract);
		}

		// Token: 0x06017017 RID: 94231 RVA: 0x00218B5B File Offset: 0x00216D5B
		public virtual void OnCustomPlayerRangeLeave()
		{
			AKuroGameBudgetBlueprintActor.__OnCustomPlayerRangeLeave_Internal(base.NativePtr);
		}

		// Token: 0x06017018 RID: 94232 RVA: 0x00218B68 File Offset: 0x00216D68
		public virtual void OnCustomPlayerRangeEnter()
		{
			AKuroGameBudgetBlueprintActor.__OnCustomPlayerRangeEnter_Internal(base.NativePtr);
		}

		// Token: 0x06017019 RID: 94233 RVA: 0x00218B75 File Offset: 0x00216D75
		public virtual void OnApplyWorldOffset(in FVector InWorldOffset, bool bWorldShift)
		{
			AKuroGameBudgetBlueprintActor.__OnApplyWorldOffset_Internal(base.NativePtr, InWorldOffset, bWorldShift);
		}

		// Token: 0x0601701A RID: 94234 RVA: 0x00218B84 File Offset: 0x00216D84
		public void MarkSpecialBlueprintActor()
		{
			AKuroGameBudgetBlueprintActor.__MarkSpecialBlueprintActor_Internal(base.NativePtr);
		}

		// Token: 0x0601701B RID: 94235 RVA: 0x00218B91 File Offset: 0x00216D91
		public void ManualUnregisterTick()
		{
			AKuroGameBudgetBlueprintActor.__ManualUnregisterTick_Internal(base.NativePtr);
		}

		// Token: 0x0601701C RID: 94236 RVA: 0x00218B9E File Offset: 0x00216D9E
		public void ManualRegisterTick()
		{
			AKuroGameBudgetBlueprintActor.__ManualRegisterTick_Internal(base.NativePtr);
		}

		// Token: 0x0601701D RID: 94237 RVA: 0x00218BAB File Offset: 0x00216DAB
		public virtual FVectorDouble K2_GetGameBudgetLocationProxy()
		{
			return AKuroGameBudgetBlueprintActor.__K2_GetGameBudgetLocationProxy_Internal(base.NativePtr);
		}

		// Token: 0x0601701E RID: 94238 RVA: 0x00218BB8 File Offset: 0x00216DB8
		protected virtual FVectorDouble K2_GetGameBudgetLocationProxy_Implementation()
		{
			return AKuroGameBudgetBlueprintActor.__K2_GetGameBudgetLocationProxy_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601701F RID: 94239 RVA: 0x00218BC5 File Offset: 0x00216DC5
		public virtual void AfterTick(float DeltaSeconds)
		{
			AKuroGameBudgetBlueprintActor.__AfterTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06017020 RID: 94240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateSimpleCustomPlayerRangeDistance_Internal(IntPtr @this, float EnterRange, float LeaveRange);

		// Token: 0x06017021 RID: 94241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateOverrideBoundsFromSet_Internal(IntPtr @this, IntPtr InActors);

		// Token: 0x06017022 RID: 94242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateOverrideBounds_Internal(IntPtr @this, IntPtr InActors);

		// Token: 0x06017023 RID: 94243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCustomPlayerRangeDistance_Internal(IntPtr @this, FName RangeName, float EnterRange, float LeaveRange);

		// Token: 0x06017024 RID: 94244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterCustomPlayerRangeEvent_Internal(IntPtr @this, FName RangeName);

		// Token: 0x06017025 RID: 94245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPlayerRangeEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06017026 RID: 94246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeGameBudget_Internal(IntPtr @this);

		// Token: 0x06017027 RID: 94247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterOnceTickWithPaused_Internal(IntPtr @this);

		// Token: 0x06017028 RID: 94248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterCustomPlayerRangeEvent_Internal(IntPtr @this, FName RangeName, IntPtr OnEnter, IntPtr OnLeave);

		// Token: 0x06017029 RID: 94249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseGameBudget_Internal(IntPtr @this);

		// Token: 0x0601702A RID: 94250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideUseWasRecentlyPassVisibilityTest_Internal(IntPtr @this, bool bUseWasRecentlyPassVisibilityTest);

		// Token: 0x0601702B RID: 94251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideTickWithPaused_Internal(IntPtr @this, bool bTickWithPaused);

		// Token: 0x0601702C RID: 94252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideLocationProxy_Internal(IntPtr @this, bool bInOverrideLocationProxy);

		// Token: 0x0601702D RID: 94253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideGameBudgetGroupType_Internal(IntPtr @this, EGameBudgetBlueprintGroup InOverrideGroupType);

		// Token: 0x0601702E RID: 94254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnVisible_Internal(IntPtr @this);

		// Token: 0x0601702F RID: 94255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLogicEnable_Internal(IntPtr @this);

		// Token: 0x06017030 RID: 94256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLogicDisable_Internal(IntPtr @this);

		// Token: 0x06017031 RID: 94257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnInvisible_Internal(IntPtr @this);

		// Token: 0x06017032 RID: 94258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnEnvInteractChanged_Internal(IntPtr @this, bool bEnableEnvInteract);

		// Token: 0x06017033 RID: 94259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCustomPlayerRangeLeave_Internal(IntPtr @this);

		// Token: 0x06017034 RID: 94260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCustomPlayerRangeEnter_Internal(IntPtr @this);

		// Token: 0x06017035 RID: 94261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnApplyWorldOffset_Internal(IntPtr @this, in FVector InWorldOffset, bool bWorldShift);

		// Token: 0x06017036 RID: 94262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkSpecialBlueprintActor_Internal(IntPtr @this);

		// Token: 0x06017037 RID: 94263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualUnregisterTick_Internal(IntPtr @this);

		// Token: 0x06017038 RID: 94264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualRegisterTick_Internal(IntPtr @this);

		// Token: 0x06017039 RID: 94265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __K2_GetGameBudgetLocationProxy_Internal(IntPtr @this);

		// Token: 0x0601703A RID: 94266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __K2_GetGameBudgetLocationProxy_Implementation_Internal(IntPtr @this);

		// Token: 0x0601703B RID: 94267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AfterTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601703C RID: 94268 RVA: 0x00218BD3 File Offset: 0x00216DD3
		static AKuroGameBudgetBlueprintActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetBlueprintActor");
		}

		// Token: 0x0601703D RID: 94269 RVA: 0x00218BE1 File Offset: 0x00216DE1
		protected AKuroGameBudgetBlueprintActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C7D9 RID: 51161
		internal static int __InterfaceOffset_IInterface_KuroGameBudgetBlueprint;

		// Token: 0x0400C7DA RID: 51162
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetBlueprintActor";

		// Token: 0x0400C7DB RID: 51163
		private static IntPtr _ClassPtr;

		// Token: 0x0400C7DC RID: 51164
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C7DD RID: 51165
		internal static int __PropertyOffset_TickActorComponents;

		// Token: 0x0400C7DE RID: 51166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UActorComponent> _TickActorComponents;

		// Token: 0x0400C7DF RID: 51167
		internal static int __PropertyOffset_GameBudgetBoundsComponent;

		// Token: 0x0400C7E0 RID: 51168
		internal static int __PropertyOffset_GameBudgetBlueprint;

		// Token: 0x0400C7E1 RID: 51169
		[Nullable(2)]
		private FKuroGameBudgetBlueprint _GameBudgetBlueprint;

		// Token: 0x0400C7E2 RID: 51170
		internal static int __PropertyOffset_GameBudgetBlueprintEnvironment;

		// Token: 0x02002F72 RID: 12146
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnEnvInteractChanged_FunctionParams
		{
			// Token: 0x04016B2D RID: 92973
			[FieldOffset(0)]
			public bool bEnableEnvInteract;
		}

		// Token: 0x02002F73 RID: 12147
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnApplyWorldOffset_FunctionParams
		{
			// Token: 0x04016B2E RID: 92974
			[FieldOffset(0)]
			public FVector InWorldOffset;

			// Token: 0x04016B2F RID: 92975
			[FieldOffset(12)]
			public bool bWorldShift;
		}

		// Token: 0x02002F74 RID: 12148
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_GetGameBudgetLocationProxy_FunctionParams
		{
			// Token: 0x04016B30 RID: 92976
			[FieldOffset(0)]
			public FVectorDouble __Result;
		}

		// Token: 0x02002F75 RID: 12149
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __AfterTick_FunctionParams
		{
			// Token: 0x04016B31 RID: 92977
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
