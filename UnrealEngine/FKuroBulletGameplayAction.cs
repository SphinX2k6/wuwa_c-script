using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016FC RID: 5884
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletGameplayAction")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroBulletGameplayAction : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601541A RID: 87066 RVA: 0x001F3E86 File Offset: 0x001F2086
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBulletGameplayAction._ScriptStructPtr != 0) ? FKuroBulletGameplayAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroBulletGameplayAction", ref FKuroBulletGameplayAction._ScriptStructPtr);
		}

		// Token: 0x17005414 RID: 21524
		// (get) Token: 0x0601541B RID: 87067 RVA: 0x001F3EAA File Offset: 0x001F20AA
		// (set) Token: 0x0601541C RID: 87068 RVA: 0x001F3EBE File Offset: 0x001F20BE
		public unsafe FGameplayTag ActionTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletGameplayAction.__PropertyOffset_ActionTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletGameplayAction.__PropertyOffset_ActionTag) = value;
			}
		}

		// Token: 0x0601541D RID: 87069 RVA: 0x001F3ED3 File Offset: 0x001F20D3
		public FKuroBulletGameplayAction()
		{
		}

		// Token: 0x0601541E RID: 87070 RVA: 0x001F3EDB File Offset: 0x001F20DB
		public FKuroBulletGameplayAction(FGameplayTag ActionTag)
		{
			this.ActionTag = ActionTag;
		}

		// Token: 0x0601541F RID: 87071 RVA: 0x001F3EEA File Offset: 0x001F20EA
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBulletGameplayAction.StaticStruct();
		}

		// Token: 0x06015420 RID: 87072 RVA: 0x001F3EF6 File Offset: 0x001F20F6
		[NullableContext(2)]
		public FKuroBulletGameplayAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015421 RID: 87073 RVA: 0x001F3F00 File Offset: 0x001F2100
		public FKuroBulletGameplayAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015422 RID: 87074 RVA: 0x001F3F0B File Offset: 0x001F210B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBulletGameplayAction(Pointer, false, true);
		}

		// Token: 0x06015423 RID: 87075 RVA: 0x001F3F15 File Offset: 0x001F2115
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBulletGameplayAction(Pointer, MemoryOwner);
		}

		// Token: 0x0400B970 RID: 47472
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletGameplayAction";

		// Token: 0x0400B971 RID: 47473
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B972 RID: 47474
		internal static int __PropertyOffset_ActionTag;
	}
}
