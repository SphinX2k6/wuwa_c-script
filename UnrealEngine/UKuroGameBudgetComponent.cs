using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200186B RID: 6251
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetComponent")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKuroGameBudgetComponent : UActorComponent, IUnrealUObject, IUnrealObject, IInterface_KuroGameBudgetBlueprint, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601704A RID: 94282 RVA: 0x00218D76 File Offset: 0x00216F76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameBudgetComponent._ClassPtr;
		}

		// Token: 0x0601704B RID: 94283 RVA: 0x00218D82 File Offset: 0x00216F82
		int IInterface_KuroGameBudgetBlueprint.InterfaceOffset()
		{
			return UKuroGameBudgetComponent.__InterfaceOffset_IInterface_KuroGameBudgetBlueprint;
		}

		// Token: 0x0601704C RID: 94284 RVA: 0x00218D8C File Offset: 0x00216F8C
		public UKuroGameBudgetComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601704D RID: 94285 RVA: 0x00218DB4 File Offset: 0x00216FB4
		[NullableContext(1)]
		public UKuroGameBudgetComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C9E RID: 23710
		// (get) Token: 0x0601704E RID: 94286 RVA: 0x00218DE8 File Offset: 0x00216FE8
		// (set) Token: 0x0601704F RID: 94287 RVA: 0x00218E21 File Offset: 0x00217021
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
					result = (this._TickActorComponents = new TSet<UActorComponent>(base.NativePtr + (IntPtr)UKuroGameBudgetComponent.__PropertyOffset_TickActorComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TickActorComponents.CopyAssign(value);
			}
		}

		// Token: 0x17005C9F RID: 23711
		// (get) Token: 0x06017050 RID: 94288 RVA: 0x00218E30 File Offset: 0x00217030
		// (set) Token: 0x06017051 RID: 94289 RVA: 0x00218E69 File Offset: 0x00217069
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
					result = (this._GameBudgetBlueprint = new FKuroGameBudgetBlueprint(base.NativePtr + (IntPtr)UKuroGameBudgetComponent.__PropertyOffset_GameBudgetBlueprint, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGameBudgetBlueprint.StaticStruct(), base.NativePtr + (IntPtr)UKuroGameBudgetComponent.__PropertyOffset_GameBudgetBlueprint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CA0 RID: 23712
		// (get) Token: 0x06017052 RID: 94290 RVA: 0x00218E8A File Offset: 0x0021708A
		// (set) Token: 0x06017053 RID: 94291 RVA: 0x00218E9A File Offset: 0x0021709A
		public unsafe EGameBudgetBlueprintEnvironment GameBudgetBlueprintEnvironment
		{
			get
			{
				return (EGameBudgetBlueprintEnvironment)(*(base.NativePtr + (IntPtr)UKuroGameBudgetComponent.__PropertyOffset_GameBudgetBlueprintEnvironment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGameBudgetComponent.__PropertyOffset_GameBudgetBlueprintEnvironment) = (byte)value;
			}
		}

		// Token: 0x06017054 RID: 94292 RVA: 0x00218EAB File Offset: 0x002170AB
		public void UpdateOverrideBoundsFromSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<AActor> InActors)
		{
			UKuroGameBudgetComponent.__UpdateOverrideBoundsFromSet_Internal(base.NativePtr, (InActors ?? new TSet<AActor>()).NativeSetPtr);
		}

		// Token: 0x06017055 RID: 94293 RVA: 0x00218EC7 File Offset: 0x002170C7
		public void UpdateOverrideBounds([Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> InActors)
		{
			UKuroGameBudgetComponent.__UpdateOverrideBounds_Internal(base.NativePtr, (InActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06017056 RID: 94294 RVA: 0x00218EE3 File Offset: 0x002170E3
		public void ResumeGameBudget()
		{
			UKuroGameBudgetComponent.__ResumeGameBudget_Internal(base.NativePtr);
		}

		// Token: 0x06017057 RID: 94295 RVA: 0x00218EF0 File Offset: 0x002170F0
		public void RegisterOnceTickWithPaused()
		{
			UKuroGameBudgetComponent.__RegisterOnceTickWithPaused_Internal(base.NativePtr);
		}

		// Token: 0x06017058 RID: 94296 RVA: 0x00218EFD File Offset: 0x002170FD
		public void PauseGameBudget()
		{
			UKuroGameBudgetComponent.__PauseGameBudget_Internal(base.NativePtr);
		}

		// Token: 0x06017059 RID: 94297 RVA: 0x00218F0A File Offset: 0x0021710A
		public void OverrideUseWasRecentlyPassVisibilityTest(bool bUseWasRecentlyPassVisibilityTest)
		{
			UKuroGameBudgetComponent.__OverrideUseWasRecentlyPassVisibilityTest_Internal(base.NativePtr, bUseWasRecentlyPassVisibilityTest);
		}

		// Token: 0x0601705A RID: 94298 RVA: 0x00218F18 File Offset: 0x00217118
		public void OverrideTickWithPaused(bool bTickWithPaused)
		{
			UKuroGameBudgetComponent.__OverrideTickWithPaused_Internal(base.NativePtr, bTickWithPaused);
		}

		// Token: 0x0601705B RID: 94299 RVA: 0x00218F26 File Offset: 0x00217126
		public void OverrideLocationProxy(bool bInOverrideLocationProxy)
		{
			UKuroGameBudgetComponent.__OverrideLocationProxy_Internal(base.NativePtr, bInOverrideLocationProxy);
		}

		// Token: 0x0601705C RID: 94300 RVA: 0x00218F34 File Offset: 0x00217134
		public void OverrideGameBudgetGroupType(EGameBudgetBlueprintGroup InOverrideGroupType)
		{
			UKuroGameBudgetComponent.__OverrideGameBudgetGroupType_Internal(base.NativePtr, InOverrideGroupType);
		}

		// Token: 0x0601705D RID: 94301 RVA: 0x00218F42 File Offset: 0x00217142
		public virtual void OnVisible()
		{
			UKuroGameBudgetComponent.__OnVisible_Internal(base.NativePtr);
		}

		// Token: 0x0601705E RID: 94302 RVA: 0x00218F4F File Offset: 0x0021714F
		public virtual void OnLogicEnable()
		{
			UKuroGameBudgetComponent.__OnLogicEnable_Internal(base.NativePtr);
		}

		// Token: 0x0601705F RID: 94303 RVA: 0x00218F5C File Offset: 0x0021715C
		public virtual void OnLogicDisable()
		{
			UKuroGameBudgetComponent.__OnLogicDisable_Internal(base.NativePtr);
		}

		// Token: 0x06017060 RID: 94304 RVA: 0x00218F69 File Offset: 0x00217169
		public virtual void OnInvisible()
		{
			UKuroGameBudgetComponent.__OnInvisible_Internal(base.NativePtr);
		}

		// Token: 0x06017061 RID: 94305 RVA: 0x00218F76 File Offset: 0x00217176
		public virtual void OnEnvInteractChanged(bool bEnableEnvInteract)
		{
			UKuroGameBudgetComponent.__OnEnvInteractChanged_Internal(base.NativePtr, bEnableEnvInteract);
		}

		// Token: 0x06017062 RID: 94306 RVA: 0x00218F84 File Offset: 0x00217184
		public virtual void OnApplyWorldOffset(in FVector InWorldOffset, bool bWorldShift)
		{
			UKuroGameBudgetComponent.__OnApplyWorldOffset_Internal(base.NativePtr, InWorldOffset, bWorldShift);
		}

		// Token: 0x06017063 RID: 94307 RVA: 0x00218F93 File Offset: 0x00217193
		public void MarkSpecialBlueprintActor()
		{
			UKuroGameBudgetComponent.__MarkSpecialBlueprintActor_Internal(base.NativePtr);
		}

		// Token: 0x06017064 RID: 94308 RVA: 0x00218FA0 File Offset: 0x002171A0
		public void ManualUnregisterTick()
		{
			UKuroGameBudgetComponent.__ManualUnregisterTick_Internal(base.NativePtr);
		}

		// Token: 0x06017065 RID: 94309 RVA: 0x00218FAD File Offset: 0x002171AD
		public void ManualRegisterTick()
		{
			UKuroGameBudgetComponent.__ManualRegisterTick_Internal(base.NativePtr);
		}

		// Token: 0x06017066 RID: 94310 RVA: 0x00218FBA File Offset: 0x002171BA
		public virtual FVectorDouble K2_GetGameBudgetLocationProxy()
		{
			return UKuroGameBudgetComponent.__K2_GetGameBudgetLocationProxy_Internal(base.NativePtr);
		}

		// Token: 0x06017067 RID: 94311 RVA: 0x00218FC7 File Offset: 0x002171C7
		protected virtual FVectorDouble K2_GetGameBudgetLocationProxy_Implementation()
		{
			return UKuroGameBudgetComponent.__K2_GetGameBudgetLocationProxy_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06017068 RID: 94312 RVA: 0x00218FD4 File Offset: 0x002171D4
		public virtual void AfterTick(float DeltaSeconds)
		{
			UKuroGameBudgetComponent.__AfterTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06017069 RID: 94313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateOverrideBoundsFromSet_Internal(IntPtr @this, IntPtr InActors);

		// Token: 0x0601706A RID: 94314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateOverrideBounds_Internal(IntPtr @this, IntPtr InActors);

		// Token: 0x0601706B RID: 94315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeGameBudget_Internal(IntPtr @this);

		// Token: 0x0601706C RID: 94316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterOnceTickWithPaused_Internal(IntPtr @this);

		// Token: 0x0601706D RID: 94317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseGameBudget_Internal(IntPtr @this);

		// Token: 0x0601706E RID: 94318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideUseWasRecentlyPassVisibilityTest_Internal(IntPtr @this, bool bUseWasRecentlyPassVisibilityTest);

		// Token: 0x0601706F RID: 94319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideTickWithPaused_Internal(IntPtr @this, bool bTickWithPaused);

		// Token: 0x06017070 RID: 94320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideLocationProxy_Internal(IntPtr @this, bool bInOverrideLocationProxy);

		// Token: 0x06017071 RID: 94321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideGameBudgetGroupType_Internal(IntPtr @this, EGameBudgetBlueprintGroup InOverrideGroupType);

		// Token: 0x06017072 RID: 94322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnVisible_Internal(IntPtr @this);

		// Token: 0x06017073 RID: 94323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLogicEnable_Internal(IntPtr @this);

		// Token: 0x06017074 RID: 94324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLogicDisable_Internal(IntPtr @this);

		// Token: 0x06017075 RID: 94325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnInvisible_Internal(IntPtr @this);

		// Token: 0x06017076 RID: 94326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnEnvInteractChanged_Internal(IntPtr @this, bool bEnableEnvInteract);

		// Token: 0x06017077 RID: 94327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnApplyWorldOffset_Internal(IntPtr @this, in FVector InWorldOffset, bool bWorldShift);

		// Token: 0x06017078 RID: 94328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkSpecialBlueprintActor_Internal(IntPtr @this);

		// Token: 0x06017079 RID: 94329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualUnregisterTick_Internal(IntPtr @this);

		// Token: 0x0601707A RID: 94330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualRegisterTick_Internal(IntPtr @this);

		// Token: 0x0601707B RID: 94331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __K2_GetGameBudgetLocationProxy_Internal(IntPtr @this);

		// Token: 0x0601707C RID: 94332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __K2_GetGameBudgetLocationProxy_Implementation_Internal(IntPtr @this);

		// Token: 0x0601707D RID: 94333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AfterTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601707E RID: 94334 RVA: 0x00218FE2 File Offset: 0x002171E2
		static UKuroGameBudgetComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetComponent");
		}

		// Token: 0x0601707F RID: 94335 RVA: 0x00218FF0 File Offset: 0x002171F0
		protected UKuroGameBudgetComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C7EB RID: 51179
		internal static int __InterfaceOffset_IInterface_KuroGameBudgetBlueprint;

		// Token: 0x0400C7EC RID: 51180
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetComponent";

		// Token: 0x0400C7ED RID: 51181
		private static IntPtr _ClassPtr;

		// Token: 0x0400C7EE RID: 51182
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C7EF RID: 51183
		internal static int __PropertyOffset_TickActorComponents;

		// Token: 0x0400C7F0 RID: 51184
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UActorComponent> _TickActorComponents;

		// Token: 0x0400C7F1 RID: 51185
		internal static int __PropertyOffset_GameBudgetBlueprint;

		// Token: 0x0400C7F2 RID: 51186
		[Nullable(2)]
		private FKuroGameBudgetBlueprint _GameBudgetBlueprint;

		// Token: 0x0400C7F3 RID: 51187
		internal static int __PropertyOffset_GameBudgetBlueprintEnvironment;

		// Token: 0x02002F77 RID: 12151
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnEnvInteractChanged_FunctionParams
		{
			// Token: 0x04016B33 RID: 92979
			[FieldOffset(0)]
			public bool bEnableEnvInteract;
		}

		// Token: 0x02002F78 RID: 12152
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnApplyWorldOffset_FunctionParams
		{
			// Token: 0x04016B34 RID: 92980
			[FieldOffset(0)]
			public FVector InWorldOffset;

			// Token: 0x04016B35 RID: 92981
			[FieldOffset(12)]
			public bool bWorldShift;
		}

		// Token: 0x02002F79 RID: 12153
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_GetGameBudgetLocationProxy_FunctionParams
		{
			// Token: 0x04016B36 RID: 92982
			[FieldOffset(0)]
			public FVectorDouble __Result;
		}

		// Token: 0x02002F7A RID: 12154
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __AfterTick_FunctionParams
		{
			// Token: 0x04016B37 RID: 92983
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
