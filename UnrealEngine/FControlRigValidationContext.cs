using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004D6 RID: 1238
	[UnrealObjectPath("/Script/ControlRig.ControlRigValidationContext")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FControlRigValidationContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600426F RID: 17007 RVA: 0x00063488 File Offset: 0x00061688
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigValidationContext._ScriptStructPtr != 0) ? FControlRigValidationContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigValidationContext", ref FControlRigValidationContext._ScriptStructPtr);
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x000634AC File Offset: 0x000616AC
		public FControlRigValidationContext()
		{
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x000634B4 File Offset: 0x000616B4
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigValidationContext.StaticStruct();
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x000634C0 File Offset: 0x000616C0
		[NullableContext(2)]
		public FControlRigValidationContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x000634CA File Offset: 0x000616CA
		public FControlRigValidationContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x000634D5 File Offset: 0x000616D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigValidationContext(Pointer, false, true);
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x000634DF File Offset: 0x000616DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigValidationContext(Pointer, MemoryOwner);
		}

		// Token: 0x04001F92 RID: 8082
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.ControlRigValidationContext";

		// Token: 0x04001F93 RID: 8083
		private static IntPtr _ScriptStructPtr;
	}
}
