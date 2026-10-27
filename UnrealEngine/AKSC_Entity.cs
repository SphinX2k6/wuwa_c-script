using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DDC RID: 7644
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1272)]
	public class AKSC_Entity : AKSC_BaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D338 RID: 119608 RVA: 0x002B21E6 File Offset: 0x002B03E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity._ClassPtr;
		}

		// Token: 0x0601D339 RID: 119609 RVA: 0x002B21F4 File Offset: 0x002B03F4
		public AKSC_Entity() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D33A RID: 119610 RVA: 0x002B221C File Offset: 0x002B041C
		[NullableContext(1)]
		public AKSC_Entity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075F0 RID: 30192
		// (get) Token: 0x0601D33B RID: 119611 RVA: 0x002B224F File Offset: 0x002B044F
		// (set) Token: 0x0601D33C RID: 119612 RVA: 0x002B2263 File Offset: 0x002B0463
		public unsafe UKSC_SceneComp SceneComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SceneComp>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_SceneComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_SceneComp_, value);
			}
		}

		// Token: 0x170075F1 RID: 30193
		// (get) Token: 0x0601D33D RID: 119613 RVA: 0x002B2278 File Offset: 0x002B0478
		// (set) Token: 0x0601D33E RID: 119614 RVA: 0x002B228C File Offset: 0x002B048C
		public unsafe UKSC_Move Move_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Move>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_Move_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_Move_, value);
			}
		}

		// Token: 0x170075F2 RID: 30194
		// (get) Token: 0x0601D33F RID: 119615 RVA: 0x002B22A1 File Offset: 0x002B04A1
		// (set) Token: 0x0601D340 RID: 119616 RVA: 0x002B22B5 File Offset: 0x002B04B5
		public unsafe UKSC_Anim Anim_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Anim>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_Anim_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_Anim_, value);
			}
		}

		// Token: 0x170075F3 RID: 30195
		// (get) Token: 0x0601D341 RID: 119617 RVA: 0x002B22CA File Offset: 0x002B04CA
		// (set) Token: 0x0601D342 RID: 119618 RVA: 0x002B22DE File Offset: 0x002B04DE
		public unsafe UKSC_SkillComp SkillComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_SkillComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_SkillComp_, value);
			}
		}

		// Token: 0x170075F4 RID: 30196
		// (get) Token: 0x0601D343 RID: 119619 RVA: 0x002B22F3 File Offset: 0x002B04F3
		// (set) Token: 0x0601D344 RID: 119620 RVA: 0x002B2307 File Offset: 0x002B0507
		public unsafe UKSC_TimeScaleComp TimeScaleComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_TimeScaleComp>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_TimeScaleComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_TimeScaleComp_, value);
			}
		}

		// Token: 0x170075F5 RID: 30197
		// (get) Token: 0x0601D345 RID: 119621 RVA: 0x002B231C File Offset: 0x002B051C
		// (set) Token: 0x0601D346 RID: 119622 RVA: 0x002B2330 File Offset: 0x002B0530
		public unsafe UKSC_DA_Entity DaEntity_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Entity>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_DaEntity_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_DaEntity_, value);
			}
		}

		// Token: 0x170075F6 RID: 30198
		// (get) Token: 0x0601D347 RID: 119623 RVA: 0x002B2348 File Offset: 0x002B0548
		// (set) Token: 0x0601D348 RID: 119624 RVA: 0x002B2381 File Offset: 0x002B0581
		[Nullable(1)]
		public TMap<FName, FVector> SocketOffsets
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FVector> result;
				if ((result = this._SocketOffsets) == null)
				{
					result = (this._SocketOffsets = new TMap<FName, FVector>(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_SocketOffsets, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SocketOffsets.CopyAssign(value);
			}
		}

		// Token: 0x170075F7 RID: 30199
		// (get) Token: 0x0601D349 RID: 119625 RVA: 0x002B238F File Offset: 0x002B058F
		// (set) Token: 0x0601D34A RID: 119626 RVA: 0x002B239F File Offset: 0x002B059F
		public unsafe int EntityId_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_EntityId_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_EntityId_) = value;
			}
		}

		// Token: 0x170075F8 RID: 30200
		// (get) Token: 0x0601D34B RID: 119627 RVA: 0x002B23B0 File Offset: 0x002B05B0
		// (set) Token: 0x0601D34C RID: 119628 RVA: 0x002B23C0 File Offset: 0x002B05C0
		public unsafe bool IsKscEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_IsKscEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_IsKscEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170075F9 RID: 30201
		// (get) Token: 0x0601D34D RID: 119629 RVA: 0x002B23D1 File Offset: 0x002B05D1
		// (set) Token: 0x0601D34E RID: 119630 RVA: 0x002B23EB File Offset: 0x002B05EB
		public unsafe IKSC_HeadUiHandle HeadUiHandle
		{
			get
			{
				return (IKSC_HeadUiHandle)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_HeadUiHandle));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_HeadUiHandle) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x170075FA RID: 30202
		// (get) Token: 0x0601D34F RID: 119631 RVA: 0x002B2411 File Offset: 0x002B0611
		// (set) Token: 0x0601D350 RID: 119632 RVA: 0x002B2425 File Offset: 0x002B0625
		public unsafe AActor RenderActor_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_RenderActor_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_RenderActor_, value);
			}
		}

		// Token: 0x0601D351 RID: 119633 RVA: 0x002B243A File Offset: 0x002B063A
		public void UpdateBuffWithStackNumSelf(UKSC_DA_Buff DaBuff, int StackNum)
		{
			AKSC_Entity.__UpdateBuffWithStackNumSelf_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero, StackNum);
		}

		// Token: 0x0601D352 RID: 119634 RVA: 0x002B2458 File Offset: 0x002B0658
		public void TryActiveSKill(int SkillIndex)
		{
			AKSC_Entity.__TryActiveSKill_Internal(base.NativePtr, SkillIndex);
		}

		// Token: 0x0601D353 RID: 119635 RVA: 0x002B2468 File Offset: 0x002B0668
		public unsafe void SetTransformByWorld(in FTransformDouble D_Transform)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = D_Transform;
			AKSC_Entity.__SetTransformByWorld_Internal(base.NativePtr, ptr);
		}

		// Token: 0x0601D354 RID: 119636 RVA: 0x002B249D File Offset: 0x002B069D
		public void SetRenderActor(AActor RenderActor)
		{
			AKSC_Entity.__SetRenderActor_Internal(base.NativePtr, (RenderActor != null) ? RenderActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D355 RID: 119637 RVA: 0x002B24BA File Offset: 0x002B06BA
		public void SetLocationByWorld(in FVectorDouble D_Location)
		{
			AKSC_Entity.__SetLocationByWorld_Internal(base.NativePtr, D_Location);
		}

		// Token: 0x0601D356 RID: 119638 RVA: 0x002B24C8 File Offset: 0x002B06C8
		public void SetIgnoreFactions(in TArray<EKSC_Faction> Factions)
		{
			AKSC_Entity.__SetIgnoreFactions_Internal(base.NativePtr, (Factions ?? new TArray<EKSC_Faction>()).NativePtr);
		}

		// Token: 0x0601D357 RID: 119639 RVA: 0x002B24E5 File Offset: 0x002B06E5
		public void SetFaction(EKSC_Faction Faction)
		{
			AKSC_Entity.__SetFaction_Internal(base.NativePtr, Faction);
		}

		// Token: 0x0601D358 RID: 119640 RVA: 0x002B24F3 File Offset: 0x002B06F3
		public bool SetEntityActive(bool InActive)
		{
			return AKSC_Entity.__SetEntityActive_Internal(base.NativePtr, InActive);
		}

		// Token: 0x0601D359 RID: 119641 RVA: 0x002B2501 File Offset: 0x002B0701
		public void SetAttr(EKSC_AttrType Type, int Value)
		{
			AKSC_Entity.__SetAttr_Internal(base.NativePtr, Type, Value);
		}

		// Token: 0x0601D35A RID: 119642 RVA: 0x002B2510 File Offset: 0x002B0710
		public void RemoveDaBuffImmediately(UKSC_DA_Buff DaBuff)
		{
			AKSC_Entity.__RemoveDaBuffImmediately_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D35B RID: 119643 RVA: 0x002B252D File Offset: 0x002B072D
		public void RemoveBuffSelf(UKSC_DA_Buff DaBuff)
		{
			AKSC_Entity.__RemoveBuffSelf_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D35C RID: 119644 RVA: 0x002B254A File Offset: 0x002B074A
		public float GetTimeScale()
		{
			return AKSC_Entity.__GetTimeScale_Internal(base.NativePtr);
		}

		// Token: 0x0601D35D RID: 119645 RVA: 0x002B2557 File Offset: 0x002B0757
		public UKSC_SkillComp GetSkillComp()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_SkillComp>(AKSC_Entity.__GetSkillComp_Internal(base.NativePtr));
		}

		// Token: 0x0601D35E RID: 119646 RVA: 0x002B2569 File Offset: 0x002B0769
		public UKSC_SceneComp GetSceneComp()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_SceneComp>(AKSC_Entity.__GetSceneComp_Internal(base.NativePtr));
		}

		// Token: 0x0601D35F RID: 119647 RVA: 0x002B257B File Offset: 0x002B077B
		public AActor GetRenderActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AKSC_Entity.__GetRenderActor_Internal(base.NativePtr));
		}

		// Token: 0x0601D360 RID: 119648 RVA: 0x002B258D File Offset: 0x002B078D
		public UKSC_Move GetMoveComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_Move>(AKSC_Entity.__GetMoveComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601D361 RID: 119649 RVA: 0x002B259F File Offset: 0x002B079F
		public UKSC_Anim GetAnimComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_Anim>(AKSC_Entity.__GetAnimComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601D362 RID: 119650 RVA: 0x002B25B1 File Offset: 0x002B07B1
		public void Dead(int KillBy)
		{
			AKSC_Entity.__Dead_Internal(base.NativePtr, KillBy);
		}

		// Token: 0x0601D363 RID: 119651 RVA: 0x002B25BF File Offset: 0x002B07BF
		public void ApplyBuffSelf(UKSC_DA_Buff DaBuff)
		{
			AKSC_Entity.__ApplyBuffSelf_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D364 RID: 119652 RVA: 0x002B25DC File Offset: 0x002B07DC
		public void ApplyBuffByOther(UKSC_DA_Buff DaBuff, int EntityId)
		{
			AKSC_Entity.__ApplyBuffByOther_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero, EntityId);
		}

		// Token: 0x0601D365 RID: 119653 RVA: 0x002B25FA File Offset: 0x002B07FA
		public void AddAttr(EKSC_AttrType Type, int Delta)
		{
			AKSC_Entity.__AddAttr_Internal(base.NativePtr, Type, Delta);
		}

		// Token: 0x0601D366 RID: 119654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBuffWithStackNumSelf_Internal(IntPtr @this, IntPtr DaBuff, int StackNum);

		// Token: 0x0601D367 RID: 119655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryActiveSKill_Internal(IntPtr @this, int SkillIndex);

		// Token: 0x0601D368 RID: 119656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransformByWorld_Internal(IntPtr @this, in FTransformDouble D_Transform);

		// Token: 0x0601D369 RID: 119657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderActor_Internal(IntPtr @this, IntPtr RenderActor);

		// Token: 0x0601D36A RID: 119658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocationByWorld_Internal(IntPtr @this, in FVectorDouble D_Location);

		// Token: 0x0601D36B RID: 119659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreFactions_Internal(IntPtr @this, IntPtr Factions);

		// Token: 0x0601D36C RID: 119660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFaction_Internal(IntPtr @this, EKSC_Faction Faction);

		// Token: 0x0601D36D RID: 119661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetEntityActive_Internal(IntPtr @this, bool InActive);

		// Token: 0x0601D36E RID: 119662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttr_Internal(IntPtr @this, EKSC_AttrType Type, int Value);

		// Token: 0x0601D36F RID: 119663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveDaBuffImmediately_Internal(IntPtr @this, IntPtr DaBuff);

		// Token: 0x0601D370 RID: 119664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBuffSelf_Internal(IntPtr @this, IntPtr DaBuff);

		// Token: 0x0601D371 RID: 119665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeScale_Internal(IntPtr @this);

		// Token: 0x0601D372 RID: 119666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSkillComp_Internal(IntPtr @this);

		// Token: 0x0601D373 RID: 119667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSceneComp_Internal(IntPtr @this);

		// Token: 0x0601D374 RID: 119668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRenderActor_Internal(IntPtr @this);

		// Token: 0x0601D375 RID: 119669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMoveComponent_Internal(IntPtr @this);

		// Token: 0x0601D376 RID: 119670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnimComponent_Internal(IntPtr @this);

		// Token: 0x0601D377 RID: 119671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Dead_Internal(IntPtr @this, int KillBy);

		// Token: 0x0601D378 RID: 119672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyBuffSelf_Internal(IntPtr @this, IntPtr DaBuff);

		// Token: 0x0601D379 RID: 119673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyBuffByOther_Internal(IntPtr @this, IntPtr DaBuff, int EntityId);

		// Token: 0x0601D37A RID: 119674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAttr_Internal(IntPtr @this, EKSC_AttrType Type, int Delta);

		// Token: 0x0601D37B RID: 119675 RVA: 0x002B2609 File Offset: 0x002B0809
		static AKSC_Entity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity");
		}

		// Token: 0x0601D37C RID: 119676 RVA: 0x002B2617 File Offset: 0x002B0817
		protected AKSC_Entity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD9F RID: 64927
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity";

		// Token: 0x0400FDA0 RID: 64928
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDA1 RID: 64929
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDA2 RID: 64930
		internal static int __PropertyOffset_SceneComp_;

		// Token: 0x0400FDA3 RID: 64931
		internal static int __PropertyOffset_Move_;

		// Token: 0x0400FDA4 RID: 64932
		internal static int __PropertyOffset_Anim_;

		// Token: 0x0400FDA5 RID: 64933
		internal static int __PropertyOffset_SkillComp_;

		// Token: 0x0400FDA6 RID: 64934
		internal static int __PropertyOffset_TimeScaleComp_;

		// Token: 0x0400FDA7 RID: 64935
		internal static int __PropertyOffset_DaEntity_;

		// Token: 0x0400FDA8 RID: 64936
		internal static int __PropertyOffset_SocketOffsets;

		// Token: 0x0400FDA9 RID: 64937
		private TMap<FName, FVector> _SocketOffsets;

		// Token: 0x0400FDAA RID: 64938
		internal static int __PropertyOffset_EntityId_;

		// Token: 0x0400FDAB RID: 64939
		internal static int __PropertyOffset_IsKscEnable;

		// Token: 0x0400FDAC RID: 64940
		internal static int __PropertyOffset_HeadUiHandle;

		// Token: 0x0400FDAD RID: 64941
		internal static int __PropertyOffset_RenderActor_;
	}
}
