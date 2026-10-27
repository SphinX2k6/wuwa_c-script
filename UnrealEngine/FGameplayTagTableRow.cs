using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013E9 RID: 5097
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagTableRow")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FGameplayTagTableRow : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012A1B RID: 76315 RVA: 0x001B6ABE File Offset: 0x001B4CBE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagTableRow._ScriptStructPtr != 0) ? FGameplayTagTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagTableRow", ref FGameplayTagTableRow._ScriptStructPtr);
		}

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x06012A1C RID: 76316 RVA: 0x001B6AE2 File Offset: 0x001B4CE2
		// (set) Token: 0x06012A1D RID: 76317 RVA: 0x001B6AF6 File Offset: 0x001B4CF6
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagTableRow.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagTableRow.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x1700483B RID: 18491
		// (get) Token: 0x06012A1E RID: 76318 RVA: 0x001B6B0B File Offset: 0x001B4D0B
		// (set) Token: 0x06012A1F RID: 76319 RVA: 0x001B6B1F File Offset: 0x001B4D1F
		public unsafe string DevComment
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayTagTableRow.__PropertyOffset_DevComment)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayTagTableRow.__PropertyOffset_DevComment)), value);
			}
		}

		// Token: 0x06012A20 RID: 76320 RVA: 0x001B6B34 File Offset: 0x001B4D34
		public FGameplayTagTableRow()
		{
		}

		// Token: 0x06012A21 RID: 76321 RVA: 0x001B6B3C File Offset: 0x001B4D3C
		public FGameplayTagTableRow(FName Tag, string DevComment)
		{
			this.Tag = Tag;
			this.DevComment = DevComment;
		}

		// Token: 0x06012A22 RID: 76322 RVA: 0x001B6B52 File Offset: 0x001B4D52
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagTableRow.StaticStruct();
		}

		// Token: 0x06012A23 RID: 76323 RVA: 0x001B6B5E File Offset: 0x001B4D5E
		[NullableContext(2)]
		public FGameplayTagTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012A24 RID: 76324 RVA: 0x001B6B68 File Offset: 0x001B4D68
		public FGameplayTagTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012A25 RID: 76325 RVA: 0x001B6B73 File Offset: 0x001B4D73
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagTableRow(Pointer, false, true);
		}

		// Token: 0x06012A26 RID: 76326 RVA: 0x001B6B7D File Offset: 0x001B4D7D
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x04009F48 RID: 40776
		public new const string __ObjectPath = "/Script/GameplayTags.GameplayTagTableRow";

		// Token: 0x04009F49 RID: 40777
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009F4A RID: 40778
		internal static int __PropertyOffset_Tag;

		// Token: 0x04009F4B RID: 40779
		internal static int __PropertyOffset_DevComment;
	}
}
