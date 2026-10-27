using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DEF RID: 7663
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_LandFireContext")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKSC_LandFireContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D49D RID: 119965 RVA: 0x002B3EDD File Offset: 0x002B20DD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_LandFireContext._ScriptStructPtr != 0) ? FKSC_LandFireContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_LandFireContext", ref FKSC_LandFireContext._ScriptStructPtr);
		}

		// Token: 0x17007649 RID: 30281
		// (get) Token: 0x0601D49E RID: 119966 RVA: 0x002B3F01 File Offset: 0x002B2101
		// (set) Token: 0x0601D49F RID: 119967 RVA: 0x002B3F11 File Offset: 0x002B2111
		public unsafe bool ClearCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_LandFireContext.__PropertyOffset_ClearCell) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_LandFireContext.__PropertyOffset_ClearCell) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700764A RID: 30282
		// (get) Token: 0x0601D4A0 RID: 119968 RVA: 0x002B3F22 File Offset: 0x002B2122
		// (set) Token: 0x0601D4A1 RID: 119969 RVA: 0x002B3F32 File Offset: 0x002B2132
		public unsafe int SpawnerEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_LandFireContext.__PropertyOffset_SpawnerEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_LandFireContext.__PropertyOffset_SpawnerEntityId) = value;
			}
		}

		// Token: 0x1700764B RID: 30283
		// (get) Token: 0x0601D4A2 RID: 119970 RVA: 0x002B3F43 File Offset: 0x002B2143
		// (set) Token: 0x0601D4A3 RID: 119971 RVA: 0x002B3F53 File Offset: 0x002B2153
		public unsafe int EffectRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_LandFireContext.__PropertyOffset_EffectRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_LandFireContext.__PropertyOffset_EffectRange) = value;
			}
		}

		// Token: 0x1700764C RID: 30284
		// (get) Token: 0x0601D4A4 RID: 119972 RVA: 0x002B3F64 File Offset: 0x002B2164
		// (set) Token: 0x0601D4A5 RID: 119973 RVA: 0x002B3F74 File Offset: 0x002B2174
		public unsafe int FireNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_LandFireContext.__PropertyOffset_FireNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_LandFireContext.__PropertyOffset_FireNum) = value;
			}
		}

		// Token: 0x1700764D RID: 30285
		// (get) Token: 0x0601D4A6 RID: 119974 RVA: 0x002B3F88 File Offset: 0x002B2188
		// (set) Token: 0x0601D4A7 RID: 119975 RVA: 0x002B3FCB File Offset: 0x002B21CB
		public TMap<EKSC_AttrType, int> Params
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)FKSC_LandFireContext.__PropertyOffset_Params, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Params.CopyAssign(value);
			}
		}

		// Token: 0x0601D4A8 RID: 119976 RVA: 0x002B3FD9 File Offset: 0x002B21D9
		public FKSC_LandFireContext()
		{
		}

		// Token: 0x0601D4A9 RID: 119977 RVA: 0x002B3FE1 File Offset: 0x002B21E1
		public FKSC_LandFireContext(bool ClearCell, int SpawnerEntityId, int EffectRange, int FireNum, TMap<EKSC_AttrType, int> Params)
		{
			this.ClearCell = ClearCell;
			this.SpawnerEntityId = SpawnerEntityId;
			this.EffectRange = EffectRange;
			this.FireNum = FireNum;
			this.Params = Params;
		}

		// Token: 0x0601D4AA RID: 119978 RVA: 0x002B400E File Offset: 0x002B220E
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_LandFireContext.StaticStruct();
		}

		// Token: 0x0601D4AB RID: 119979 RVA: 0x002B401A File Offset: 0x002B221A
		[NullableContext(2)]
		public FKSC_LandFireContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D4AC RID: 119980 RVA: 0x002B4024 File Offset: 0x002B2224
		public FKSC_LandFireContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D4AD RID: 119981 RVA: 0x002B402F File Offset: 0x002B222F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_LandFireContext(Pointer, false, true);
		}

		// Token: 0x0601D4AE RID: 119982 RVA: 0x002B4039 File Offset: 0x002B2239
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_LandFireContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400FE47 RID: 65095
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_LandFireContext";

		// Token: 0x0400FE48 RID: 65096
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FE49 RID: 65097
		internal static int __PropertyOffset_ClearCell;

		// Token: 0x0400FE4A RID: 65098
		internal static int __PropertyOffset_SpawnerEntityId;

		// Token: 0x0400FE4B RID: 65099
		internal static int __PropertyOffset_EffectRange;

		// Token: 0x0400FE4C RID: 65100
		internal static int __PropertyOffset_FireNum;

		// Token: 0x0400FE4D RID: 65101
		internal static int __PropertyOffset_Params;

		// Token: 0x0400FE4E RID: 65102
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _Params;
	}
}
