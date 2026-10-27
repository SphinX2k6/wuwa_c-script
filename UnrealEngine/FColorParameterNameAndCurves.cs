using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200231E RID: 8990
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.ColorParameterNameAndCurves")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 656)]
	public class FColorParameterNameAndCurves : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602206E RID: 139374 RVA: 0x00324D3A File Offset: 0x00322F3A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FColorParameterNameAndCurves._ScriptStructPtr != 0) ? FColorParameterNameAndCurves._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.ColorParameterNameAndCurves", ref FColorParameterNameAndCurves._ScriptStructPtr);
		}

		// Token: 0x17008376 RID: 33654
		// (get) Token: 0x0602206F RID: 139375 RVA: 0x00324D5E File Offset: 0x00322F5E
		// (set) Token: 0x06022070 RID: 139376 RVA: 0x00324D72 File Offset: 0x00322F72
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17008377 RID: 33655
		// (get) Token: 0x06022071 RID: 139377 RVA: 0x00324D88 File Offset: 0x00322F88
		// (set) Token: 0x06022072 RID: 139378 RVA: 0x00324DCB File Offset: 0x00322FCB
		public FMovieSceneFloatChannel RedCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._RedCurve) == null)
				{
					result = (this._RedCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_RedCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_RedCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008378 RID: 33656
		// (get) Token: 0x06022073 RID: 139379 RVA: 0x00324DEC File Offset: 0x00322FEC
		// (set) Token: 0x06022074 RID: 139380 RVA: 0x00324E2F File Offset: 0x0032302F
		public FMovieSceneFloatChannel GreenCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._GreenCurve) == null)
				{
					result = (this._GreenCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_GreenCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_GreenCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008379 RID: 33657
		// (get) Token: 0x06022075 RID: 139381 RVA: 0x00324E50 File Offset: 0x00323050
		// (set) Token: 0x06022076 RID: 139382 RVA: 0x00324E93 File Offset: 0x00323093
		public FMovieSceneFloatChannel BlueCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._BlueCurve) == null)
				{
					result = (this._BlueCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_BlueCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_BlueCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700837A RID: 33658
		// (get) Token: 0x06022077 RID: 139383 RVA: 0x00324EB4 File Offset: 0x003230B4
		// (set) Token: 0x06022078 RID: 139384 RVA: 0x00324EF7 File Offset: 0x003230F7
		public FMovieSceneFloatChannel AlphaCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._AlphaCurve) == null)
				{
					result = (this._AlphaCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_AlphaCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FColorParameterNameAndCurves.__PropertyOffset_AlphaCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022079 RID: 139385 RVA: 0x00324F18 File Offset: 0x00323118
		public FColorParameterNameAndCurves()
		{
		}

		// Token: 0x0602207A RID: 139386 RVA: 0x00324F20 File Offset: 0x00323120
		public FColorParameterNameAndCurves(FName ParameterName, FMovieSceneFloatChannel RedCurve, FMovieSceneFloatChannel GreenCurve, FMovieSceneFloatChannel BlueCurve, FMovieSceneFloatChannel AlphaCurve)
		{
			this.ParameterName = ParameterName;
			this.RedCurve = RedCurve;
			this.GreenCurve = GreenCurve;
			this.BlueCurve = BlueCurve;
			this.AlphaCurve = AlphaCurve;
		}

		// Token: 0x0602207B RID: 139387 RVA: 0x00324F4D File Offset: 0x0032314D
		protected override IntPtr GetUStructPtr()
		{
			return FColorParameterNameAndCurves.StaticStruct();
		}

		// Token: 0x0602207C RID: 139388 RVA: 0x00324F59 File Offset: 0x00323159
		[NullableContext(2)]
		public FColorParameterNameAndCurves(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602207D RID: 139389 RVA: 0x00324F63 File Offset: 0x00323163
		public FColorParameterNameAndCurves(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602207E RID: 139390 RVA: 0x00324F6E File Offset: 0x0032316E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FColorParameterNameAndCurves(Pointer, false, true);
		}

		// Token: 0x0602207F RID: 139391 RVA: 0x00324F78 File Offset: 0x00323178
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FColorParameterNameAndCurves(Pointer, MemoryOwner);
		}

		// Token: 0x04012275 RID: 74357
		public const string __ObjectPath = "/Script/MovieSceneTracks.ColorParameterNameAndCurves";

		// Token: 0x04012276 RID: 74358
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012277 RID: 74359
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04012278 RID: 74360
		internal static int __PropertyOffset_RedCurve;

		// Token: 0x04012279 RID: 74361
		[Nullable(2)]
		private FMovieSceneFloatChannel _RedCurve;

		// Token: 0x0401227A RID: 74362
		internal static int __PropertyOffset_GreenCurve;

		// Token: 0x0401227B RID: 74363
		[Nullable(2)]
		private FMovieSceneFloatChannel _GreenCurve;

		// Token: 0x0401227C RID: 74364
		internal static int __PropertyOffset_BlueCurve;

		// Token: 0x0401227D RID: 74365
		[Nullable(2)]
		private FMovieSceneFloatChannel _BlueCurve;

		// Token: 0x0401227E RID: 74366
		internal static int __PropertyOffset_AlphaCurve;

		// Token: 0x0401227F RID: 74367
		[Nullable(2)]
		private FMovieSceneFloatChannel _AlphaCurve;
	}
}
