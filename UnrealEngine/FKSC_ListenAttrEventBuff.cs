using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DF0 RID: 7664
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_ListenAttrEventBuff")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKSC_ListenAttrEventBuff : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D4AF RID: 119983 RVA: 0x002B4042 File Offset: 0x002B2242
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_ListenAttrEventBuff._ScriptStructPtr != 0) ? FKSC_ListenAttrEventBuff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_ListenAttrEventBuff", ref FKSC_ListenAttrEventBuff._ScriptStructPtr);
		}

		// Token: 0x1700764E RID: 30286
		// (get) Token: 0x0601D4B0 RID: 119984 RVA: 0x002B4066 File Offset: 0x002B2266
		// (set) Token: 0x0601D4B1 RID: 119985 RVA: 0x002B4076 File Offset: 0x002B2276
		public unsafe EKSC_AttrType AttrId
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_AttrId));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_AttrId) = (byte)value;
			}
		}

		// Token: 0x1700764F RID: 30287
		// (get) Token: 0x0601D4B2 RID: 119986 RVA: 0x002B4087 File Offset: 0x002B2287
		// (set) Token: 0x0601D4B3 RID: 119987 RVA: 0x002B4097 File Offset: 0x002B2297
		public unsafe EKSC_ComparisonSymbols Comparison
		{
			get
			{
				return (EKSC_ComparisonSymbols)(*(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_Comparison));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_Comparison) = (byte)value;
			}
		}

		// Token: 0x17007650 RID: 30288
		// (get) Token: 0x0601D4B4 RID: 119988 RVA: 0x002B40A8 File Offset: 0x002B22A8
		// (set) Token: 0x0601D4B5 RID: 119989 RVA: 0x002B40B8 File Offset: 0x002B22B8
		public unsafe int AttrValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_AttrValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_AttrValue) = value;
			}
		}

		// Token: 0x17007651 RID: 30289
		// (get) Token: 0x0601D4B6 RID: 119990 RVA: 0x002B40C9 File Offset: 0x002B22C9
		// (set) Token: 0x0601D4B7 RID: 119991 RVA: 0x002B40D9 File Offset: 0x002B22D9
		public unsafe int ThresholdValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_ThresholdValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_ThresholdValue) = value;
			}
		}

		// Token: 0x17007652 RID: 30290
		// (get) Token: 0x0601D4B8 RID: 119992 RVA: 0x002B40EA File Offset: 0x002B22EA
		// (set) Token: 0x0601D4B9 RID: 119993 RVA: 0x002B40FA File Offset: 0x002B22FA
		public unsafe bool bAccumulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_bAccumulate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_ListenAttrEventBuff.__PropertyOffset_bAccumulate) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D4BA RID: 119994 RVA: 0x002B410B File Offset: 0x002B230B
		public FKSC_ListenAttrEventBuff()
		{
		}

		// Token: 0x0601D4BB RID: 119995 RVA: 0x002B4113 File Offset: 0x002B2313
		public FKSC_ListenAttrEventBuff(EKSC_AttrType AttrId, EKSC_ComparisonSymbols Comparison, int AttrValue, int ThresholdValue, bool bAccumulate)
		{
			this.AttrId = AttrId;
			this.Comparison = Comparison;
			this.AttrValue = AttrValue;
			this.ThresholdValue = ThresholdValue;
			this.bAccumulate = bAccumulate;
		}

		// Token: 0x0601D4BC RID: 119996 RVA: 0x002B4140 File Offset: 0x002B2340
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_ListenAttrEventBuff.StaticStruct();
		}

		// Token: 0x0601D4BD RID: 119997 RVA: 0x002B414C File Offset: 0x002B234C
		[NullableContext(2)]
		public FKSC_ListenAttrEventBuff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D4BE RID: 119998 RVA: 0x002B4156 File Offset: 0x002B2356
		public FKSC_ListenAttrEventBuff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D4BF RID: 119999 RVA: 0x002B4161 File Offset: 0x002B2361
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_ListenAttrEventBuff(Pointer, false, true);
		}

		// Token: 0x0601D4C0 RID: 120000 RVA: 0x002B416B File Offset: 0x002B236B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_ListenAttrEventBuff(Pointer, MemoryOwner);
		}

		// Token: 0x0400FE4F RID: 65103
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_ListenAttrEventBuff";

		// Token: 0x0400FE50 RID: 65104
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FE51 RID: 65105
		internal static int __PropertyOffset_AttrId;

		// Token: 0x0400FE52 RID: 65106
		internal static int __PropertyOffset_Comparison;

		// Token: 0x0400FE53 RID: 65107
		internal static int __PropertyOffset_AttrValue;

		// Token: 0x0400FE54 RID: 65108
		internal static int __PropertyOffset_ThresholdValue;

		// Token: 0x0400FE55 RID: 65109
		internal static int __PropertyOffset_bAccumulate;
	}
}
