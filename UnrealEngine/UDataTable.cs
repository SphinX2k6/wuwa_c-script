using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200099D RID: 2461
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DataTable")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UDataTable : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008AF0 RID: 35568 RVA: 0x000C70A4 File Offset: 0x000C52A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataTable._ClassPtr;
		}

		// Token: 0x06008AF1 RID: 35569 RVA: 0x000C70B0 File Offset: 0x000C52B0
		public UDataTable() : this(BuiltinUtils.AllocNativeUObject(UDataTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008AF2 RID: 35570 RVA: 0x000C70D8 File Offset: 0x000C52D8
		public UDataTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06008AF3 RID: 35571 RVA: 0x000C710B File Offset: 0x000C530B
		// (set) Token: 0x06008AF4 RID: 35572 RVA: 0x000C711F File Offset: 0x000C531F
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

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06008AF5 RID: 35573 RVA: 0x000C7134 File Offset: 0x000C5334
		// (set) Token: 0x06008AF6 RID: 35574 RVA: 0x000C714D File Offset: 0x000C534D
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

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06008AF7 RID: 35575 RVA: 0x000C717D File Offset: 0x000C537D
		// (set) Token: 0x06008AF8 RID: 35576 RVA: 0x000C7196 File Offset: 0x000C5396
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

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06008AF9 RID: 35577 RVA: 0x000C71C6 File Offset: 0x000C53C6
		// (set) Token: 0x06008AFA RID: 35578 RVA: 0x000C71DF File Offset: 0x000C53DF
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

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06008AFB RID: 35579 RVA: 0x000C720F File Offset: 0x000C540F
		// (set) Token: 0x06008AFC RID: 35580 RVA: 0x000C7223 File Offset: 0x000C5423
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

		// Token: 0x06008AFD RID: 35581 RVA: 0x000C7238 File Offset: 0x000C5438
		static UDataTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataTable");
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x000C7246 File Offset: 0x000C5446
		protected UDataTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041FE RID: 16894
		public new const string __ObjectPath = "/Script/Engine.DataTable";

		// Token: 0x040041FF RID: 16895
		private static IntPtr _ClassPtr;

		// Token: 0x04004200 RID: 16896
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004201 RID: 16897
		internal static int __PropertyOffset_RowStruct;

		// Token: 0x04004202 RID: 16898
		internal static int __PropertyOffset_bStripFromClientBuilds;

		// Token: 0x04004203 RID: 16899
		internal static byte __PropertyMask_bStripFromClientBuilds;

		// Token: 0x04004204 RID: 16900
		internal static int __PropertyOffset_bIgnoreExtraFields;

		// Token: 0x04004205 RID: 16901
		internal static byte __PropertyMask_bIgnoreExtraFields;

		// Token: 0x04004206 RID: 16902
		internal static int __PropertyOffset_bIgnoreMissingFields;

		// Token: 0x04004207 RID: 16903
		internal static byte __PropertyMask_bIgnoreMissingFields;

		// Token: 0x04004208 RID: 16904
		internal static int __PropertyOffset_ImportKeyField;
	}
}
