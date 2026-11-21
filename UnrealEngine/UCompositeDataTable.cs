using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001BA RID: 442
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CompositeDataTable")]
	[UnrealStructLayout(608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UCompositeDataTable : UDataTable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002069 RID: 8297 RVA: 0x0002FC8F File Offset: 0x0002DE8F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCompositeDataTable._ClassPtr;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0002FC9C File Offset: 0x0002DE9C
		public UCompositeDataTable() : this(BuiltinUtils.AllocNativeUObject(UCompositeDataTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0002FCC4 File Offset: 0x0002DEC4
		public UCompositeDataTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCompositeDataTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x0002FCF8 File Offset: 0x0002DEF8
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x0002FD31 File Offset: 0x0002DF31
		public TArray<UDataTable> ParentTables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UDataTable> result;
				if ((result = this._ParentTables) == null)
				{
					result = (this._ParentTables = new TArray<UDataTable>(base.NativePtr + (IntPtr)UCompositeDataTable.__PropertyOffset_ParentTables, this));
				}
				return result;
			}
			set
			{
				this.ParentTables.CopyAssign(value);
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0002FD40 File Offset: 0x0002DF40
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x0002FD79 File Offset: 0x0002DF79
		public TArray<UDataTable> OldParentTables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UDataTable> result;
				if ((result = this._OldParentTables) == null)
				{
					result = (this._OldParentTables = new TArray<UDataTable>(base.NativePtr + (IntPtr)UCompositeDataTable.__PropertyOffset_OldParentTables, this));
				}
				return result;
			}
			set
			{
				this.OldParentTables.CopyAssign(value);
			}
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0002FD87 File Offset: 0x0002DF87
		static UCompositeDataTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CompositeDataTable");
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0002FD95 File Offset: 0x0002DF95
		protected UCompositeDataTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AC7 RID: 2759
		public new const string __ObjectPath = "/Script/Engine.CompositeDataTable";

		// Token: 0x04000AC8 RID: 2760
		private static IntPtr _ClassPtr;

		// Token: 0x04000AC9 RID: 2761
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000ACA RID: 2762
		internal static int __PropertyOffset_ParentTables;

		// Token: 0x04000ACB RID: 2763
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDataTable> _ParentTables;

		// Token: 0x04000ACC RID: 2764
		internal static int __PropertyOffset_OldParentTables;

		// Token: 0x04000ACD RID: 2765
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDataTable> _OldParentTables;
	}
}
