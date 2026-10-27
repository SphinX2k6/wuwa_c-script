using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000512 RID: 1298
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.MovieSceneControlRigParameterSection")]
	[UnrealStructLayout(824, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 824)]
	public class UMovieSceneControlRigParameterSection : UMovieSceneParameterSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060043C1 RID: 17345 RVA: 0x00064E19 File Offset: 0x00063019
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneControlRigParameterSection._ClassPtr;
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00064E28 File Offset: 0x00063028
		public UMovieSceneControlRigParameterSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneControlRigParameterSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00064E50 File Offset: 0x00063050
		public UMovieSceneControlRigParameterSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneControlRigParameterSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x00064E83 File Offset: 0x00063083
		// (set) Token: 0x060043C5 RID: 17349 RVA: 0x00064E97 File Offset: 0x00063097
		[Nullable(2)]
		public unsafe UControlRig ControlRig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UControlRig>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneControlRigParameterSection.__PropertyOffset_ControlRig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneControlRigParameterSection.__PropertyOffset_ControlRig, value);
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x060043C6 RID: 17350 RVA: 0x00064EAC File Offset: 0x000630AC
		// (set) Token: 0x060043C7 RID: 17351 RVA: 0x00064EE5 File Offset: 0x000630E5
		public TArray<bool> ControlsMask
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._ControlsMask) == null)
				{
					result = (this._ControlsMask = new TArray<bool>(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_ControlsMask, this));
				}
				return result;
			}
			set
			{
				this.ControlsMask.CopyAssign(value);
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x060043C8 RID: 17352 RVA: 0x00064EF4 File Offset: 0x000630F4
		// (set) Token: 0x060043C9 RID: 17353 RVA: 0x00064F2D File Offset: 0x0006312D
		public FMovieSceneTransformMask TransformMask
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTransformMask result;
				if ((result = this._TransformMask) == null)
				{
					result = (this._TransformMask = new FMovieSceneTransformMask(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_TransformMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTransformMask.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_TransformMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x060043CA RID: 17354 RVA: 0x00064F4E File Offset: 0x0006314E
		// (set) Token: 0x060043CB RID: 17355 RVA: 0x00064F5E File Offset: 0x0006315E
		public unsafe bool bAdditive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_bAdditive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_bAdditive) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x060043CC RID: 17356 RVA: 0x00064F6F File Offset: 0x0006316F
		// (set) Token: 0x060043CD RID: 17357 RVA: 0x00064F7F File Offset: 0x0006317F
		public unsafe bool bApplyBoneFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_bApplyBoneFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_bApplyBoneFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x060043CE RID: 17358 RVA: 0x00064F90 File Offset: 0x00063190
		// (set) Token: 0x060043CF RID: 17359 RVA: 0x00064FC9 File Offset: 0x000631C9
		public FInputBlendPose BoneFilter
		{
			get
			{
				base.FastCheckIsValid();
				FInputBlendPose result;
				if ((result = this._BoneFilter) == null)
				{
					result = (this._BoneFilter = new FInputBlendPose(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_BoneFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputBlendPose.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_BoneFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x060043D0 RID: 17360 RVA: 0x00064FEC File Offset: 0x000631EC
		// (set) Token: 0x060043D1 RID: 17361 RVA: 0x00065025 File Offset: 0x00063225
		public FMovieSceneFloatChannel Weight
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._Weight) == null)
				{
					result = (this._Weight = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_Weight, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_Weight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x060043D2 RID: 17362 RVA: 0x00065048 File Offset: 0x00063248
		// (set) Token: 0x060043D3 RID: 17363 RVA: 0x00065081 File Offset: 0x00063281
		public TMap<FName, FChannelMapInfo> ControlChannelMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FChannelMapInfo> result;
				if ((result = this._ControlChannelMap) == null)
				{
					result = (this._ControlChannelMap = new TMap<FName, FChannelMapInfo>(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_ControlChannelMap, this));
				}
				return result;
			}
			set
			{
				this.ControlChannelMap.CopyAssign(value);
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060043D4 RID: 17364 RVA: 0x00065090 File Offset: 0x00063290
		// (set) Token: 0x060043D5 RID: 17365 RVA: 0x000650C9 File Offset: 0x000632C9
		public TArray<FEnumParameterNameAndCurve> EnumParameterNamesAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEnumParameterNameAndCurve> result;
				if ((result = this._EnumParameterNamesAndCurves) == null)
				{
					result = (this._EnumParameterNamesAndCurves = new TArray<FEnumParameterNameAndCurve>(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_EnumParameterNamesAndCurves, this));
				}
				return result;
			}
			set
			{
				this.EnumParameterNamesAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060043D6 RID: 17366 RVA: 0x000650D8 File Offset: 0x000632D8
		// (set) Token: 0x060043D7 RID: 17367 RVA: 0x00065111 File Offset: 0x00063311
		public TArray<FIntegerParameterNameAndCurve> IntegerParameterNamesAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIntegerParameterNameAndCurve> result;
				if ((result = this._IntegerParameterNamesAndCurves) == null)
				{
					result = (this._IntegerParameterNamesAndCurves = new TArray<FIntegerParameterNameAndCurve>(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterSection.__PropertyOffset_IntegerParameterNamesAndCurves, this));
				}
				return result;
			}
			set
			{
				this.IntegerParameterNamesAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x0006511F File Offset: 0x0006331F
		static UMovieSceneControlRigParameterSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.MovieSceneControlRigParameterSection");
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x0006512D File Offset: 0x0006332D
		protected UMovieSceneControlRigParameterSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040020F9 RID: 8441
		public new const string __ObjectPath = "/Script/ControlRig.MovieSceneControlRigParameterSection";

		// Token: 0x040020FA RID: 8442
		private static IntPtr _ClassPtr;

		// Token: 0x040020FB RID: 8443
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040020FC RID: 8444
		internal static int __PropertyOffset_ControlRig;

		// Token: 0x040020FD RID: 8445
		internal static int __PropertyOffset_ControlsMask;

		// Token: 0x040020FE RID: 8446
		[Nullable(2)]
		private TArray<bool> _ControlsMask;

		// Token: 0x040020FF RID: 8447
		internal static int __PropertyOffset_TransformMask;

		// Token: 0x04002100 RID: 8448
		[Nullable(2)]
		private FMovieSceneTransformMask _TransformMask;

		// Token: 0x04002101 RID: 8449
		internal static int __PropertyOffset_bAdditive;

		// Token: 0x04002102 RID: 8450
		internal static int __PropertyOffset_bApplyBoneFilter;

		// Token: 0x04002103 RID: 8451
		internal static int __PropertyOffset_BoneFilter;

		// Token: 0x04002104 RID: 8452
		[Nullable(2)]
		private FInputBlendPose _BoneFilter;

		// Token: 0x04002105 RID: 8453
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002106 RID: 8454
		[Nullable(2)]
		private FMovieSceneFloatChannel _Weight;

		// Token: 0x04002107 RID: 8455
		internal static int __PropertyOffset_ControlChannelMap;

		// Token: 0x04002108 RID: 8456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FChannelMapInfo> _ControlChannelMap;

		// Token: 0x04002109 RID: 8457
		internal static int __PropertyOffset_EnumParameterNamesAndCurves;

		// Token: 0x0400210A RID: 8458
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEnumParameterNameAndCurve> _EnumParameterNamesAndCurves;

		// Token: 0x0400210B RID: 8459
		internal static int __PropertyOffset_IntegerParameterNamesAndCurves;

		// Token: 0x0400210C RID: 8460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FIntegerParameterNameAndCurve> _IntegerParameterNamesAndCurves;
	}
}
