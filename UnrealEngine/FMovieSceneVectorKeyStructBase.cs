using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023B8 RID: 9144
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVectorKeyStructBase")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneVectorKeyStructBase : FMovieSceneKeyStruct, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060226A2 RID: 140962 RVA: 0x0032E547 File Offset: 0x0032C747
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneVectorKeyStructBase._ScriptStructPtr != 0) ? FMovieSceneVectorKeyStructBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneVectorKeyStructBase", ref FMovieSceneVectorKeyStructBase._ScriptStructPtr);
		}

		// Token: 0x17008497 RID: 33943
		// (get) Token: 0x060226A3 RID: 140963 RVA: 0x0032E56C File Offset: 0x0032C76C
		// (set) Token: 0x060226A4 RID: 140964 RVA: 0x0032E5AF File Offset: 0x0032C7AF
		public FFrameNumber Time
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneVectorKeyStructBase.__PropertyOffset_Time, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneVectorKeyStructBase.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060226A5 RID: 140965 RVA: 0x0032E5D0 File Offset: 0x0032C7D0
		public FMovieSceneVectorKeyStructBase()
		{
		}

		// Token: 0x060226A6 RID: 140966 RVA: 0x0032E5D8 File Offset: 0x0032C7D8
		public FMovieSceneVectorKeyStructBase(FFrameNumber Time)
		{
			this.Time = Time;
		}

		// Token: 0x060226A7 RID: 140967 RVA: 0x0032E5E7 File Offset: 0x0032C7E7
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneVectorKeyStructBase.StaticStruct();
		}

		// Token: 0x060226A8 RID: 140968 RVA: 0x0032E5F3 File Offset: 0x0032C7F3
		[NullableContext(2)]
		public FMovieSceneVectorKeyStructBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060226A9 RID: 140969 RVA: 0x0032E5FD File Offset: 0x0032C7FD
		public FMovieSceneVectorKeyStructBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060226AA RID: 140970 RVA: 0x0032E608 File Offset: 0x0032C808
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneVectorKeyStructBase(Pointer, false, true);
		}

		// Token: 0x060226AB RID: 140971 RVA: 0x0032E612 File Offset: 0x0032C812
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneVectorKeyStructBase(Pointer, MemoryOwner);
		}

		// Token: 0x040125EE RID: 75246
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVectorKeyStructBase";

		// Token: 0x040125EF RID: 75247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125F0 RID: 75248
		internal static int __PropertyOffset_Time;

		// Token: 0x040125F1 RID: 75249
		[Nullable(2)]
		private FFrameNumber _Time;
	}
}
