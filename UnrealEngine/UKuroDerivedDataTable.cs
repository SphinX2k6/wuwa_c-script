using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000368 RID: 872
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroData.KuroDerivedDataTable")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UKuroDerivedDataTable : UDataTable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060058BE RID: 22718 RVA: 0x0007D0BF File Offset: 0x0007B2BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDerivedDataTable._ClassPtr;
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x0007D0CC File Offset: 0x0007B2CC
		public UKuroDerivedDataTable() : this(BuiltinUtils.AllocNativeUObject(UKuroDerivedDataTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x0007D0F4 File Offset: 0x0007B2F4
		public UKuroDerivedDataTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDerivedDataTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060058C1 RID: 22721 RVA: 0x0007D127 File Offset: 0x0007B327
		// (set) Token: 0x060058C2 RID: 22722 RVA: 0x0007D13B File Offset: 0x0007B33B
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

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060058C3 RID: 22723 RVA: 0x0007D150 File Offset: 0x0007B350
		// (set) Token: 0x060058C4 RID: 22724 RVA: 0x0007D189 File Offset: 0x0007B389
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

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x060058C5 RID: 22725 RVA: 0x0007D198 File Offset: 0x0007B398
		// (set) Token: 0x060058C6 RID: 22726 RVA: 0x0007D1D1 File Offset: 0x0007B3D1
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

		// Token: 0x060058C7 RID: 22727 RVA: 0x0007D1DF File Offset: 0x0007B3DF
		public void UnmarkFieldOverridden(FName RowName, FName PropertyName)
		{
			UKuroDerivedDataTable.__UnmarkFieldOverridden_Internal(base.NativePtr, RowName, PropertyName);
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x0007D1EE File Offset: 0x0007B3EE
		public void RevertRowToParent(FName RowName)
		{
			UKuroDerivedDataTable.__RevertRowToParent_Internal(base.NativePtr, RowName);
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x0007D1FC File Offset: 0x0007B3FC
		public void MarkRowFullyOverridden(FName RowName)
		{
			UKuroDerivedDataTable.__MarkRowFullyOverridden_Internal(base.NativePtr, RowName);
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x0007D20A File Offset: 0x0007B40A
		public void MarkFieldOverridden(FName RowName, FName PropertyName)
		{
			UKuroDerivedDataTable.__MarkFieldOverridden_Internal(base.NativePtr, RowName, PropertyName);
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x0007D219 File Offset: 0x0007B419
		public bool IsFieldOverridden(FName RowName, FName PropertyName)
		{
			return UKuroDerivedDataTable.__IsFieldOverridden_Internal(base.NativePtr, RowName, PropertyName);
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x0007D228 File Offset: 0x0007B428
		public bool IsChildOnlyRow(FName RowName)
		{
			return UKuroDerivedDataTable.__IsChildOnlyRow_Internal(base.NativePtr, RowName);
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x0007D236 File Offset: 0x0007B436
		public bool HasAnyOverrideInRow(FName RowName)
		{
			return UKuroDerivedDataTable.__HasAnyOverrideInRow_Internal(base.NativePtr, RowName);
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x0007D244 File Offset: 0x0007B444
		public TArray<FName> GetAllResolvedRowNames()
		{
			return new TArray<FName>(UKuroDerivedDataTable.__GetAllResolvedRowNames_Internal(base.NativePtr), null);
		}

		// Token: 0x060058CF RID: 22735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnmarkFieldOverridden_Internal(IntPtr @this, FName RowName, FName PropertyName);

		// Token: 0x060058D0 RID: 22736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertRowToParent_Internal(IntPtr @this, FName RowName);

		// Token: 0x060058D1 RID: 22737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkRowFullyOverridden_Internal(IntPtr @this, FName RowName);

		// Token: 0x060058D2 RID: 22738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkFieldOverridden_Internal(IntPtr @this, FName RowName, FName PropertyName);

		// Token: 0x060058D3 RID: 22739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFieldOverridden_Internal(IntPtr @this, FName RowName, FName PropertyName);

		// Token: 0x060058D4 RID: 22740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsChildOnlyRow_Internal(IntPtr @this, FName RowName);

		// Token: 0x060058D5 RID: 22741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyOverrideInRow_Internal(IntPtr @this, FName RowName);

		// Token: 0x060058D6 RID: 22742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllResolvedRowNames_Internal(IntPtr @this);

		// Token: 0x060058D7 RID: 22743 RVA: 0x0007D257 File Offset: 0x0007B457
		static UKuroDerivedDataTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.KuroDerivedDataTable");
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x0007D265 File Offset: 0x0007B465
		protected UKuroDerivedDataTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040024A4 RID: 9380
		public new const string __ObjectPath = "/Script/KuroData.KuroDerivedDataTable";

		// Token: 0x040024A5 RID: 9381
		private static IntPtr _ClassPtr;

		// Token: 0x040024A6 RID: 9382
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040024A7 RID: 9383
		internal static int __PropertyOffset_ParentDataTable;

		// Token: 0x040024A8 RID: 9384
		internal static int __PropertyOffset_OverriddenFields;

		// Token: 0x040024A9 RID: 9385
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _OverriddenFields;

		// Token: 0x040024AA RID: 9386
		internal static int __PropertyOffset_ChildOnlyRows;

		// Token: 0x040024AB RID: 9387
		[Nullable(2)]
		private TSet<FName> _ChildOnlyRows;
	}
}
