using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011A8 RID: 4520
	[UnrealObjectPath("/Script/Engine.StreamableTextureInstance")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FStreamableTextureInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010AA6 RID: 68262 RVA: 0x00187ABE File Offset: 0x00185CBE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamableTextureInstance._ScriptStructPtr != 0) ? FStreamableTextureInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StreamableTextureInstance", ref FStreamableTextureInstance._ScriptStructPtr);
		}

		// Token: 0x06010AA7 RID: 68263 RVA: 0x00187AE2 File Offset: 0x00185CE2
		public FStreamableTextureInstance()
		{
		}

		// Token: 0x06010AA8 RID: 68264 RVA: 0x00187AEA File Offset: 0x00185CEA
		protected override IntPtr GetUStructPtr()
		{
			return FStreamableTextureInstance.StaticStruct();
		}

		// Token: 0x06010AA9 RID: 68265 RVA: 0x00187AF6 File Offset: 0x00185CF6
		[NullableContext(2)]
		public FStreamableTextureInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010AAA RID: 68266 RVA: 0x00187B00 File Offset: 0x00185D00
		public FStreamableTextureInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010AAB RID: 68267 RVA: 0x00187B0B File Offset: 0x00185D0B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamableTextureInstance(Pointer, false, true);
		}

		// Token: 0x06010AAC RID: 68268 RVA: 0x00187B15 File Offset: 0x00185D15
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamableTextureInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04008EA1 RID: 36513
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StreamableTextureInstance";

		// Token: 0x04008EA2 RID: 36514
		private static IntPtr _ScriptStructPtr;
	}
}
