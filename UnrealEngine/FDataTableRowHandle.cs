using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009A0 RID: 2464
	[UnrealObjectPath("/Script/Engine.DataTableRowHandle")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FDataTableRowHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008B1B RID: 35611 RVA: 0x000C7537 File Offset: 0x000C5737
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDataTableRowHandle._ScriptStructPtr != 0) ? FDataTableRowHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DataTableRowHandle", ref FDataTableRowHandle._ScriptStructPtr);
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06008B1C RID: 35612 RVA: 0x000C755B File Offset: 0x000C575B
		// (set) Token: 0x06008B1D RID: 35613 RVA: 0x000C756F File Offset: 0x000C576F
		[Nullable(2)]
		public unsafe UDataTable DataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + FDataTableRowHandle.__PropertyOffset_DataTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDataTableRowHandle.__PropertyOffset_DataTable, value);
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06008B1E RID: 35614 RVA: 0x000C7584 File Offset: 0x000C5784
		// (set) Token: 0x06008B1F RID: 35615 RVA: 0x000C7598 File Offset: 0x000C5798
		public unsafe FName RowName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDataTableRowHandle.__PropertyOffset_RowName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDataTableRowHandle.__PropertyOffset_RowName) = value;
			}
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x000C75AD File Offset: 0x000C57AD
		public FDataTableRowHandle()
		{
		}

		// Token: 0x06008B21 RID: 35617 RVA: 0x000C75B5 File Offset: 0x000C57B5
		[NullableContext(1)]
		public FDataTableRowHandle(UDataTable DataTable, FName RowName)
		{
			this.DataTable = DataTable;
			this.RowName = RowName;
		}

		// Token: 0x06008B22 RID: 35618 RVA: 0x000C75CB File Offset: 0x000C57CB
		protected override IntPtr GetUStructPtr()
		{
			return FDataTableRowHandle.StaticStruct();
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x000C75D7 File Offset: 0x000C57D7
		[NullableContext(2)]
		public FDataTableRowHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x000C75E1 File Offset: 0x000C57E1
		public FDataTableRowHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B25 RID: 35621 RVA: 0x000C75EC File Offset: 0x000C57EC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDataTableRowHandle(Pointer, false, true);
		}

		// Token: 0x06008B26 RID: 35622 RVA: 0x000C75F6 File Offset: 0x000C57F6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDataTableRowHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04004212 RID: 16914
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DataTableRowHandle";

		// Token: 0x04004213 RID: 16915
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004214 RID: 16916
		internal static int __PropertyOffset_DataTable;

		// Token: 0x04004215 RID: 16917
		internal static int __PropertyOffset_RowName;
	}
}
