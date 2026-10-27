using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D5D RID: 7517
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_DiffTransferAddAttr")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UKSC_DA_Buff_DiffTransferAddAttr : UKSC_DA_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CCB6 RID: 117942 RVA: 0x002A8F59 File Offset: 0x002A7159
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_DiffTransferAddAttr._ClassPtr;
		}

		// Token: 0x0601CCB7 RID: 117943 RVA: 0x002A8F68 File Offset: 0x002A7168
		public UKSC_DA_Buff_DiffTransferAddAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_DiffTransferAddAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CCB8 RID: 117944 RVA: 0x002A8F90 File Offset: 0x002A7190
		public UKSC_DA_Buff_DiffTransferAddAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_DiffTransferAddAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073F6 RID: 29686
		// (get) Token: 0x0601CCB9 RID: 117945 RVA: 0x002A8FC4 File Offset: 0x002A71C4
		// (set) Token: 0x0601CCBA RID: 117946 RVA: 0x002A8FFD File Offset: 0x002A71FD
		public TMap<EKSC_AttrType, FKSC_DiffTransferAddAttr> Addition
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, FKSC_DiffTransferAddAttr> result;
				if ((result = this._Addition) == null)
				{
					result = (this._Addition = new TMap<EKSC_AttrType, FKSC_DiffTransferAddAttr>(base.NativePtr + (IntPtr)UKSC_DA_Buff_DiffTransferAddAttr.__PropertyOffset_Addition, this));
				}
				return result;
			}
			set
			{
				this.Addition.CopyAssign(value);
			}
		}

		// Token: 0x0601CCBB RID: 117947 RVA: 0x002A900B File Offset: 0x002A720B
		static UKSC_DA_Buff_DiffTransferAddAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_DiffTransferAddAttr");
		}

		// Token: 0x0601CCBC RID: 117948 RVA: 0x002A9019 File Offset: 0x002A7219
		protected UKSC_DA_Buff_DiffTransferAddAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9D9 RID: 63961
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_DiffTransferAddAttr";

		// Token: 0x0400F9DA RID: 63962
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9DB RID: 63963
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9DC RID: 63964
		internal static int __PropertyOffset_Addition;

		// Token: 0x0400F9DD RID: 63965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKSC_AttrType, FKSC_DiffTransferAddAttr> _Addition;
	}
}
