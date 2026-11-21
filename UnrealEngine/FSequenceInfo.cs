using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D9 RID: 1753
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SequenceInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FSequenceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009502 RID: 38146 RVA: 0x000E0E56 File Offset: 0x000DF056
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSequenceInfo._ScriptStructPtr != 0) ? FSequenceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SequenceInfo", ref FSequenceInfo._ScriptStructPtr);
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06009503 RID: 38147 RVA: 0x000E0E7C File Offset: 0x000DF07C
		// (set) Token: 0x06009504 RID: 38148 RVA: 0x000E0EBF File Offset: 0x000DF0BF
		public FSoftObjectPath LevelSequence
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._LevelSequence) == null)
				{
					result = (this._LevelSequence = new FSoftObjectPath(base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_LevelSequence, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_LevelSequence, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06009505 RID: 38149 RVA: 0x000E0EE0 File Offset: 0x000DF0E0
		// (set) Token: 0x06009506 RID: 38150 RVA: 0x000E0EF0 File Offset: 0x000DF0F0
		public unsafe bool bUseAsHardRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_bUseAsHardRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_bUseAsHardRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06009507 RID: 38151 RVA: 0x000E0F01 File Offset: 0x000DF101
		// (set) Token: 0x06009508 RID: 38152 RVA: 0x000E0F11 File Offset: 0x000DF111
		public unsafe bool ChildrenInteractiveDuringPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_ChildrenInteractiveDuringPlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_ChildrenInteractiveDuringPlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06009509 RID: 38153 RVA: 0x000E0F22 File Offset: 0x000DF122
		// (set) Token: 0x0600950A RID: 38154 RVA: 0x000E0F32 File Offset: 0x000DF132
		public unsafe bool BlockAllEventWhilePlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_BlockAllEventWhilePlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_BlockAllEventWhilePlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x0600950B RID: 38155 RVA: 0x000E0F44 File Offset: 0x000DF144
		// (set) Token: 0x0600950C RID: 38156 RVA: 0x000E0F87 File Offset: 0x000DF187
		public FMovieSceneSequencePlaybackSettings PlaySetting
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequencePlaybackSettings result;
				if ((result = this._PlaySetting) == null)
				{
					result = (this._PlaySetting = new FMovieSceneSequencePlaybackSettings(base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_PlaySetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequencePlaybackSettings.StaticStruct(), base.NativePtr + (IntPtr)FSequenceInfo.__PropertyOffset_PlaySetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x000E0FA8 File Offset: 0x000DF1A8
		public FSequenceInfo()
		{
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x000E0FB0 File Offset: 0x000DF1B0
		protected override IntPtr GetUStructPtr()
		{
			return FSequenceInfo.StaticStruct();
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x000E0FBC File Offset: 0x000DF1BC
		[NullableContext(2)]
		public FSequenceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x000E0FC6 File Offset: 0x000DF1C6
		public FSequenceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x000E0FD1 File Offset: 0x000DF1D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSequenceInfo(Pointer, false, true);
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x000E0FDB File Offset: 0x000DF1DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSequenceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040040C9 RID: 16585
		public const string __ObjectPath = "/Script/LGUI.SequenceInfo";

		// Token: 0x040040CA RID: 16586
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040CB RID: 16587
		internal static int __PropertyOffset_LevelSequence;

		// Token: 0x040040CC RID: 16588
		[Nullable(2)]
		private FSoftObjectPath _LevelSequence;

		// Token: 0x040040CD RID: 16589
		internal static int __PropertyOffset_bUseAsHardRef;

		// Token: 0x040040CE RID: 16590
		internal static int __PropertyOffset_ChildrenInteractiveDuringPlaying;

		// Token: 0x040040CF RID: 16591
		internal static int __PropertyOffset_BlockAllEventWhilePlaying;

		// Token: 0x040040D0 RID: 16592
		internal static int __PropertyOffset_PlaySetting;

		// Token: 0x040040D1 RID: 16593
		[Nullable(2)]
		private FMovieSceneSequencePlaybackSettings _PlaySetting;
	}
}
