using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000254 RID: 596
	[UnrealObjectPath("/Script/AkAudio.AKWaapiJsonObject")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAKWaapiJsonObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002338 RID: 9016 RVA: 0x0003425D File Offset: 0x0003245D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAKWaapiJsonObject._ScriptStructPtr != 0) ? FAKWaapiJsonObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AKWaapiJsonObject", ref FAKWaapiJsonObject._ScriptStructPtr);
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00034281 File Offset: 0x00032481
		public FAKWaapiJsonObject()
		{
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00034289 File Offset: 0x00032489
		protected override IntPtr GetUStructPtr()
		{
			return FAKWaapiJsonObject.StaticStruct();
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00034295 File Offset: 0x00032495
		[NullableContext(2)]
		public FAKWaapiJsonObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0003429F File Offset: 0x0003249F
		public FAKWaapiJsonObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x000342AA File Offset: 0x000324AA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAKWaapiJsonObject(Pointer, false, true);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x000342B4 File Offset: 0x000324B4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAKWaapiJsonObject(Pointer, MemoryOwner);
		}

		// Token: 0x04000C26 RID: 3110
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AKWaapiJsonObject";

		// Token: 0x04000C27 RID: 3111
		private static IntPtr _ScriptStructPtr;
	}
}
