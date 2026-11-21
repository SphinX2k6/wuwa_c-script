using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200057B RID: 1403
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_HeadHpContext")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKSC_HeadHpContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007FA0 RID: 32672 RVA: 0x000BCCE9 File Offset: 0x000BAEE9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_HeadHpContext._ScriptStructPtr != 0) ? FKSC_HeadHpContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_HeadHpContext", ref FKSC_HeadHpContext._ScriptStructPtr);
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06007FA1 RID: 32673 RVA: 0x000BCD0D File Offset: 0x000BAF0D
		// (set) Token: 0x06007FA2 RID: 32674 RVA: 0x000BCD1D File Offset: 0x000BAF1D
		public unsafe EKSC_HeadHpContextType ActionType
		{
			get
			{
				return (EKSC_HeadHpContextType)(*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_ActionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_ActionType) = (byte)value;
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06007FA3 RID: 32675 RVA: 0x000BCD2E File Offset: 0x000BAF2E
		// (set) Token: 0x06007FA4 RID: 32676 RVA: 0x000BCD42 File Offset: 0x000BAF42
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x06007FA5 RID: 32677 RVA: 0x000BCD57 File Offset: 0x000BAF57
		// (set) Token: 0x06007FA6 RID: 32678 RVA: 0x000BCD67 File Offset: 0x000BAF67
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06007FA7 RID: 32679 RVA: 0x000BCD78 File Offset: 0x000BAF78
		// (set) Token: 0x06007FA8 RID: 32680 RVA: 0x000BCD88 File Offset: 0x000BAF88
		public unsafe int CurHp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_CurHp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_CurHp) = value;
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06007FA9 RID: 32681 RVA: 0x000BCD99 File Offset: 0x000BAF99
		// (set) Token: 0x06007FAA RID: 32682 RVA: 0x000BCDA9 File Offset: 0x000BAFA9
		public unsafe int MaxHp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_MaxHp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_MaxHp) = value;
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06007FAB RID: 32683 RVA: 0x000BCDBA File Offset: 0x000BAFBA
		// (set) Token: 0x06007FAC RID: 32684 RVA: 0x000BCDCA File Offset: 0x000BAFCA
		public unsafe int Shield
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_Shield);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_Shield) = value;
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06007FAD RID: 32685 RVA: 0x000BCDDB File Offset: 0x000BAFDB
		// (set) Token: 0x06007FAE RID: 32686 RVA: 0x000BCDEB File Offset: 0x000BAFEB
		public unsafe EKSC_HeadUiType HeadUiType
		{
			get
			{
				return (EKSC_HeadUiType)(*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_HeadUiType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_HeadUiType) = (byte)value;
			}
		}

		// Token: 0x06007FAF RID: 32687 RVA: 0x000BCDFC File Offset: 0x000BAFFC
		public FKSC_HeadHpContext()
		{
		}

		// Token: 0x06007FB0 RID: 32688 RVA: 0x000BCE04 File Offset: 0x000BB004
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_HeadHpContext.StaticStruct();
		}

		// Token: 0x06007FB1 RID: 32689 RVA: 0x000BCE10 File Offset: 0x000BB010
		[NullableContext(2)]
		public FKSC_HeadHpContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007FB2 RID: 32690 RVA: 0x000BCE1A File Offset: 0x000BB01A
		public FKSC_HeadHpContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007FB3 RID: 32691 RVA: 0x000BCE25 File Offset: 0x000BB025
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_HeadHpContext(Pointer, false, true);
		}

		// Token: 0x06007FB4 RID: 32692 RVA: 0x000BCE2F File Offset: 0x000BB02F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_HeadHpContext(Pointer, MemoryOwner);
		}

		// Token: 0x040037BC RID: 14268
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_HeadHpContext";

		// Token: 0x040037BD RID: 14269
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040037BE RID: 14270
		internal static int __PropertyOffset_ActionType;

		// Token: 0x040037BF RID: 14271
		internal static int __PropertyOffset_Location;

		// Token: 0x040037C0 RID: 14272
		internal static int __PropertyOffset_EntityId;

		// Token: 0x040037C1 RID: 14273
		internal static int __PropertyOffset_CurHp;

		// Token: 0x040037C2 RID: 14274
		internal static int __PropertyOffset_MaxHp;

		// Token: 0x040037C3 RID: 14275
		internal static int __PropertyOffset_Shield;

		// Token: 0x040037C4 RID: 14276
		internal static int __PropertyOffset_HeadUiType;
	}
}
