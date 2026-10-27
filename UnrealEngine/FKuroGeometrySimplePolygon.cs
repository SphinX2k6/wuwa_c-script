using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019C6 RID: 6598
	[UnrealObjectPath("/Script/KuroMath.KuroGeometrySimplePolygon")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroGeometrySimplePolygon : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601884D RID: 100429 RVA: 0x00241D12 File Offset: 0x0023FF12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGeometrySimplePolygon._ScriptStructPtr != 0) ? FKuroGeometrySimplePolygon._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMath.KuroGeometrySimplePolygon", ref FKuroGeometrySimplePolygon._ScriptStructPtr);
		}

		// Token: 0x0601884E RID: 100430 RVA: 0x00241D36 File Offset: 0x0023FF36
		public FKuroGeometrySimplePolygon()
		{
		}

		// Token: 0x0601884F RID: 100431 RVA: 0x00241D3E File Offset: 0x0023FF3E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGeometrySimplePolygon.StaticStruct();
		}

		// Token: 0x06018850 RID: 100432 RVA: 0x00241D4A File Offset: 0x0023FF4A
		[NullableContext(2)]
		public FKuroGeometrySimplePolygon(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018851 RID: 100433 RVA: 0x00241D54 File Offset: 0x0023FF54
		public FKuroGeometrySimplePolygon(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018852 RID: 100434 RVA: 0x00241D5F File Offset: 0x0023FF5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGeometrySimplePolygon(Pointer, false, true);
		}

		// Token: 0x06018853 RID: 100435 RVA: 0x00241D69 File Offset: 0x0023FF69
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGeometrySimplePolygon(Pointer, MemoryOwner);
		}

		// Token: 0x0400D408 RID: 54280
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMath.KuroGeometrySimplePolygon";

		// Token: 0x0400D409 RID: 54281
		private static IntPtr _ScriptStructPtr;
	}
}
