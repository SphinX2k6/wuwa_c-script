using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002103 RID: 8451
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SequenceInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FSequenceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FCBC RID: 130236 RVA: 0x002F4892 File Offset: 0x002F2A92
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSequenceInfo._ScriptStructPtr != 0) ? FSequenceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SequenceInfo", ref FSequenceInfo._ScriptStructPtr);
		}

		// Token: 0x17007D14 RID: 32020
		// (get) Token: 0x0601FCBD RID: 130237 RVA: 0x002F48B8 File Offset: 0x002F2AB8
		// (set) Token: 0x0601FCBE RID: 130238 RVA: 0x002F48FB File Offset: 0x002F2AFB
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

		// Token: 0x17007D15 RID: 32021
		// (get) Token: 0x0601FCBF RID: 130239 RVA: 0x002F491C File Offset: 0x002F2B1C
		// (set) Token: 0x0601FCC0 RID: 130240 RVA: 0x002F492C File Offset: 0x002F2B2C
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

		// Token: 0x17007D16 RID: 32022
		// (get) Token: 0x0601FCC1 RID: 130241 RVA: 0x002F493D File Offset: 0x002F2B3D
		// (set) Token: 0x0601FCC2 RID: 130242 RVA: 0x002F494D File Offset: 0x002F2B4D
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

		// Token: 0x17007D17 RID: 32023
		// (get) Token: 0x0601FCC3 RID: 130243 RVA: 0x002F495E File Offset: 0x002F2B5E
		// (set) Token: 0x0601FCC4 RID: 130244 RVA: 0x002F496E File Offset: 0x002F2B6E
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

		// Token: 0x17007D18 RID: 32024
		// (get) Token: 0x0601FCC5 RID: 130245 RVA: 0x002F4980 File Offset: 0x002F2B80
		// (set) Token: 0x0601FCC6 RID: 130246 RVA: 0x002F49C3 File Offset: 0x002F2BC3
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

		// Token: 0x0601FCC7 RID: 130247 RVA: 0x002F49E4 File Offset: 0x002F2BE4
		public FSequenceInfo()
		{
		}

		// Token: 0x0601FCC8 RID: 130248 RVA: 0x002F49EC File Offset: 0x002F2BEC
		public FSequenceInfo(FSoftObjectPath LevelSequence, bool bUseAsHardRef, bool ChildrenInteractiveDuringPlaying, bool BlockAllEventWhilePlaying, FMovieSceneSequencePlaybackSettings PlaySetting)
		{
			this.LevelSequence = LevelSequence;
			this.bUseAsHardRef = bUseAsHardRef;
			this.ChildrenInteractiveDuringPlaying = ChildrenInteractiveDuringPlaying;
			this.BlockAllEventWhilePlaying = BlockAllEventWhilePlaying;
			this.PlaySetting = PlaySetting;
		}

		// Token: 0x0601FCC9 RID: 130249 RVA: 0x002F4A19 File Offset: 0x002F2C19
		protected override IntPtr GetUStructPtr()
		{
			return FSequenceInfo.StaticStruct();
		}

		// Token: 0x0601FCCA RID: 130250 RVA: 0x002F4A25 File Offset: 0x002F2C25
		[NullableContext(2)]
		public FSequenceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FCCB RID: 130251 RVA: 0x002F4A2F File Offset: 0x002F2C2F
		public FSequenceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FCCC RID: 130252 RVA: 0x002F4A3A File Offset: 0x002F2C3A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSequenceInfo(Pointer, false, true);
		}

		// Token: 0x0601FCCD RID: 130253 RVA: 0x002F4A44 File Offset: 0x002F2C44
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSequenceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401122B RID: 70187
		public const string __ObjectPath = "/Script/LGUI.SequenceInfo";

		// Token: 0x0401122C RID: 70188
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401122D RID: 70189
		internal static int __PropertyOffset_LevelSequence;

		// Token: 0x0401122E RID: 70190
		[Nullable(2)]
		private FSoftObjectPath _LevelSequence;

		// Token: 0x0401122F RID: 70191
		internal static int __PropertyOffset_bUseAsHardRef;

		// Token: 0x04011230 RID: 70192
		internal static int __PropertyOffset_ChildrenInteractiveDuringPlaying;

		// Token: 0x04011231 RID: 70193
		internal static int __PropertyOffset_BlockAllEventWhilePlaying;

		// Token: 0x04011232 RID: 70194
		internal static int __PropertyOffset_PlaySetting;

		// Token: 0x04011233 RID: 70195
		[Nullable(2)]
		private FMovieSceneSequencePlaybackSettings _PlaySetting;
	}
}
