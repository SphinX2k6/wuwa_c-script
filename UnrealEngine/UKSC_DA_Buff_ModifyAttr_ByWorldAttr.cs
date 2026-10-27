using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D6D RID: 7533
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_ByWorldAttr")]
	[UnrealStructLayout(528, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UKSC_DA_Buff_ModifyAttr_ByWorldAttr : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CDBE RID: 118206 RVA: 0x002AA8CB File Offset: 0x002A8ACB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ModifyAttr_ByWorldAttr._ClassPtr;
		}

		// Token: 0x0601CDBF RID: 118207 RVA: 0x002AA8D8 File Offset: 0x002A8AD8
		public UKSC_DA_Buff_ModifyAttr_ByWorldAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr_ByWorldAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CDC0 RID: 118208 RVA: 0x002AA900 File Offset: 0x002A8B00
		public UKSC_DA_Buff_ModifyAttr_ByWorldAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr_ByWorldAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007452 RID: 29778
		// (get) Token: 0x0601CDC1 RID: 118209 RVA: 0x002AA934 File Offset: 0x002A8B34
		// (set) Token: 0x0601CDC2 RID: 118210 RVA: 0x002AA96D File Offset: 0x002A8B6D
		public TMap<EKSC_AttrType, int> ModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._ModifyMap) == null)
				{
					result = (this._ModifyMap = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_ModifyMap, this));
				}
				return result;
			}
			set
			{
				this.ModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x17007453 RID: 29779
		// (get) Token: 0x0601CDC3 RID: 118211 RVA: 0x002AA97B File Offset: 0x002A8B7B
		// (set) Token: 0x0601CDC4 RID: 118212 RVA: 0x002AA98B File Offset: 0x002A8B8B
		public unsafe EKSC_WorldAttrType BindWorldAttr
		{
			get
			{
				return (EKSC_WorldAttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_BindWorldAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_BindWorldAttr) = (byte)value;
			}
		}

		// Token: 0x17007454 RID: 29780
		// (get) Token: 0x0601CDC5 RID: 118213 RVA: 0x002AA99C File Offset: 0x002A8B9C
		// (set) Token: 0x0601CDC6 RID: 118214 RVA: 0x002AA9AC File Offset: 0x002A8BAC
		public unsafe float BindWorldAttrFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_BindWorldAttrFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_BindWorldAttrFactor) = value;
			}
		}

		// Token: 0x17007455 RID: 29781
		// (get) Token: 0x0601CDC7 RID: 118215 RVA: 0x002AA9BD File Offset: 0x002A8BBD
		// (set) Token: 0x0601CDC8 RID: 118216 RVA: 0x002AA9CD File Offset: 0x002A8BCD
		public unsafe EKSC_WorldAttrType MaxWorldAttr
		{
			get
			{
				return (EKSC_WorldAttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_MaxWorldAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_MaxWorldAttr) = (byte)value;
			}
		}

		// Token: 0x17007456 RID: 29782
		// (get) Token: 0x0601CDC9 RID: 118217 RVA: 0x002AA9DE File Offset: 0x002A8BDE
		// (set) Token: 0x0601CDCA RID: 118218 RVA: 0x002AA9EE File Offset: 0x002A8BEE
		public unsafe float MaxWorldAttrFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_MaxWorldAttrFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_MaxWorldAttrFactor) = value;
			}
		}

		// Token: 0x0601CDCB RID: 118219 RVA: 0x002AA9FF File Offset: 0x002A8BFF
		static UKSC_DA_Buff_ModifyAttr_ByWorldAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_ByWorldAttr");
		}

		// Token: 0x0601CDCC RID: 118220 RVA: 0x002AAA0D File Offset: 0x002A8C0D
		protected UKSC_DA_Buff_ModifyAttr_ByWorldAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA80 RID: 64128
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_ByWorldAttr";

		// Token: 0x0400FA81 RID: 64129
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA82 RID: 64130
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA83 RID: 64131
		internal static int __PropertyOffset_ModifyMap;

		// Token: 0x0400FA84 RID: 64132
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _ModifyMap;

		// Token: 0x0400FA85 RID: 64133
		internal static int __PropertyOffset_BindWorldAttr;

		// Token: 0x0400FA86 RID: 64134
		internal static int __PropertyOffset_BindWorldAttrFactor;

		// Token: 0x0400FA87 RID: 64135
		internal static int __PropertyOffset_MaxWorldAttr;

		// Token: 0x0400FA88 RID: 64136
		internal static int __PropertyOffset_MaxWorldAttrFactor;
	}
}
