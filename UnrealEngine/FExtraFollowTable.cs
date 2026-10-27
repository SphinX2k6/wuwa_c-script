using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200164D RID: 5709
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.ExtraFollowTable")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FExtraFollowTable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060148D8 RID: 84184 RVA: 0x001E3B83 File Offset: 0x001E1D83
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtraFollowTable._ScriptStructPtr != 0) ? FExtraFollowTable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.ExtraFollowTable", ref FExtraFollowTable._ScriptStructPtr);
		}

		// Token: 0x170050EE RID: 20718
		// (get) Token: 0x060148D9 RID: 84185 RVA: 0x001E3BA8 File Offset: 0x001E1DA8
		// (set) Token: 0x060148DA RID: 84186 RVA: 0x001E3BEB File Offset: 0x001E1DEB
		public TMap<FName, UAnimSequence> DataTable
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UAnimSequence> result;
				if ((result = this._DataTable) == null)
				{
					result = (this._DataTable = new TMap<FName, UAnimSequence>(base.NativePtr + (IntPtr)FExtraFollowTable.__PropertyOffset_DataTable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataTable.CopyAssign(value);
			}
		}

		// Token: 0x060148DB RID: 84187 RVA: 0x001E3BF9 File Offset: 0x001E1DF9
		public FExtraFollowTable()
		{
		}

		// Token: 0x060148DC RID: 84188 RVA: 0x001E3C01 File Offset: 0x001E1E01
		public FExtraFollowTable(TMap<FName, UAnimSequence> DataTable)
		{
			this.DataTable = DataTable;
		}

		// Token: 0x060148DD RID: 84189 RVA: 0x001E3C10 File Offset: 0x001E1E10
		protected override IntPtr GetUStructPtr()
		{
			return FExtraFollowTable.StaticStruct();
		}

		// Token: 0x060148DE RID: 84190 RVA: 0x001E3C1C File Offset: 0x001E1E1C
		[NullableContext(2)]
		public FExtraFollowTable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060148DF RID: 84191 RVA: 0x001E3C26 File Offset: 0x001E1E26
		public FExtraFollowTable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060148E0 RID: 84192 RVA: 0x001E3C31 File Offset: 0x001E1E31
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtraFollowTable(Pointer, false, true);
		}

		// Token: 0x060148E1 RID: 84193 RVA: 0x001E3C3B File Offset: 0x001E1E3B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtraFollowTable(Pointer, MemoryOwner);
		}

		// Token: 0x0400B391 RID: 45969
		public const string __ObjectPath = "/Script/KuroAnim.ExtraFollowTable";

		// Token: 0x0400B392 RID: 45970
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B393 RID: 45971
		internal static int __PropertyOffset_DataTable;

		// Token: 0x0400B394 RID: 45972
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UAnimSequence> _DataTable;
	}
}
