using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200057C RID: 1404
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_LandFireContext")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKSC_LandFireContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007FB5 RID: 32693 RVA: 0x000BCE38 File Offset: 0x000BB038
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_LandFireContext._ScriptStructPtr != 0) ? FKSC_LandFireContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_LandFireContext", ref FKSC_LandFireContext._ScriptStructPtr);
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06007FB6 RID: 32694 RVA: 0x000BCE5C File Offset: 0x000BB05C
		// (set) Token: 0x06007FB7 RID: 32695 RVA: 0x000BCE6C File Offset: 0x000BB06C
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

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06007FB8 RID: 32696 RVA: 0x000BCE7D File Offset: 0x000BB07D
		// (set) Token: 0x06007FB9 RID: 32697 RVA: 0x000BCE8D File Offset: 0x000BB08D
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

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06007FBA RID: 32698 RVA: 0x000BCE9E File Offset: 0x000BB09E
		// (set) Token: 0x06007FBB RID: 32699 RVA: 0x000BCEAE File Offset: 0x000BB0AE
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

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06007FBC RID: 32700 RVA: 0x000BCEBF File Offset: 0x000BB0BF
		// (set) Token: 0x06007FBD RID: 32701 RVA: 0x000BCECF File Offset: 0x000BB0CF
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

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06007FBE RID: 32702 RVA: 0x000BCEE0 File Offset: 0x000BB0E0
		// (set) Token: 0x06007FBF RID: 32703 RVA: 0x000BCF23 File Offset: 0x000BB123
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

		// Token: 0x06007FC0 RID: 32704 RVA: 0x000BCF31 File Offset: 0x000BB131
		public FKSC_LandFireContext()
		{
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x000BCF39 File Offset: 0x000BB139
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_LandFireContext.StaticStruct();
		}

		// Token: 0x06007FC2 RID: 32706 RVA: 0x000BCF45 File Offset: 0x000BB145
		[NullableContext(2)]
		public FKSC_LandFireContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x000BCF4F File Offset: 0x000BB14F
		public FKSC_LandFireContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007FC4 RID: 32708 RVA: 0x000BCF5A File Offset: 0x000BB15A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_LandFireContext(Pointer, false, true);
		}

		// Token: 0x06007FC5 RID: 32709 RVA: 0x000BCF64 File Offset: 0x000BB164
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_LandFireContext(Pointer, MemoryOwner);
		}

		// Token: 0x040037C5 RID: 14277
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_LandFireContext";

		// Token: 0x040037C6 RID: 14278
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040037C7 RID: 14279
		internal static int __PropertyOffset_ClearCell;

		// Token: 0x040037C8 RID: 14280
		internal static int __PropertyOffset_SpawnerEntityId;

		// Token: 0x040037C9 RID: 14281
		internal static int __PropertyOffset_EffectRange;

		// Token: 0x040037CA RID: 14282
		internal static int __PropertyOffset_FireNum;

		// Token: 0x040037CB RID: 14283
		internal static int __PropertyOffset_Params;

		// Token: 0x040037CC RID: 14284
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _Params;
	}
}
