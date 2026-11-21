using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200045B RID: 1115
	[UnrealObjectPath("/Script/KuroMath.KuroGeometryGeneralPolygonList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroGeometryGeneralPolygonList : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B26 RID: 27430 RVA: 0x0009C0C9 File Offset: 0x0009A2C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGeometryGeneralPolygonList._ScriptStructPtr != 0) ? FKuroGeometryGeneralPolygonList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMath.KuroGeometryGeneralPolygonList", ref FKuroGeometryGeneralPolygonList._ScriptStructPtr);
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x0009C0ED File Offset: 0x0009A2ED
		public FKuroGeometryGeneralPolygonList()
		{
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x0009C0F5 File Offset: 0x0009A2F5
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGeometryGeneralPolygonList.StaticStruct();
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x0009C101 File Offset: 0x0009A301
		[NullableContext(2)]
		public FKuroGeometryGeneralPolygonList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x0009C10B File Offset: 0x0009A30B
		public FKuroGeometryGeneralPolygonList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x0009C116 File Offset: 0x0009A316
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGeometryGeneralPolygonList(Pointer, false, true);
		}

		// Token: 0x06006B2C RID: 27436 RVA: 0x0009C120 File Offset: 0x0009A320
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGeometryGeneralPolygonList(Pointer, MemoryOwner);
		}

		// Token: 0x04002DA2 RID: 11682
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMath.KuroGeometryGeneralPolygonList";

		// Token: 0x04002DA3 RID: 11683
		private static IntPtr _ScriptStructPtr;
	}
}
