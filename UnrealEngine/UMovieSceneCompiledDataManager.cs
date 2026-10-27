using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023E1 RID: 9185
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneCompiledDataManager")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class UMovieSceneCompiledDataManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060227D4 RID: 141268 RVA: 0x003302A6 File Offset: 0x0032E4A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCompiledDataManager._ClassPtr;
		}

		// Token: 0x060227D5 RID: 141269 RVA: 0x003302B4 File Offset: 0x0032E4B4
		public UMovieSceneCompiledDataManager() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCompiledDataManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060227D6 RID: 141270 RVA: 0x003302DC File Offset: 0x0032E4DC
		public UMovieSceneCompiledDataManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCompiledDataManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170084D8 RID: 34008
		// (get) Token: 0x060227D7 RID: 141271 RVA: 0x00330310 File Offset: 0x0032E510
		// (set) Token: 0x060227D8 RID: 141272 RVA: 0x00330349 File Offset: 0x0032E549
		public TMap<int, FMovieSceneSequenceHierarchy> Hierarchies
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FMovieSceneSequenceHierarchy> result;
				if ((result = this._Hierarchies) == null)
				{
					result = (this._Hierarchies = new TMap<int, FMovieSceneSequenceHierarchy>(base.NativePtr + (IntPtr)UMovieSceneCompiledDataManager.__PropertyOffset_Hierarchies, this));
				}
				return result;
			}
			set
			{
				this.Hierarchies.CopyAssign(value);
			}
		}

		// Token: 0x170084D9 RID: 34009
		// (get) Token: 0x060227D9 RID: 141273 RVA: 0x00330358 File Offset: 0x0032E558
		// (set) Token: 0x060227DA RID: 141274 RVA: 0x00330391 File Offset: 0x0032E591
		public TMap<int, FMovieSceneEvaluationTemplate> TrackTemplates
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FMovieSceneEvaluationTemplate> result;
				if ((result = this._TrackTemplates) == null)
				{
					result = (this._TrackTemplates = new TMap<int, FMovieSceneEvaluationTemplate>(base.NativePtr + (IntPtr)UMovieSceneCompiledDataManager.__PropertyOffset_TrackTemplates, this));
				}
				return result;
			}
			set
			{
				this.TrackTemplates.CopyAssign(value);
			}
		}

		// Token: 0x170084DA RID: 34010
		// (get) Token: 0x060227DB RID: 141275 RVA: 0x003303A0 File Offset: 0x0032E5A0
		// (set) Token: 0x060227DC RID: 141276 RVA: 0x003303D9 File Offset: 0x0032E5D9
		public TMap<int, FMovieSceneEvaluationField> TrackTemplateFields
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FMovieSceneEvaluationField> result;
				if ((result = this._TrackTemplateFields) == null)
				{
					result = (this._TrackTemplateFields = new TMap<int, FMovieSceneEvaluationField>(base.NativePtr + (IntPtr)UMovieSceneCompiledDataManager.__PropertyOffset_TrackTemplateFields, this));
				}
				return result;
			}
			set
			{
				this.TrackTemplateFields.CopyAssign(value);
			}
		}

		// Token: 0x170084DB RID: 34011
		// (get) Token: 0x060227DD RID: 141277 RVA: 0x003303E8 File Offset: 0x0032E5E8
		// (set) Token: 0x060227DE RID: 141278 RVA: 0x00330421 File Offset: 0x0032E621
		public TMap<int, FMovieSceneEntityComponentField> EntityComponentFields
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FMovieSceneEntityComponentField> result;
				if ((result = this._EntityComponentFields) == null)
				{
					result = (this._EntityComponentFields = new TMap<int, FMovieSceneEntityComponentField>(base.NativePtr + (IntPtr)UMovieSceneCompiledDataManager.__PropertyOffset_EntityComponentFields, this));
				}
				return result;
			}
			set
			{
				this.EntityComponentFields.CopyAssign(value);
			}
		}

		// Token: 0x060227DF RID: 141279 RVA: 0x0033042F File Offset: 0x0032E62F
		static UMovieSceneCompiledDataManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneCompiledDataManager");
		}

		// Token: 0x060227E0 RID: 141280 RVA: 0x0033043D File Offset: 0x0032E63D
		protected UMovieSceneCompiledDataManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126F9 RID: 75513
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneCompiledDataManager";

		// Token: 0x040126FA RID: 75514
		private static IntPtr _ClassPtr;

		// Token: 0x040126FB RID: 75515
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040126FC RID: 75516
		internal static int __PropertyOffset_Hierarchies;

		// Token: 0x040126FD RID: 75517
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FMovieSceneSequenceHierarchy> _Hierarchies;

		// Token: 0x040126FE RID: 75518
		internal static int __PropertyOffset_TrackTemplates;

		// Token: 0x040126FF RID: 75519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FMovieSceneEvaluationTemplate> _TrackTemplates;

		// Token: 0x04012700 RID: 75520
		internal static int __PropertyOffset_TrackTemplateFields;

		// Token: 0x04012701 RID: 75521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FMovieSceneEvaluationField> _TrackTemplateFields;

		// Token: 0x04012702 RID: 75522
		internal static int __PropertyOffset_EntityComponentFields;

		// Token: 0x04012703 RID: 75523
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FMovieSceneEntityComponentField> _EntityComponentFields;
	}
}
