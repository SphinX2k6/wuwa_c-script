using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000520 RID: 1312
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/ControlRig.RigElementKeyCollection")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigElementKeyCollection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044D0 RID: 17616 RVA: 0x00066722 File Offset: 0x00064922
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigElementKeyCollection._ScriptStructPtr != 0) ? FRigElementKeyCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigElementKeyCollection", ref FRigElementKeyCollection._ScriptStructPtr);
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x00066746 File Offset: 0x00064946
		public FRigElementKeyCollection()
		{
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x0006674E File Offset: 0x0006494E
		protected override IntPtr GetUStructPtr()
		{
			return FRigElementKeyCollection.StaticStruct();
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x0006675A File Offset: 0x0006495A
		[NullableContext(2)]
		public FRigElementKeyCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x00066764 File Offset: 0x00064964
		public FRigElementKeyCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x0006676F File Offset: 0x0006496F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigElementKeyCollection(Pointer, false, true);
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x00066779 File Offset: 0x00064979
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigElementKeyCollection(Pointer, MemoryOwner);
		}

		// Token: 0x04002185 RID: 8581
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigElementKeyCollection";

		// Token: 0x04002186 RID: 8582
		private static IntPtr _ScriptStructPtr;
	}
}
