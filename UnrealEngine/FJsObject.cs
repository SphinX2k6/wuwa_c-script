using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015B4 RID: 5556
	[UnrealObjectPath("/Script/JsEnv.JsObject")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FJsObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060140FE RID: 82174 RVA: 0x001D7076 File Offset: 0x001D5276
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJsObject._ScriptStructPtr != 0) ? FJsObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/JsEnv.JsObject", ref FJsObject._ScriptStructPtr);
		}

		// Token: 0x060140FF RID: 82175 RVA: 0x001D709A File Offset: 0x001D529A
		public FJsObject()
		{
		}

		// Token: 0x06014100 RID: 82176 RVA: 0x001D70A2 File Offset: 0x001D52A2
		protected override IntPtr GetUStructPtr()
		{
			return FJsObject.StaticStruct();
		}

		// Token: 0x06014101 RID: 82177 RVA: 0x001D70AE File Offset: 0x001D52AE
		[NullableContext(2)]
		public FJsObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014102 RID: 82178 RVA: 0x001D70B8 File Offset: 0x001D52B8
		public FJsObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014103 RID: 82179 RVA: 0x001D70C3 File Offset: 0x001D52C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJsObject(Pointer, false, true);
		}

		// Token: 0x06014104 RID: 82180 RVA: 0x001D70CD File Offset: 0x001D52CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJsObject(Pointer, MemoryOwner);
		}

		// Token: 0x0400AE84 RID: 44676
		[Nullable(1)]
		public const string __ObjectPath = "/Script/JsEnv.JsObject";

		// Token: 0x0400AE85 RID: 44677
		private static IntPtr _ScriptStructPtr;
	}
}
