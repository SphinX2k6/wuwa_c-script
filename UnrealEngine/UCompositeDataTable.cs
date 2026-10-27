using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000967 RID: 2407
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CompositeDataTable")]
	[UnrealStructLayout(608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UCompositeDataTable : UDataTable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060087EA RID: 34794 RVA: 0x000C2B3E File Offset: 0x000C0D3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCompositeDataTable._ClassPtr;
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x000C2B4C File Offset: 0x000C0D4C
		public UCompositeDataTable() : this(BuiltinUtils.AllocNativeUObject(UCompositeDataTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x000C2B74 File Offset: 0x000C0D74
		public UCompositeDataTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCompositeDataTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x060087ED RID: 34797 RVA: 0x000C2BA8 File Offset: 0x000C0DA8
		// (set) Token: 0x060087EE RID: 34798 RVA: 0x000C2BE1 File Offset: 0x000C0DE1
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

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x060087EF RID: 34799 RVA: 0x000C2BF0 File Offset: 0x000C0DF0
		// (set) Token: 0x060087F0 RID: 34800 RVA: 0x000C2C29 File Offset: 0x000C0E29
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

		// Token: 0x060087F1 RID: 34801 RVA: 0x000C2C37 File Offset: 0x000C0E37
		static UCompositeDataTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CompositeDataTable");
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x000C2C45 File Offset: 0x000C0E45
		protected UCompositeDataTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400409B RID: 16539
		public new const string __ObjectPath = "/Script/Engine.CompositeDataTable";

		// Token: 0x0400409C RID: 16540
		private static IntPtr _ClassPtr;

		// Token: 0x0400409D RID: 16541
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400409E RID: 16542
		internal static int __PropertyOffset_ParentTables;

		// Token: 0x0400409F RID: 16543
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDataTable> _ParentTables;

		// Token: 0x040040A0 RID: 16544
		internal static int __PropertyOffset_OldParentTables;

		// Token: 0x040040A1 RID: 16545
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDataTable> _OldParentTables;
	}
}
