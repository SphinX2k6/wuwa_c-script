using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200243A RID: 9274
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceTickManager")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMovieSceneSequenceTickManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022C6E RID: 142446 RVA: 0x00336B53 File Offset: 0x00334D53
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSequenceTickManager._ClassPtr;
		}

		// Token: 0x06022C6F RID: 142447 RVA: 0x00336B60 File Offset: 0x00334D60
		public UMovieSceneSequenceTickManager() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSequenceTickManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022C70 RID: 142448 RVA: 0x00336B88 File Offset: 0x00334D88
		public UMovieSceneSequenceTickManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSequenceTickManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170085B8 RID: 34232
		// (get) Token: 0x06022C71 RID: 142449 RVA: 0x00336BBC File Offset: 0x00334DBC
		// (set) Token: 0x06022C72 RID: 142450 RVA: 0x00336BF5 File Offset: 0x00334DF5
		public TArray<AActor> SequenceActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._SequenceActors) == null)
				{
					result = (this._SequenceActors = new TArray<AActor>(base.NativePtr + (IntPtr)UMovieSceneSequenceTickManager.__PropertyOffset_SequenceActors, this));
				}
				return result;
			}
			set
			{
				this.SequenceActors.CopyAssign(value);
			}
		}

		// Token: 0x170085B9 RID: 34233
		// (get) Token: 0x06022C73 RID: 142451 RVA: 0x00336C03 File Offset: 0x00334E03
		// (set) Token: 0x06022C74 RID: 142452 RVA: 0x00336C17 File Offset: 0x00334E17
		[Nullable(2)]
		public unsafe UMovieSceneEntitySystemLinker Linker
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneEntitySystemLinker>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSequenceTickManager.__PropertyOffset_Linker);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSequenceTickManager.__PropertyOffset_Linker, value);
			}
		}

		// Token: 0x170085BA RID: 34234
		// (get) Token: 0x06022C75 RID: 142453 RVA: 0x00336C2C File Offset: 0x00334E2C
		// (set) Token: 0x06022C76 RID: 142454 RVA: 0x00336C65 File Offset: 0x00334E65
		public TArray<AActor> RemoveSequenceActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._RemoveSequenceActors) == null)
				{
					result = (this._RemoveSequenceActors = new TArray<AActor>(base.NativePtr + (IntPtr)UMovieSceneSequenceTickManager.__PropertyOffset_RemoveSequenceActors, this));
				}
				return result;
			}
			set
			{
				this.RemoveSequenceActors.CopyAssign(value);
			}
		}

		// Token: 0x06022C77 RID: 142455 RVA: 0x00336C73 File Offset: 0x00334E73
		static UMovieSceneSequenceTickManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSequenceTickManager");
		}

		// Token: 0x06022C78 RID: 142456 RVA: 0x00336C81 File Offset: 0x00334E81
		protected UMovieSceneSequenceTickManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012915 RID: 76053
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceTickManager";

		// Token: 0x04012916 RID: 76054
		private static IntPtr _ClassPtr;

		// Token: 0x04012917 RID: 76055
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012918 RID: 76056
		internal static int __PropertyOffset_SequenceActors;

		// Token: 0x04012919 RID: 76057
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _SequenceActors;

		// Token: 0x0401291A RID: 76058
		internal static int __PropertyOffset_Linker;

		// Token: 0x0401291B RID: 76059
		internal static int __PropertyOffset_RemoveSequenceActors;

		// Token: 0x0401291C RID: 76060
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _RemoveSequenceActors;
	}
}
