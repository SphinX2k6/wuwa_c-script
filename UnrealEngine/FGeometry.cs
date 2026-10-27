using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200281A RID: 10266
	[UnrealObjectPath("/Script/SlateCore.Geometry")]
	[UnrealStructLayout(56, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FGeometry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602628E RID: 156302 RVA: 0x0039E836 File Offset: 0x0039CA36
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometry._ScriptStructPtr != 0) ? FGeometry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.Geometry", ref FGeometry._ScriptStructPtr);
		}

		// Token: 0x0602628F RID: 156303 RVA: 0x0039E85A File Offset: 0x0039CA5A
		public FGeometry()
		{
		}

		// Token: 0x06026290 RID: 156304 RVA: 0x0039E862 File Offset: 0x0039CA62
		protected override IntPtr GetUStructPtr()
		{
			return FGeometry.StaticStruct();
		}

		// Token: 0x06026291 RID: 156305 RVA: 0x0039E86E File Offset: 0x0039CA6E
		[NullableContext(2)]
		public FGeometry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026292 RID: 156306 RVA: 0x0039E878 File Offset: 0x0039CA78
		public FGeometry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026293 RID: 156307 RVA: 0x0039E883 File Offset: 0x0039CA83
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeometry(Pointer, false, true);
		}

		// Token: 0x06026294 RID: 156308 RVA: 0x0039E88D File Offset: 0x0039CA8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeometry(Pointer, MemoryOwner);
		}

		// Token: 0x04014E32 RID: 85554
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.Geometry";

		// Token: 0x04014E33 RID: 85555
		private static IntPtr _ScriptStructPtr;
	}
}
