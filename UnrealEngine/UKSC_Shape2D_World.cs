using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000590 RID: 1424
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_World")]
	[UnrealStructLayout(3248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3248)]
	public class UKSC_Shape2D_World : UKSC_World, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060080C8 RID: 32968 RVA: 0x000BE2C6 File Offset: 0x000BC4C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Shape2D_World._ClassPtr;
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x000BE2D4 File Offset: 0x000BC4D4
		public UKSC_Shape2D_World() : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2D_World.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x000BE2FC File Offset: 0x000BC4FC
		[NullableContext(1)]
		public UKSC_Shape2D_World(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2D_World.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x060080CB RID: 32971 RVA: 0x000BE32F File Offset: 0x000BC52F
		// (set) Token: 0x060080CC RID: 32972 RVA: 0x000BE343 File Offset: 0x000BC543
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

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x060080CD RID: 32973 RVA: 0x000BE358 File Offset: 0x000BC558
		// (set) Token: 0x060080CE RID: 32974 RVA: 0x000BE36C File Offset: 0x000BC56C
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

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060080CF RID: 32975 RVA: 0x000BE381 File Offset: 0x000BC581
		// (set) Token: 0x060080D0 RID: 32976 RVA: 0x000BE395 File Offset: 0x000BC595
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

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x060080D1 RID: 32977 RVA: 0x000BE3AA File Offset: 0x000BC5AA
		// (set) Token: 0x060080D2 RID: 32978 RVA: 0x000BE3BE File Offset: 0x000BC5BE
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

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x060080D3 RID: 32979 RVA: 0x000BE3D4 File Offset: 0x000BC5D4
		// (set) Token: 0x060080D4 RID: 32980 RVA: 0x000BE40D File Offset: 0x000BC60D
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

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x060080D5 RID: 32981 RVA: 0x000BE41C File Offset: 0x000BC61C
		// (set) Token: 0x060080D6 RID: 32982 RVA: 0x000BE455 File Offset: 0x000BC655
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

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x060080D7 RID: 32983 RVA: 0x000BE464 File Offset: 0x000BC664
		// (set) Token: 0x060080D8 RID: 32984 RVA: 0x000BE49D File Offset: 0x000BC69D
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

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x060080D9 RID: 32985 RVA: 0x000BE4AB File Offset: 0x000BC6AB
		// (set) Token: 0x060080DA RID: 32986 RVA: 0x000BE4BF File Offset: 0x000BC6BF
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

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x060080DB RID: 32987 RVA: 0x000BE4D4 File Offset: 0x000BC6D4
		// (set) Token: 0x060080DC RID: 32988 RVA: 0x000BE4E8 File Offset: 0x000BC6E8
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

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x060080DD RID: 32989 RVA: 0x000BE4FD File Offset: 0x000BC6FD
		// (set) Token: 0x060080DE RID: 32990 RVA: 0x000BE511 File Offset: 0x000BC711
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

		// Token: 0x060080DF RID: 32991 RVA: 0x000BE526 File Offset: 0x000BC726
		public void SetWorldOrigin(in FVectorDouble NewOrigin)
		{
			UKSC_Shape2D_World.__SetWorldOrigin_Internal(base.NativePtr, NewOrigin);
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x000BE534 File Offset: 0x000BC734
		public void SetVictory()
		{
			UKSC_Shape2D_World.__SetVictory_Internal(base.NativePtr);
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x000BE541 File Offset: 0x000BC741
		public void SetShapeMaterialDT(UDataTable DataTable)
		{
			UKSC_Shape2D_World.__SetShapeMaterialDT_Internal(base.NativePtr, (DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x000BE55E File Offset: 0x000BC75E
		public void SetShape2DWorldDA(UKSC_DA_Shape2D_World DA_ShapeWorld)
		{
			UKSC_Shape2D_World.__SetShape2DWorldDA_Internal(base.NativePtr, (DA_ShapeWorld != null) ? DA_ShapeWorld.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x000BE57B File Offset: 0x000BC77B
		public void SetGameEnd()
		{
			UKSC_Shape2D_World.__SetGameEnd_Internal(base.NativePtr);
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x000BE588 File Offset: 0x000BC788
		public void ReviveTeam()
		{
			UKSC_Shape2D_World.__ReviveTeam_Internal(base.NativePtr);
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x000BE595 File Offset: 0x000BC795
		public void RebuildWorldBounds(UKSC_DA_WorldBounds DA_WorldBounds)
		{
			UKSC_Shape2D_World.__RebuildWorldBounds_Internal(base.NativePtr, (DA_WorldBounds != null) ? DA_WorldBounds.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x000BE5B2 File Offset: 0x000BC7B2
		public void InitTeamPlayerEntityIds(in TArray<int> PlayerEntityIds)
		{
			UKSC_Shape2D_World.__InitTeamPlayerEntityIds_Internal(base.NativePtr, (PlayerEntityIds ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x060080E7 RID: 32999 RVA: 0x000BE5CF File Offset: 0x000BC7CF
		public void GetDamageTotalInfo([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKSC_Shape2D_DamageTotalInfo> OutInfos)
		{
			UKSC_Shape2D_World.__GetDamageTotalInfo_Internal(base.NativePtr, (OutInfos ?? new TArray<FKSC_Shape2D_DamageTotalInfo>()).NativePtr);
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x000BE5EC File Offset: 0x000BC7EC
		public void GetDamageInfo(ref TMap<int, int> OutInfos)
		{
			UKSC_Shape2D_World.__GetDamageInfo_Internal(base.NativePtr, (OutInfos ?? new TMap<int, int>()).NativeMapPtr);
		}

		// Token: 0x060080E9 RID: 33001 RVA: 0x000BE609 File Offset: 0x000BC809
		public void ClearDamageTotalInfo()
		{
			UKSC_Shape2D_World.__ClearDamageTotalInfo_Internal(base.NativePtr);
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x000BE616 File Offset: 0x000BC816
		public void ClearDamageInfo()
		{
			UKSC_Shape2D_World.__ClearDamageInfo_Internal(base.NativePtr);
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x000BE623 File Offset: 0x000BC823
		public void AssignWorldUpdateOnce(in FOnWorldUpdateOnce InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnWorldUpdateOnce fonWorldUpdateOnce = InDelegate;
			UKSC_Shape2D_World.__AssignWorldUpdateOnce_Internal(nativePtr, (fonWorldUpdateOnce != null) ? fonWorldUpdateOnce.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x000BE63F File Offset: 0x000BC83F
		public void AssignTeamAllDead(in FOnTeamAllDead InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnTeamAllDead fonTeamAllDead = InDelegate;
			UKSC_Shape2D_World.__AssignTeamAllDead_Internal(nativePtr, (fonTeamAllDead != null) ? fonTeamAllDead.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x000BE65B File Offset: 0x000BC85B
		public void AssignRelaunchPlayer(in FOnRelaunchPlayer InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnRelaunchPlayer fonRelaunchPlayer = InDelegate;
			UKSC_Shape2D_World.__AssignRelaunchPlayer_Internal(nativePtr, (fonRelaunchPlayer != null) ? fonRelaunchPlayer.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x000BE677 File Offset: 0x000BC877
		public void AddDamageEffectData(int DamageId, in FKSC_Shape2D_DamageEffect Data)
		{
			UKSC_Shape2D_World.__AddDamageEffectData_Internal(base.NativePtr, DamageId, (Data ?? new FKSC_Shape2D_DamageEffect()).NativePtr);
		}

		// Token: 0x060080EF RID: 33007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldOrigin_Internal(IntPtr @this, in FVectorDouble NewOrigin);

		// Token: 0x060080F0 RID: 33008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVictory_Internal(IntPtr @this);

		// Token: 0x060080F1 RID: 33009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShapeMaterialDT_Internal(IntPtr @this, IntPtr DataTable);

		// Token: 0x060080F2 RID: 33010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShape2DWorldDA_Internal(IntPtr @this, IntPtr DA_ShapeWorld);

		// Token: 0x060080F3 RID: 33011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameEnd_Internal(IntPtr @this);

		// Token: 0x060080F4 RID: 33012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReviveTeam_Internal(IntPtr @this);

		// Token: 0x060080F5 RID: 33013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RebuildWorldBounds_Internal(IntPtr @this, IntPtr DA_WorldBounds);

		// Token: 0x060080F6 RID: 33014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitTeamPlayerEntityIds_Internal(IntPtr @this, IntPtr PlayerEntityIds);

		// Token: 0x060080F7 RID: 33015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetDamageTotalInfo_Internal(IntPtr @this, IntPtr OutInfos);

		// Token: 0x060080F8 RID: 33016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetDamageInfo_Internal(IntPtr @this, IntPtr OutInfos);

		// Token: 0x060080F9 RID: 33017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDamageTotalInfo_Internal(IntPtr @this);

		// Token: 0x060080FA RID: 33018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDamageInfo_Internal(IntPtr @this);

		// Token: 0x060080FB RID: 33019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignWorldUpdateOnce_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060080FC RID: 33020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignTeamAllDead_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060080FD RID: 33021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignRelaunchPlayer_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060080FE RID: 33022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDamageEffectData_Internal(IntPtr @this, int DamageId, IntPtr Data);

		// Token: 0x060080FF RID: 33023 RVA: 0x000BE695 File Offset: 0x000BC895
		static UKSC_Shape2D_World()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_World");
		}

		// Token: 0x06008100 RID: 33024 RVA: 0x000BE6A3 File Offset: 0x000BC8A3
		protected UKSC_Shape2D_World(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400383A RID: 14394
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_World";

		// Token: 0x0400383B RID: 14395
		private static IntPtr _ClassPtr;

		// Token: 0x0400383C RID: 14396
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400383D RID: 14397
		internal static int __PropertyOffset_ShapeMaterialDataTable;

		// Token: 0x0400383E RID: 14398
		internal static int __PropertyOffset_CurrentPlayer;

		// Token: 0x0400383F RID: 14399
		internal static int __PropertyOffset_MainPlayer;

		// Token: 0x04003840 RID: 14400
		internal static int __PropertyOffset_TeamPlayer;

		// Token: 0x04003841 RID: 14401
		internal static int __PropertyOffset_TeamPlayerEntities;

		// Token: 0x04003842 RID: 14402
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Shape2D_Entity_Player> _TeamPlayerEntities;

		// Token: 0x04003843 RID: 14403
		internal static int __PropertyOffset_TeamPlayerEntityIds;

		// Token: 0x04003844 RID: 14404
		private TArray<int> _TeamPlayerEntityIds;

		// Token: 0x04003845 RID: 14405
		internal static int __PropertyOffset_TeamPlayerEntityIdsOriginal;

		// Token: 0x04003846 RID: 14406
		private TArray<int> _TeamPlayerEntityIdsOriginal;

		// Token: 0x04003847 RID: 14407
		internal static int __PropertyOffset_DA_Shape2D_World;

		// Token: 0x04003848 RID: 14408
		internal static int __PropertyOffset_Temp_DA_WorldBounds;

		// Token: 0x04003849 RID: 14409
		internal static int __PropertyOffset_DamageHandler_WF;
	}
}
