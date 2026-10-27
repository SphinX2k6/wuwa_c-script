using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001697 RID: 5783
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioEnvironmentInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroAudioEnvironmentInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014F83 RID: 85891 RVA: 0x001ED2C6 File Offset: 0x001EB4C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAudioEnvironmentInfo._ScriptStructPtr != 0) ? FKuroAudioEnvironmentInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAudio.KuroAudioEnvironmentInfo", ref FKuroAudioEnvironmentInfo._ScriptStructPtr);
		}

		// Token: 0x1700530D RID: 21261
		// (get) Token: 0x06014F84 RID: 85892 RVA: 0x001ED2EA File Offset: 0x001EB4EA
		// (set) Token: 0x06014F85 RID: 85893 RVA: 0x001ED2FE File Offset: 0x001EB4FE
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

		// Token: 0x1700530E RID: 21262
		// (get) Token: 0x06014F86 RID: 85894 RVA: 0x001ED313 File Offset: 0x001EB513
		// (set) Token: 0x06014F87 RID: 85895 RVA: 0x001ED323 File Offset: 0x001EB523
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

		// Token: 0x06014F88 RID: 85896 RVA: 0x001ED334 File Offset: 0x001EB534
		public FKuroAudioEnvironmentInfo()
		{
		}

		// Token: 0x06014F89 RID: 85897 RVA: 0x001ED33C File Offset: 0x001EB53C
		public FKuroAudioEnvironmentInfo(string StateEvent, bool bEnableDynamicReverb)
		{
			this.StateEvent = StateEvent;
			this.bEnableDynamicReverb = bEnableDynamicReverb;
		}

		// Token: 0x06014F8A RID: 85898 RVA: 0x001ED352 File Offset: 0x001EB552
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAudioEnvironmentInfo.StaticStruct();
		}

		// Token: 0x06014F8B RID: 85899 RVA: 0x001ED35E File Offset: 0x001EB55E
		[NullableContext(2)]
		public FKuroAudioEnvironmentInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014F8C RID: 85900 RVA: 0x001ED368 File Offset: 0x001EB568
		public FKuroAudioEnvironmentInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014F8D RID: 85901 RVA: 0x001ED373 File Offset: 0x001EB573
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAudioEnvironmentInfo(Pointer, false, true);
		}

		// Token: 0x06014F8E RID: 85902 RVA: 0x001ED37D File Offset: 0x001EB57D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAudioEnvironmentInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400B6CD RID: 46797
		public const string __ObjectPath = "/Script/KuroAudio.KuroAudioEnvironmentInfo";

		// Token: 0x0400B6CE RID: 46798
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B6CF RID: 46799
		internal static int __PropertyOffset_StateEvent;

		// Token: 0x0400B6D0 RID: 46800
		internal static int __PropertyOffset_bEnableDynamicReverb;
	}
}
