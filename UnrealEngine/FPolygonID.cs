using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022CC RID: 8908
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MeshDescription.PolygonID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FPolygonID : FElementID, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021DBD RID: 138685 RVA: 0x003208C6 File Offset: 0x0031EAC6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPolygonID._ScriptStructPtr != 0) ? FPolygonID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshDescription.PolygonID", ref FPolygonID._ScriptStructPtr);
		}

		// Token: 0x06021DBE RID: 138686 RVA: 0x003208EA File Offset: 0x0031EAEA
		public FPolygonID()
		{
		}

		// Token: 0x06021DBF RID: 138687 RVA: 0x003208F2 File Offset: 0x0031EAF2
		public FPolygonID(int IDValue)
		{
			base.IDValue = IDValue;
		}

		// Token: 0x06021DC0 RID: 138688 RVA: 0x00320901 File Offset: 0x0031EB01
		protected override IntPtr GetUStructPtr()
		{
			return FPolygonID.StaticStruct();
		}

		// Token: 0x06021DC1 RID: 138689 RVA: 0x0032090D File Offset: 0x0031EB0D
		[NullableContext(2)]
		public FPolygonID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021DC2 RID: 138690 RVA: 0x00320917 File Offset: 0x0031EB17
		public FPolygonID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021DC3 RID: 138691 RVA: 0x00320922 File Offset: 0x0031EB22
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPolygonID(Pointer, false, true);
		}

		// Token: 0x06021DC4 RID: 138692 RVA: 0x0032092C File Offset: 0x0031EB2C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPolygonID(Pointer, MemoryOwner);
		}

		// Token: 0x040120A6 RID: 73894
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshDescription.PolygonID";

		// Token: 0x040120A7 RID: 73895
		private static IntPtr _ScriptStructPtr;
	}
}
