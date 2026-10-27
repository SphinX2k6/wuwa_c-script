using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022CF RID: 8911
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MeshDescription.VertexInstanceID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FVertexInstanceID : FElementID, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021DD5 RID: 138709 RVA: 0x00320A13 File Offset: 0x0031EC13
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVertexInstanceID._ScriptStructPtr != 0) ? FVertexInstanceID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshDescription.VertexInstanceID", ref FVertexInstanceID._ScriptStructPtr);
		}

		// Token: 0x06021DD6 RID: 138710 RVA: 0x00320A37 File Offset: 0x0031EC37
		public FVertexInstanceID()
		{
		}

		// Token: 0x06021DD7 RID: 138711 RVA: 0x00320A3F File Offset: 0x0031EC3F
		public FVertexInstanceID(int IDValue)
		{
			base.IDValue = IDValue;
		}

		// Token: 0x06021DD8 RID: 138712 RVA: 0x00320A4E File Offset: 0x0031EC4E
		protected override IntPtr GetUStructPtr()
		{
			return FVertexInstanceID.StaticStruct();
		}

		// Token: 0x06021DD9 RID: 138713 RVA: 0x00320A5A File Offset: 0x0031EC5A
		[NullableContext(2)]
		public FVertexInstanceID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021DDA RID: 138714 RVA: 0x00320A64 File Offset: 0x0031EC64
		public FVertexInstanceID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021DDB RID: 138715 RVA: 0x00320A6F File Offset: 0x0031EC6F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVertexInstanceID(Pointer, false, true);
		}

		// Token: 0x06021DDC RID: 138716 RVA: 0x00320A79 File Offset: 0x0031EC79
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVertexInstanceID(Pointer, MemoryOwner);
		}

		// Token: 0x040120AC RID: 73900
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshDescription.VertexInstanceID";

		// Token: 0x040120AD RID: 73901
		private static IntPtr _ScriptStructPtr;
	}
}
