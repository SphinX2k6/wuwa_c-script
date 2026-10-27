using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200070B RID: 1803
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.DateTime")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FDateTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600618B RID: 24971 RVA: 0x0008BDAA File Offset: 0x00089FAA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDateTime._ScriptStructPtr != 0) ? FDateTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.DateTime", ref FDateTime._ScriptStructPtr);
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x0008BDCE File Offset: 0x00089FCE
		public FDateTime()
		{
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x0008BDD6 File Offset: 0x00089FD6
		protected override IntPtr GetUStructPtr()
		{
			return FDateTime.StaticStruct();
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x0008BDE2 File Offset: 0x00089FE2
		[NullableContext(2)]
		public FDateTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x0008BDEC File Offset: 0x00089FEC
		public FDateTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x0008BDF7 File Offset: 0x00089FF7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDateTime(Pointer, false, true);
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x0008BE01 File Offset: 0x0008A001
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDateTime(Pointer, MemoryOwner);
		}

		// Token: 0x04002D9F RID: 11679
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.DateTime";

		// Token: 0x04002DA0 RID: 11680
		private static IntPtr _ScriptStructPtr;
	}
}
