using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019C5 RID: 6597
	[UnrealObjectPath("/Script/KuroMath.KuroGeometryGeneralPolygonList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroGeometryGeneralPolygonList : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018846 RID: 100422 RVA: 0x00241CB2 File Offset: 0x0023FEB2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGeometryGeneralPolygonList._ScriptStructPtr != 0) ? FKuroGeometryGeneralPolygonList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMath.KuroGeometryGeneralPolygonList", ref FKuroGeometryGeneralPolygonList._ScriptStructPtr);
		}

		// Token: 0x06018847 RID: 100423 RVA: 0x00241CD6 File Offset: 0x0023FED6
		public FKuroGeometryGeneralPolygonList()
		{
		}

		// Token: 0x06018848 RID: 100424 RVA: 0x00241CDE File Offset: 0x0023FEDE
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGeometryGeneralPolygonList.StaticStruct();
		}

		// Token: 0x06018849 RID: 100425 RVA: 0x00241CEA File Offset: 0x0023FEEA
		[NullableContext(2)]
		public FKuroGeometryGeneralPolygonList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601884A RID: 100426 RVA: 0x00241CF4 File Offset: 0x0023FEF4
		public FKuroGeometryGeneralPolygonList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601884B RID: 100427 RVA: 0x00241CFF File Offset: 0x0023FEFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGeometryGeneralPolygonList(Pointer, false, true);
		}

		// Token: 0x0601884C RID: 100428 RVA: 0x00241D09 File Offset: 0x0023FF09
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGeometryGeneralPolygonList(Pointer, MemoryOwner);
		}

		// Token: 0x0400D406 RID: 54278
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMath.KuroGeometryGeneralPolygonList";

		// Token: 0x0400D407 RID: 54279
		private static IntPtr _ScriptStructPtr;
	}
}
