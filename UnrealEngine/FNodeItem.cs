using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EF0 RID: 3824
	[UnrealObjectPath("/Script/Engine.NodeItem")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNodeItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CF6E RID: 53102 RVA: 0x0012E97E File Offset: 0x0012CB7E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNodeItem._ScriptStructPtr != 0) ? FNodeItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NodeItem", ref FNodeItem._ScriptStructPtr);
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x0600CF6F RID: 53103 RVA: 0x0012E9A2 File Offset: 0x0012CBA2
		// (set) Token: 0x0600CF70 RID: 53104 RVA: 0x0012E9B6 File Offset: 0x0012CBB6
		public unsafe FName ParentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNodeItem.__PropertyOffset_ParentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNodeItem.__PropertyOffset_ParentName) = value;
			}
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x0600CF71 RID: 53105 RVA: 0x0012E9CB File Offset: 0x0012CBCB
		// (set) Token: 0x0600CF72 RID: 53106 RVA: 0x0012E9DF File Offset: 0x0012CBDF
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNodeItem.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNodeItem.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x0600CF73 RID: 53107 RVA: 0x0012E9F4 File Offset: 0x0012CBF4
		public FNodeItem()
		{
		}

		// Token: 0x0600CF74 RID: 53108 RVA: 0x0012E9FC File Offset: 0x0012CBFC
		public FNodeItem(FName ParentName, FTransform Transform)
		{
			this.ParentName = ParentName;
			this.Transform = Transform;
		}

		// Token: 0x0600CF75 RID: 53109 RVA: 0x0012EA12 File Offset: 0x0012CC12
		protected override IntPtr GetUStructPtr()
		{
			return FNodeItem.StaticStruct();
		}

		// Token: 0x0600CF76 RID: 53110 RVA: 0x0012EA1E File Offset: 0x0012CC1E
		[NullableContext(2)]
		public FNodeItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CF77 RID: 53111 RVA: 0x0012EA28 File Offset: 0x0012CC28
		public FNodeItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CF78 RID: 53112 RVA: 0x0012EA33 File Offset: 0x0012CC33
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNodeItem(Pointer, false, true);
		}

		// Token: 0x0600CF79 RID: 53113 RVA: 0x0012EA3D File Offset: 0x0012CC3D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNodeItem(Pointer, MemoryOwner);
		}

		// Token: 0x04006FD9 RID: 28633
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NodeItem";

		// Token: 0x04006FDA RID: 28634
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006FDB RID: 28635
		internal static int __PropertyOffset_ParentName;

		// Token: 0x04006FDC RID: 28636
		internal static int __PropertyOffset_Transform;
	}
}
