using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E3A RID: 7738
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_World")]
	[UnrealStructLayout(3248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3248)]
	public class UKSC_Shape2D_World : UKSC_World, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D7AB RID: 120747 RVA: 0x002B87D2 File Offset: 0x002B69D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Shape2D_World._ClassPtr;
		}

		// Token: 0x0601D7AC RID: 120748 RVA: 0x002B87E0 File Offset: 0x002B69E0
		public UKSC_Shape2D_World() : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2D_World.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D7AD RID: 120749 RVA: 0x002B8808 File Offset: 0x002B6A08
		[NullableContext(1)]
		public UKSC_Shape2D_World(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2D_World.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076CA RID: 30410
		// (get) Token: 0x0601D7AE RID: 120750 RVA: 0x002B883B File Offset: 0x002B6A3B
		// (set) Token: 0x0601D7AF RID: 120751 RVA: 0x002B884F File Offset: 0x002B6A4F
		public unsafe UDataTable ShapeMaterialDataTable
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_ShapeMaterialDataTable);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_ShapeMaterialDataTable, value);
			}
		}

		// Token: 0x170076CB RID: 30411
		// (get) Token: 0x0601D7B0 RID: 120752 RVA: 0x002B8864 File Offset: 0x002B6A64
		// (set) Token: 0x0601D7B1 RID: 120753 RVA: 0x002B8878 File Offset: 0x002B6A78
		public unsafe AKSC_Shape2D_Entity_Player CurrentPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKSC_Shape2D_Entity_Player>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_CurrentPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_CurrentPlayer, value);
			}
		}

		// Token: 0x170076CC RID: 30412
		// (get) Token: 0x0601D7B2 RID: 120754 RVA: 0x002B888D File Offset: 0x002B6A8D
		// (set) Token: 0x0601D7B3 RID: 120755 RVA: 0x002B88A1 File Offset: 0x002B6AA1
		public unsafe AKSC_Shape2D_Entity_Player MainPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKSC_Shape2D_Entity_Player>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_MainPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_MainPlayer, value);
			}
		}

		// Token: 0x170076CD RID: 30413
		// (get) Token: 0x0601D7B4 RID: 120756 RVA: 0x002B88B6 File Offset: 0x002B6AB6
		// (set) Token: 0x0601D7B5 RID: 120757 RVA: 0x002B88CA File Offset: 0x002B6ACA
		public unsafe AKSC_Shape2D_Entity_TeamPlayer TeamPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKSC_Shape2D_Entity_TeamPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_TeamPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_TeamPlayer, value);
			}
		}

		// Token: 0x170076CE RID: 30414
		// (get) Token: 0x0601D7B6 RID: 120758 RVA: 0x002B88E0 File Offset: 0x002B6AE0
		// (set) Token: 0x0601D7B7 RID: 120759 RVA: 0x002B8919 File Offset: 0x002B6B19
		[Nullable(1)]
		public TArray<AKSC_Shape2D_Entity_Player> TeamPlayerEntities
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Shape2D_Entity_Player> result;
				if ((result = this._TeamPlayerEntities) == null)
				{
					result = (this._TeamPlayerEntities = new TArray<AKSC_Shape2D_Entity_Player>(base.NativePtr + (IntPtr)UKSC_Shape2D_World.__PropertyOffset_TeamPlayerEntities, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TeamPlayerEntities.CopyAssign(value);
			}
		}

		// Token: 0x170076CF RID: 30415
		// (get) Token: 0x0601D7B8 RID: 120760 RVA: 0x002B8928 File Offset: 0x002B6B28
		// (set) Token: 0x0601D7B9 RID: 120761 RVA: 0x002B8961 File Offset: 0x002B6B61
		[Nullable(1)]
		public TArray<int> TeamPlayerEntityIds
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TeamPlayerEntityIds) == null)
				{
					result = (this._TeamPlayerEntityIds = new TArray<int>(base.NativePtr + (IntPtr)UKSC_Shape2D_World.__PropertyOffset_TeamPlayerEntityIds, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TeamPlayerEntityIds.CopyAssign(value);
			}
		}

		// Token: 0x170076D0 RID: 30416
		// (get) Token: 0x0601D7BA RID: 120762 RVA: 0x002B8970 File Offset: 0x002B6B70
		// (set) Token: 0x0601D7BB RID: 120763 RVA: 0x002B89A9 File Offset: 0x002B6BA9
		[Nullable(1)]
		public TArray<int> TeamPlayerEntityIdsOriginal
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TeamPlayerEntityIdsOriginal) == null)
				{
					result = (this._TeamPlayerEntityIdsOriginal = new TArray<int>(base.NativePtr + (IntPtr)UKSC_Shape2D_World.__PropertyOffset_TeamPlayerEntityIdsOriginal, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TeamPlayerEntityIdsOriginal.CopyAssign(value);
			}
		}

		// Token: 0x170076D1 RID: 30417
		// (get) Token: 0x0601D7BC RID: 120764 RVA: 0x002B89B7 File Offset: 0x002B6BB7
		// (set) Token: 0x0601D7BD RID: 120765 RVA: 0x002B89CB File Offset: 0x002B6BCB
		public unsafe UKSC_DA_Shape2D_World DA_Shape2D_World
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_DA_Shape2D_World);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_DA_Shape2D_World, value);
			}
		}

		// Token: 0x170076D2 RID: 30418
		// (get) Token: 0x0601D7BE RID: 120766 RVA: 0x002B89E0 File Offset: 0x002B6BE0
		// (set) Token: 0x0601D7BF RID: 120767 RVA: 0x002B89F4 File Offset: 0x002B6BF4
		public unsafe UKSC_DA_WorldBounds Temp_DA_WorldBounds
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_WorldBounds>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_Temp_DA_WorldBounds);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_Temp_DA_WorldBounds, value);
			}
		}

		// Token: 0x170076D3 RID: 30419
		// (get) Token: 0x0601D7C0 RID: 120768 RVA: 0x002B8A0C File Offset: 0x002B6C0C
		// (set) Token: 0x0601D7C1 RID: 120769 RVA: 0x002B8A45 File Offset: 0x002B6C45
		[Nullable(1)]
		public TArray<FKSC_Shape2D_CollisionListenContext> CollisionListenContexts
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_Shape2D_CollisionListenContext> result;
				if ((result = this._CollisionListenContexts) == null)
				{
					result = (this._CollisionListenContexts = new TArray<FKSC_Shape2D_CollisionListenContext>(base.NativePtr + (IntPtr)UKSC_Shape2D_World.__PropertyOffset_CollisionListenContexts, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CollisionListenContexts.CopyAssign(value);
			}
		}

		// Token: 0x170076D4 RID: 30420
		// (get) Token: 0x0601D7C2 RID: 120770 RVA: 0x002B8A53 File Offset: 0x002B6C53
		// (set) Token: 0x0601D7C3 RID: 120771 RVA: 0x002B8A67 File Offset: 0x002B6C67
		public unsafe UKSC_DamageHandler_WF DamageHandler_WF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DamageHandler_WF>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_DamageHandler_WF);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_World.__PropertyOffset_DamageHandler_WF, value);
			}
		}

		// Token: 0x0601D7C4 RID: 120772 RVA: 0x002B8A7C File Offset: 0x002B6C7C
		public void SetWorldOrigin(in FVectorDouble NewOrigin)
		{
			UKSC_Shape2D_World.__SetWorldOrigin_Internal(base.NativePtr, NewOrigin);
		}

		// Token: 0x0601D7C5 RID: 120773 RVA: 0x002B8A8A File Offset: 0x002B6C8A
		public void SetVictory()
		{
			UKSC_Shape2D_World.__SetVictory_Internal(base.NativePtr);
		}

		// Token: 0x0601D7C6 RID: 120774 RVA: 0x002B8A97 File Offset: 0x002B6C97
		public void SetShapeMaterialDT(UDataTable DataTable)
		{
			UKSC_Shape2D_World.__SetShapeMaterialDT_Internal(base.NativePtr, (DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D7C7 RID: 120775 RVA: 0x002B8AB4 File Offset: 0x002B6CB4
		public void SetShape2DWorldDA(UKSC_DA_Shape2D_World DA_ShapeWorld)
		{
			UKSC_Shape2D_World.__SetShape2DWorldDA_Internal(base.NativePtr, (DA_ShapeWorld != null) ? DA_ShapeWorld.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D7C8 RID: 120776 RVA: 0x002B8AD1 File Offset: 0x002B6CD1
		public void SetGameEnd()
		{
			UKSC_Shape2D_World.__SetGameEnd_Internal(base.NativePtr);
		}

		// Token: 0x0601D7C9 RID: 120777 RVA: 0x002B8ADE File Offset: 0x002B6CDE
		public void ReviveTeam()
		{
			UKSC_Shape2D_World.__ReviveTeam_Internal(base.NativePtr);
		}

		// Token: 0x0601D7CA RID: 120778 RVA: 0x002B8AEB File Offset: 0x002B6CEB
		public void RebuildWorldBounds(UKSC_DA_WorldBounds DA_WorldBounds)
		{
			UKSC_Shape2D_World.__RebuildWorldBounds_Internal(base.NativePtr, (DA_WorldBounds != null) ? DA_WorldBounds.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D7CB RID: 120779 RVA: 0x002B8B08 File Offset: 0x002B6D08
		public void InitTeamPlayerEntityIds(in TArray<int> PlayerEntityIds)
		{
			UKSC_Shape2D_World.__InitTeamPlayerEntityIds_Internal(base.NativePtr, (PlayerEntityIds ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0601D7CC RID: 120780 RVA: 0x002B8B25 File Offset: 0x002B6D25
		public void GetDamageTotalInfo([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKSC_Shape2D_DamageTotalInfo> OutInfos)
		{
			UKSC_Shape2D_World.__GetDamageTotalInfo_Internal(base.NativePtr, (OutInfos ?? new TArray<FKSC_Shape2D_DamageTotalInfo>()).NativePtr);
		}

		// Token: 0x0601D7CD RID: 120781 RVA: 0x002B8B42 File Offset: 0x002B6D42
		public void GetDamageInfo(ref TMap<int, int> OutInfos)
		{
			UKSC_Shape2D_World.__GetDamageInfo_Internal(base.NativePtr, (OutInfos ?? new TMap<int, int>()).NativeMapPtr);
		}

		// Token: 0x0601D7CE RID: 120782 RVA: 0x002B8B5F File Offset: 0x002B6D5F
		public void ClearDamageTotalInfo()
		{
			UKSC_Shape2D_World.__ClearDamageTotalInfo_Internal(base.NativePtr);
		}

		// Token: 0x0601D7CF RID: 120783 RVA: 0x002B8B6C File Offset: 0x002B6D6C
		public void ClearDamageInfo()
		{
			UKSC_Shape2D_World.__ClearDamageInfo_Internal(base.NativePtr);
		}

		// Token: 0x0601D7D0 RID: 120784 RVA: 0x002B8B79 File Offset: 0x002B6D79
		public void AssignWorldUpdateOnce(in FOnWorldUpdateOnce InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnWorldUpdateOnce fonWorldUpdateOnce = InDelegate;
			UKSC_Shape2D_World.__AssignWorldUpdateOnce_Internal(nativePtr, (fonWorldUpdateOnce != null) ? fonWorldUpdateOnce.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D7D1 RID: 120785 RVA: 0x002B8B95 File Offset: 0x002B6D95
		public void AssignTeamAllDead(in FOnTeamAllDead InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnTeamAllDead fonTeamAllDead = InDelegate;
			UKSC_Shape2D_World.__AssignTeamAllDead_Internal(nativePtr, (fonTeamAllDead != null) ? fonTeamAllDead.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D7D2 RID: 120786 RVA: 0x002B8BB1 File Offset: 0x002B6DB1
		public void AssignRelaunchPlayer(in FOnRelaunchPlayer InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnRelaunchPlayer fonRelaunchPlayer = InDelegate;
			UKSC_Shape2D_World.__AssignRelaunchPlayer_Internal(nativePtr, (fonRelaunchPlayer != null) ? fonRelaunchPlayer.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D7D3 RID: 120787 RVA: 0x002B8BCD File Offset: 0x002B6DCD
		public void AddDamageEffectData(int DamageId, in FKSC_Shape2D_DamageEffect Data)
		{
			UKSC_Shape2D_World.__AddDamageEffectData_Internal(base.NativePtr, DamageId, (Data ?? new FKSC_Shape2D_DamageEffect()).NativePtr);
		}

		// Token: 0x0601D7D4 RID: 120788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldOrigin_Internal(IntPtr @this, in FVectorDouble NewOrigin);

		// Token: 0x0601D7D5 RID: 120789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVictory_Internal(IntPtr @this);

		// Token: 0x0601D7D6 RID: 120790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShapeMaterialDT_Internal(IntPtr @this, IntPtr DataTable);

		// Token: 0x0601D7D7 RID: 120791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShape2DWorldDA_Internal(IntPtr @this, IntPtr DA_ShapeWorld);

		// Token: 0x0601D7D8 RID: 120792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameEnd_Internal(IntPtr @this);

		// Token: 0x0601D7D9 RID: 120793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReviveTeam_Internal(IntPtr @this);

		// Token: 0x0601D7DA RID: 120794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RebuildWorldBounds_Internal(IntPtr @this, IntPtr DA_WorldBounds);

		// Token: 0x0601D7DB RID: 120795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitTeamPlayerEntityIds_Internal(IntPtr @this, IntPtr PlayerEntityIds);

		// Token: 0x0601D7DC RID: 120796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetDamageTotalInfo_Internal(IntPtr @this, IntPtr OutInfos);

		// Token: 0x0601D7DD RID: 120797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetDamageInfo_Internal(IntPtr @this, IntPtr OutInfos);

		// Token: 0x0601D7DE RID: 120798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDamageTotalInfo_Internal(IntPtr @this);

		// Token: 0x0601D7DF RID: 120799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDamageInfo_Internal(IntPtr @this);

		// Token: 0x0601D7E0 RID: 120800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignWorldUpdateOnce_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601D7E1 RID: 120801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignTeamAllDead_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601D7E2 RID: 120802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignRelaunchPlayer_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601D7E3 RID: 120803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDamageEffectData_Internal(IntPtr @this, int DamageId, IntPtr Data);

		// Token: 0x0601D7E4 RID: 120804 RVA: 0x002B8BEB File Offset: 0x002B6DEB
		static UKSC_Shape2D_World()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_World");
		}

		// Token: 0x0601D7E5 RID: 120805 RVA: 0x002B8BF9 File Offset: 0x002B6DF9
		protected UKSC_Shape2D_World(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFB2 RID: 65458
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_World";

		// Token: 0x0400FFB3 RID: 65459
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFB4 RID: 65460
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFB5 RID: 65461
		internal static int __PropertyOffset_ShapeMaterialDataTable;

		// Token: 0x0400FFB6 RID: 65462
		internal static int __PropertyOffset_CurrentPlayer;

		// Token: 0x0400FFB7 RID: 65463
		internal static int __PropertyOffset_MainPlayer;

		// Token: 0x0400FFB8 RID: 65464
		internal static int __PropertyOffset_TeamPlayer;

		// Token: 0x0400FFB9 RID: 65465
		internal static int __PropertyOffset_TeamPlayerEntities;

		// Token: 0x0400FFBA RID: 65466
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Shape2D_Entity_Player> _TeamPlayerEntities;

		// Token: 0x0400FFBB RID: 65467
		internal static int __PropertyOffset_TeamPlayerEntityIds;

		// Token: 0x0400FFBC RID: 65468
		private TArray<int> _TeamPlayerEntityIds;

		// Token: 0x0400FFBD RID: 65469
		internal static int __PropertyOffset_TeamPlayerEntityIdsOriginal;

		// Token: 0x0400FFBE RID: 65470
		private TArray<int> _TeamPlayerEntityIdsOriginal;

		// Token: 0x0400FFBF RID: 65471
		internal static int __PropertyOffset_DA_Shape2D_World;

		// Token: 0x0400FFC0 RID: 65472
		internal static int __PropertyOffset_Temp_DA_WorldBounds;

		// Token: 0x0400FFC1 RID: 65473
		internal static int __PropertyOffset_CollisionListenContexts;

		// Token: 0x0400FFC2 RID: 65474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_Shape2D_CollisionListenContext> _CollisionListenContexts;

		// Token: 0x0400FFC3 RID: 65475
		internal static int __PropertyOffset_DamageHandler_WF;
	}
}
