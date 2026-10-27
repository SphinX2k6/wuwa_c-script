using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011A9 RID: 4521
	[UnrealObjectPath("/Script/Engine.StreamedAudioPlatformData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FStreamedAudioPlatformData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010AAD RID: 68269 RVA: 0x00187B1E File Offset: 0x00185D1E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamedAudioPlatformData._ScriptStructPtr != 0) ? FStreamedAudioPlatformData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StreamedAudioPlatformData", ref FStreamedAudioPlatformData._ScriptStructPtr);
		}

		// Token: 0x06010AAE RID: 68270 RVA: 0x00187B42 File Offset: 0x00185D42
		public FStreamedAudioPlatformData()
		{
		}

		// Token: 0x06010AAF RID: 68271 RVA: 0x00187B4A File Offset: 0x00185D4A
		protected override IntPtr GetUStructPtr()
		{
			return FStreamedAudioPlatformData.StaticStruct();
		}

		// Token: 0x06010AB0 RID: 68272 RVA: 0x00187B56 File Offset: 0x00185D56
		[NullableContext(2)]
		public FStreamedAudioPlatformData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010AB1 RID: 68273 RVA: 0x00187B60 File Offset: 0x00185D60
		public FStreamedAudioPlatformData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010AB2 RID: 68274 RVA: 0x00187B6B File Offset: 0x00185D6B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamedAudioPlatformData(Pointer, false, true);
		}

		// Token: 0x06010AB3 RID: 68275 RVA: 0x00187B75 File Offset: 0x00185D75
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamedAudioPlatformData(Pointer, MemoryOwner);
		}

		// Token: 0x04008EA3 RID: 36515
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StreamedAudioPlatformData";

		// Token: 0x04008EA4 RID: 36516
		private static IntPtr _ScriptStructPtr;
	}
}
