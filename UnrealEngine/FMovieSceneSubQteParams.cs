using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D4 RID: 2004
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneSubQteParams")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FMovieSceneSubQteParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ACC5 RID: 44229 RVA: 0x000FF122 File Offset: 0x000FD322
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSubQteParams._ScriptStructPtr != 0) ? FMovieSceneSubQteParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneSubQteParams", ref FMovieSceneSubQteParams._ScriptStructPtr);
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600ACC6 RID: 44230 RVA: 0x000FF146 File Offset: 0x000FD346
		// (set) Token: 0x0600ACC7 RID: 44231 RVA: 0x000FF156 File Offset: 0x000FD356
		public unsafe int SubQteId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSubQteParams.__PropertyOffset_SubQteId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSubQteParams.__PropertyOffset_SubQteId) = value;
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x0600ACC8 RID: 44232 RVA: 0x000FF168 File Offset: 0x000FD368
		// (set) Token: 0x0600ACC9 RID: 44233 RVA: 0x000FF1AB File Offset: 0x000FD3AB
		public FQteSpineInfo SpineInfo
		{
			get
			{
				base.FastCheckIsValid();
				FQteSpineInfo result;
				if ((result = this._SpineInfo) == null)
				{
					result = (this._SpineInfo = new FQteSpineInfo(base.NativePtr + (IntPtr)FMovieSceneSubQteParams.__PropertyOffset_SpineInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQteSpineInfo.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubQteParams.__PropertyOffset_SpineInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x000FF1CC File Offset: 0x000FD3CC
		public FMovieSceneSubQteParams()
		{
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x000FF1D4 File Offset: 0x000FD3D4
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSubQteParams.StaticStruct();
		}

		// Token: 0x0600ACCC RID: 44236 RVA: 0x000FF1E0 File Offset: 0x000FD3E0
		[NullableContext(2)]
		public FMovieSceneSubQteParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x000FF1EA File Offset: 0x000FD3EA
		public FMovieSceneSubQteParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x000FF1F5 File Offset: 0x000FD3F5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSubQteParams(Pointer, false, true);
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x000FF1FF File Offset: 0x000FD3FF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSubQteParams(Pointer, MemoryOwner);
		}

		// Token: 0x04004A83 RID: 19075
		public const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneSubQteParams";

		// Token: 0x04004A84 RID: 19076
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004A85 RID: 19077
		internal static int __PropertyOffset_SubQteId;

		// Token: 0x04004A86 RID: 19078
		internal static int __PropertyOffset_SpineInfo;

		// Token: 0x04004A87 RID: 19079
		[Nullable(2)]
		private FQteSpineInfo _SpineInfo;
	}
}
