using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FCB RID: 8139
	[UnrealObjectPath("/Script/LGUI.AudioControl")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAudioControl : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EE04 RID: 126468 RVA: 0x002DE25A File Offset: 0x002DC45A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAudioControl._ScriptStructPtr != 0) ? FAudioControl._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.AudioControl", ref FAudioControl._ScriptStructPtr);
		}

		// Token: 0x17007ADE RID: 31454
		// (get) Token: 0x0601EE05 RID: 126469 RVA: 0x002DE27E File Offset: 0x002DC47E
		// (set) Token: 0x0601EE06 RID: 126470 RVA: 0x002DE292 File Offset: 0x002DC492
		[Nullable(2)]
		public unsafe UAkAudioEvent StartAkEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + FAudioControl.__PropertyOffset_StartAkEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAudioControl.__PropertyOffset_StartAkEvent, value);
			}
		}

		// Token: 0x17007ADF RID: 31455
		// (get) Token: 0x0601EE07 RID: 126471 RVA: 0x002DE2A7 File Offset: 0x002DC4A7
		// (set) Token: 0x0601EE08 RID: 126472 RVA: 0x002DE2B7 File Offset: 0x002DC4B7
		public unsafe bool bInterruptOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioControl.__PropertyOffset_bInterruptOnEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioControl.__PropertyOffset_bInterruptOnEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007AE0 RID: 31456
		// (get) Token: 0x0601EE09 RID: 126473 RVA: 0x002DE2C8 File Offset: 0x002DC4C8
		// (set) Token: 0x0601EE0A RID: 126474 RVA: 0x002DE2D8 File Offset: 0x002DC4D8
		public unsafe int FadeOutMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioControl.__PropertyOffset_FadeOutMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioControl.__PropertyOffset_FadeOutMs) = value;
			}
		}

		// Token: 0x0601EE0B RID: 126475 RVA: 0x002DE2E9 File Offset: 0x002DC4E9
		public FAudioControl()
		{
		}

		// Token: 0x0601EE0C RID: 126476 RVA: 0x002DE2F1 File Offset: 0x002DC4F1
		[NullableContext(1)]
		public FAudioControl(UAkAudioEvent StartAkEvent, bool bInterruptOnEnd, int FadeOutMs)
		{
			this.StartAkEvent = StartAkEvent;
			this.bInterruptOnEnd = bInterruptOnEnd;
			this.FadeOutMs = FadeOutMs;
		}

		// Token: 0x0601EE0D RID: 126477 RVA: 0x002DE30E File Offset: 0x002DC50E
		protected override IntPtr GetUStructPtr()
		{
			return FAudioControl.StaticStruct();
		}

		// Token: 0x0601EE0E RID: 126478 RVA: 0x002DE31A File Offset: 0x002DC51A
		[NullableContext(2)]
		public FAudioControl(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE0F RID: 126479 RVA: 0x002DE324 File Offset: 0x002DC524
		public FAudioControl(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE10 RID: 126480 RVA: 0x002DE32F File Offset: 0x002DC52F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAudioControl(Pointer, false, true);
		}

		// Token: 0x0601EE11 RID: 126481 RVA: 0x002DE339 File Offset: 0x002DC539
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAudioControl(Pointer, MemoryOwner);
		}

		// Token: 0x04010AE0 RID: 68320
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.AudioControl";

		// Token: 0x04010AE1 RID: 68321
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010AE2 RID: 68322
		internal static int __PropertyOffset_StartAkEvent;

		// Token: 0x04010AE3 RID: 68323
		internal static int __PropertyOffset_bInterruptOnEnd;

		// Token: 0x04010AE4 RID: 68324
		internal static int __PropertyOffset_FadeOutMs;
	}
}
