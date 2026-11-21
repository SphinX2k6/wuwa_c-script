using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000152 RID: 338
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.Timespan")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FTimespan : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600131C RID: 4892 RVA: 0x0001E352 File Offset: 0x0001C552
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimespan._ScriptStructPtr != 0) ? FTimespan._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Timespan", ref FTimespan._ScriptStructPtr);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0001E376 File Offset: 0x0001C576
		public FTimespan()
		{
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0001E37E File Offset: 0x0001C57E
		protected override IntPtr GetUStructPtr()
		{
			return FTimespan.StaticStruct();
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0001E38A File Offset: 0x0001C58A
		[NullableContext(2)]
		public FTimespan(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0001E394 File Offset: 0x0001C594
		public FTimespan(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0001E39F File Offset: 0x0001C59F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimespan(Pointer, false, true);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0001E3A9 File Offset: 0x0001C5A9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimespan(Pointer, MemoryOwner);
		}

		// Token: 0x0400060E RID: 1550
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.Timespan";

		// Token: 0x0400060F RID: 1551
		private static IntPtr _ScriptStructPtr;
	}
}
