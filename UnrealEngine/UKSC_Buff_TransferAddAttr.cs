using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D3B RID: 7483
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_TransferAddAttr")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UKSC_Buff_TransferAddAttr : UKSC_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CABE RID: 117438 RVA: 0x002A62B7 File Offset: 0x002A44B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_TransferAddAttr._ClassPtr;
		}

		// Token: 0x0601CABF RID: 117439 RVA: 0x002A62C4 File Offset: 0x002A44C4
		public UKSC_Buff_TransferAddAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_TransferAddAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAC0 RID: 117440 RVA: 0x002A62EC File Offset: 0x002A44EC
		[NullableContext(1)]
		public UKSC_Buff_TransferAddAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_TransferAddAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007355 RID: 29525
		// (get) Token: 0x0601CAC1 RID: 117441 RVA: 0x002A631F File Offset: 0x002A451F
		// (set) Token: 0x0601CAC2 RID: 117442 RVA: 0x002A6333 File Offset: 0x002A4533
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_TransferAddAttr TransferAddAttr
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_TransferAddAttr>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_TransferAddAttr.__PropertyOffset_TransferAddAttr);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_TransferAddAttr.__PropertyOffset_TransferAddAttr, value);
			}
		}

		// Token: 0x0601CAC3 RID: 117443 RVA: 0x002A6348 File Offset: 0x002A4548
		public void OnAttrChange(EKSC_AttrType AttrType, int Value)
		{
			UKSC_Buff_TransferAddAttr.__OnAttrChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601CAC4 RID: 117444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttrChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601CAC5 RID: 117445 RVA: 0x002A6357 File Offset: 0x002A4557
		static UKSC_Buff_TransferAddAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_TransferAddAttr");
		}

		// Token: 0x0601CAC6 RID: 117446 RVA: 0x002A6365 File Offset: 0x002A4565
		protected UKSC_Buff_TransferAddAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8B4 RID: 63668
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_TransferAddAttr";

		// Token: 0x0400F8B5 RID: 63669
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8B6 RID: 63670
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8B7 RID: 63671
		internal static int __PropertyOffset_TransferAddAttr;
	}
}
