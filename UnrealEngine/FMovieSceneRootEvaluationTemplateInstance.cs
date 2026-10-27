using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002426 RID: 9254
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneRootEvaluationTemplateInstance")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 248)]
	public class FMovieSceneRootEvaluationTemplateInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022AAC RID: 141996 RVA: 0x003342FE File Offset: 0x003324FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneRootEvaluationTemplateInstance._ScriptStructPtr != 0) ? FMovieSceneRootEvaluationTemplateInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneRootEvaluationTemplateInstance", ref FMovieSceneRootEvaluationTemplateInstance._ScriptStructPtr);
		}

		// Token: 0x1700855F RID: 34143
		// (get) Token: 0x06022AAD RID: 141997 RVA: 0x00334322 File Offset: 0x00332522
		// (set) Token: 0x06022AAE RID: 141998 RVA: 0x00334336 File Offset: 0x00332536
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UMovieSceneSequence> WeakRootSequence
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneRootEvaluationTemplateInstance.__PropertyOffset_WeakRootSequence);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneRootEvaluationTemplateInstance.__PropertyOffset_WeakRootSequence) = value;
			}
		}

		// Token: 0x17008560 RID: 34144
		// (get) Token: 0x06022AAF RID: 141999 RVA: 0x0033434B File Offset: 0x0033254B
		// (set) Token: 0x06022AB0 RID: 142000 RVA: 0x0033435F File Offset: 0x0033255F
		[Nullable(2)]
		public unsafe UMovieSceneCompiledDataManager CompiledDataManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneCompiledDataManager>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneRootEvaluationTemplateInstance.__PropertyOffset_CompiledDataManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneRootEvaluationTemplateInstance.__PropertyOffset_CompiledDataManager, value);
			}
		}

		// Token: 0x17008561 RID: 34145
		// (get) Token: 0x06022AB1 RID: 142001 RVA: 0x00334374 File Offset: 0x00332574
		// (set) Token: 0x06022AB2 RID: 142002 RVA: 0x00334388 File Offset: 0x00332588
		[Nullable(2)]
		public unsafe UMovieSceneEntitySystemLinker EntitySystemLinker
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneEntitySystemLinker>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneRootEvaluationTemplateInstance.__PropertyOffset_EntitySystemLinker);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneRootEvaluationTemplateInstance.__PropertyOffset_EntitySystemLinker, value);
			}
		}

		// Token: 0x17008562 RID: 34146
		// (get) Token: 0x06022AB3 RID: 142003 RVA: 0x003343A0 File Offset: 0x003325A0
		// (set) Token: 0x06022AB4 RID: 142004 RVA: 0x003343E3 File Offset: 0x003325E3
		public TMap<FMovieSceneSequenceID, UObject> DirectorInstances
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FMovieSceneSequenceID, UObject> result;
				if ((result = this._DirectorInstances) == null)
				{
					result = (this._DirectorInstances = new TMap<FMovieSceneSequenceID, UObject>(base.NativePtr + (IntPtr)FMovieSceneRootEvaluationTemplateInstance.__PropertyOffset_DirectorInstances, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DirectorInstances.CopyAssign(value);
			}
		}

		// Token: 0x06022AB5 RID: 142005 RVA: 0x003343F1 File Offset: 0x003325F1
		public FMovieSceneRootEvaluationTemplateInstance()
		{
		}

		// Token: 0x06022AB6 RID: 142006 RVA: 0x003343F9 File Offset: 0x003325F9
		public FMovieSceneRootEvaluationTemplateInstance([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSequence> WeakRootSequence, UMovieSceneCompiledDataManager CompiledDataManager, UMovieSceneEntitySystemLinker EntitySystemLinker, TMap<FMovieSceneSequenceID, UObject> DirectorInstances)
		{
			this.WeakRootSequence = WeakRootSequence;
			this.CompiledDataManager = CompiledDataManager;
			this.EntitySystemLinker = EntitySystemLinker;
			this.DirectorInstances = DirectorInstances;
		}

		// Token: 0x06022AB7 RID: 142007 RVA: 0x0033441E File Offset: 0x0033261E
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneRootEvaluationTemplateInstance.StaticStruct();
		}

		// Token: 0x06022AB8 RID: 142008 RVA: 0x0033442A File Offset: 0x0033262A
		[NullableContext(2)]
		public FMovieSceneRootEvaluationTemplateInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022AB9 RID: 142009 RVA: 0x00334434 File Offset: 0x00332634
		public FMovieSceneRootEvaluationTemplateInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022ABA RID: 142010 RVA: 0x0033443F File Offset: 0x0033263F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneRootEvaluationTemplateInstance(Pointer, false, true);
		}

		// Token: 0x06022ABB RID: 142011 RVA: 0x00334449 File Offset: 0x00332649
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneRootEvaluationTemplateInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04012851 RID: 75857
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneRootEvaluationTemplateInstance";

		// Token: 0x04012852 RID: 75858
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012853 RID: 75859
		internal static int __PropertyOffset_WeakRootSequence;

		// Token: 0x04012854 RID: 75860
		internal static int __PropertyOffset_CompiledDataManager;

		// Token: 0x04012855 RID: 75861
		internal static int __PropertyOffset_EntitySystemLinker;

		// Token: 0x04012856 RID: 75862
		internal static int __PropertyOffset_DirectorInstances;

		// Token: 0x04012857 RID: 75863
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FMovieSceneSequenceID, UObject> _DirectorInstances;
	}
}
