using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000983 RID: 2435
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.CurveTableRowHandle")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCurveTableRowHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060089AD RID: 35245 RVA: 0x000C5472 File Offset: 0x000C3672
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCurveTableRowHandle._ScriptStructPtr != 0) ? FCurveTableRowHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CurveTableRowHandle", ref FCurveTableRowHandle._ScriptStructPtr);
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x060089AE RID: 35246 RVA: 0x000C5496 File Offset: 0x000C3696
		// (set) Token: 0x060089AF RID: 35247 RVA: 0x000C54AA File Offset: 0x000C36AA
		[Nullable(2)]
		public unsafe UCurveTable CurveTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveTable>(base.NativePtr / (IntPtr)sizeof(void*) + FCurveTableRowHandle.__PropertyOffset_CurveTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCurveTableRowHandle.__PropertyOffset_CurveTable, value);
			}
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x060089B0 RID: 35248 RVA: 0x000C54BF File Offset: 0x000C36BF
		// (set) Token: 0x060089B1 RID: 35249 RVA: 0x000C54D3 File Offset: 0x000C36D3
		public unsafe FName RowName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveTableRowHandle.__PropertyOffset_RowName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveTableRowHandle.__PropertyOffset_RowName) = value;
			}
		}

		// Token: 0x060089B2 RID: 35250 RVA: 0x000C54E8 File Offset: 0x000C36E8
		public FCurveTableRowHandle()
		{
		}

		// Token: 0x060089B3 RID: 35251 RVA: 0x000C54F0 File Offset: 0x000C36F0
		[NullableContext(1)]
		public FCurveTableRowHandle(UCurveTable CurveTable, FName RowName)
		{
			this.CurveTable = CurveTable;
			this.RowName = RowName;
		}

		// Token: 0x060089B4 RID: 35252 RVA: 0x000C5506 File Offset: 0x000C3706
		protected override IntPtr GetUStructPtr()
		{
			return FCurveTableRowHandle.StaticStruct();
		}

		// Token: 0x060089B5 RID: 35253 RVA: 0x000C5512 File Offset: 0x000C3712
		[NullableContext(2)]
		public FCurveTableRowHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060089B6 RID: 35254 RVA: 0x000C551C File Offset: 0x000C371C
		public FCurveTableRowHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060089B7 RID: 35255 RVA: 0x000C5527 File Offset: 0x000C3727
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCurveTableRowHandle(Pointer, false, true);
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x000C5531 File Offset: 0x000C3731
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCurveTableRowHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04004162 RID: 16738
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CurveTableRowHandle";

		// Token: 0x04004163 RID: 16739
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004164 RID: 16740
		internal static int __PropertyOffset_CurveTable;

		// Token: 0x04004165 RID: 16741
		internal static int __PropertyOffset_RowName;
	}
}
