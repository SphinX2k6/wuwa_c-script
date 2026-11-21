using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000311 RID: 785
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioEnvironmentInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroAudioEnvironmentInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005365 RID: 21349 RVA: 0x000749EE File Offset: 0x00072BEE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAudioEnvironmentInfo._ScriptStructPtr != 0) ? FKuroAudioEnvironmentInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAudio.KuroAudioEnvironmentInfo", ref FKuroAudioEnvironmentInfo._ScriptStructPtr);
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06005366 RID: 21350 RVA: 0x00074A12 File Offset: 0x00072C12
		// (set) Token: 0x06005367 RID: 21351 RVA: 0x00074A26 File Offset: 0x00072C26
		public unsafe string StateEvent
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAudioEnvironmentInfo.__PropertyOffset_StateEvent)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAudioEnvironmentInfo.__PropertyOffset_StateEvent)), value);
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x00074A3B File Offset: 0x00072C3B
		// (set) Token: 0x06005369 RID: 21353 RVA: 0x00074A4B File Offset: 0x00072C4B
		public unsafe bool bEnableDynamicReverb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAudioEnvironmentInfo.__PropertyOffset_bEnableDynamicReverb) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAudioEnvironmentInfo.__PropertyOffset_bEnableDynamicReverb) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00074A5C File Offset: 0x00072C5C
		public FKuroAudioEnvironmentInfo()
		{
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x00074A64 File Offset: 0x00072C64
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAudioEnvironmentInfo.StaticStruct();
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x00074A70 File Offset: 0x00072C70
		[NullableContext(2)]
		public FKuroAudioEnvironmentInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00074A7A File Offset: 0x00072C7A
		public FKuroAudioEnvironmentInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00074A85 File Offset: 0x00072C85
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAudioEnvironmentInfo(Pointer, false, true);
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00074A8F File Offset: 0x00072C8F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAudioEnvironmentInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400221F RID: 8735
		public const string __ObjectPath = "/Script/KuroAudio.KuroAudioEnvironmentInfo";

		// Token: 0x04002220 RID: 8736
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002221 RID: 8737
		internal static int __PropertyOffset_StateEvent;

		// Token: 0x04002222 RID: 8738
		internal static int __PropertyOffset_bEnableDynamicReverb;
	}
}
