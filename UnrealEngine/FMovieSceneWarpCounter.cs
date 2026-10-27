using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200245C RID: 9308
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneWarpCounter")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneWarpCounter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022DF9 RID: 142841 RVA: 0x00339044 File Offset: 0x00337244
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneWarpCounter._ScriptStructPtr != 0) ? FMovieSceneWarpCounter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneWarpCounter", ref FMovieSceneWarpCounter._ScriptStructPtr);
		}

		// Token: 0x1700860A RID: 34314
		// (get) Token: 0x06022DFA RID: 142842 RVA: 0x00339068 File Offset: 0x00337268
		// (set) Token: 0x06022DFB RID: 142843 RVA: 0x003390AB File Offset: 0x003372AB
		public TArray<uint> WarpCounts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._WarpCounts) == null)
				{
					result = (this._WarpCounts = new TArray<uint>(base.NativePtr + (IntPtr)FMovieSceneWarpCounter.__PropertyOffset_WarpCounts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WarpCounts.CopyAssign(value);
			}
		}

		// Token: 0x06022DFC RID: 142844 RVA: 0x003390B9 File Offset: 0x003372B9
		public FMovieSceneWarpCounter()
		{
		}

		// Token: 0x06022DFD RID: 142845 RVA: 0x003390C1 File Offset: 0x003372C1
		public FMovieSceneWarpCounter(TArray<uint> WarpCounts)
		{
			this.WarpCounts = WarpCounts;
		}

		// Token: 0x06022DFE RID: 142846 RVA: 0x003390D0 File Offset: 0x003372D0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneWarpCounter.StaticStruct();
		}

		// Token: 0x06022DFF RID: 142847 RVA: 0x003390DC File Offset: 0x003372DC
		[NullableContext(2)]
		public FMovieSceneWarpCounter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022E00 RID: 142848 RVA: 0x003390E6 File Offset: 0x003372E6
		public FMovieSceneWarpCounter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022E01 RID: 142849 RVA: 0x003390F1 File Offset: 0x003372F1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneWarpCounter(Pointer, false, true);
		}

		// Token: 0x06022E02 RID: 142850 RVA: 0x003390FB File Offset: 0x003372FB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneWarpCounter(Pointer, MemoryOwner);
		}

		// Token: 0x040129E4 RID: 76260
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneWarpCounter";

		// Token: 0x040129E5 RID: 76261
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129E6 RID: 76262
		internal static int __PropertyOffset_WarpCounts;

		// Token: 0x040129E7 RID: 76263
		[Nullable(2)]
		private TArray<uint> _WarpCounts;
	}
}
