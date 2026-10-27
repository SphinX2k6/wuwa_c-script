using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017F7 RID: 6135
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroData.KuroDerivedDataTable")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UKuroDerivedDataTable : UDataTable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016AF7 RID: 92919 RVA: 0x00211BD7 File Offset: 0x0020FDD7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDerivedDataTable._ClassPtr;
		}

		// Token: 0x06016AF8 RID: 92920 RVA: 0x00211BE4 File Offset: 0x0020FDE4
		public UKuroDerivedDataTable() : this(BuiltinUtils.AllocNativeUObject(UKuroDerivedDataTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016AF9 RID: 92921 RVA: 0x00211C0C File Offset: 0x0020FE0C
		public UKuroDerivedDataTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDerivedDataTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BB2 RID: 23474
		// (get) Token: 0x06016AFA RID: 92922 RVA: 0x00211C3F File Offset: 0x0020FE3F
		// (set) Token: 0x06016AFB RID: 92923 RVA: 0x00211C53 File Offset: 0x0020FE53
		[Nullable(2)]
		public unsafe UDataTable ParentDataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDerivedDataTable.__PropertyOffset_ParentDataTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDerivedDataTable.__PropertyOffset_ParentDataTable, value);
			}
		}

		// Token: 0x17005BB3 RID: 23475
		// (get) Token: 0x06016AFC RID: 92924 RVA: 0x00211C68 File Offset: 0x0020FE68
		// (set) Token: 0x06016AFD RID: 92925 RVA: 0x00211CA1 File Offset: 0x0020FEA1
		public TSet<string> OverriddenFields
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._OverriddenFields) == null)
				{
					result = (this._OverriddenFields = new TSet<string>(base.NativePtr + (IntPtr)UKuroDerivedDataTable.__PropertyOffset_OverriddenFields, this));
				}
				return result;
			}
			set
			{
				this.OverriddenFields.CopyAssign(value);
			}
		}

		// Token: 0x17005BB4 RID: 23476
		// (get) Token: 0x06016AFE RID: 92926 RVA: 0x00211CB0 File Offset: 0x0020FEB0
		// (set) Token: 0x06016AFF RID: 92927 RVA: 0x00211CE9 File Offset: 0x0020FEE9
		public TSet<FName> ChildOnlyRows
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._ChildOnlyRows) == null)
				{
					result = (this._ChildOnlyRows = new TSet<FName>(base.NativePtr + (IntPtr)UKuroDerivedDataTable.__PropertyOffset_ChildOnlyRows, this));
				}
				return result;
			}
			set
			{
				this.ChildOnlyRows.CopyAssign(value);
			}
		}

		// Token: 0x06016B00 RID: 92928 RVA: 0x00211CF7 File Offset: 0x0020FEF7
		public void UnmarkFieldOverridden(FName RowName, FName PropertyName)
		{
			UKuroDerivedDataTable.__UnmarkFieldOverridden_Internal(base.NativePtr, RowName, PropertyName);
		}

		// Token: 0x06016B01 RID: 92929 RVA: 0x00211D06 File Offset: 0x0020FF06
		public void RevertRowToParent(FName RowName)
		{
			UKuroDerivedDataTable.__RevertRowToParent_Internal(base.NativePtr, RowName);
		}

		// Token: 0x06016B02 RID: 92930 RVA: 0x00211D14 File Offset: 0x0020FF14
		public void MarkRowFullyOverridden(FName RowName)
		{
			UKuroDerivedDataTable.__MarkRowFullyOverridden_Internal(base.NativePtr, RowName);
		}

		// Token: 0x06016B03 RID: 92931 RVA: 0x00211D22 File Offset: 0x0020FF22
		public void MarkFieldOverridden(FName RowName, FName PropertyName)
		{
			UKuroDerivedDataTable.__MarkFieldOverridden_Internal(base.NativePtr, RowName, PropertyName);
		}

		// Token: 0x06016B04 RID: 92932 RVA: 0x00211D31 File Offset: 0x0020FF31
		public bool IsFieldOverridden(FName RowName, FName PropertyName)
		{
			return UKuroDerivedDataTable.__IsFieldOverridden_Internal(base.NativePtr, RowName, PropertyName);
		}

		// Token: 0x06016B05 RID: 92933 RVA: 0x00211D40 File Offset: 0x0020FF40
		public bool IsChildOnlyRow(FName RowName)
		{
			return UKuroDerivedDataTable.__IsChildOnlyRow_Internal(base.NativePtr, RowName);
		}

		// Token: 0x06016B06 RID: 92934 RVA: 0x00211D4E File Offset: 0x0020FF4E
		public bool HasAnyOverrideInRow(FName RowName)
		{
			return UKuroDerivedDataTable.__HasAnyOverrideInRow_Internal(base.NativePtr, RowName);
		}

		// Token: 0x06016B07 RID: 92935 RVA: 0x00211D5C File Offset: 0x0020FF5C
		public TArray<FName> GetAllResolvedRowNames()
		{
			return new TArray<FName>(UKuroDerivedDataTable.__GetAllResolvedRowNames_Internal(base.NativePtr), null);
		}

		// Token: 0x06016B08 RID: 92936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnmarkFieldOverridden_Internal(IntPtr @this, FName RowName, FName PropertyName);

		// Token: 0x06016B09 RID: 92937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertRowToParent_Internal(IntPtr @this, FName RowName);

		// Token: 0x06016B0A RID: 92938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkRowFullyOverridden_Internal(IntPtr @this, FName RowName);

		// Token: 0x06016B0B RID: 92939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkFieldOverridden_Internal(IntPtr @this, FName RowName, FName PropertyName);

		// Token: 0x06016B0C RID: 92940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFieldOverridden_Internal(IntPtr @this, FName RowName, FName PropertyName);

		// Token: 0x06016B0D RID: 92941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsChildOnlyRow_Internal(IntPtr @this, FName RowName);

		// Token: 0x06016B0E RID: 92942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyOverrideInRow_Internal(IntPtr @this, FName RowName);

		// Token: 0x06016B0F RID: 92943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllResolvedRowNames_Internal(IntPtr @this);

		// Token: 0x06016B10 RID: 92944 RVA: 0x00211D6F File Offset: 0x0020FF6F
		static UKuroDerivedDataTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.KuroDerivedDataTable");
		}

		// Token: 0x06016B11 RID: 92945 RVA: 0x00211D7D File Offset: 0x0020FF7D
		protected UKuroDerivedDataTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C50F RID: 50447
		public new const string __ObjectPath = "/Script/KuroData.KuroDerivedDataTable";

		// Token: 0x0400C510 RID: 50448
		private static IntPtr _ClassPtr;

		// Token: 0x0400C511 RID: 50449
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C512 RID: 50450
		internal static int __PropertyOffset_ParentDataTable;

		// Token: 0x0400C513 RID: 50451
		internal static int __PropertyOffset_OverriddenFields;

		// Token: 0x0400C514 RID: 50452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _OverriddenFields;

		// Token: 0x0400C515 RID: 50453
		internal static int __PropertyOffset_ChildOnlyRows;

		// Token: 0x0400C516 RID: 50454
		[Nullable(2)]
		private TSet<FName> _ChildOnlyRows;
	}
}
