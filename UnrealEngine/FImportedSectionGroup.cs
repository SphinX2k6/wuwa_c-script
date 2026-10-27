using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C43 RID: 3139
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ImportedSectionGroup")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FImportedSectionGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009F53 RID: 40787 RVA: 0x000E2770 File Offset: 0x000E0970
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FImportedSectionGroup._ScriptStructPtr != 0) ? FImportedSectionGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ImportedSectionGroup", ref FImportedSectionGroup._ScriptStructPtr);
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x06009F54 RID: 40788 RVA: 0x000E2794 File Offset: 0x000E0994
		// (set) Token: 0x06009F55 RID: 40789 RVA: 0x000E27D7 File Offset: 0x000E09D7
		public TMap<FName, FSectionIndexes> GroupData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FSectionIndexes> result;
				if ((result = this._GroupData) == null)
				{
					result = (this._GroupData = new TMap<FName, FSectionIndexes>(base.NativePtr + (IntPtr)FImportedSectionGroup.__PropertyOffset_GroupData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GroupData.CopyAssign(value);
			}
		}

		// Token: 0x06009F56 RID: 40790 RVA: 0x000E27E5 File Offset: 0x000E09E5
		public FImportedSectionGroup()
		{
		}

		// Token: 0x06009F57 RID: 40791 RVA: 0x000E27ED File Offset: 0x000E09ED
		public FImportedSectionGroup(TMap<FName, FSectionIndexes> GroupData)
		{
			this.GroupData = GroupData;
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x000E27FC File Offset: 0x000E09FC
		protected override IntPtr GetUStructPtr()
		{
			return FImportedSectionGroup.StaticStruct();
		}

		// Token: 0x06009F59 RID: 40793 RVA: 0x000E2808 File Offset: 0x000E0A08
		[NullableContext(2)]
		public FImportedSectionGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009F5A RID: 40794 RVA: 0x000E2812 File Offset: 0x000E0A12
		public FImportedSectionGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009F5B RID: 40795 RVA: 0x000E281D File Offset: 0x000E0A1D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FImportedSectionGroup(Pointer, false, true);
		}

		// Token: 0x06009F5C RID: 40796 RVA: 0x000E2827 File Offset: 0x000E0A27
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FImportedSectionGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040057B5 RID: 22453
		public const string __ObjectPath = "/Script/Engine.ImportedSectionGroup";

		// Token: 0x040057B6 RID: 22454
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040057B7 RID: 22455
		internal static int __PropertyOffset_GroupData;

		// Token: 0x040057B8 RID: 22456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FSectionIndexes> _GroupData;
	}
}
