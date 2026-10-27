using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200080C RID: 2060
	[UnrealObjectPath("/Script/Engine.AnimInstanceProxy")]
	[UnrealStructLayout(2400, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2400)]
	public class FAnimInstanceProxy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006EA4 RID: 28324 RVA: 0x0009EAF6 File Offset: 0x0009CCF6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimInstanceProxy._ScriptStructPtr != 0) ? FAnimInstanceProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimInstanceProxy", ref FAnimInstanceProxy._ScriptStructPtr);
		}

		// Token: 0x06006EA5 RID: 28325 RVA: 0x0009EB1A File Offset: 0x0009CD1A
		public FAnimInstanceProxy()
		{
		}

		// Token: 0x06006EA6 RID: 28326 RVA: 0x0009EB22 File Offset: 0x0009CD22
		protected override IntPtr GetUStructPtr()
		{
			return FAnimInstanceProxy.StaticStruct();
		}

		// Token: 0x06006EA7 RID: 28327 RVA: 0x0009EB2E File Offset: 0x0009CD2E
		[NullableContext(2)]
		public FAnimInstanceProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x0009EB38 File Offset: 0x0009CD38
		public FAnimInstanceProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x0009EB43 File Offset: 0x0009CD43
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimInstanceProxy(Pointer, false, true);
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x0009EB4D File Offset: 0x0009CD4D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimInstanceProxy(Pointer, MemoryOwner);
		}

		// Token: 0x04003520 RID: 13600
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimInstanceProxy";

		// Token: 0x04003521 RID: 13601
		private static IntPtr _ScriptStructPtr;
	}
}
