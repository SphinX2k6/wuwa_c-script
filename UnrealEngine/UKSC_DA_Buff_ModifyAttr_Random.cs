using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D6E RID: 7534
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_Random")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKSC_DA_Buff_ModifyAttr_Random : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CDCD RID: 118221 RVA: 0x002AAA16 File Offset: 0x002A8C16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ModifyAttr_Random._ClassPtr;
		}

		// Token: 0x0601CDCE RID: 118222 RVA: 0x002AAA24 File Offset: 0x002A8C24
		public UKSC_DA_Buff_ModifyAttr_Random() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr_Random.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CDCF RID: 118223 RVA: 0x002AAA4C File Offset: 0x002A8C4C
		[NullableContext(1)]
		public UKSC_DA_Buff_ModifyAttr_Random(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr_Random.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007457 RID: 29783
		// (get) Token: 0x0601CDD0 RID: 118224 RVA: 0x002AAA7F File Offset: 0x002A8C7F
		// (set) Token: 0x0601CDD1 RID: 118225 RVA: 0x002AAA8F File Offset: 0x002A8C8F
		public unsafe bool bIsRevertAttr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_bIsRevertAttr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_bIsRevertAttr) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007458 RID: 29784
		// (get) Token: 0x0601CDD2 RID: 118226 RVA: 0x002AAAA0 File Offset: 0x002A8CA0
		// (set) Token: 0x0601CDD3 RID: 118227 RVA: 0x002AAAB0 File Offset: 0x002A8CB0
		public unsafe EKSC_AttrType AttrType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_AttrType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_AttrType) = (byte)value;
			}
		}

		// Token: 0x17007459 RID: 29785
		// (get) Token: 0x0601CDD4 RID: 118228 RVA: 0x002AAAC1 File Offset: 0x002A8CC1
		// (set) Token: 0x0601CDD5 RID: 118229 RVA: 0x002AAAD1 File Offset: 0x002A8CD1
		public unsafe int RandomMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_RandomMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_RandomMin) = value;
			}
		}

		// Token: 0x1700745A RID: 29786
		// (get) Token: 0x0601CDD6 RID: 118230 RVA: 0x002AAAE2 File Offset: 0x002A8CE2
		// (set) Token: 0x0601CDD7 RID: 118231 RVA: 0x002AAAF2 File Offset: 0x002A8CF2
		public unsafe int RandomMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_RandomMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_RandomMax) = value;
			}
		}

		// Token: 0x1700745B RID: 29787
		// (get) Token: 0x0601CDD8 RID: 118232 RVA: 0x002AAB03 File Offset: 0x002A8D03
		// (set) Token: 0x0601CDD9 RID: 118233 RVA: 0x002AAB13 File Offset: 0x002A8D13
		public unsafe int RandomStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_RandomStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_Random.__PropertyOffset_RandomStep) = value;
			}
		}

		// Token: 0x0601CDDA RID: 118234 RVA: 0x002AAB24 File Offset: 0x002A8D24
		static UKSC_DA_Buff_ModifyAttr_Random()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_Random");
		}

		// Token: 0x0601CDDB RID: 118235 RVA: 0x002AAB32 File Offset: 0x002A8D32
		protected UKSC_DA_Buff_ModifyAttr_Random(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA89 RID: 64137
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_Random";

		// Token: 0x0400FA8A RID: 64138
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA8B RID: 64139
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA8C RID: 64140
		internal static int __PropertyOffset_bIsRevertAttr;

		// Token: 0x0400FA8D RID: 64141
		internal static int __PropertyOffset_AttrType;

		// Token: 0x0400FA8E RID: 64142
		internal static int __PropertyOffset_RandomMin;

		// Token: 0x0400FA8F RID: 64143
		internal static int __PropertyOffset_RandomMax;

		// Token: 0x0400FA90 RID: 64144
		internal static int __PropertyOffset_RandomStep;
	}
}
