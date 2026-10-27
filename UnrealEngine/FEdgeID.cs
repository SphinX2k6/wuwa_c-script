using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022C7 RID: 8903
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MeshDescription.EdgeID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FEdgeID : FElementID, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021CEF RID: 138479 RVA: 0x0031F9D7 File Offset: 0x0031DBD7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEdgeID._ScriptStructPtr != 0) ? FEdgeID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshDescription.EdgeID", ref FEdgeID._ScriptStructPtr);
		}

		// Token: 0x06021CF0 RID: 138480 RVA: 0x0031F9FB File Offset: 0x0031DBFB
		public FEdgeID()
		{
		}

		// Token: 0x06021CF1 RID: 138481 RVA: 0x0031FA03 File Offset: 0x0031DC03
		public FEdgeID(int IDValue)
		{
			base.IDValue = IDValue;
		}

		// Token: 0x06021CF2 RID: 138482 RVA: 0x0031FA12 File Offset: 0x0031DC12
		protected override IntPtr GetUStructPtr()
		{
			return FEdgeID.StaticStruct();
		}

		// Token: 0x06021CF3 RID: 138483 RVA: 0x0031FA1E File Offset: 0x0031DC1E
		[NullableContext(2)]
		public FEdgeID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021CF4 RID: 138484 RVA: 0x0031FA28 File Offset: 0x0031DC28
		public FEdgeID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021CF5 RID: 138485 RVA: 0x0031FA33 File Offset: 0x0031DC33
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEdgeID(Pointer, false, true);
		}

		// Token: 0x06021CF6 RID: 138486 RVA: 0x0031FA3D File Offset: 0x0031DC3D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEdgeID(Pointer, MemoryOwner);
		}

		// Token: 0x04012099 RID: 73881
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshDescription.EdgeID";

		// Token: 0x0401209A RID: 73882
		private static IntPtr _ScriptStructPtr;
	}
}
