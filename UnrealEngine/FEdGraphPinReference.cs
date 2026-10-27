using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000A4A RID: 2634
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.EdGraphPinReference")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FEdGraphPinReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008EFA RID: 36602 RVA: 0x000CC748 File Offset: 0x000CA948
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEdGraphPinReference._ScriptStructPtr != 0) ? FEdGraphPinReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EdGraphPinReference", ref FEdGraphPinReference._ScriptStructPtr);
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06008EFB RID: 36603 RVA: 0x000CC76C File Offset: 0x000CA96C
		// (set) Token: 0x06008EFC RID: 36604 RVA: 0x000CC780 File Offset: 0x000CA980
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UEdGraphNode> OwningNode
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphPinReference.__PropertyOffset_OwningNode);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphPinReference.__PropertyOffset_OwningNode) = value;
			}
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06008EFD RID: 36605 RVA: 0x000CC795 File Offset: 0x000CA995
		// (set) Token: 0x06008EFE RID: 36606 RVA: 0x000CC7A9 File Offset: 0x000CA9A9
		public unsafe FGuid PinId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphPinReference.__PropertyOffset_PinId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphPinReference.__PropertyOffset_PinId) = value;
			}
		}

		// Token: 0x06008EFF RID: 36607 RVA: 0x000CC7BE File Offset: 0x000CA9BE
		public FEdGraphPinReference()
		{
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x000CC7C6 File Offset: 0x000CA9C6
		public FEdGraphPinReference([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UEdGraphNode> OwningNode, FGuid PinId)
		{
			this.OwningNode = OwningNode;
			this.PinId = PinId;
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x000CC7DC File Offset: 0x000CA9DC
		protected override IntPtr GetUStructPtr()
		{
			return FEdGraphPinReference.StaticStruct();
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x000CC7E8 File Offset: 0x000CA9E8
		[NullableContext(2)]
		public FEdGraphPinReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x000CC7F2 File Offset: 0x000CA9F2
		public FEdGraphPinReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x000CC7FD File Offset: 0x000CA9FD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEdGraphPinReference(Pointer, false, true);
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x000CC807 File Offset: 0x000CAA07
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEdGraphPinReference(Pointer, MemoryOwner);
		}

		// Token: 0x04004692 RID: 18066
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.EdGraphPinReference";

		// Token: 0x04004693 RID: 18067
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004694 RID: 18068
		internal static int __PropertyOffset_OwningNode;

		// Token: 0x04004695 RID: 18069
		internal static int __PropertyOffset_PinId;
	}
}
