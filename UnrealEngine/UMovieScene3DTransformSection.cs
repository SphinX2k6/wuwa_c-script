using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002333 RID: 9011
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DTransformSection")]
	[UnrealStructLayout(1928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1928)]
	public class UMovieScene3DTransformSection : UMovieSceneSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022140 RID: 139584 RVA: 0x0032617A File Offset: 0x0032437A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DTransformSection._ClassPtr;
		}

		// Token: 0x06022141 RID: 139585 RVA: 0x00326186 File Offset: 0x00324386
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieScene3DTransformSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x06022142 RID: 139586 RVA: 0x00326190 File Offset: 0x00324390
		public UMovieScene3DTransformSection() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022143 RID: 139587 RVA: 0x003261B8 File Offset: 0x003243B8
		public UMovieScene3DTransformSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083A5 RID: 33701
		// (get) Token: 0x06022144 RID: 139588 RVA: 0x003261EC File Offset: 0x003243EC
		// (set) Token: 0x06022145 RID: 139589 RVA: 0x00326225 File Offset: 0x00324425
		public FMovieSceneTransformMask TransformMask
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTransformMask result;
				if ((result = this._TransformMask) == null)
				{
					result = (this._TransformMask = new FMovieSceneTransformMask(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_TransformMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTransformMask.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_TransformMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083A6 RID: 33702
		// (get) Token: 0x06022146 RID: 139590 RVA: 0x00326248 File Offset: 0x00324448
		// (set) Token: 0x06022147 RID: 139591 RVA: 0x00326282 File Offset: 0x00324482
		public TFixedArray<FMovieSceneFloatChannel> Translation
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Translation) == null)
				{
					result = (this._Translation = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_Translation, 3, this));
				}
				return result;
			}
			set
			{
				this.Translation.CopyAssign(value);
			}
		}

		// Token: 0x170083A7 RID: 33703
		// (get) Token: 0x06022148 RID: 139592 RVA: 0x00326290 File Offset: 0x00324490
		// (set) Token: 0x06022149 RID: 139593 RVA: 0x003262CA File Offset: 0x003244CA
		public TFixedArray<FMovieSceneFloatChannel> Rotation
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_Rotation, 3, this));
				}
				return result;
			}
			set
			{
				this.Rotation.CopyAssign(value);
			}
		}

		// Token: 0x170083A8 RID: 33704
		// (get) Token: 0x0602214A RID: 139594 RVA: 0x003262D8 File Offset: 0x003244D8
		// (set) Token: 0x0602214B RID: 139595 RVA: 0x00326312 File Offset: 0x00324512
		public TFixedArray<FMovieSceneFloatChannel> Scale
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_Scale, 3, this));
				}
				return result;
			}
			set
			{
				this.Scale.CopyAssign(value);
			}
		}

		// Token: 0x170083A9 RID: 33705
		// (get) Token: 0x0602214C RID: 139596 RVA: 0x00326320 File Offset: 0x00324520
		// (set) Token: 0x0602214D RID: 139597 RVA: 0x00326359 File Offset: 0x00324559
		public FMovieSceneFloatChannel ManualWeight
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._ManualWeight) == null)
				{
					result = (this._ManualWeight = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_ManualWeight, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_ManualWeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083AA RID: 33706
		// (get) Token: 0x0602214E RID: 139598 RVA: 0x0032637A File Offset: 0x0032457A
		// (set) Token: 0x0602214F RID: 139599 RVA: 0x0032638A File Offset: 0x0032458A
		public unsafe bool bUseQuaternionInterpolation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_bUseQuaternionInterpolation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_bUseQuaternionInterpolation) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022150 RID: 139600 RVA: 0x0032639B File Offset: 0x0032459B
		static UMovieScene3DTransformSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DTransformSection");
		}

		// Token: 0x06022151 RID: 139601 RVA: 0x003263A9 File Offset: 0x003245A9
		protected UMovieScene3DTransformSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040122FC RID: 74492
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x040122FD RID: 74493
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DTransformSection";

		// Token: 0x040122FE RID: 74494
		private static IntPtr _ClassPtr;

		// Token: 0x040122FF RID: 74495
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012300 RID: 74496
		internal static int __PropertyOffset_TransformMask;

		// Token: 0x04012301 RID: 74497
		[Nullable(2)]
		private FMovieSceneTransformMask _TransformMask;

		// Token: 0x04012302 RID: 74498
		internal static int __PropertyOffset_Translation;

		// Token: 0x04012303 RID: 74499
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Translation;

		// Token: 0x04012304 RID: 74500
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04012305 RID: 74501
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Rotation;

		// Token: 0x04012306 RID: 74502
		internal static int __PropertyOffset_Scale;

		// Token: 0x04012307 RID: 74503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Scale;

		// Token: 0x04012308 RID: 74504
		internal static int __PropertyOffset_ManualWeight;

		// Token: 0x04012309 RID: 74505
		[Nullable(2)]
		private FMovieSceneFloatChannel _ManualWeight;

		// Token: 0x0401230A RID: 74506
		internal static int __PropertyOffset_bUseQuaternionInterpolation;
	}
}
