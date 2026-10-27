using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C58 RID: 3160
	[UnrealObjectPath("/Script/Engine.InputClampState")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FInputClampState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A038 RID: 41016 RVA: 0x000E3A8F File Offset: 0x000E1C8F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputClampState._ScriptStructPtr != 0) ? FInputClampState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputClampState", ref FInputClampState._ScriptStructPtr);
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x000E3AB3 File Offset: 0x000E1CB3
		public FInputClampState()
		{
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x000E3ABB File Offset: 0x000E1CBB
		protected override IntPtr GetUStructPtr()
		{
			return FInputClampState.StaticStruct();
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x000E3AC7 File Offset: 0x000E1CC7
		[NullableContext(2)]
		public FInputClampState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x000E3AD1 File Offset: 0x000E1CD1
		public FInputClampState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x000E3ADC File Offset: 0x000E1CDC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputClampState(Pointer, false, true);
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x000E3AE6 File Offset: 0x000E1CE6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputClampState(Pointer, MemoryOwner);
		}

		// Token: 0x04005823 RID: 22563
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InputClampState";

		// Token: 0x04005824 RID: 22564
		private static IntPtr _ScriptStructPtr;
	}
}
