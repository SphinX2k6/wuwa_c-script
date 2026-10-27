using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009C3 RID: 2499
	[UnrealObjectPath("/Script/Engine.DirectorTrackCut")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FDirectorTrackCut : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008D93 RID: 36243 RVA: 0x000CA6D4 File Offset: 0x000C88D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDirectorTrackCut._ScriptStructPtr != 0) ? FDirectorTrackCut._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DirectorTrackCut", ref FDirectorTrackCut._ScriptStructPtr);
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x06008D94 RID: 36244 RVA: 0x000CA6F8 File Offset: 0x000C88F8
		// (set) Token: 0x06008D95 RID: 36245 RVA: 0x000CA708 File Offset: 0x000C8908
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDirectorTrackCut.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDirectorTrackCut.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x06008D96 RID: 36246 RVA: 0x000CA719 File Offset: 0x000C8919
		// (set) Token: 0x06008D97 RID: 36247 RVA: 0x000CA729 File Offset: 0x000C8929
		public unsafe float TransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDirectorTrackCut.__PropertyOffset_TransitionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDirectorTrackCut.__PropertyOffset_TransitionTime) = value;
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x06008D98 RID: 36248 RVA: 0x000CA73A File Offset: 0x000C893A
		// (set) Token: 0x06008D99 RID: 36249 RVA: 0x000CA74E File Offset: 0x000C894E
		public unsafe FName TargetCamGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDirectorTrackCut.__PropertyOffset_TargetCamGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDirectorTrackCut.__PropertyOffset_TargetCamGroup) = value;
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x06008D9A RID: 36250 RVA: 0x000CA763 File Offset: 0x000C8963
		// (set) Token: 0x06008D9B RID: 36251 RVA: 0x000CA773 File Offset: 0x000C8973
		public unsafe int ShotNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDirectorTrackCut.__PropertyOffset_ShotNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDirectorTrackCut.__PropertyOffset_ShotNumber) = value;
			}
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x000CA784 File Offset: 0x000C8984
		public FDirectorTrackCut()
		{
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x000CA78C File Offset: 0x000C898C
		public FDirectorTrackCut(float Time, float TransitionTime, FName TargetCamGroup, int ShotNumber)
		{
			this.Time = Time;
			this.TransitionTime = TransitionTime;
			this.TargetCamGroup = TargetCamGroup;
			this.ShotNumber = ShotNumber;
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x000CA7B1 File Offset: 0x000C89B1
		protected override IntPtr GetUStructPtr()
		{
			return FDirectorTrackCut.StaticStruct();
		}

		// Token: 0x06008D9F RID: 36255 RVA: 0x000CA7BD File Offset: 0x000C89BD
		[NullableContext(2)]
		public FDirectorTrackCut(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008DA0 RID: 36256 RVA: 0x000CA7C7 File Offset: 0x000C89C7
		public FDirectorTrackCut(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008DA1 RID: 36257 RVA: 0x000CA7D2 File Offset: 0x000C89D2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDirectorTrackCut(Pointer, false, true);
		}

		// Token: 0x06008DA2 RID: 36258 RVA: 0x000CA7DC File Offset: 0x000C89DC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDirectorTrackCut(Pointer, MemoryOwner);
		}

		// Token: 0x04004335 RID: 17205
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DirectorTrackCut";

		// Token: 0x04004336 RID: 17206
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004337 RID: 17207
		internal static int __PropertyOffset_Time;

		// Token: 0x04004338 RID: 17208
		internal static int __PropertyOffset_TransitionTime;

		// Token: 0x04004339 RID: 17209
		internal static int __PropertyOffset_TargetCamGroup;

		// Token: 0x0400433A RID: 17210
		internal static int __PropertyOffset_ShotNumber;
	}
}
