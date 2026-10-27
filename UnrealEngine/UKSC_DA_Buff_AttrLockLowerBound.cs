using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D55 RID: 7509
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_AttrLockLowerBound")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff_AttrLockLowerBound : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CC0C RID: 117772 RVA: 0x002A7FEC File Offset: 0x002A61EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_AttrLockLowerBound._ClassPtr;
		}

		// Token: 0x0601CC0D RID: 117773 RVA: 0x002A7FF8 File Offset: 0x002A61F8
		public UKSC_DA_Buff_AttrLockLowerBound() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AttrLockLowerBound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CC0E RID: 117774 RVA: 0x002A8020 File Offset: 0x002A6220
		[NullableContext(1)]
		public UKSC_DA_Buff_AttrLockLowerBound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AttrLockLowerBound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073B5 RID: 29621
		// (get) Token: 0x0601CC0F RID: 117775 RVA: 0x002A8053 File Offset: 0x002A6253
		// (set) Token: 0x0601CC10 RID: 117776 RVA: 0x002A8063 File Offset: 0x002A6263
		public unsafe EKSC_AttrType Id
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrLockLowerBound.__PropertyOffset_Id));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrLockLowerBound.__PropertyOffset_Id) = (byte)value;
			}
		}

		// Token: 0x170073B6 RID: 29622
		// (get) Token: 0x0601CC11 RID: 117777 RVA: 0x002A8074 File Offset: 0x002A6274
		// (set) Token: 0x0601CC12 RID: 117778 RVA: 0x002A8084 File Offset: 0x002A6284
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrLockLowerBound.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrLockLowerBound.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0601CC13 RID: 117779 RVA: 0x002A8095 File Offset: 0x002A6295
		static UKSC_DA_Buff_AttrLockLowerBound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_AttrLockLowerBound");
		}

		// Token: 0x0601CC14 RID: 117780 RVA: 0x002A80A3 File Offset: 0x002A62A3
		protected UKSC_DA_Buff_AttrLockLowerBound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F973 RID: 63859
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_AttrLockLowerBound";

		// Token: 0x0400F974 RID: 63860
		private static IntPtr _ClassPtr;

		// Token: 0x0400F975 RID: 63861
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F976 RID: 63862
		internal static int __PropertyOffset_Id;

		// Token: 0x0400F977 RID: 63863
		internal static int __PropertyOffset_Value;
	}
}
