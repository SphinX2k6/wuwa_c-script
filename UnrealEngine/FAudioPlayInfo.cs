using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FCC RID: 8140
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.AudioPlayInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAudioPlayInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EE12 RID: 126482 RVA: 0x002DE342 File Offset: 0x002DC542
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAudioPlayInfo._ScriptStructPtr != 0) ? FAudioPlayInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.AudioPlayInfo", ref FAudioPlayInfo._ScriptStructPtr);
		}

		// Token: 0x17007AE1 RID: 31457
		// (get) Token: 0x0601EE13 RID: 126483 RVA: 0x002DE368 File Offset: 0x002DC568
		// (set) Token: 0x0601EE14 RID: 126484 RVA: 0x002DE3AB File Offset: 0x002DC5AB
		public FSoftObjectPath AkAudioEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._AkAudioEvent) == null)
				{
					result = (this._AkAudioEvent = new FSoftObjectPath(base.NativePtr + (IntPtr)FAudioPlayInfo.__PropertyOffset_AkAudioEvent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FAudioPlayInfo.__PropertyOffset_AkAudioEvent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007AE2 RID: 31458
		// (get) Token: 0x0601EE15 RID: 126485 RVA: 0x002DE3CC File Offset: 0x002DC5CC
		// (set) Token: 0x0601EE16 RID: 126486 RVA: 0x002DE40F File Offset: 0x002DC60F
		public FLGUIButtonAudioDelegate OnPostAudioEvent
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonAudioDelegate result;
				if ((result = this._OnPostAudioEvent) == null)
				{
					result = (this._OnPostAudioEvent = new FLGUIButtonAudioDelegate(base.NativePtr + (IntPtr)FAudioPlayInfo.__PropertyOffset_OnPostAudioEvent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FAudioPlayInfo.__PropertyOffset_OnPostAudioEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601EE17 RID: 126487 RVA: 0x002DE430 File Offset: 0x002DC630
		public FAudioPlayInfo()
		{
		}

		// Token: 0x0601EE18 RID: 126488 RVA: 0x002DE438 File Offset: 0x002DC638
		public FAudioPlayInfo(FSoftObjectPath AkAudioEvent, FLGUIButtonAudioDelegate OnPostAudioEvent)
		{
			this.AkAudioEvent = AkAudioEvent;
			this.OnPostAudioEvent = OnPostAudioEvent;
		}

		// Token: 0x0601EE19 RID: 126489 RVA: 0x002DE44E File Offset: 0x002DC64E
		protected override IntPtr GetUStructPtr()
		{
			return FAudioPlayInfo.StaticStruct();
		}

		// Token: 0x0601EE1A RID: 126490 RVA: 0x002DE45A File Offset: 0x002DC65A
		[NullableContext(2)]
		public FAudioPlayInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE1B RID: 126491 RVA: 0x002DE464 File Offset: 0x002DC664
		public FAudioPlayInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE1C RID: 126492 RVA: 0x002DE46F File Offset: 0x002DC66F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAudioPlayInfo(Pointer, false, true);
		}

		// Token: 0x0601EE1D RID: 126493 RVA: 0x002DE479 File Offset: 0x002DC679
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAudioPlayInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010AE5 RID: 68325
		public const string __ObjectPath = "/Script/LGUI.AudioPlayInfo";

		// Token: 0x04010AE6 RID: 68326
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010AE7 RID: 68327
		internal static int __PropertyOffset_AkAudioEvent;

		// Token: 0x04010AE8 RID: 68328
		[Nullable(2)]
		private FSoftObjectPath _AkAudioEvent;

		// Token: 0x04010AE9 RID: 68329
		internal static int __PropertyOffset_OnPostAudioEvent;

		// Token: 0x04010AEA RID: 68330
		[Nullable(2)]
		private FLGUIButtonAudioDelegate _OnPostAudioEvent;
	}
}
