using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000255 RID: 597
	[UnrealObjectPath("/Script/AkAudio.AkWaapiSubscriptionId")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FAkWaapiSubscriptionId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600233F RID: 9023 RVA: 0x000342BD File Offset: 0x000324BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkWaapiSubscriptionId._ScriptStructPtr != 0) ? FAkWaapiSubscriptionId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkWaapiSubscriptionId", ref FAkWaapiSubscriptionId._ScriptStructPtr);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x000342E1 File Offset: 0x000324E1
		public FAkWaapiSubscriptionId()
		{
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x000342E9 File Offset: 0x000324E9
		protected override IntPtr GetUStructPtr()
		{
			return FAkWaapiSubscriptionId.StaticStruct();
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x000342F5 File Offset: 0x000324F5
		[NullableContext(2)]
		public FAkWaapiSubscriptionId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x000342FF File Offset: 0x000324FF
		public FAkWaapiSubscriptionId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0003430A File Offset: 0x0003250A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkWaapiSubscriptionId(Pointer, false, true);
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x00034314 File Offset: 0x00032514
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkWaapiSubscriptionId(Pointer, MemoryOwner);
		}

		// Token: 0x04000C28 RID: 3112
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkWaapiSubscriptionId";

		// Token: 0x04000C29 RID: 3113
		private static IntPtr _ScriptStructPtr;
	}
}
