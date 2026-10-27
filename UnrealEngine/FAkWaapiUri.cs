using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000256 RID: 598
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWaapiUri")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAkWaapiUri : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002346 RID: 9030 RVA: 0x0003431D File Offset: 0x0003251D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkWaapiUri._ScriptStructPtr != 0) ? FAkWaapiUri._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkWaapiUri", ref FAkWaapiUri._ScriptStructPtr);
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x00034341 File Offset: 0x00032541
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00034355 File Offset: 0x00032555
		public unsafe string Uri
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkWaapiUri.__PropertyOffset_Uri)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkWaapiUri.__PropertyOffset_Uri)), value);
			}
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0003436A File Offset: 0x0003256A
		public FAkWaapiUri()
		{
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00034372 File Offset: 0x00032572
		public FAkWaapiUri(string Uri)
		{
			this.Uri = Uri;
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00034381 File Offset: 0x00032581
		protected override IntPtr GetUStructPtr()
		{
			return FAkWaapiUri.StaticStruct();
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0003438D File Offset: 0x0003258D
		[NullableContext(2)]
		public FAkWaapiUri(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00034397 File Offset: 0x00032597
		public FAkWaapiUri(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x000343A2 File Offset: 0x000325A2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkWaapiUri(Pointer, false, true);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x000343AC File Offset: 0x000325AC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkWaapiUri(Pointer, MemoryOwner);
		}

		// Token: 0x04000C2A RID: 3114
		public const string __ObjectPath = "/Script/AkAudio.AkWaapiUri";

		// Token: 0x04000C2B RID: 3115
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C2C RID: 3116
		internal static int __PropertyOffset_Uri;
	}
}
