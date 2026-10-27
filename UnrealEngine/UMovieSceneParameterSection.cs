using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002390 RID: 9104
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneParameterSection")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UMovieSceneParameterSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060224E7 RID: 140519 RVA: 0x0032BBDB File Offset: 0x00329DDB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneParameterSection._ClassPtr;
		}

		// Token: 0x060224E8 RID: 140520 RVA: 0x0032BBE8 File Offset: 0x00329DE8
		public UMovieSceneParameterSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneParameterSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060224E9 RID: 140521 RVA: 0x0032BC10 File Offset: 0x00329E10
		public UMovieSceneParameterSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneParameterSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008444 RID: 33860
		// (get) Token: 0x060224EA RID: 140522 RVA: 0x0032BC44 File Offset: 0x00329E44
		// (set) Token: 0x060224EB RID: 140523 RVA: 0x0032BC7D File Offset: 0x00329E7D
		public TArray<FBoolParameterNameAndCurve> BoolParameterNamesAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoolParameterNameAndCurve> result;
				if ((result = this._BoolParameterNamesAndCurves) == null)
				{
					result = (this._BoolParameterNamesAndCurves = new TArray<FBoolParameterNameAndCurve>(base.NativePtr + (IntPtr)UMovieSceneParameterSection.__PropertyOffset_BoolParameterNamesAndCurves, this));
				}
				return result;
			}
			set
			{
				this.BoolParameterNamesAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x17008445 RID: 33861
		// (get) Token: 0x060224EC RID: 140524 RVA: 0x0032BC8C File Offset: 0x00329E8C
		// (set) Token: 0x060224ED RID: 140525 RVA: 0x0032BCC5 File Offset: 0x00329EC5
		public TArray<FScalarParameterNameAndCurve> ScalarParameterNamesAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FScalarParameterNameAndCurve> result;
				if ((result = this._ScalarParameterNamesAndCurves) == null)
				{
					result = (this._ScalarParameterNamesAndCurves = new TArray<FScalarParameterNameAndCurve>(base.NativePtr + (IntPtr)UMovieSceneParameterSection.__PropertyOffset_ScalarParameterNamesAndCurves, this));
				}
				return result;
			}
			set
			{
				this.ScalarParameterNamesAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x17008446 RID: 33862
		// (get) Token: 0x060224EE RID: 140526 RVA: 0x0032BCD4 File Offset: 0x00329ED4
		// (set) Token: 0x060224EF RID: 140527 RVA: 0x0032BD0D File Offset: 0x00329F0D
		public TArray<FVector2DParameterNameAndCurves> Vector2DParameterNamesAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2DParameterNameAndCurves> result;
				if ((result = this._Vector2DParameterNamesAndCurves) == null)
				{
					result = (this._Vector2DParameterNamesAndCurves = new TArray<FVector2DParameterNameAndCurves>(base.NativePtr + (IntPtr)UMovieSceneParameterSection.__PropertyOffset_Vector2DParameterNamesAndCurves, this));
				}
				return result;
			}
			set
			{
				this.Vector2DParameterNamesAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x17008447 RID: 33863
		// (get) Token: 0x060224F0 RID: 140528 RVA: 0x0032BD1C File Offset: 0x00329F1C
		// (set) Token: 0x060224F1 RID: 140529 RVA: 0x0032BD55 File Offset: 0x00329F55
		public TArray<FVectorParameterNameAndCurves> VectorParameterNamesAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorParameterNameAndCurves> result;
				if ((result = this._VectorParameterNamesAndCurves) == null)
				{
					result = (this._VectorParameterNamesAndCurves = new TArray<FVectorParameterNameAndCurves>(base.NativePtr + (IntPtr)UMovieSceneParameterSection.__PropertyOffset_VectorParameterNamesAndCurves, this));
				}
				return result;
			}
			set
			{
				this.VectorParameterNamesAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x17008448 RID: 33864
		// (get) Token: 0x060224F2 RID: 140530 RVA: 0x0032BD64 File Offset: 0x00329F64
		// (set) Token: 0x060224F3 RID: 140531 RVA: 0x0032BD9D File Offset: 0x00329F9D
		public TArray<FColorParameterNameAndCurves> ColorParameterNamesAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColorParameterNameAndCurves> result;
				if ((result = this._ColorParameterNamesAndCurves) == null)
				{
					result = (this._ColorParameterNamesAndCurves = new TArray<FColorParameterNameAndCurves>(base.NativePtr + (IntPtr)UMovieSceneParameterSection.__PropertyOffset_ColorParameterNamesAndCurves, this));
				}
				return result;
			}
			set
			{
				this.ColorParameterNamesAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x17008449 RID: 33865
		// (get) Token: 0x060224F4 RID: 140532 RVA: 0x0032BDAC File Offset: 0x00329FAC
		// (set) Token: 0x060224F5 RID: 140533 RVA: 0x0032BDE5 File Offset: 0x00329FE5
		public TArray<FTransformParameterNameAndCurves> TransformParameterNamesAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransformParameterNameAndCurves> result;
				if ((result = this._TransformParameterNamesAndCurves) == null)
				{
					result = (this._TransformParameterNamesAndCurves = new TArray<FTransformParameterNameAndCurves>(base.NativePtr + (IntPtr)UMovieSceneParameterSection.__PropertyOffset_TransformParameterNamesAndCurves, this));
				}
				return result;
			}
			set
			{
				this.TransformParameterNamesAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x060224F6 RID: 140534 RVA: 0x0032BDF3 File Offset: 0x00329FF3
		public bool RemoveVectorParameter(FName InParameterName)
		{
			return UMovieSceneParameterSection.__RemoveVectorParameter_Internal(base.NativePtr, InParameterName);
		}

		// Token: 0x060224F7 RID: 140535 RVA: 0x0032BE01 File Offset: 0x0032A001
		public bool RemoveVector2DParameter(FName InParameterName)
		{
			return UMovieSceneParameterSection.__RemoveVector2DParameter_Internal(base.NativePtr, InParameterName);
		}

		// Token: 0x060224F8 RID: 140536 RVA: 0x0032BE0F File Offset: 0x0032A00F
		public bool RemoveTransformParameter(FName InParameterName)
		{
			return UMovieSceneParameterSection.__RemoveTransformParameter_Internal(base.NativePtr, InParameterName);
		}

		// Token: 0x060224F9 RID: 140537 RVA: 0x0032BE1D File Offset: 0x0032A01D
		public bool RemoveScalarParameter(FName InParameterName)
		{
			return UMovieSceneParameterSection.__RemoveScalarParameter_Internal(base.NativePtr, InParameterName);
		}

		// Token: 0x060224FA RID: 140538 RVA: 0x0032BE2B File Offset: 0x0032A02B
		public bool RemoveColorParameter(FName InParameterName)
		{
			return UMovieSceneParameterSection.__RemoveColorParameter_Internal(base.NativePtr, InParameterName);
		}

		// Token: 0x060224FB RID: 140539 RVA: 0x0032BE39 File Offset: 0x0032A039
		public bool RemoveBoolParameter(FName InParameterName)
		{
			return UMovieSceneParameterSection.__RemoveBoolParameter_Internal(base.NativePtr, InParameterName);
		}

		// Token: 0x060224FC RID: 140540 RVA: 0x0032BE47 File Offset: 0x0032A047
		[NullableContext(2)]
		public void GetParameterNames(ref TSet<FName> ParameterNames)
		{
			UMovieSceneParameterSection.__GetParameterNames_Internal(base.NativePtr, (ParameterNames ?? new TSet<FName>()).NativeSetPtr);
		}

		// Token: 0x060224FD RID: 140541 RVA: 0x0032BE64 File Offset: 0x0032A064
		[NullableContext(2)]
		public void AddVectorParameterKey(FName InParameterName, FFrameNumber InTime, FVector InValue)
		{
			UMovieSceneParameterSection.__AddVectorParameterKey_Internal(base.NativePtr, InParameterName, (InTime ?? new FFrameNumber()).NativePtr, InValue);
		}

		// Token: 0x060224FE RID: 140542 RVA: 0x0032BE82 File Offset: 0x0032A082
		[NullableContext(2)]
		public void AddVector2DParameterKey(FName InParameterName, FFrameNumber InTime, FVector2D InValue)
		{
			UMovieSceneParameterSection.__AddVector2DParameterKey_Internal(base.NativePtr, InParameterName, (InTime ?? new FFrameNumber()).NativePtr, InValue);
		}

		// Token: 0x060224FF RID: 140543 RVA: 0x0032BEA0 File Offset: 0x0032A0A0
		[NullableContext(2)]
		public unsafe void AddTransformParameterKey(FName InParameterName, FFrameNumber InTime, in FTransform InValue)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UMovieSceneParameterSection.__AddTransformParameterKey_Internal(base.NativePtr, InParameterName, (InTime ?? new FFrameNumber()).NativePtr, ptr);
		}

		// Token: 0x06022500 RID: 140544 RVA: 0x0032BEE5 File Offset: 0x0032A0E5
		[NullableContext(2)]
		public void AddScalarParameterKey(FName InParameterName, FFrameNumber InTime, float InValue)
		{
			UMovieSceneParameterSection.__AddScalarParameterKey_Internal(base.NativePtr, InParameterName, (InTime ?? new FFrameNumber()).NativePtr, InValue);
		}

		// Token: 0x06022501 RID: 140545 RVA: 0x0032BF03 File Offset: 0x0032A103
		[NullableContext(2)]
		public void AddColorParameterKey(FName InParameterName, FFrameNumber InTime, FLinearColor InValue)
		{
			UMovieSceneParameterSection.__AddColorParameterKey_Internal(base.NativePtr, InParameterName, (InTime ?? new FFrameNumber()).NativePtr, InValue);
		}

		// Token: 0x06022502 RID: 140546 RVA: 0x0032BF21 File Offset: 0x0032A121
		[NullableContext(2)]
		public void AddBoolParameterKey(FName InParameterName, FFrameNumber InTime, bool InValue)
		{
			UMovieSceneParameterSection.__AddBoolParameterKey_Internal(base.NativePtr, InParameterName, (InTime ?? new FFrameNumber()).NativePtr, InValue);
		}

		// Token: 0x06022503 RID: 140547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveVectorParameter_Internal(IntPtr @this, FName InParameterName);

		// Token: 0x06022504 RID: 140548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveVector2DParameter_Internal(IntPtr @this, FName InParameterName);

		// Token: 0x06022505 RID: 140549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveTransformParameter_Internal(IntPtr @this, FName InParameterName);

		// Token: 0x06022506 RID: 140550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveScalarParameter_Internal(IntPtr @this, FName InParameterName);

		// Token: 0x06022507 RID: 140551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveColorParameter_Internal(IntPtr @this, FName InParameterName);

		// Token: 0x06022508 RID: 140552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveBoolParameter_Internal(IntPtr @this, FName InParameterName);

		// Token: 0x06022509 RID: 140553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetParameterNames_Internal(IntPtr @this, IntPtr ParameterNames);

		// Token: 0x0602250A RID: 140554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddVectorParameterKey_Internal(IntPtr @this, FName InParameterName, IntPtr InTime, FVector InValue);

		// Token: 0x0602250B RID: 140555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddVector2DParameterKey_Internal(IntPtr @this, FName InParameterName, IntPtr InTime, FVector2D InValue);

		// Token: 0x0602250C RID: 140556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTransformParameterKey_Internal(IntPtr @this, FName InParameterName, IntPtr InTime, in FTransform InValue);

		// Token: 0x0602250D RID: 140557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddScalarParameterKey_Internal(IntPtr @this, FName InParameterName, IntPtr InTime, float InValue);

		// Token: 0x0602250E RID: 140558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColorParameterKey_Internal(IntPtr @this, FName InParameterName, IntPtr InTime, FLinearColor InValue);

		// Token: 0x0602250F RID: 140559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddBoolParameterKey_Internal(IntPtr @this, FName InParameterName, IntPtr InTime, bool InValue);

		// Token: 0x06022510 RID: 140560 RVA: 0x0032BF3F File Offset: 0x0032A13F
		static UMovieSceneParameterSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneParameterSection");
		}

		// Token: 0x06022511 RID: 140561 RVA: 0x0032BF4D File Offset: 0x0032A14D
		protected UMovieSceneParameterSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012506 RID: 75014
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneParameterSection";

		// Token: 0x04012507 RID: 75015
		private static IntPtr _ClassPtr;

		// Token: 0x04012508 RID: 75016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012509 RID: 75017
		internal static int __PropertyOffset_BoolParameterNamesAndCurves;

		// Token: 0x0401250A RID: 75018
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoolParameterNameAndCurve> _BoolParameterNamesAndCurves;

		// Token: 0x0401250B RID: 75019
		internal static int __PropertyOffset_ScalarParameterNamesAndCurves;

		// Token: 0x0401250C RID: 75020
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FScalarParameterNameAndCurve> _ScalarParameterNamesAndCurves;

		// Token: 0x0401250D RID: 75021
		internal static int __PropertyOffset_Vector2DParameterNamesAndCurves;

		// Token: 0x0401250E RID: 75022
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVector2DParameterNameAndCurves> _Vector2DParameterNamesAndCurves;

		// Token: 0x0401250F RID: 75023
		internal static int __PropertyOffset_VectorParameterNamesAndCurves;

		// Token: 0x04012510 RID: 75024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVectorParameterNameAndCurves> _VectorParameterNamesAndCurves;

		// Token: 0x04012511 RID: 75025
		internal static int __PropertyOffset_ColorParameterNamesAndCurves;

		// Token: 0x04012512 RID: 75026
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FColorParameterNameAndCurves> _ColorParameterNamesAndCurves;

		// Token: 0x04012513 RID: 75027
		internal static int __PropertyOffset_TransformParameterNamesAndCurves;

		// Token: 0x04012514 RID: 75028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransformParameterNameAndCurves> _TransformParameterNamesAndCurves;
	}
}
