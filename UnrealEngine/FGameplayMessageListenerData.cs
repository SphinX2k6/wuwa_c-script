using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013CD RID: 5069
	[UnrealObjectPath("/Script/GameplayMessageRuntime.GameplayMessageListenerData")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FGameplayMessageListenerData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060128F1 RID: 76017 RVA: 0x001B4FA7 File Offset: 0x001B31A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayMessageListenerData._ScriptStructPtr != 0) ? FGameplayMessageListenerData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayMessageRuntime.GameplayMessageListenerData", ref FGameplayMessageListenerData._ScriptStructPtr);
		}

		// Token: 0x060128F2 RID: 76018 RVA: 0x001B4FCB File Offset: 0x001B31CB
		public FGameplayMessageListenerData()
		{
		}

		// Token: 0x060128F3 RID: 76019 RVA: 0x001B4FD3 File Offset: 0x001B31D3
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayMessageListenerData.StaticStruct();
		}

		// Token: 0x060128F4 RID: 76020 RVA: 0x001B4FDF File Offset: 0x001B31DF
		[NullableContext(2)]
		public FGameplayMessageListenerData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060128F5 RID: 76021 RVA: 0x001B4FE9 File Offset: 0x001B31E9
		public FGameplayMessageListenerData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060128F6 RID: 76022 RVA: 0x001B4FF4 File Offset: 0x001B31F4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayMessageListenerData(Pointer, false, true);
		}

		// Token: 0x060128F7 RID: 76023 RVA: 0x001B4FFE File Offset: 0x001B31FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayMessageListenerData(Pointer, MemoryOwner);
		}

		// Token: 0x04009EB8 RID: 40632
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayMessageRuntime.GameplayMessageListenerData";

		// Token: 0x04009EB9 RID: 40633
		private static IntPtr _ScriptStructPtr;
	}
}
