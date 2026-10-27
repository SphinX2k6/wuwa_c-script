using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022CB RID: 8907
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MeshDescription.PolygonGroupID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FPolygonGroupID : FElementID, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021DB5 RID: 138677 RVA: 0x00320857 File Offset: 0x0031EA57
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPolygonGroupID._ScriptStructPtr != 0) ? FPolygonGroupID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshDescription.PolygonGroupID", ref FPolygonGroupID._ScriptStructPtr);
		}

		// Token: 0x06021DB6 RID: 138678 RVA: 0x0032087B File Offset: 0x0031EA7B
		public FPolygonGroupID()
		{
		}

		// Token: 0x06021DB7 RID: 138679 RVA: 0x00320883 File Offset: 0x0031EA83
		public FPolygonGroupID(int IDValue)
		{
			base.IDValue = IDValue;
		}

		// Token: 0x06021DB8 RID: 138680 RVA: 0x00320892 File Offset: 0x0031EA92
		protected override IntPtr GetUStructPtr()
		{
			return FPolygonGroupID.StaticStruct();
		}

		// Token: 0x06021DB9 RID: 138681 RVA: 0x0032089E File Offset: 0x0031EA9E
		[NullableContext(2)]
		public FPolygonGroupID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021DBA RID: 138682 RVA: 0x003208A8 File Offset: 0x0031EAA8
		public FPolygonGroupID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021DBB RID: 138683 RVA: 0x003208B3 File Offset: 0x0031EAB3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPolygonGroupID(Pointer, false, true);
		}

		// Token: 0x06021DBC RID: 138684 RVA: 0x003208BD File Offset: 0x0031EABD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPolygonGroupID(Pointer, MemoryOwner);
		}

		// Token: 0x040120A4 RID: 73892
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshDescription.PolygonGroupID";

		// Token: 0x040120A5 RID: 73893
		private static IntPtr _ScriptStructPtr;
	}
}
