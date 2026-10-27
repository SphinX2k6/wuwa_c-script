using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019A4 RID: 6564
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroInteractionEffectNDCConfigBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroInteractionEffectNDCConfigBase : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060186C2 RID: 100034 RVA: 0x0023FEFA File Offset: 0x0023E0FA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInteractionEffectNDCConfigBase._ScriptStructPtr != 0) ? FKuroInteractionEffectNDCConfigBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroInteractionEffectNDCConfigBase", ref FKuroInteractionEffectNDCConfigBase._ScriptStructPtr);
		}

		// Token: 0x1700618E RID: 24974
		// (get) Token: 0x060186C3 RID: 100035 RVA: 0x0023FF1E File Offset: 0x0023E11E
		// (set) Token: 0x060186C4 RID: 100036 RVA: 0x0023FF2E File Offset: 0x0023E12E
		public unsafe bool bEnableNDC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_bEnableNDC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_bEnableNDC) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700618F RID: 24975
		// (get) Token: 0x060186C5 RID: 100037 RVA: 0x0023FF3F File Offset: 0x0023E13F
		// (set) Token: 0x060186C6 RID: 100038 RVA: 0x0023FF4F File Offset: 0x0023E14F
		public unsafe float SpawnNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_SpawnNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_SpawnNum) = value;
			}
		}

		// Token: 0x17006190 RID: 24976
		// (get) Token: 0x060186C7 RID: 100039 RVA: 0x0023FF60 File Offset: 0x0023E160
		// (set) Token: 0x060186C8 RID: 100040 RVA: 0x0023FF70 File Offset: 0x0023E170
		public unsafe float HeightClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_HeightClamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_HeightClamp) = value;
			}
		}

		// Token: 0x17006191 RID: 24977
		// (get) Token: 0x060186C9 RID: 100041 RVA: 0x0023FF81 File Offset: 0x0023E181
		// (set) Token: 0x060186CA RID: 100042 RVA: 0x0023FF91 File Offset: 0x0023E191
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17006192 RID: 24978
		// (get) Token: 0x060186CB RID: 100043 RVA: 0x0023FFA2 File Offset: 0x0023E1A2
		// (set) Token: 0x060186CC RID: 100044 RVA: 0x0023FFB2 File Offset: 0x0023E1B2
		public unsafe float MoveSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_MoveSpawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_MoveSpawn) = value;
			}
		}

		// Token: 0x17006193 RID: 24979
		// (get) Token: 0x060186CD RID: 100045 RVA: 0x0023FFC3 File Offset: 0x0023E1C3
		// (set) Token: 0x060186CE RID: 100046 RVA: 0x0023FFD3 File Offset: 0x0023E1D3
		public unsafe float WeaponSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_WeaponSpawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_WeaponSpawn) = value;
			}
		}

		// Token: 0x17006194 RID: 24980
		// (get) Token: 0x060186CF RID: 100047 RVA: 0x0023FFE4 File Offset: 0x0023E1E4
		// (set) Token: 0x060186D0 RID: 100048 RVA: 0x0023FFF4 File Offset: 0x0023E1F4
		public unsafe int EffectIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_EffectIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_EffectIndex) = value;
			}
		}

		// Token: 0x17006195 RID: 24981
		// (get) Token: 0x060186D1 RID: 100049 RVA: 0x00240005 File Offset: 0x0023E205
		// (set) Token: 0x060186D2 RID: 100050 RVA: 0x00240015 File Offset: 0x0023E215
		public unsafe float TypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_TypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_TypeIndex) = value;
			}
		}

		// Token: 0x17006196 RID: 24982
		// (get) Token: 0x060186D3 RID: 100051 RVA: 0x00240026 File Offset: 0x0023E226
		// (set) Token: 0x060186D4 RID: 100052 RVA: 0x0024003A File Offset: 0x0023E23A
		public unsafe FVector PlayerSpawnOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_PlayerSpawnOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_PlayerSpawnOffset) = value;
			}
		}

		// Token: 0x060186D5 RID: 100053 RVA: 0x0024004F File Offset: 0x0023E24F
		public FKuroInteractionEffectNDCConfigBase()
		{
		}

		// Token: 0x060186D6 RID: 100054 RVA: 0x00240058 File Offset: 0x0023E258
		public FKuroInteractionEffectNDCConfigBase(bool bEnableNDC, float SpawnNum, float HeightClamp, float Weight, float MoveSpawn, float WeaponSpawn, int EffectIndex, float TypeIndex, FVector PlayerSpawnOffset)
		{
			this.bEnableNDC = bEnableNDC;
			this.SpawnNum = SpawnNum;
			this.HeightClamp = HeightClamp;
			this.Weight = Weight;
			this.MoveSpawn = MoveSpawn;
			this.WeaponSpawn = WeaponSpawn;
			this.EffectIndex = EffectIndex;
			this.TypeIndex = TypeIndex;
			this.PlayerSpawnOffset = PlayerSpawnOffset;
		}

		// Token: 0x060186D7 RID: 100055 RVA: 0x002400B0 File Offset: 0x0023E2B0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInteractionEffectNDCConfigBase.StaticStruct();
		}

		// Token: 0x060186D8 RID: 100056 RVA: 0x002400BC File Offset: 0x0023E2BC
		[NullableContext(2)]
		public FKuroInteractionEffectNDCConfigBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060186D9 RID: 100057 RVA: 0x002400C6 File Offset: 0x0023E2C6
		public FKuroInteractionEffectNDCConfigBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060186DA RID: 100058 RVA: 0x002400D1 File Offset: 0x0023E2D1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInteractionEffectNDCConfigBase(Pointer, false, true);
		}

		// Token: 0x060186DB RID: 100059 RVA: 0x002400DB File Offset: 0x0023E2DB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInteractionEffectNDCConfigBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400D32F RID: 54063
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroInteractionEffectNDCConfigBase";

		// Token: 0x0400D330 RID: 54064
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D331 RID: 54065
		internal static int __PropertyOffset_bEnableNDC;

		// Token: 0x0400D332 RID: 54066
		internal static int __PropertyOffset_SpawnNum;

		// Token: 0x0400D333 RID: 54067
		internal static int __PropertyOffset_HeightClamp;

		// Token: 0x0400D334 RID: 54068
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400D335 RID: 54069
		internal static int __PropertyOffset_MoveSpawn;

		// Token: 0x0400D336 RID: 54070
		internal static int __PropertyOffset_WeaponSpawn;

		// Token: 0x0400D337 RID: 54071
		internal static int __PropertyOffset_EffectIndex;

		// Token: 0x0400D338 RID: 54072
		internal static int __PropertyOffset_TypeIndex;

		// Token: 0x0400D339 RID: 54073
		internal static int __PropertyOffset_PlayerSpawnOffset;
	}
}
