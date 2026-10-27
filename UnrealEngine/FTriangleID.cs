using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022CD RID: 8909
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MeshDescription.TriangleID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FTriangleID : FElementID, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021DC5 RID: 138693 RVA: 0x00320935 File Offset: 0x0031EB35
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTriangleID._ScriptStructPtr != 0) ? FTriangleID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshDescription.TriangleID", ref FTriangleID._ScriptStructPtr);
		}

		// Token: 0x06021DC6 RID: 138694 RVA: 0x00320959 File Offset: 0x0031EB59
		public FTriangleID()
		{
		}

		// Token: 0x06021DC7 RID: 138695 RVA: 0x00320961 File Offset: 0x0031EB61
		public FTriangleID(int IDValue)
		{
			base.IDValue = IDValue;
		}

		// Token: 0x06021DC8 RID: 138696 RVA: 0x00320970 File Offset: 0x0031EB70
		protected override IntPtr GetUStructPtr()
		{
			return FTriangleID.StaticStruct();
		}

		// Token: 0x06021DC9 RID: 138697 RVA: 0x0032097C File Offset: 0x0031EB7C
		[NullableContext(2)]
		public FTriangleID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021DCA RID: 138698 RVA: 0x00320986 File Offset: 0x0031EB86
		public FTriangleID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021DCB RID: 138699 RVA: 0x00320991 File Offset: 0x0031EB91
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTriangleID(Pointer, false, true);
		}

		// Token: 0x06021DCC RID: 138700 RVA: 0x0032099B File Offset: 0x0031EB9B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTriangleID(Pointer, MemoryOwner);
		}

		// Token: 0x040120A8 RID: 73896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshDescription.TriangleID";

		// Token: 0x040120A9 RID: 73897
		private static IntPtr _ScriptStructPtr;
	}
}
