using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026FF RID: 9983
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneSubQteParams")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FMovieSceneSubQteParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602505F RID: 151647 RVA: 0x0036C5B2 File Offset: 0x0036A7B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSubQteParams._ScriptStructPtr != 0) ? FMovieSceneSubQteParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneSubQteParams", ref FMovieSceneSubQteParams._ScriptStructPtr);
		}

		// Token: 0x17008EED RID: 36589
		// (get) Token: 0x06025060 RID: 151648 RVA: 0x0036C5D6 File Offset: 0x0036A7D6
		// (set) Token: 0x06025061 RID: 151649 RVA: 0x0036C5E6 File Offset: 0x0036A7E6
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

		// Token: 0x17008EEE RID: 36590
		// (get) Token: 0x06025062 RID: 151650 RVA: 0x0036C5F8 File Offset: 0x0036A7F8
		// (set) Token: 0x06025063 RID: 151651 RVA: 0x0036C63B File Offset: 0x0036A83B
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

		// Token: 0x06025064 RID: 151652 RVA: 0x0036C65C File Offset: 0x0036A85C
		public FMovieSceneSubQteParams()
		{
		}

		// Token: 0x06025065 RID: 151653 RVA: 0x0036C664 File Offset: 0x0036A864
		public FMovieSceneSubQteParams(int SubQteId, FQteSpineInfo SpineInfo)
		{
			this.SubQteId = SubQteId;
			this.SpineInfo = SpineInfo;
		}

		// Token: 0x06025066 RID: 151654 RVA: 0x0036C67A File Offset: 0x0036A87A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSubQteParams.StaticStruct();
		}

		// Token: 0x06025067 RID: 151655 RVA: 0x0036C686 File Offset: 0x0036A886
		[NullableContext(2)]
		public FMovieSceneSubQteParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025068 RID: 151656 RVA: 0x0036C690 File Offset: 0x0036A890
		public FMovieSceneSubQteParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025069 RID: 151657 RVA: 0x0036C69B File Offset: 0x0036A89B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSubQteParams(Pointer, false, true);
		}

		// Token: 0x0602506A RID: 151658 RVA: 0x0036C6A5 File Offset: 0x0036A8A5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSubQteParams(Pointer, MemoryOwner);
		}

		// Token: 0x04013F33 RID: 81715
		public const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneSubQteParams";

		// Token: 0x04013F34 RID: 81716
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F35 RID: 81717
		internal static int __PropertyOffset_SubQteId;

		// Token: 0x04013F36 RID: 81718
		internal static int __PropertyOffset_SpineInfo;

		// Token: 0x04013F37 RID: 81719
		[Nullable(2)]
		private FQteSpineInfo _SpineInfo;
	}
}
