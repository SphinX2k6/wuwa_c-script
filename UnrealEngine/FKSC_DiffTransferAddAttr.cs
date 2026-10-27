using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DD6 RID: 7638
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DiffTransferAddAttr")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKSC_DiffTransferAddAttr : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D2F5 RID: 119541 RVA: 0x002B1D4A File Offset: 0x002AFF4A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_DiffTransferAddAttr._ScriptStructPtr != 0) ? FKSC_DiffTransferAddAttr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_DiffTransferAddAttr", ref FKSC_DiffTransferAddAttr._ScriptStructPtr);
		}

		// Token: 0x170075E5 RID: 30181
		// (get) Token: 0x0601D2F6 RID: 119542 RVA: 0x002B1D6E File Offset: 0x002AFF6E
		// (set) Token: 0x0601D2F7 RID: 119543 RVA: 0x002B1D7E File Offset: 0x002AFF7E
		public unsafe EKSC_AttrType FromAttr
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_FromAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_FromAttr) = (byte)value;
			}
		}

		// Token: 0x170075E6 RID: 30182
		// (get) Token: 0x0601D2F8 RID: 119544 RVA: 0x002B1D8F File Offset: 0x002AFF8F
		// (set) Token: 0x0601D2F9 RID: 119545 RVA: 0x002B1D9F File Offset: 0x002AFF9F
		public unsafe float FromAttrAmplify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_FromAttrAmplify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_FromAttrAmplify) = value;
			}
		}

		// Token: 0x170075E7 RID: 30183
		// (get) Token: 0x0601D2FA RID: 119546 RVA: 0x002B1DB0 File Offset: 0x002AFFB0
		// (set) Token: 0x0601D2FB RID: 119547 RVA: 0x002B1DC0 File Offset: 0x002AFFC0
		public unsafe EKSC_AttrType ThresholdAttr
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_ThresholdAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_ThresholdAttr) = (byte)value;
			}
		}

		// Token: 0x170075E8 RID: 30184
		// (get) Token: 0x0601D2FC RID: 119548 RVA: 0x002B1DD1 File Offset: 0x002AFFD1
		// (set) Token: 0x0601D2FD RID: 119549 RVA: 0x002B1DE1 File Offset: 0x002AFFE1
		public unsafe float ThresholdAttrAmplify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_ThresholdAttrAmplify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_ThresholdAttrAmplify) = value;
			}
		}

		// Token: 0x170075E9 RID: 30185
		// (get) Token: 0x0601D2FE RID: 119550 RVA: 0x002B1DF2 File Offset: 0x002AFFF2
		// (set) Token: 0x0601D2FF RID: 119551 RVA: 0x002B1E02 File Offset: 0x002B0002
		public unsafe int BaseValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_BaseValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DiffTransferAddAttr.__PropertyOffset_BaseValue) = value;
			}
		}

		// Token: 0x0601D300 RID: 119552 RVA: 0x002B1E13 File Offset: 0x002B0013
		public FKSC_DiffTransferAddAttr()
		{
		}

		// Token: 0x0601D301 RID: 119553 RVA: 0x002B1E1B File Offset: 0x002B001B
		public FKSC_DiffTransferAddAttr(EKSC_AttrType FromAttr, float FromAttrAmplify, EKSC_AttrType ThresholdAttr, float ThresholdAttrAmplify, int BaseValue)
		{
			this.FromAttr = FromAttr;
			this.FromAttrAmplify = FromAttrAmplify;
			this.ThresholdAttr = ThresholdAttr;
			this.ThresholdAttrAmplify = ThresholdAttrAmplify;
			this.BaseValue = BaseValue;
		}

		// Token: 0x0601D302 RID: 119554 RVA: 0x002B1E48 File Offset: 0x002B0048
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_DiffTransferAddAttr.StaticStruct();
		}

		// Token: 0x0601D303 RID: 119555 RVA: 0x002B1E54 File Offset: 0x002B0054
		[NullableContext(2)]
		public FKSC_DiffTransferAddAttr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D304 RID: 119556 RVA: 0x002B1E5E File Offset: 0x002B005E
		public FKSC_DiffTransferAddAttr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D305 RID: 119557 RVA: 0x002B1E69 File Offset: 0x002B0069
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_DiffTransferAddAttr(Pointer, false, true);
		}

		// Token: 0x0601D306 RID: 119558 RVA: 0x002B1E73 File Offset: 0x002B0073
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_DiffTransferAddAttr(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD85 RID: 64901
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DiffTransferAddAttr";

		// Token: 0x0400FD86 RID: 64902
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FD87 RID: 64903
		internal static int __PropertyOffset_FromAttr;

		// Token: 0x0400FD88 RID: 64904
		internal static int __PropertyOffset_FromAttrAmplify;

		// Token: 0x0400FD89 RID: 64905
		internal static int __PropertyOffset_ThresholdAttr;

		// Token: 0x0400FD8A RID: 64906
		internal static int __PropertyOffset_ThresholdAttrAmplify;

		// Token: 0x0400FD8B RID: 64907
		internal static int __PropertyOffset_BaseValue;
	}
}
