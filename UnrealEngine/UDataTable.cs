using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C4 RID: 452
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DataTable")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UDataTable : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002103 RID: 8451 RVA: 0x000307E0 File Offset: 0x0002E9E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataTable._ClassPtr;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000307EC File Offset: 0x0002E9EC
		public UDataTable() : this(BuiltinUtils.AllocNativeUObject(UDataTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00030814 File Offset: 0x0002EA14
		public UDataTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00030847 File Offset: 0x0002EA47
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x0003085B File Offset: 0x0002EA5B
		[Nullable(2)]
		public unsafe UScriptStruct RowStruct
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UScriptStruct>(base.NativePtr / (IntPtr)sizeof(void*) + UDataTable.__PropertyOffset_RowStruct);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDataTable.__PropertyOffset_RowStruct, value);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x00030870 File Offset: 0x0002EA70
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x00030889 File Offset: 0x0002EA89
		public unsafe bool bStripFromClientBuilds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDataTable.__PropertyOffset_bStripFromClientBuilds) & UDataTable.__PropertyMask_bStripFromClientBuilds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDataTable.__PropertyOffset_bStripFromClientBuilds) = ((*(base.NativePtr + (IntPtr)UDataTable.__PropertyOffset_bStripFromClientBuilds) & ~UDataTable.__PropertyMask_bStripFromClientBuilds) | (value ? UDataTable.__PropertyMask_bStripFromClientBuilds : 0));
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x000308B9 File Offset: 0x0002EAB9
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x000308D2 File Offset: 0x0002EAD2
		public unsafe bool bIgnoreExtraFields
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDataTable.__PropertyOffset_bIgnoreExtraFields) & UDataTable.__PropertyMask_bIgnoreExtraFields) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDataTable.__PropertyOffset_bIgnoreExtraFields) = ((*(base.NativePtr + (IntPtr)UDataTable.__PropertyOffset_bIgnoreExtraFields) & ~UDataTable.__PropertyMask_bIgnoreExtraFields) | (value ? UDataTable.__PropertyMask_bIgnoreExtraFields : 0));
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x00030902 File Offset: 0x0002EB02
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x0003091B File Offset: 0x0002EB1B
		public unsafe bool bIgnoreMissingFields
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDataTable.__PropertyOffset_bIgnoreMissingFields) & UDataTable.__PropertyMask_bIgnoreMissingFields) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDataTable.__PropertyOffset_bIgnoreMissingFields) = ((*(base.NativePtr + (IntPtr)UDataTable.__PropertyOffset_bIgnoreMissingFields) & ~UDataTable.__PropertyMask_bIgnoreMissingFields) | (value ? UDataTable.__PropertyMask_bIgnoreMissingFields : 0));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x0003094B File Offset: 0x0002EB4B
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x0003095F File Offset: 0x0002EB5F
		public unsafe string ImportKeyField
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDataTable.__PropertyOffset_ImportKeyField)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDataTable.__PropertyOffset_ImportKeyField)), value);
			}
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00030974 File Offset: 0x0002EB74
		static UDataTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataTable");
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00030982 File Offset: 0x0002EB82
		protected UDataTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AFE RID: 2814
		public new const string __ObjectPath = "/Script/Engine.DataTable";

		// Token: 0x04000AFF RID: 2815
		private static IntPtr _ClassPtr;

		// Token: 0x04000B00 RID: 2816
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B01 RID: 2817
		internal static int __PropertyOffset_RowStruct;

		// Token: 0x04000B02 RID: 2818
		internal static int __PropertyOffset_bStripFromClientBuilds;

		// Token: 0x04000B03 RID: 2819
		internal static byte __PropertyMask_bStripFromClientBuilds;

		// Token: 0x04000B04 RID: 2820
		internal static int __PropertyOffset_bIgnoreExtraFields;

		// Token: 0x04000B05 RID: 2821
		internal static byte __PropertyMask_bIgnoreExtraFields;

		// Token: 0x04000B06 RID: 2822
		internal static int __PropertyOffset_bIgnoreMissingFields;

		// Token: 0x04000B07 RID: 2823
		internal static byte __PropertyMask_bIgnoreMissingFields;

		// Token: 0x04000B08 RID: 2824
		internal static int __PropertyOffset_ImportKeyField;
	}
}
