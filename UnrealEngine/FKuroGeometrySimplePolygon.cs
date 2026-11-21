using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200045C RID: 1116
	[UnrealObjectPath("/Script/KuroMath.KuroGeometrySimplePolygon")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroGeometrySimplePolygon : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B2D RID: 27437 RVA: 0x0009C129 File Offset: 0x0009A329
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGeometrySimplePolygon._ScriptStructPtr != 0) ? FKuroGeometrySimplePolygon._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMath.KuroGeometrySimplePolygon", ref FKuroGeometrySimplePolygon._ScriptStructPtr);
		}

		// Token: 0x06006B2E RID: 27438 RVA: 0x0009C14D File Offset: 0x0009A34D
		public FKuroGeometrySimplePolygon()
		{
		}

		// Token: 0x06006B2F RID: 27439 RVA: 0x0009C155 File Offset: 0x0009A355
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGeometrySimplePolygon.StaticStruct();
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x0009C161 File Offset: 0x0009A361
		[NullableContext(2)]
		public FKuroGeometrySimplePolygon(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x0009C16B File Offset: 0x0009A36B
		public FKuroGeometrySimplePolygon(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x0009C176 File Offset: 0x0009A376
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGeometrySimplePolygon(Pointer, false, true);
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x0009C180 File Offset: 0x0009A380
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGeometrySimplePolygon(Pointer, MemoryOwner);
		}

		// Token: 0x04002DA4 RID: 11684
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMath.KuroGeometrySimplePolygon";

		// Token: 0x04002DA5 RID: 11685
		private static IntPtr _ScriptStructPtr;
	}
}
