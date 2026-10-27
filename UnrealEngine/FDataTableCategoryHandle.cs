using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200099E RID: 2462
	[UnrealObjectPath("/Script/Engine.DataTableCategoryHandle")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FDataTableCategoryHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008AFF RID: 35583 RVA: 0x000C724F File Offset: 0x000C544F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDataTableCategoryHandle._ScriptStructPtr != 0) ? FDataTableCategoryHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DataTableCategoryHandle", ref FDataTableCategoryHandle._ScriptStructPtr);
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06008B00 RID: 35584 RVA: 0x000C7273 File Offset: 0x000C5473
		// (set) Token: 0x06008B01 RID: 35585 RVA: 0x000C7287 File Offset: 0x000C5487
		[Nullable(2)]
		public unsafe UDataTable DataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + FDataTableCategoryHandle.__PropertyOffset_DataTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDataTableCategoryHandle.__PropertyOffset_DataTable, value);
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06008B02 RID: 35586 RVA: 0x000C729C File Offset: 0x000C549C
		// (set) Token: 0x06008B03 RID: 35587 RVA: 0x000C72B0 File Offset: 0x000C54B0
		public unsafe FName ColumnName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDataTableCategoryHandle.__PropertyOffset_ColumnName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDataTableCategoryHandle.__PropertyOffset_ColumnName) = value;
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06008B04 RID: 35588 RVA: 0x000C72C5 File Offset: 0x000C54C5
		// (set) Token: 0x06008B05 RID: 35589 RVA: 0x000C72D9 File Offset: 0x000C54D9
		public unsafe FName RowContents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDataTableCategoryHandle.__PropertyOffset_RowContents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDataTableCategoryHandle.__PropertyOffset_RowContents) = value;
			}
		}

		// Token: 0x06008B06 RID: 35590 RVA: 0x000C72EE File Offset: 0x000C54EE
		public FDataTableCategoryHandle()
		{
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x000C72F6 File Offset: 0x000C54F6
		[NullableContext(1)]
		public FDataTableCategoryHandle(UDataTable DataTable, FName ColumnName, FName RowContents)
		{
			this.DataTable = DataTable;
			this.ColumnName = ColumnName;
			this.RowContents = RowContents;
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x000C7313 File Offset: 0x000C5513
		protected override IntPtr GetUStructPtr()
		{
			return FDataTableCategoryHandle.StaticStruct();
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x000C731F File Offset: 0x000C551F
		[NullableContext(2)]
		public FDataTableCategoryHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x000C7329 File Offset: 0x000C5529
		public FDataTableCategoryHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x000C7334 File Offset: 0x000C5534
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDataTableCategoryHandle(Pointer, false, true);
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x000C733E File Offset: 0x000C553E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDataTableCategoryHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04004209 RID: 16905
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DataTableCategoryHandle";

		// Token: 0x0400420A RID: 16906
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400420B RID: 16907
		internal static int __PropertyOffset_DataTable;

		// Token: 0x0400420C RID: 16908
		internal static int __PropertyOffset_ColumnName;

		// Token: 0x0400420D RID: 16909
		internal static int __PropertyOffset_RowContents;
	}
}
