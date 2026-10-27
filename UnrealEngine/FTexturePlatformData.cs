using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011DD RID: 4573
	[UnrealObjectPath("/Script/Engine.TexturePlatformData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FTexturePlatformData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010D72 RID: 68978 RVA: 0x0018BAE4 File Offset: 0x00189CE4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTexturePlatformData._ScriptStructPtr != 0) ? FTexturePlatformData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TexturePlatformData", ref FTexturePlatformData._ScriptStructPtr);
		}

		// Token: 0x06010D73 RID: 68979 RVA: 0x0018BB08 File Offset: 0x00189D08
		public FTexturePlatformData()
		{
		}

		// Token: 0x06010D74 RID: 68980 RVA: 0x0018BB10 File Offset: 0x00189D10
		protected override IntPtr GetUStructPtr()
		{
			return FTexturePlatformData.StaticStruct();
		}

		// Token: 0x06010D75 RID: 68981 RVA: 0x0018BB1C File Offset: 0x00189D1C
		[NullableContext(2)]
		public FTexturePlatformData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010D76 RID: 68982 RVA: 0x0018BB26 File Offset: 0x00189D26
		public FTexturePlatformData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010D77 RID: 68983 RVA: 0x0018BB31 File Offset: 0x00189D31
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTexturePlatformData(Pointer, false, true);
		}

		// Token: 0x06010D78 RID: 68984 RVA: 0x0018BB3B File Offset: 0x00189D3B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTexturePlatformData(Pointer, MemoryOwner);
		}

		// Token: 0x04009065 RID: 36965
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TexturePlatformData";

		// Token: 0x04009066 RID: 36966
		private static IntPtr _ScriptStructPtr;
	}
}
