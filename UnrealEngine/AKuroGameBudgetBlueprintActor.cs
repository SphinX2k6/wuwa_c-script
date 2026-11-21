using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039A RID: 922
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetBlueprintActor")]
	[UnrealStructLayout(1424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1424)]
	public class AKuroGameBudgetBlueprintActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005B79 RID: 23417 RVA: 0x00080FD3 File Offset: 0x0007F1D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroGameBudgetBlueprintActor._ClassPtr;
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x00080FE0 File Offset: 0x0007F1E0
		public AKuroGameBudgetBlueprintActor() : this(BuiltinUtils.AllocNativeUObject(AKuroGameBudgetBlueprintActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x00081008 File Offset: 0x0007F208
		[NullableContext(1)]
		public AKuroGameBudgetBlueprintActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroGameBudgetBlueprintActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06005B7C RID: 23420 RVA: 0x0008103C File Offset: 0x0007F23C
		// (set) Token: 0x06005B7D RID: 23421 RVA: 0x00081075 File Offset: 0x0007F275
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

		// Token: 0x06005B7E RID: 23422 RVA: 0x00081083 File Offset: 0x0007F283
		public void UpdateSimpleCustomPlayerRangeDistance(float EnterRange, float LeaveRange)
		{
			AKuroGameBudgetBlueprintActor.__UpdateSimpleCustomPlayerRangeDistance_Internal(base.NativePtr, EnterRange, LeaveRange);
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x00081092 File Offset: 0x0007F292
		public void UpdateOverrideBoundsFromSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<AActor> InActors)
		{
			AKuroGameBudgetBlueprintActor.__UpdateOverrideBoundsFromSet_Internal(base.NativePtr, (InActors ?? new TSet<AActor>()).NativeSetPtr);
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x000810AE File Offset: 0x0007F2AE
		public void UpdateOverrideBounds([Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> InActors)
		{
			AKuroGameBudgetBlueprintActor.__UpdateOverrideBounds_Internal(base.NativePtr, (InActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x000810CA File Offset: 0x0007F2CA
		public void UpdateCustomPlayerRangeDistance(FName RangeName, float EnterRange, float LeaveRange)
		{
			AKuroGameBudgetBlueprintActor.__UpdateCustomPlayerRangeDistance_Internal(base.NativePtr, RangeName, EnterRange, LeaveRange);
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x000810DA File Offset: 0x0007F2DA
		public void UnregisterCustomPlayerRangeEvent(FName RangeName)
		{
			AKuroGameBudgetBlueprintActor.__UnregisterCustomPlayerRangeEvent_Internal(base.NativePtr, RangeName);
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x000810E8 File Offset: 0x0007F2E8
		public void SetCustomPlayerRangeEnabled(bool bEnabled)
		{
			AKuroGameBudgetBlueprintActor.__SetCustomPlayerRangeEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x000810F6 File Offset: 0x0007F2F6
		public void ResumeGameBudget()
		{
			AKuroGameBudgetBlueprintActor.__ResumeGameBudget_Internal(base.NativePtr);
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00081103 File Offset: 0x0007F303
		public void RegisterOnceTickWithPaused()
		{
			AKuroGameBudgetBlueprintActor.__RegisterOnceTickWithPaused_Internal(base.NativePtr);
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x00081110 File Offset: 0x0007F310
		[NullableContext(2)]
		public void RegisterCustomPlayerRangeEvent(FName RangeName, FCustomPlayerRangeEnterEvent OnEnter, FCustomPlayerRangeLeaveEvent OnLeave)
		{
			AKuroGameBudgetBlueprintActor.__RegisterCustomPlayerRangeEvent_Internal(base.NativePtr, RangeName, (OnEnter != null) ? OnEnter.NativePtr : ((IntPtr)0), (OnLeave != null) ? OnLeave.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x00081138 File Offset: 0x0007F338
		public void PauseGameBudget()
		{
			AKuroGameBudgetBlueprintActor.__PauseGameBudget_Internal(base.NativePtr);
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x00081145 File Offset: 0x0007F345
		public void OverrideUseWasRecentlyPassVisibilityTest(bool bUseWasRecentlyPassVisibilityTest)
		{
			AKuroGameBudgetBlueprintActor.__OverrideUseWasRecentlyPassVisibilityTest_Internal(base.NativePtr, bUseWasRecentlyPassVisibilityTest);
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x00081153 File Offset: 0x0007F353
		public void OverrideTickWithPaused(bool bTickWithPaused)
		{
			AKuroGameBudgetBlueprintActor.__OverrideTickWithPaused_Internal(base.NativePtr, bTickWithPaused);
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x00081161 File Offset: 0x0007F361
		public void OverrideLocationProxy(bool bInOverrideLocationProxy)
		{
			AKuroGameBudgetBlueprintActor.__OverrideLocationProxy_Internal(base.NativePtr, bInOverrideLocationProxy);
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x0008116F File Offset: 0x0007F36F
		public void OverrideGameBudgetGroupType(EGameBudgetBlueprintGroup InOverrideGroupType)
		{
			AKuroGameBudgetBlueprintActor.__OverrideGameBudgetGroupType_Internal(base.NativePtr, InOverrideGroupType);
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x0008117D File Offset: 0x0007F37D
		public virtual void OnVisible()
		{
			AKuroGameBudgetBlueprintActor.__OnVisible_Internal(base.NativePtr);
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x0008118A File Offset: 0x0007F38A
		public virtual void OnLogicEnable()
		{
			AKuroGameBudgetBlueprintActor.__OnLogicEnable_Internal(base.NativePtr);
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x00081197 File Offset: 0x0007F397
		public virtual void OnLogicDisable()
		{
			AKuroGameBudgetBlueprintActor.__OnLogicDisable_Internal(base.NativePtr);
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x000811A4 File Offset: 0x0007F3A4
		public virtual void OnInvisible()
		{
			AKuroGameBudgetBlueprintActor.__OnInvisible_Internal(base.NativePtr);
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x000811B1 File Offset: 0x0007F3B1
		public virtual void OnEnvInteractChanged(bool bEnableEnvInteract)
		{
			AKuroGameBudgetBlueprintActor.__OnEnvInteractChanged_Internal(base.NativePtr, bEnableEnvInteract);
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x000811BF File Offset: 0x0007F3BF
		public virtual void OnCustomPlayerRangeLeave()
		{
			AKuroGameBudgetBlueprintActor.__OnCustomPlayerRangeLeave_Internal(base.NativePtr);
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x000811CC File Offset: 0x0007F3CC
		public virtual void OnCustomPlayerRangeEnter()
		{
			AKuroGameBudgetBlueprintActor.__OnCustomPlayerRangeEnter_Internal(base.NativePtr);
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x000811D9 File Offset: 0x0007F3D9
		public virtual void OnApplyWorldOffset(in FVector InWorldOffset, bool bWorldShift)
		{
			AKuroGameBudgetBlueprintActor.__OnApplyWorldOffset_Internal(base.NativePtr, InWorldOffset, bWorldShift);
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x000811E8 File Offset: 0x0007F3E8
		public void MarkSpecialBlueprintActor()
		{
			AKuroGameBudgetBlueprintActor.__MarkSpecialBlueprintActor_Internal(base.NativePtr);
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x000811F5 File Offset: 0x0007F3F5
		public void ManualUnregisterTick()
		{
			AKuroGameBudgetBlueprintActor.__ManualUnregisterTick_Internal(base.NativePtr);
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x00081202 File Offset: 0x0007F402
		public void ManualRegisterTick()
		{
			AKuroGameBudgetBlueprintActor.__ManualRegisterTick_Internal(base.NativePtr);
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x0008120F File Offset: 0x0007F40F
		public virtual FVectorDouble K2_GetGameBudgetLocationProxy()
		{
			return AKuroGameBudgetBlueprintActor.__K2_GetGameBudgetLocationProxy_Internal(base.NativePtr);
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x0008121C File Offset: 0x0007F41C
		protected virtual FVectorDouble K2_GetGameBudgetLocationProxy_Implementation()
		{
			return AKuroGameBudgetBlueprintActor.__K2_GetGameBudgetLocationProxy_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x00081229 File Offset: 0x0007F429
		public virtual void AfterTick(float DeltaSeconds)
		{
			AKuroGameBudgetBlueprintActor.__AfterTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06005B9A RID: 23450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateSimpleCustomPlayerRangeDistance_Internal(IntPtr @this, float EnterRange, float LeaveRange);

		// Token: 0x06005B9B RID: 23451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateOverrideBoundsFromSet_Internal(IntPtr @this, IntPtr InActors);

		// Token: 0x06005B9C RID: 23452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateOverrideBounds_Internal(IntPtr @this, IntPtr InActors);

		// Token: 0x06005B9D RID: 23453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCustomPlayerRangeDistance_Internal(IntPtr @this, FName RangeName, float EnterRange, float LeaveRange);

		// Token: 0x06005B9E RID: 23454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterCustomPlayerRangeEvent_Internal(IntPtr @this, FName RangeName);

		// Token: 0x06005B9F RID: 23455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomPlayerRangeEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06005BA0 RID: 23456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeGameBudget_Internal(IntPtr @this);

		// Token: 0x06005BA1 RID: 23457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterOnceTickWithPaused_Internal(IntPtr @this);

		// Token: 0x06005BA2 RID: 23458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterCustomPlayerRangeEvent_Internal(IntPtr @this, FName RangeName, IntPtr OnEnter, IntPtr OnLeave);

		// Token: 0x06005BA3 RID: 23459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseGameBudget_Internal(IntPtr @this);

		// Token: 0x06005BA4 RID: 23460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideUseWasRecentlyPassVisibilityTest_Internal(IntPtr @this, bool bUseWasRecentlyPassVisibilityTest);

		// Token: 0x06005BA5 RID: 23461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideTickWithPaused_Internal(IntPtr @this, bool bTickWithPaused);

		// Token: 0x06005BA6 RID: 23462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideLocationProxy_Internal(IntPtr @this, bool bInOverrideLocationProxy);

		// Token: 0x06005BA7 RID: 23463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideGameBudgetGroupType_Internal(IntPtr @this, EGameBudgetBlueprintGroup InOverrideGroupType);

		// Token: 0x06005BA8 RID: 23464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnVisible_Internal(IntPtr @this);

		// Token: 0x06005BA9 RID: 23465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLogicEnable_Internal(IntPtr @this);

		// Token: 0x06005BAA RID: 23466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLogicDisable_Internal(IntPtr @this);

		// Token: 0x06005BAB RID: 23467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnInvisible_Internal(IntPtr @this);

		// Token: 0x06005BAC RID: 23468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnEnvInteractChanged_Internal(IntPtr @this, bool bEnableEnvInteract);

		// Token: 0x06005BAD RID: 23469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCustomPlayerRangeLeave_Internal(IntPtr @this);

		// Token: 0x06005BAE RID: 23470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCustomPlayerRangeEnter_Internal(IntPtr @this);

		// Token: 0x06005BAF RID: 23471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnApplyWorldOffset_Internal(IntPtr @this, in FVector InWorldOffset, bool bWorldShift);

		// Token: 0x06005BB0 RID: 23472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkSpecialBlueprintActor_Internal(IntPtr @this);

		// Token: 0x06005BB1 RID: 23473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualUnregisterTick_Internal(IntPtr @this);

		// Token: 0x06005BB2 RID: 23474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualRegisterTick_Internal(IntPtr @this);

		// Token: 0x06005BB3 RID: 23475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __K2_GetGameBudgetLocationProxy_Internal(IntPtr @this);

		// Token: 0x06005BB4 RID: 23476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __K2_GetGameBudgetLocationProxy_Implementation_Internal(IntPtr @this);

		// Token: 0x06005BB5 RID: 23477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AfterTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06005BB6 RID: 23478 RVA: 0x00081237 File Offset: 0x0007F437
		static AKuroGameBudgetBlueprintActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetBlueprintActor");
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x00081245 File Offset: 0x0007F445
		protected AKuroGameBudgetBlueprintActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400261C RID: 9756
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetBlueprintActor";

		// Token: 0x0400261D RID: 9757
		private static IntPtr _ClassPtr;

		// Token: 0x0400261E RID: 9758
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400261F RID: 9759
		internal static int __PropertyOffset_TickActorComponents;

		// Token: 0x04002620 RID: 9760
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UActorComponent> _TickActorComponents;

		// Token: 0x02000A9B RID: 2715
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnEnvInteractChanged_FunctionParams
		{
			// Token: 0x04005AEF RID: 23279
			[FieldOffset(0)]
			public bool bEnableEnvInteract;
		}

		// Token: 0x02000A9C RID: 2716
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnApplyWorldOffset_FunctionParams
		{
			// Token: 0x04005AF0 RID: 23280
			[FieldOffset(0)]
			public FVector InWorldOffset;

			// Token: 0x04005AF1 RID: 23281
			[FieldOffset(12)]
			public bool bWorldShift;
		}

		// Token: 0x02000A9D RID: 2717
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_GetGameBudgetLocationProxy_FunctionParams
		{
			// Token: 0x04005AF2 RID: 23282
			[FieldOffset(0)]
			public FVectorDouble __Result;
		}

		// Token: 0x02000A9E RID: 2718
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __AfterTick_FunctionParams
		{
			// Token: 0x04005AF3 RID: 23283
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
