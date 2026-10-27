using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D13 RID: 7443
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_DiffTransferAddAttr")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UKSC_Buff_DiffTransferAddAttr : UKSC_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C98C RID: 117132 RVA: 0x002A4633 File Offset: 0x002A2833
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_DiffTransferAddAttr._ClassPtr;
		}

		// Token: 0x0601C98D RID: 117133 RVA: 0x002A4640 File Offset: 0x002A2840
		public UKSC_Buff_DiffTransferAddAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_DiffTransferAddAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C98E RID: 117134 RVA: 0x002A4668 File Offset: 0x002A2868
		[NullableContext(1)]
		public UKSC_Buff_DiffTransferAddAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_DiffTransferAddAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007323 RID: 29475
		// (get) Token: 0x0601C98F RID: 117135 RVA: 0x002A469B File Offset: 0x002A289B
		// (set) Token: 0x0601C990 RID: 117136 RVA: 0x002A46AF File Offset: 0x002A28AF
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_DiffTransferAddAttr TransferAddAttr
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_DiffTransferAddAttr>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_DiffTransferAddAttr.__PropertyOffset_TransferAddAttr);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_DiffTransferAddAttr.__PropertyOffset_TransferAddAttr, value);
			}
		}

		// Token: 0x0601C991 RID: 117137 RVA: 0x002A46C4 File Offset: 0x002A28C4
		public void OnAttrChange(EKSC_AttrType AttrType, int Value)
		{
			UKSC_Buff_DiffTransferAddAttr.__OnAttrChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601C992 RID: 117138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttrChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601C993 RID: 117139 RVA: 0x002A46D3 File Offset: 0x002A28D3
		static UKSC_Buff_DiffTransferAddAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_DiffTransferAddAttr");
		}

		// Token: 0x0601C994 RID: 117140 RVA: 0x002A46E1 File Offset: 0x002A28E1
		protected UKSC_Buff_DiffTransferAddAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F806 RID: 63494
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_DiffTransferAddAttr";

		// Token: 0x0400F807 RID: 63495
		private static IntPtr _ClassPtr;

		// Token: 0x0400F808 RID: 63496
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F809 RID: 63497
		internal static int __PropertyOffset_TransferAddAttr;
	}
}
