using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002331 RID: 9009
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DTransformKeyStruct")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FMovieScene3DTransformKeyStruct : FMovieSceneKeyStruct, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602212B RID: 139563 RVA: 0x00325F92 File Offset: 0x00324192
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScene3DTransformKeyStruct._ScriptStructPtr != 0) ? FMovieScene3DTransformKeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieScene3DTransformKeyStruct", ref FMovieScene3DTransformKeyStruct._ScriptStructPtr);
		}

		// Token: 0x170083A1 RID: 33697
		// (get) Token: 0x0602212C RID: 139564 RVA: 0x00325FB6 File Offset: 0x003241B6
		// (set) Token: 0x0602212D RID: 139565 RVA: 0x00325FCA File Offset: 0x003241CA
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScene3DTransformKeyStruct.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DTransformKeyStruct.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170083A2 RID: 33698
		// (get) Token: 0x0602212E RID: 139566 RVA: 0x00325FDF File Offset: 0x003241DF
		// (set) Token: 0x0602212F RID: 139567 RVA: 0x00325FF3 File Offset: 0x003241F3
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScene3DTransformKeyStruct.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DTransformKeyStruct.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170083A3 RID: 33699
		// (get) Token: 0x06022130 RID: 139568 RVA: 0x00326008 File Offset: 0x00324208
		// (set) Token: 0x06022131 RID: 139569 RVA: 0x0032601C File Offset: 0x0032421C
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScene3DTransformKeyStruct.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DTransformKeyStruct.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170083A4 RID: 33700
		// (get) Token: 0x06022132 RID: 139570 RVA: 0x00326034 File Offset: 0x00324234
		// (set) Token: 0x06022133 RID: 139571 RVA: 0x00326077 File Offset: 0x00324277
		public FFrameNumber Time
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FFrameNumber(base.NativePtr + (IntPtr)FMovieScene3DTransformKeyStruct.__PropertyOffset_Time, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieScene3DTransformKeyStruct.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022134 RID: 139572 RVA: 0x00326098 File Offset: 0x00324298
		public FMovieScene3DTransformKeyStruct()
		{
		}

		// Token: 0x06022135 RID: 139573 RVA: 0x003260A0 File Offset: 0x003242A0
		public FMovieScene3DTransformKeyStruct(FVector Location, FRotator Rotation, FVector Scale, FFrameNumber Time)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.Scale = Scale;
			this.Time = Time;
		}

		// Token: 0x06022136 RID: 139574 RVA: 0x003260C5 File Offset: 0x003242C5
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScene3DTransformKeyStruct.StaticStruct();
		}

		// Token: 0x06022137 RID: 139575 RVA: 0x003260D1 File Offset: 0x003242D1
		[NullableContext(2)]
		public FMovieScene3DTransformKeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022138 RID: 139576 RVA: 0x003260DB File Offset: 0x003242DB
		public FMovieScene3DTransformKeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022139 RID: 139577 RVA: 0x003260E6 File Offset: 0x003242E6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScene3DTransformKeyStruct(Pointer, false, true);
		}

		// Token: 0x0602213A RID: 139578 RVA: 0x003260F0 File Offset: 0x003242F0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScene3DTransformKeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040122F2 RID: 74482
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DTransformKeyStruct";

		// Token: 0x040122F3 RID: 74483
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122F4 RID: 74484
		internal static int __PropertyOffset_Location;

		// Token: 0x040122F5 RID: 74485
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040122F6 RID: 74486
		internal static int __PropertyOffset_Scale;

		// Token: 0x040122F7 RID: 74487
		internal static int __PropertyOffset_Time;

		// Token: 0x040122F8 RID: 74488
		[Nullable(2)]
		private FFrameNumber _Time;
	}
}
