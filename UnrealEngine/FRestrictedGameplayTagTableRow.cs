using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013EC RID: 5100
	[UnrealObjectPath("/Script/GameplayTags.RestrictedGameplayTagTableRow")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRestrictedGameplayTagTableRow : FGameplayTagTableRow, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012A3C RID: 76348 RVA: 0x001B6D66 File Offset: 0x001B4F66
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRestrictedGameplayTagTableRow._ScriptStructPtr != 0) ? FRestrictedGameplayTagTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.RestrictedGameplayTagTableRow", ref FRestrictedGameplayTagTableRow._ScriptStructPtr);
		}

		// Token: 0x17004840 RID: 18496
		// (get) Token: 0x06012A3D RID: 76349 RVA: 0x001B6D8A File Offset: 0x001B4F8A
		// (set) Token: 0x06012A3E RID: 76350 RVA: 0x001B6D9A File Offset: 0x001B4F9A
		public unsafe bool bAllowNonRestrictedChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRestrictedGameplayTagTableRow.__PropertyOffset_bAllowNonRestrictedChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRestrictedGameplayTagTableRow.__PropertyOffset_bAllowNonRestrictedChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x06012A3F RID: 76351 RVA: 0x001B6DAB File Offset: 0x001B4FAB
		public FRestrictedGameplayTagTableRow()
		{
		}

		// Token: 0x06012A40 RID: 76352 RVA: 0x001B6DB3 File Offset: 0x001B4FB3
		[NullableContext(1)]
		public FRestrictedGameplayTagTableRow(bool bAllowNonRestrictedChildren, FName Tag, string DevComment)
		{
			this.bAllowNonRestrictedChildren = bAllowNonRestrictedChildren;
			base.Tag = Tag;
			base.DevComment = DevComment;
		}

		// Token: 0x06012A41 RID: 76353 RVA: 0x001B6DD0 File Offset: 0x001B4FD0
		protected override IntPtr GetUStructPtr()
		{
			return FRestrictedGameplayTagTableRow.StaticStruct();
		}

		// Token: 0x06012A42 RID: 76354 RVA: 0x001B6DDC File Offset: 0x001B4FDC
		[NullableContext(2)]
		public FRestrictedGameplayTagTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012A43 RID: 76355 RVA: 0x001B6DE6 File Offset: 0x001B4FE6
		public FRestrictedGameplayTagTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012A44 RID: 76356 RVA: 0x001B6DF1 File Offset: 0x001B4FF1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRestrictedGameplayTagTableRow(Pointer, false, true);
		}

		// Token: 0x06012A45 RID: 76357 RVA: 0x001B6DFB File Offset: 0x001B4FFB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRestrictedGameplayTagTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x04009F57 RID: 40791
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayTags.RestrictedGameplayTagTableRow";

		// Token: 0x04009F58 RID: 40792
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009F59 RID: 40793
		internal static int __PropertyOffset_bAllowNonRestrictedChildren;
	}
}
