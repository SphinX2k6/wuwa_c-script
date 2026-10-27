using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023C0 RID: 9152
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.Vector2DParameterNameAndCurves")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FVector2DParameterNameAndCurves : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060226F4 RID: 141044 RVA: 0x0032EC87 File Offset: 0x0032CE87
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector2DParameterNameAndCurves._ScriptStructPtr != 0) ? FVector2DParameterNameAndCurves._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.Vector2DParameterNameAndCurves", ref FVector2DParameterNameAndCurves._ScriptStructPtr);
		}

		// Token: 0x170084A4 RID: 33956
		// (get) Token: 0x060226F5 RID: 141045 RVA: 0x0032ECAB File Offset: 0x0032CEAB
		// (set) Token: 0x060226F6 RID: 141046 RVA: 0x0032ECBF File Offset: 0x0032CEBF
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVector2DParameterNameAndCurves.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVector2DParameterNameAndCurves.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170084A5 RID: 33957
		// (get) Token: 0x060226F7 RID: 141047 RVA: 0x0032ECD4 File Offset: 0x0032CED4
		// (set) Token: 0x060226F8 RID: 141048 RVA: 0x0032ED17 File Offset: 0x0032CF17
		public FMovieSceneFloatChannel XCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._XCurve) == null)
				{
					result = (this._XCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FVector2DParameterNameAndCurves.__PropertyOffset_XCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FVector2DParameterNameAndCurves.__PropertyOffset_XCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084A6 RID: 33958
		// (get) Token: 0x060226F9 RID: 141049 RVA: 0x0032ED38 File Offset: 0x0032CF38
		// (set) Token: 0x060226FA RID: 141050 RVA: 0x0032ED7B File Offset: 0x0032CF7B
		public FMovieSceneFloatChannel YCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._YCurve) == null)
				{
					result = (this._YCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FVector2DParameterNameAndCurves.__PropertyOffset_YCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FVector2DParameterNameAndCurves.__PropertyOffset_YCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060226FB RID: 141051 RVA: 0x0032ED9C File Offset: 0x0032CF9C
		public FVector2DParameterNameAndCurves()
		{
		}

		// Token: 0x060226FC RID: 141052 RVA: 0x0032EDA4 File Offset: 0x0032CFA4
		public FVector2DParameterNameAndCurves(FName ParameterName, FMovieSceneFloatChannel XCurve, FMovieSceneFloatChannel YCurve)
		{
			this.ParameterName = ParameterName;
			this.XCurve = XCurve;
			this.YCurve = YCurve;
		}

		// Token: 0x060226FD RID: 141053 RVA: 0x0032EDC1 File Offset: 0x0032CFC1
		protected override IntPtr GetUStructPtr()
		{
			return FVector2DParameterNameAndCurves.StaticStruct();
		}

		// Token: 0x060226FE RID: 141054 RVA: 0x0032EDCD File Offset: 0x0032CFCD
		[NullableContext(2)]
		public FVector2DParameterNameAndCurves(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060226FF RID: 141055 RVA: 0x0032EDD7 File Offset: 0x0032CFD7
		public FVector2DParameterNameAndCurves(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022700 RID: 141056 RVA: 0x0032EDE2 File Offset: 0x0032CFE2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVector2DParameterNameAndCurves(Pointer, false, true);
		}

		// Token: 0x06022701 RID: 141057 RVA: 0x0032EDEC File Offset: 0x0032CFEC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVector2DParameterNameAndCurves(Pointer, MemoryOwner);
		}

		// Token: 0x04012616 RID: 75286
		public const string __ObjectPath = "/Script/MovieSceneTracks.Vector2DParameterNameAndCurves";

		// Token: 0x04012617 RID: 75287
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012618 RID: 75288
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04012619 RID: 75289
		internal static int __PropertyOffset_XCurve;

		// Token: 0x0401261A RID: 75290
		[Nullable(2)]
		private FMovieSceneFloatChannel _XCurve;

		// Token: 0x0401261B RID: 75291
		internal static int __PropertyOffset_YCurve;

		// Token: 0x0401261C RID: 75292
		[Nullable(2)]
		private FMovieSceneFloatChannel _YCurve;
	}
}
