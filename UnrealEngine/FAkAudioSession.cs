using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001F2 RID: 498
	[UnrealObjectPath("/Script/AkAudio.AkAudioSession")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FAkAudioSession : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001D51 RID: 7505 RVA: 0x0002BAA9 File Offset: 0x00029CA9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkAudioSession._ScriptStructPtr != 0) ? FAkAudioSession._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkAudioSession", ref FAkAudioSession._ScriptStructPtr);
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x0002BACD File Offset: 0x00029CCD
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x0002BADD File Offset: 0x00029CDD
		public unsafe EAkAudioSessionCategory AudioSessionCategory
		{
			get
			{
				return (EAkAudioSessionCategory)(*(base.NativePtr + (IntPtr)FAkAudioSession.__PropertyOffset_AudioSessionCategory));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAudioSession.__PropertyOffset_AudioSessionCategory) = (int)value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x0002BAEE File Offset: 0x00029CEE
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0002BAFE File Offset: 0x00029CFE
		public unsafe uint AudioSessionCategoryOptions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAudioSession.__PropertyOffset_AudioSessionCategoryOptions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAudioSession.__PropertyOffset_AudioSessionCategoryOptions) = (int)value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0002BB0F File Offset: 0x00029D0F
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x0002BB1F File Offset: 0x00029D1F
		public unsafe EAkAudioSessionMode AudioSessionMode
		{
			get
			{
				return (EAkAudioSessionMode)(*(base.NativePtr + (IntPtr)FAkAudioSession.__PropertyOffset_AudioSessionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAudioSession.__PropertyOffset_AudioSessionMode) = (int)value;
			}
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0002BB30 File Offset: 0x00029D30
		public FAkAudioSession()
		{
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x0002BB38 File Offset: 0x00029D38
		public FAkAudioSession(EAkAudioSessionCategory AudioSessionCategory, uint AudioSessionCategoryOptions, EAkAudioSessionMode AudioSessionMode)
		{
			this.AudioSessionCategory = AudioSessionCategory;
			this.AudioSessionCategoryOptions = AudioSessionCategoryOptions;
			this.AudioSessionMode = AudioSessionMode;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0002BB55 File Offset: 0x00029D55
		protected override IntPtr GetUStructPtr()
		{
			return FAkAudioSession.StaticStruct();
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0002BB61 File Offset: 0x00029D61
		[NullableContext(2)]
		public FAkAudioSession(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x0002BB6B File Offset: 0x00029D6B
		public FAkAudioSession(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x0002BB76 File Offset: 0x00029D76
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkAudioSession(Pointer, false, true);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x0002BB80 File Offset: 0x00029D80
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkAudioSession(Pointer, MemoryOwner);
		}

		// Token: 0x040009A7 RID: 2471
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkAudioSession";

		// Token: 0x040009A8 RID: 2472
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040009A9 RID: 2473
		internal static int __PropertyOffset_AudioSessionCategory;

		// Token: 0x040009AA RID: 2474
		internal static int __PropertyOffset_AudioSessionCategoryOptions;

		// Token: 0x040009AB RID: 2475
		internal static int __PropertyOffset_AudioSessionMode;
	}
}
