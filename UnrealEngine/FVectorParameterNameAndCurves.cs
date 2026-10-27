using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023C1 RID: 9153
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.VectorParameterNameAndCurves")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 496)]
	public class FVectorParameterNameAndCurves : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022702 RID: 141058 RVA: 0x0032EDF5 File Offset: 0x0032CFF5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorParameterNameAndCurves._ScriptStructPtr != 0) ? FVectorParameterNameAndCurves._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.VectorParameterNameAndCurves", ref FVectorParameterNameAndCurves._ScriptStructPtr);
		}

		// Token: 0x170084A7 RID: 33959
		// (get) Token: 0x06022703 RID: 141059 RVA: 0x0032EE19 File Offset: 0x0032D019
		// (set) Token: 0x06022704 RID: 141060 RVA: 0x0032EE2D File Offset: 0x0032D02D
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVectorParameterNameAndCurves.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVectorParameterNameAndCurves.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170084A8 RID: 33960
		// (get) Token: 0x06022705 RID: 141061 RVA: 0x0032EE44 File Offset: 0x0032D044
		// (set) Token: 0x06022706 RID: 141062 RVA: 0x0032EE87 File Offset: 0x0032D087
		public FMovieSceneFloatChannel XCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._XCurve) == null)
				{
					result = (this._XCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FVectorParameterNameAndCurves.__PropertyOffset_XCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FVectorParameterNameAndCurves.__PropertyOffset_XCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084A9 RID: 33961
		// (get) Token: 0x06022707 RID: 141063 RVA: 0x0032EEA8 File Offset: 0x0032D0A8
		// (set) Token: 0x06022708 RID: 141064 RVA: 0x0032EEEB File Offset: 0x0032D0EB
		public FMovieSceneFloatChannel YCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._YCurve) == null)
				{
					result = (this._YCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FVectorParameterNameAndCurves.__PropertyOffset_YCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FVectorParameterNameAndCurves.__PropertyOffset_YCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084AA RID: 33962
		// (get) Token: 0x06022709 RID: 141065 RVA: 0x0032EF0C File Offset: 0x0032D10C
		// (set) Token: 0x0602270A RID: 141066 RVA: 0x0032EF4F File Offset: 0x0032D14F
		public FMovieSceneFloatChannel ZCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._ZCurve) == null)
				{
					result = (this._ZCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FVectorParameterNameAndCurves.__PropertyOffset_ZCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FVectorParameterNameAndCurves.__PropertyOffset_ZCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602270B RID: 141067 RVA: 0x0032EF70 File Offset: 0x0032D170
		public FVectorParameterNameAndCurves()
		{
		}

		// Token: 0x0602270C RID: 141068 RVA: 0x0032EF78 File Offset: 0x0032D178
		public FVectorParameterNameAndCurves(FName ParameterName, FMovieSceneFloatChannel XCurve, FMovieSceneFloatChannel YCurve, FMovieSceneFloatChannel ZCurve)
		{
			this.ParameterName = ParameterName;
			this.XCurve = XCurve;
			this.YCurve = YCurve;
			this.ZCurve = ZCurve;
		}

		// Token: 0x0602270D RID: 141069 RVA: 0x0032EF9D File Offset: 0x0032D19D
		protected override IntPtr GetUStructPtr()
		{
			return FVectorParameterNameAndCurves.StaticStruct();
		}

		// Token: 0x0602270E RID: 141070 RVA: 0x0032EFA9 File Offset: 0x0032D1A9
		[NullableContext(2)]
		public FVectorParameterNameAndCurves(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602270F RID: 141071 RVA: 0x0032EFB3 File Offset: 0x0032D1B3
		public FVectorParameterNameAndCurves(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022710 RID: 141072 RVA: 0x0032EFBE File Offset: 0x0032D1BE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVectorParameterNameAndCurves(Pointer, false, true);
		}

		// Token: 0x06022711 RID: 141073 RVA: 0x0032EFC8 File Offset: 0x0032D1C8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVectorParameterNameAndCurves(Pointer, MemoryOwner);
		}

		// Token: 0x0401261D RID: 75293
		public const string __ObjectPath = "/Script/MovieSceneTracks.VectorParameterNameAndCurves";

		// Token: 0x0401261E RID: 75294
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401261F RID: 75295
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04012620 RID: 75296
		internal static int __PropertyOffset_XCurve;

		// Token: 0x04012621 RID: 75297
		[Nullable(2)]
		private FMovieSceneFloatChannel _XCurve;

		// Token: 0x04012622 RID: 75298
		internal static int __PropertyOffset_YCurve;

		// Token: 0x04012623 RID: 75299
		[Nullable(2)]
		private FMovieSceneFloatChannel _YCurve;

		// Token: 0x04012624 RID: 75300
		internal static int __PropertyOffset_ZCurve;

		// Token: 0x04012625 RID: 75301
		[Nullable(2)]
		private FMovieSceneFloatChannel _ZCurve;
	}
}
