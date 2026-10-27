using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009A9 RID: 2473
	[UnrealObjectPath("/Script/Engine.DebuggingInfoForSingleFunction")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 400)]
	public class FDebuggingInfoForSingleFunction : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008B9B RID: 35739 RVA: 0x000C7FEE File Offset: 0x000C61EE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDebuggingInfoForSingleFunction._ScriptStructPtr != 0) ? FDebuggingInfoForSingleFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DebuggingInfoForSingleFunction", ref FDebuggingInfoForSingleFunction._ScriptStructPtr);
		}

		// Token: 0x06008B9C RID: 35740 RVA: 0x000C8012 File Offset: 0x000C6212
		public FDebuggingInfoForSingleFunction()
		{
		}

		// Token: 0x06008B9D RID: 35741 RVA: 0x000C801A File Offset: 0x000C621A
		protected override IntPtr GetUStructPtr()
		{
			return FDebuggingInfoForSingleFunction.StaticStruct();
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x000C8026 File Offset: 0x000C6226
		[NullableContext(2)]
		public FDebuggingInfoForSingleFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x000C8030 File Offset: 0x000C6230
		public FDebuggingInfoForSingleFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x000C803B File Offset: 0x000C623B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDebuggingInfoForSingleFunction(Pointer, false, true);
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x000C8045 File Offset: 0x000C6245
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDebuggingInfoForSingleFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04004251 RID: 16977
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DebuggingInfoForSingleFunction";

		// Token: 0x04004252 RID: 16978
		private static IntPtr _ScriptStructPtr;
	}
}
