using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002334 RID: 9012
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DTransformTemplateData")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1616)]
	public class FMovieScene3DTransformTemplateData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022152 RID: 139602 RVA: 0x003263B2 File Offset: 0x003245B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScene3DTransformTemplateData._ScriptStructPtr != 0) ? FMovieScene3DTransformTemplateData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieScene3DTransformTemplateData", ref FMovieScene3DTransformTemplateData._ScriptStructPtr);
		}

		// Token: 0x170083AB RID: 33707
		// (get) Token: 0x06022153 RID: 139603 RVA: 0x003263D8 File Offset: 0x003245D8
		// (set) Token: 0x06022154 RID: 139604 RVA: 0x0032641C File Offset: 0x0032461C
		public TFixedArray<FMovieSceneFloatChannel> TranslationCurve
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._TranslationCurve) == null)
				{
					result = (this._TranslationCurve = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_TranslationCurve, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TranslationCurve.CopyAssign(value);
			}
		}

		// Token: 0x170083AC RID: 33708
		// (get) Token: 0x06022155 RID: 139605 RVA: 0x0032642C File Offset: 0x0032462C
		// (set) Token: 0x06022156 RID: 139606 RVA: 0x00326470 File Offset: 0x00324670
		public TFixedArray<FMovieSceneFloatChannel> RotationCurve
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._RotationCurve) == null)
				{
					result = (this._RotationCurve = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_RotationCurve, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotationCurve.CopyAssign(value);
			}
		}

		// Token: 0x170083AD RID: 33709
		// (get) Token: 0x06022157 RID: 139607 RVA: 0x00326480 File Offset: 0x00324680
		// (set) Token: 0x06022158 RID: 139608 RVA: 0x003264C4 File Offset: 0x003246C4
		public TFixedArray<FMovieSceneFloatChannel> ScaleCurve
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._ScaleCurve) == null)
				{
					result = (this._ScaleCurve = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_ScaleCurve, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScaleCurve.CopyAssign(value);
			}
		}

		// Token: 0x170083AE RID: 33710
		// (get) Token: 0x06022159 RID: 139609 RVA: 0x003264D4 File Offset: 0x003246D4
		// (set) Token: 0x0602215A RID: 139610 RVA: 0x00326517 File Offset: 0x00324717
		public FMovieSceneFloatChannel ManualWeight
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._ManualWeight) == null)
				{
					result = (this._ManualWeight = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_ManualWeight, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_ManualWeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083AF RID: 33711
		// (get) Token: 0x0602215B RID: 139611 RVA: 0x00326538 File Offset: 0x00324738
		// (set) Token: 0x0602215C RID: 139612 RVA: 0x00326548 File Offset: 0x00324748
		public unsafe EMovieSceneBlendType BlendType
		{
			get
			{
				return (EMovieSceneBlendType)(*(base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_BlendType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_BlendType) = (byte)value;
			}
		}

		// Token: 0x170083B0 RID: 33712
		// (get) Token: 0x0602215D RID: 139613 RVA: 0x0032655C File Offset: 0x0032475C
		// (set) Token: 0x0602215E RID: 139614 RVA: 0x0032659F File Offset: 0x0032479F
		public FMovieSceneTransformMask Mask
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTransformMask result;
				if ((result = this._Mask) == null)
				{
					result = (this._Mask = new FMovieSceneTransformMask(base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_Mask, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTransformMask.StaticStruct(), base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_Mask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083B1 RID: 33713
		// (get) Token: 0x0602215F RID: 139615 RVA: 0x003265C0 File Offset: 0x003247C0
		// (set) Token: 0x06022160 RID: 139616 RVA: 0x003265D0 File Offset: 0x003247D0
		public unsafe bool bUseQuaternionInterpolation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_bUseQuaternionInterpolation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DTransformTemplateData.__PropertyOffset_bUseQuaternionInterpolation) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022161 RID: 139617 RVA: 0x003265E1 File Offset: 0x003247E1
		public FMovieScene3DTransformTemplateData()
		{
		}

		// Token: 0x06022162 RID: 139618 RVA: 0x003265E9 File Offset: 0x003247E9
		public FMovieScene3DTransformTemplateData(TFixedArray<FMovieSceneFloatChannel> TranslationCurve, TFixedArray<FMovieSceneFloatChannel> RotationCurve, TFixedArray<FMovieSceneFloatChannel> ScaleCurve, FMovieSceneFloatChannel ManualWeight, EMovieSceneBlendType BlendType, FMovieSceneTransformMask Mask, bool bUseQuaternionInterpolation)
		{
			this.TranslationCurve = TranslationCurve;
			this.RotationCurve = RotationCurve;
			this.ScaleCurve = ScaleCurve;
			this.ManualWeight = ManualWeight;
			this.BlendType = BlendType;
			this.Mask = Mask;
			this.bUseQuaternionInterpolation = bUseQuaternionInterpolation;
		}

		// Token: 0x06022163 RID: 139619 RVA: 0x00326626 File Offset: 0x00324826
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScene3DTransformTemplateData.StaticStruct();
		}

		// Token: 0x06022164 RID: 139620 RVA: 0x00326632 File Offset: 0x00324832
		[NullableContext(2)]
		public FMovieScene3DTransformTemplateData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022165 RID: 139621 RVA: 0x0032663C File Offset: 0x0032483C
		public FMovieScene3DTransformTemplateData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022166 RID: 139622 RVA: 0x00326647 File Offset: 0x00324847
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScene3DTransformTemplateData(Pointer, false, true);
		}

		// Token: 0x06022167 RID: 139623 RVA: 0x00326651 File Offset: 0x00324851
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScene3DTransformTemplateData(Pointer, MemoryOwner);
		}

		// Token: 0x0401230B RID: 74507
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DTransformTemplateData";

		// Token: 0x0401230C RID: 74508
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401230D RID: 74509
		internal static int __PropertyOffset_TranslationCurve;

		// Token: 0x0401230E RID: 74510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _TranslationCurve;

		// Token: 0x0401230F RID: 74511
		internal static int __PropertyOffset_RotationCurve;

		// Token: 0x04012310 RID: 74512
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _RotationCurve;

		// Token: 0x04012311 RID: 74513
		internal static int __PropertyOffset_ScaleCurve;

		// Token: 0x04012312 RID: 74514
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _ScaleCurve;

		// Token: 0x04012313 RID: 74515
		internal static int __PropertyOffset_ManualWeight;

		// Token: 0x04012314 RID: 74516
		[Nullable(2)]
		private FMovieSceneFloatChannel _ManualWeight;

		// Token: 0x04012315 RID: 74517
		internal static int __PropertyOffset_BlendType;

		// Token: 0x04012316 RID: 74518
		internal static int __PropertyOffset_Mask;

		// Token: 0x04012317 RID: 74519
		[Nullable(2)]
		private FMovieSceneTransformMask _Mask;

		// Token: 0x04012318 RID: 74520
		internal static int __PropertyOffset_bUseQuaternionInterpolation;
	}
}
