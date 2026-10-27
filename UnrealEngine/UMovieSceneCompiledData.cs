using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023E0 RID: 9184
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneCompiledData")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class UMovieSceneCompiledData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060227BB RID: 141243 RVA: 0x0032FF42 File Offset: 0x0032E142
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCompiledData._ClassPtr;
		}

		// Token: 0x060227BC RID: 141244 RVA: 0x0032FF50 File Offset: 0x0032E150
		public UMovieSceneCompiledData() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCompiledData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060227BD RID: 141245 RVA: 0x0032FF78 File Offset: 0x0032E178
		public UMovieSceneCompiledData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCompiledData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170084CE RID: 33998
		// (get) Token: 0x060227BE RID: 141246 RVA: 0x0032FFAC File Offset: 0x0032E1AC
		// (set) Token: 0x060227BF RID: 141247 RVA: 0x0032FFE5 File Offset: 0x0032E1E5
		public FMovieSceneEvaluationTemplate EvaluationTemplate
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvaluationTemplate result;
				if ((result = this._EvaluationTemplate) == null)
				{
					result = (this._EvaluationTemplate = new FMovieSceneEvaluationTemplate(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_EvaluationTemplate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvaluationTemplate.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_EvaluationTemplate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084CF RID: 33999
		// (get) Token: 0x060227C0 RID: 141248 RVA: 0x00330008 File Offset: 0x0032E208
		// (set) Token: 0x060227C1 RID: 141249 RVA: 0x00330041 File Offset: 0x0032E241
		public FMovieSceneSequenceHierarchy Hierarchy
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceHierarchy result;
				if ((result = this._Hierarchy) == null)
				{
					result = (this._Hierarchy = new FMovieSceneSequenceHierarchy(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_Hierarchy, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceHierarchy.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_Hierarchy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084D0 RID: 34000
		// (get) Token: 0x060227C2 RID: 141250 RVA: 0x00330064 File Offset: 0x0032E264
		// (set) Token: 0x060227C3 RID: 141251 RVA: 0x0033009D File Offset: 0x0032E29D
		public FMovieSceneEntityComponentField EntityComponentField
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEntityComponentField result;
				if ((result = this._EntityComponentField) == null)
				{
					result = (this._EntityComponentField = new FMovieSceneEntityComponentField(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_EntityComponentField, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEntityComponentField.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_EntityComponentField, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084D1 RID: 34001
		// (get) Token: 0x060227C4 RID: 141252 RVA: 0x003300C0 File Offset: 0x0032E2C0
		// (set) Token: 0x060227C5 RID: 141253 RVA: 0x003300F9 File Offset: 0x0032E2F9
		public FMovieSceneEvaluationField TrackTemplateField
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvaluationField result;
				if ((result = this._TrackTemplateField) == null)
				{
					result = (this._TrackTemplateField = new FMovieSceneEvaluationField(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_TrackTemplateField, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvaluationField.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_TrackTemplateField, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084D2 RID: 34002
		// (get) Token: 0x060227C6 RID: 141254 RVA: 0x0033011C File Offset: 0x0032E31C
		// (set) Token: 0x060227C7 RID: 141255 RVA: 0x00330155 File Offset: 0x0032E355
		public TArray<FFrameTime> DeterminismFences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameTime> result;
				if ((result = this._DeterminismFences) == null)
				{
					result = (this._DeterminismFences = new TArray<FFrameTime>(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_DeterminismFences, this));
				}
				return result;
			}
			set
			{
				this.DeterminismFences.CopyAssign(value);
			}
		}

		// Token: 0x170084D3 RID: 34003
		// (get) Token: 0x060227C8 RID: 141256 RVA: 0x00330163 File Offset: 0x0032E363
		// (set) Token: 0x060227C9 RID: 141257 RVA: 0x00330177 File Offset: 0x0032E377
		public unsafe FGuid CompiledSignature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_CompiledSignature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_CompiledSignature) = value;
			}
		}

		// Token: 0x170084D4 RID: 34004
		// (get) Token: 0x060227CA RID: 141258 RVA: 0x0033018C File Offset: 0x0032E38C
		// (set) Token: 0x060227CB RID: 141259 RVA: 0x003301A0 File Offset: 0x0032E3A0
		public unsafe FGuid CompilerVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_CompilerVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_CompilerVersion) = value;
			}
		}

		// Token: 0x170084D5 RID: 34005
		// (get) Token: 0x060227CC RID: 141260 RVA: 0x003301B8 File Offset: 0x0032E3B8
		// (set) Token: 0x060227CD RID: 141261 RVA: 0x003301F1 File Offset: 0x0032E3F1
		public FMovieSceneSequenceCompilerMaskStruct AccumulatedMask
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceCompilerMaskStruct result;
				if ((result = this._AccumulatedMask) == null)
				{
					result = (this._AccumulatedMask = new FMovieSceneSequenceCompilerMaskStruct(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_AccumulatedMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceCompilerMaskStruct.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_AccumulatedMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084D6 RID: 34006
		// (get) Token: 0x060227CE RID: 141262 RVA: 0x00330214 File Offset: 0x0032E414
		// (set) Token: 0x060227CF RID: 141263 RVA: 0x0033024D File Offset: 0x0032E44D
		public FMovieSceneSequenceCompilerMaskStruct AllocatedMask
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceCompilerMaskStruct result;
				if ((result = this._AllocatedMask) == null)
				{
					result = (this._AllocatedMask = new FMovieSceneSequenceCompilerMaskStruct(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_AllocatedMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceCompilerMaskStruct.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_AllocatedMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084D7 RID: 34007
		// (get) Token: 0x060227D0 RID: 141264 RVA: 0x0033026E File Offset: 0x0032E46E
		// (set) Token: 0x060227D1 RID: 141265 RVA: 0x0033027E File Offset: 0x0032E47E
		public unsafe EMovieSceneSequenceFlags AccumulatedFlags
		{
			get
			{
				return (EMovieSceneSequenceFlags)(*(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_AccumulatedFlags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCompiledData.__PropertyOffset_AccumulatedFlags) = (byte)value;
			}
		}

		// Token: 0x060227D2 RID: 141266 RVA: 0x0033028F File Offset: 0x0032E48F
		static UMovieSceneCompiledData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneCompiledData");
		}

		// Token: 0x060227D3 RID: 141267 RVA: 0x0033029D File Offset: 0x0032E49D
		protected UMovieSceneCompiledData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126E5 RID: 75493
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneCompiledData";

		// Token: 0x040126E6 RID: 75494
		private static IntPtr _ClassPtr;

		// Token: 0x040126E7 RID: 75495
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040126E8 RID: 75496
		internal static int __PropertyOffset_EvaluationTemplate;

		// Token: 0x040126E9 RID: 75497
		[Nullable(2)]
		private FMovieSceneEvaluationTemplate _EvaluationTemplate;

		// Token: 0x040126EA RID: 75498
		internal static int __PropertyOffset_Hierarchy;

		// Token: 0x040126EB RID: 75499
		[Nullable(2)]
		private FMovieSceneSequenceHierarchy _Hierarchy;

		// Token: 0x040126EC RID: 75500
		internal static int __PropertyOffset_EntityComponentField;

		// Token: 0x040126ED RID: 75501
		[Nullable(2)]
		private FMovieSceneEntityComponentField _EntityComponentField;

		// Token: 0x040126EE RID: 75502
		internal static int __PropertyOffset_TrackTemplateField;

		// Token: 0x040126EF RID: 75503
		[Nullable(2)]
		private FMovieSceneEvaluationField _TrackTemplateField;

		// Token: 0x040126F0 RID: 75504
		internal static int __PropertyOffset_DeterminismFences;

		// Token: 0x040126F1 RID: 75505
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameTime> _DeterminismFences;

		// Token: 0x040126F2 RID: 75506
		internal static int __PropertyOffset_CompiledSignature;

		// Token: 0x040126F3 RID: 75507
		internal static int __PropertyOffset_CompilerVersion;

		// Token: 0x040126F4 RID: 75508
		internal static int __PropertyOffset_AccumulatedMask;

		// Token: 0x040126F5 RID: 75509
		[Nullable(2)]
		private FMovieSceneSequenceCompilerMaskStruct _AccumulatedMask;

		// Token: 0x040126F6 RID: 75510
		internal static int __PropertyOffset_AllocatedMask;

		// Token: 0x040126F7 RID: 75511
		[Nullable(2)]
		private FMovieSceneSequenceCompilerMaskStruct _AllocatedMask;

		// Token: 0x040126F8 RID: 75512
		internal static int __PropertyOffset_AccumulatedFlags;
	}
}
