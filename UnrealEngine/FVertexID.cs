using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022CE RID: 8910
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MeshDescription.VertexID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FVertexID : FElementID, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021DCD RID: 138701 RVA: 0x003209A4 File Offset: 0x0031EBA4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVertexID._ScriptStructPtr != 0) ? FVertexID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshDescription.VertexID", ref FVertexID._ScriptStructPtr);
		}

		// Token: 0x06021DCE RID: 138702 RVA: 0x003209C8 File Offset: 0x0031EBC8
		public FVertexID()
		{
		}

		// Token: 0x06021DCF RID: 138703 RVA: 0x003209D0 File Offset: 0x0031EBD0
		public FVertexID(int IDValue)
		{
			base.IDValue = IDValue;
		}

		// Token: 0x06021DD0 RID: 138704 RVA: 0x003209DF File Offset: 0x0031EBDF
		protected override IntPtr GetUStructPtr()
		{
			return FVertexID.StaticStruct();
		}

		// Token: 0x06021DD1 RID: 138705 RVA: 0x003209EB File Offset: 0x0031EBEB
		[NullableContext(2)]
		public FVertexID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021DD2 RID: 138706 RVA: 0x003209F5 File Offset: 0x0031EBF5
		public FVertexID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021DD3 RID: 138707 RVA: 0x00320A00 File Offset: 0x0031EC00
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVertexID(Pointer, false, true);
		}

		// Token: 0x06021DD4 RID: 138708 RVA: 0x00320A0A File Offset: 0x0031EC0A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVertexID(Pointer, MemoryOwner);
		}

		// Token: 0x040120AA RID: 73898
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshDescription.VertexID";

		// Token: 0x040120AB RID: 73899
		private static IntPtr _ScriptStructPtr;
	}
}
