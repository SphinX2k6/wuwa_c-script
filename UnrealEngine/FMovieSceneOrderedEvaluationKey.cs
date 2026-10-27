using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200241E RID: 9246
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneOrderedEvaluationKey")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneOrderedEvaluationKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A63 RID: 141923 RVA: 0x00333D6C File Offset: 0x00331F6C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneOrderedEvaluationKey._ScriptStructPtr != 0) ? FMovieSceneOrderedEvaluationKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneOrderedEvaluationKey", ref FMovieSceneOrderedEvaluationKey._ScriptStructPtr);
		}

		// Token: 0x17008552 RID: 34130
		// (get) Token: 0x06022A64 RID: 141924 RVA: 0x00333D90 File Offset: 0x00331F90
		// (set) Token: 0x06022A65 RID: 141925 RVA: 0x00333DD3 File Offset: 0x00331FD3
		public FMovieSceneEvaluationKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvaluationKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FMovieSceneEvaluationKey(base.NativePtr + (IntPtr)FMovieSceneOrderedEvaluationKey.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvaluationKey.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneOrderedEvaluationKey.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008553 RID: 34131
		// (get) Token: 0x06022A66 RID: 141926 RVA: 0x00333DF4 File Offset: 0x00331FF4
		// (set) Token: 0x06022A67 RID: 141927 RVA: 0x00333E04 File Offset: 0x00332004
		public unsafe ushort SetupIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneOrderedEvaluationKey.__PropertyOffset_SetupIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneOrderedEvaluationKey.__PropertyOffset_SetupIndex) = (short)value;
			}
		}

		// Token: 0x17008554 RID: 34132
		// (get) Token: 0x06022A68 RID: 141928 RVA: 0x00333E15 File Offset: 0x00332015
		// (set) Token: 0x06022A69 RID: 141929 RVA: 0x00333E25 File Offset: 0x00332025
		public unsafe ushort TearDownIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneOrderedEvaluationKey.__PropertyOffset_TearDownIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneOrderedEvaluationKey.__PropertyOffset_TearDownIndex) = (short)value;
			}
		}

		// Token: 0x06022A6A RID: 141930 RVA: 0x00333E36 File Offset: 0x00332036
		public FMovieSceneOrderedEvaluationKey()
		{
		}

		// Token: 0x06022A6B RID: 141931 RVA: 0x00333E3E File Offset: 0x0033203E
		public FMovieSceneOrderedEvaluationKey(FMovieSceneEvaluationKey Key, ushort SetupIndex, ushort TearDownIndex)
		{
			this.Key = Key;
			this.SetupIndex = SetupIndex;
			this.TearDownIndex = TearDownIndex;
		}

		// Token: 0x06022A6C RID: 141932 RVA: 0x00333E5B File Offset: 0x0033205B
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneOrderedEvaluationKey.StaticStruct();
		}

		// Token: 0x06022A6D RID: 141933 RVA: 0x00333E67 File Offset: 0x00332067
		[NullableContext(2)]
		public FMovieSceneOrderedEvaluationKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A6E RID: 141934 RVA: 0x00333E71 File Offset: 0x00332071
		public FMovieSceneOrderedEvaluationKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A6F RID: 141935 RVA: 0x00333E7C File Offset: 0x0033207C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneOrderedEvaluationKey(Pointer, false, true);
		}

		// Token: 0x06022A70 RID: 141936 RVA: 0x00333E86 File Offset: 0x00332086
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneOrderedEvaluationKey(Pointer, MemoryOwner);
		}

		// Token: 0x04012832 RID: 75826
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneOrderedEvaluationKey";

		// Token: 0x04012833 RID: 75827
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012834 RID: 75828
		internal static int __PropertyOffset_Key;

		// Token: 0x04012835 RID: 75829
		[Nullable(2)]
		private FMovieSceneEvaluationKey _Key;

		// Token: 0x04012836 RID: 75830
		internal static int __PropertyOffset_SetupIndex;

		// Token: 0x04012837 RID: 75831
		internal static int __PropertyOffset_TearDownIndex;
	}
}
