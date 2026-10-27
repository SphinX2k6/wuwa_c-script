using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002989 RID: 10633
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.MovieSceneMarginSectionTemplate")]
	[UnrealStructLayout(712, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 712)]
	public class FMovieSceneMarginSectionTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060275A6 RID: 161190 RVA: 0x003BFE85 File Offset: 0x003BE085
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMarginSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneMarginSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.MovieSceneMarginSectionTemplate", ref FMovieSceneMarginSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x1700973D RID: 38717
		// (get) Token: 0x060275A7 RID: 161191 RVA: 0x003BFEAC File Offset: 0x003BE0AC
		// (set) Token: 0x060275A8 RID: 161192 RVA: 0x003BFEEF File Offset: 0x003BE0EF
		public FMovieSceneFloatChannel TopCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._TopCurve) == null)
				{
					result = (this._TopCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_TopCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_TopCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700973E RID: 38718
		// (get) Token: 0x060275A9 RID: 161193 RVA: 0x003BFF10 File Offset: 0x003BE110
		// (set) Token: 0x060275AA RID: 161194 RVA: 0x003BFF53 File Offset: 0x003BE153
		public FMovieSceneFloatChannel LeftCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._LeftCurve) == null)
				{
					result = (this._LeftCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_LeftCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_LeftCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700973F RID: 38719
		// (get) Token: 0x060275AB RID: 161195 RVA: 0x003BFF74 File Offset: 0x003BE174
		// (set) Token: 0x060275AC RID: 161196 RVA: 0x003BFFB7 File Offset: 0x003BE1B7
		public FMovieSceneFloatChannel RightCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._RightCurve) == null)
				{
					result = (this._RightCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_RightCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_RightCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009740 RID: 38720
		// (get) Token: 0x060275AD RID: 161197 RVA: 0x003BFFD8 File Offset: 0x003BE1D8
		// (set) Token: 0x060275AE RID: 161198 RVA: 0x003C001B File Offset: 0x003BE21B
		public FMovieSceneFloatChannel BottomCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._BottomCurve) == null)
				{
					result = (this._BottomCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_BottomCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_BottomCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009741 RID: 38721
		// (get) Token: 0x060275AF RID: 161199 RVA: 0x003C003C File Offset: 0x003BE23C
		// (set) Token: 0x060275B0 RID: 161200 RVA: 0x003C004C File Offset: 0x003BE24C
		public unsafe EMovieSceneBlendType BlendType
		{
			get
			{
				return (EMovieSceneBlendType)(*(base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_BlendType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMarginSectionTemplate.__PropertyOffset_BlendType) = (byte)value;
			}
		}

		// Token: 0x060275B1 RID: 161201 RVA: 0x003C005D File Offset: 0x003BE25D
		public FMovieSceneMarginSectionTemplate()
		{
		}

		// Token: 0x060275B2 RID: 161202 RVA: 0x003C0068 File Offset: 0x003BE268
		public FMovieSceneMarginSectionTemplate(FMovieSceneFloatChannel TopCurve, FMovieSceneFloatChannel LeftCurve, FMovieSceneFloatChannel RightCurve, FMovieSceneFloatChannel BottomCurve, EMovieSceneBlendType BlendType, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.TopCurve = TopCurve;
			this.LeftCurve = LeftCurve;
			this.RightCurve = RightCurve;
			this.BottomCurve = BottomCurve;
			this.BlendType = BlendType;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060275B3 RID: 161203 RVA: 0x003C00B8 File Offset: 0x003BE2B8
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMarginSectionTemplate.StaticStruct();
		}

		// Token: 0x060275B4 RID: 161204 RVA: 0x003C00C4 File Offset: 0x003BE2C4
		[NullableContext(2)]
		public FMovieSceneMarginSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060275B5 RID: 161205 RVA: 0x003C00CE File Offset: 0x003BE2CE
		public FMovieSceneMarginSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060275B6 RID: 161206 RVA: 0x003C00D9 File Offset: 0x003BE2D9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMarginSectionTemplate(Pointer, false, true);
		}

		// Token: 0x060275B7 RID: 161207 RVA: 0x003C00E3 File Offset: 0x003BE2E3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMarginSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040159BF RID: 88511
		public new const string __ObjectPath = "/Script/UMG.MovieSceneMarginSectionTemplate";

		// Token: 0x040159C0 RID: 88512
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040159C1 RID: 88513
		internal static int __PropertyOffset_TopCurve;

		// Token: 0x040159C2 RID: 88514
		[Nullable(2)]
		private FMovieSceneFloatChannel _TopCurve;

		// Token: 0x040159C3 RID: 88515
		internal static int __PropertyOffset_LeftCurve;

		// Token: 0x040159C4 RID: 88516
		[Nullable(2)]
		private FMovieSceneFloatChannel _LeftCurve;

		// Token: 0x040159C5 RID: 88517
		internal static int __PropertyOffset_RightCurve;

		// Token: 0x040159C6 RID: 88518
		[Nullable(2)]
		private FMovieSceneFloatChannel _RightCurve;

		// Token: 0x040159C7 RID: 88519
		internal static int __PropertyOffset_BottomCurve;

		// Token: 0x040159C8 RID: 88520
		[Nullable(2)]
		private FMovieSceneFloatChannel _BottomCurve;

		// Token: 0x040159C9 RID: 88521
		internal static int __PropertyOffset_BlendType;
	}
}
