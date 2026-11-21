using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200081D RID: 2077
	[UnrealObjectPath("/Script/Slate.Anchors")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnchors : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B5D8 RID: 46552 RVA: 0x0012143F File Offset: 0x0011F63F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnchors._ScriptStructPtr != 0) ? FAnchors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Slate.Anchors", ref FAnchors._ScriptStructPtr);
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x0600B5D9 RID: 46553 RVA: 0x00121463 File Offset: 0x0011F663
		// (set) Token: 0x0600B5DA RID: 46554 RVA: 0x00121477 File Offset: 0x0011F677
		public unsafe FVector2D Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnchors.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnchors.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x0600B5DB RID: 46555 RVA: 0x0012148C File Offset: 0x0011F68C
		// (set) Token: 0x0600B5DC RID: 46556 RVA: 0x001214A0 File Offset: 0x0011F6A0
		public unsafe FVector2D Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnchors.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnchors.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x0600B5DD RID: 46557 RVA: 0x001214B5 File Offset: 0x0011F6B5
		public FAnchors()
		{
		}

		// Token: 0x0600B5DE RID: 46558 RVA: 0x001214BD File Offset: 0x0011F6BD
		protected override IntPtr GetUStructPtr()
		{
			return FAnchors.StaticStruct();
		}

		// Token: 0x0600B5DF RID: 46559 RVA: 0x001214C9 File Offset: 0x0011F6C9
		[NullableContext(2)]
		public FAnchors(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5E0 RID: 46560 RVA: 0x001214D3 File Offset: 0x0011F6D3
		public FAnchors(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5E1 RID: 46561 RVA: 0x001214DE File Offset: 0x0011F6DE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnchors(Pointer, false, true);
		}

		// Token: 0x0600B5E2 RID: 46562 RVA: 0x001214E8 File Offset: 0x0011F6E8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnchors(Pointer, MemoryOwner);
		}

		// Token: 0x04005224 RID: 21028
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Slate.Anchors";

		// Token: 0x04005225 RID: 21029
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005226 RID: 21030
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04005227 RID: 21031
		internal static int __PropertyOffset_Maximum;
	}
}
