using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EF3 RID: 3827
	[UnrealObjectPath("/Script/Engine.NodeToCodeAssociation")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FNodeToCodeAssociation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CF8A RID: 53130 RVA: 0x0012EC12 File Offset: 0x0012CE12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNodeToCodeAssociation._ScriptStructPtr != 0) ? FNodeToCodeAssociation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NodeToCodeAssociation", ref FNodeToCodeAssociation._ScriptStructPtr);
		}

		// Token: 0x0600CF8B RID: 53131 RVA: 0x0012EC36 File Offset: 0x0012CE36
		public FNodeToCodeAssociation()
		{
		}

		// Token: 0x0600CF8C RID: 53132 RVA: 0x0012EC3E File Offset: 0x0012CE3E
		protected override IntPtr GetUStructPtr()
		{
			return FNodeToCodeAssociation.StaticStruct();
		}

		// Token: 0x0600CF8D RID: 53133 RVA: 0x0012EC4A File Offset: 0x0012CE4A
		[NullableContext(2)]
		public FNodeToCodeAssociation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CF8E RID: 53134 RVA: 0x0012EC54 File Offset: 0x0012CE54
		public FNodeToCodeAssociation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CF8F RID: 53135 RVA: 0x0012EC5F File Offset: 0x0012CE5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNodeToCodeAssociation(Pointer, false, true);
		}

		// Token: 0x0600CF90 RID: 53136 RVA: 0x0012EC69 File Offset: 0x0012CE69
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNodeToCodeAssociation(Pointer, MemoryOwner);
		}

		// Token: 0x04006FE9 RID: 28649
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NodeToCodeAssociation";

		// Token: 0x04006FEA RID: 28650
		private static IntPtr _ScriptStructPtr;
	}
}
