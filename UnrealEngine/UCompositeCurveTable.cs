using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000966 RID: 2406
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CompositeCurveTable")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UCompositeCurveTable : UCurveTable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060087E1 RID: 34785 RVA: 0x000C2A2F File Offset: 0x000C0C2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCompositeCurveTable._ClassPtr;
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x000C2A3C File Offset: 0x000C0C3C
		public UCompositeCurveTable() : this(BuiltinUtils.AllocNativeUObject(UCompositeCurveTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060087E3 RID: 34787 RVA: 0x000C2A64 File Offset: 0x000C0C64
		public UCompositeCurveTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCompositeCurveTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x060087E4 RID: 34788 RVA: 0x000C2A98 File Offset: 0x000C0C98
		// (set) Token: 0x060087E5 RID: 34789 RVA: 0x000C2AD1 File Offset: 0x000C0CD1
		public TArray<UCurveTable> ParentTables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCurveTable> result;
				if ((result = this._ParentTables) == null)
				{
					result = (this._ParentTables = new TArray<UCurveTable>(base.NativePtr + (IntPtr)UCompositeCurveTable.__PropertyOffset_ParentTables, this));
				}
				return result;
			}
			set
			{
				this.ParentTables.CopyAssign(value);
			}
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x060087E6 RID: 34790 RVA: 0x000C2AE0 File Offset: 0x000C0CE0
		// (set) Token: 0x060087E7 RID: 34791 RVA: 0x000C2B19 File Offset: 0x000C0D19
		public TArray<UCurveTable> OldParentTables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCurveTable> result;
				if ((result = this._OldParentTables) == null)
				{
					result = (this._OldParentTables = new TArray<UCurveTable>(base.NativePtr + (IntPtr)UCompositeCurveTable.__PropertyOffset_OldParentTables, this));
				}
				return result;
			}
			set
			{
				this.OldParentTables.CopyAssign(value);
			}
		}

		// Token: 0x060087E8 RID: 34792 RVA: 0x000C2B27 File Offset: 0x000C0D27
		static UCompositeCurveTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CompositeCurveTable");
		}

		// Token: 0x060087E9 RID: 34793 RVA: 0x000C2B35 File Offset: 0x000C0D35
		protected UCompositeCurveTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004094 RID: 16532
		public new const string __ObjectPath = "/Script/Engine.CompositeCurveTable";

		// Token: 0x04004095 RID: 16533
		private static IntPtr _ClassPtr;

		// Token: 0x04004096 RID: 16534
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004097 RID: 16535
		internal static int __PropertyOffset_ParentTables;

		// Token: 0x04004098 RID: 16536
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCurveTable> _ParentTables;

		// Token: 0x04004099 RID: 16537
		internal static int __PropertyOffset_OldParentTables;

		// Token: 0x0400409A RID: 16538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCurveTable> _OldParentTables;
	}
}
