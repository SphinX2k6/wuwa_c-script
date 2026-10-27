using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026FC RID: 9980
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneSeqAnimDataSection")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UMovieSceneSeqAnimDataSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025030 RID: 151600 RVA: 0x0036C18D File Offset: 0x0036A38D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSeqAnimDataSection._ClassPtr;
		}

		// Token: 0x06025031 RID: 151601 RVA: 0x0036C19C File Offset: 0x0036A39C
		public UMovieSceneSeqAnimDataSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSeqAnimDataSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025032 RID: 151602 RVA: 0x0036C1C4 File Offset: 0x0036A3C4
		public UMovieSceneSeqAnimDataSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSeqAnimDataSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008EE8 RID: 36584
		// (get) Token: 0x06025033 RID: 151603 RVA: 0x0036C1F8 File Offset: 0x0036A3F8
		// (set) Token: 0x06025034 RID: 151604 RVA: 0x0036C231 File Offset: 0x0036A431
		public TArray<FFloatNameAndCurve> FloatNamesAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFloatNameAndCurve> result;
				if ((result = this._FloatNamesAndCurves) == null)
				{
					result = (this._FloatNamesAndCurves = new TArray<FFloatNameAndCurve>(base.NativePtr + (IntPtr)UMovieSceneSeqAnimDataSection.__PropertyOffset_FloatNamesAndCurves, this));
				}
				return result;
			}
			set
			{
				this.FloatNamesAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x17008EE9 RID: 36585
		// (get) Token: 0x06025035 RID: 151605 RVA: 0x0036C240 File Offset: 0x0036A440
		// (set) Token: 0x06025036 RID: 151606 RVA: 0x0036C279 File Offset: 0x0036A479
		public TArray<FVectorNameAndCurve> VectorNameAndCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorNameAndCurve> result;
				if ((result = this._VectorNameAndCurves) == null)
				{
					result = (this._VectorNameAndCurves = new TArray<FVectorNameAndCurve>(base.NativePtr + (IntPtr)UMovieSceneSeqAnimDataSection.__PropertyOffset_VectorNameAndCurves, this));
				}
				return result;
			}
			set
			{
				this.VectorNameAndCurves.CopyAssign(value);
			}
		}

		// Token: 0x06025037 RID: 151607 RVA: 0x0036C287 File Offset: 0x0036A487
		public bool RemoveScalarParameter(FName InParameterName)
		{
			return UMovieSceneSeqAnimDataSection.__RemoveScalarParameter_Internal(base.NativePtr, InParameterName);
		}

		// Token: 0x06025038 RID: 151608 RVA: 0x0036C295 File Offset: 0x0036A495
		public bool RemoveCategory(FName InParameterName)
		{
			return UMovieSceneSeqAnimDataSection.__RemoveCategory_Internal(base.NativePtr, InParameterName);
		}

		// Token: 0x06025039 RID: 151609 RVA: 0x0036C2A4 File Offset: 0x0036A4A4
		[NullableContext(2)]
		public unsafe bool GetVectorParameter(FName InParameterName, FFrameNumber InTime, ref FVector Value)
		{
			fixed (FVector* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				return UMovieSceneSeqAnimDataSection.__GetVectorParameter_Internal(base.NativePtr, InParameterName, (InTime ?? new FFrameNumber()).NativePtr, ref Value);
			}
		}

		// Token: 0x0602503A RID: 151610 RVA: 0x0036C2D2 File Offset: 0x0036A4D2
		[NullableContext(2)]
		public bool GetScalarParameters(FFrameNumber InTime, ref TMap<FName, float> Floats)
		{
			return UMovieSceneSeqAnimDataSection.__GetScalarParameters_Internal(base.NativePtr, (InTime ?? new FFrameNumber()).NativePtr, (Floats ?? new TMap<FName, float>()).NativeMapPtr);
		}

		// Token: 0x0602503B RID: 151611 RVA: 0x0036C2FE File Offset: 0x0036A4FE
		public void EmptyParameters()
		{
			UMovieSceneSeqAnimDataSection.__EmptyParameters_Internal(base.NativePtr);
		}

		// Token: 0x0602503C RID: 151612 RVA: 0x0036C30B File Offset: 0x0036A50B
		[NullableContext(2)]
		public void AddVectorParameterKeyCustom(in FSeqAnimCurveVectorDesc InParameterName, FFrameNumber InTime, FVector InValue)
		{
			UMovieSceneSeqAnimDataSection.__AddVectorParameterKeyCustom_Internal(base.NativePtr, (InParameterName ?? new FSeqAnimCurveVectorDesc()).NativePtr, (InTime ?? new FFrameNumber()).NativePtr, InValue);
		}

		// Token: 0x0602503D RID: 151613 RVA: 0x0036C338 File Offset: 0x0036A538
		[NullableContext(2)]
		public void AddVectorParameterKey(FName InParameterName, FFrameNumber InTime, FVector InValue)
		{
			UMovieSceneSeqAnimDataSection.__AddVectorParameterKey_Internal(base.NativePtr, InParameterName, (InTime ?? new FFrameNumber()).NativePtr, InValue);
		}

		// Token: 0x0602503E RID: 151614 RVA: 0x0036C356 File Offset: 0x0036A556
		[NullableContext(2)]
		public void AddScalarParameterKeyCustom(in FSeqAnimCurveFloatDesc InParameterName, FFrameNumber InTime, float InValue)
		{
			UMovieSceneSeqAnimDataSection.__AddScalarParameterKeyCustom_Internal(base.NativePtr, (InParameterName ?? new FSeqAnimCurveFloatDesc()).NativePtr, (InTime ?? new FFrameNumber()).NativePtr, InValue);
		}

		// Token: 0x0602503F RID: 151615 RVA: 0x0036C383 File Offset: 0x0036A583
		[NullableContext(2)]
		public void AddScalarParameterKey(FName InParameterName, FFrameNumber InTime, float InValue)
		{
			UMovieSceneSeqAnimDataSection.__AddScalarParameterKey_Internal(base.NativePtr, InParameterName, (InTime ?? new FFrameNumber()).NativePtr, InValue);
		}

		// Token: 0x06025040 RID: 151616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveScalarParameter_Internal(IntPtr @this, FName InParameterName);

		// Token: 0x06025041 RID: 151617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveCategory_Internal(IntPtr @this, FName InParameterName);

		// Token: 0x06025042 RID: 151618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVectorParameter_Internal(IntPtr @this, FName InParameterName, IntPtr InTime, ref FVector Value);

		// Token: 0x06025043 RID: 151619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetScalarParameters_Internal(IntPtr @this, IntPtr InTime, IntPtr Floats);

		// Token: 0x06025044 RID: 151620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EmptyParameters_Internal(IntPtr @this);

		// Token: 0x06025045 RID: 151621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddVectorParameterKeyCustom_Internal(IntPtr @this, IntPtr InParameterName, IntPtr InTime, FVector InValue);

		// Token: 0x06025046 RID: 151622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddVectorParameterKey_Internal(IntPtr @this, FName InParameterName, IntPtr InTime, FVector InValue);

		// Token: 0x06025047 RID: 151623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddScalarParameterKeyCustom_Internal(IntPtr @this, IntPtr InParameterName, IntPtr InTime, float InValue);

		// Token: 0x06025048 RID: 151624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddScalarParameterKey_Internal(IntPtr @this, FName InParameterName, IntPtr InTime, float InValue);

		// Token: 0x06025049 RID: 151625 RVA: 0x0036C3A1 File Offset: 0x0036A5A1
		static UMovieSceneSeqAnimDataSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneSeqAnimDataSection");
		}

		// Token: 0x0602504A RID: 151626 RVA: 0x0036C3AF File Offset: 0x0036A5AF
		protected UMovieSceneSeqAnimDataSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F20 RID: 81696
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneSeqAnimDataSection";

		// Token: 0x04013F21 RID: 81697
		private static IntPtr _ClassPtr;

		// Token: 0x04013F22 RID: 81698
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F23 RID: 81699
		internal static int __PropertyOffset_FloatNamesAndCurves;

		// Token: 0x04013F24 RID: 81700
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFloatNameAndCurve> _FloatNamesAndCurves;

		// Token: 0x04013F25 RID: 81701
		internal static int __PropertyOffset_VectorNameAndCurves;

		// Token: 0x04013F26 RID: 81702
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVectorNameAndCurve> _VectorNameAndCurves;
	}
}
