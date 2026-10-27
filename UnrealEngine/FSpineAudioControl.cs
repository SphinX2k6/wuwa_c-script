using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002108 RID: 8456
	[UnrealObjectPath("/Script/LGUI.SpineAudioControl")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSpineAudioControl : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD1C RID: 130332 RVA: 0x002F5336 File Offset: 0x002F3536
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpineAudioControl._ScriptStructPtr != 0) ? FSpineAudioControl._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SpineAudioControl", ref FSpineAudioControl._ScriptStructPtr);
		}

		// Token: 0x17007D28 RID: 32040
		// (get) Token: 0x0601FD1D RID: 130333 RVA: 0x002F535A File Offset: 0x002F355A
		// (set) Token: 0x0601FD1E RID: 130334 RVA: 0x002F536E File Offset: 0x002F356E
		[Nullable(2)]
		public unsafe UAkAudioEvent StartAkEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + FSpineAudioControl.__PropertyOffset_StartAkEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSpineAudioControl.__PropertyOffset_StartAkEvent, value);
			}
		}

		// Token: 0x17007D29 RID: 32041
		// (get) Token: 0x0601FD1F RID: 130335 RVA: 0x002F5383 File Offset: 0x002F3583
		// (set) Token: 0x0601FD20 RID: 130336 RVA: 0x002F5393 File Offset: 0x002F3593
		public unsafe bool bInterruptOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpineAudioControl.__PropertyOffset_bInterruptOnEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpineAudioControl.__PropertyOffset_bInterruptOnEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007D2A RID: 32042
		// (get) Token: 0x0601FD21 RID: 130337 RVA: 0x002F53A4 File Offset: 0x002F35A4
		// (set) Token: 0x0601FD22 RID: 130338 RVA: 0x002F53B4 File Offset: 0x002F35B4
		public unsafe int FadeOutMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpineAudioControl.__PropertyOffset_FadeOutMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpineAudioControl.__PropertyOffset_FadeOutMs) = value;
			}
		}

		// Token: 0x0601FD23 RID: 130339 RVA: 0x002F53C5 File Offset: 0x002F35C5
		public FSpineAudioControl()
		{
		}

		// Token: 0x0601FD24 RID: 130340 RVA: 0x002F53CD File Offset: 0x002F35CD
		[NullableContext(1)]
		public FSpineAudioControl(UAkAudioEvent StartAkEvent, bool bInterruptOnEnd, int FadeOutMs)
		{
			this.StartAkEvent = StartAkEvent;
			this.bInterruptOnEnd = bInterruptOnEnd;
			this.FadeOutMs = FadeOutMs;
		}

		// Token: 0x0601FD25 RID: 130341 RVA: 0x002F53EA File Offset: 0x002F35EA
		protected override IntPtr GetUStructPtr()
		{
			return FSpineAudioControl.StaticStruct();
		}

		// Token: 0x0601FD26 RID: 130342 RVA: 0x002F53F6 File Offset: 0x002F35F6
		[NullableContext(2)]
		public FSpineAudioControl(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD27 RID: 130343 RVA: 0x002F5400 File Offset: 0x002F3600
		public FSpineAudioControl(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD28 RID: 130344 RVA: 0x002F540B File Offset: 0x002F360B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpineAudioControl(Pointer, false, true);
		}

		// Token: 0x0601FD29 RID: 130345 RVA: 0x002F5415 File Offset: 0x002F3615
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpineAudioControl(Pointer, MemoryOwner);
		}

		// Token: 0x0401125A RID: 70234
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.SpineAudioControl";

		// Token: 0x0401125B RID: 70235
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401125C RID: 70236
		internal static int __PropertyOffset_StartAkEvent;

		// Token: 0x0401125D RID: 70237
		internal static int __PropertyOffset_bInterruptOnEnd;

		// Token: 0x0401125E RID: 70238
		internal static int __PropertyOffset_FadeOutMs;
	}
}
