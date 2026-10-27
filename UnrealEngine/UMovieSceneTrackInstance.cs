using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002454 RID: 9300
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackInstance")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UMovieSceneTrackInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022DB3 RID: 142771 RVA: 0x00338AF7 File Offset: 0x00336CF7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneTrackInstance._ClassPtr;
		}

		// Token: 0x06022DB4 RID: 142772 RVA: 0x00338B04 File Offset: 0x00336D04
		public UMovieSceneTrackInstance() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTrackInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022DB5 RID: 142773 RVA: 0x00338B2C File Offset: 0x00336D2C
		[NullableContext(1)]
		public UMovieSceneTrackInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTrackInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170085FF RID: 34303
		// (get) Token: 0x06022DB6 RID: 142774 RVA: 0x00338B5F File Offset: 0x00336D5F
		// (set) Token: 0x06022DB7 RID: 142775 RVA: 0x00338B73 File Offset: 0x00336D73
		public unsafe UObject AnimatedObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneTrackInstance.__PropertyOffset_AnimatedObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneTrackInstance.__PropertyOffset_AnimatedObject, value);
			}
		}

		// Token: 0x17008600 RID: 34304
		// (get) Token: 0x06022DB8 RID: 142776 RVA: 0x00338B88 File Offset: 0x00336D88
		// (set) Token: 0x06022DB9 RID: 142777 RVA: 0x00338B98 File Offset: 0x00336D98
		public unsafe bool bIsMasterTrackInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneTrackInstance.__PropertyOffset_bIsMasterTrackInstance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneTrackInstance.__PropertyOffset_bIsMasterTrackInstance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008601 RID: 34305
		// (get) Token: 0x06022DBA RID: 142778 RVA: 0x00338BA9 File Offset: 0x00336DA9
		// (set) Token: 0x06022DBB RID: 142779 RVA: 0x00338BBD File Offset: 0x00336DBD
		public unsafe UMovieSceneEntitySystemLinker Linker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneEntitySystemLinker>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneTrackInstance.__PropertyOffset_Linker);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneTrackInstance.__PropertyOffset_Linker, value);
			}
		}

		// Token: 0x17008602 RID: 34306
		// (get) Token: 0x06022DBC RID: 142780 RVA: 0x00338BD4 File Offset: 0x00336DD4
		// (set) Token: 0x06022DBD RID: 142781 RVA: 0x00338C0D File Offset: 0x00336E0D
		[Nullable(1)]
		public TArray<FMovieSceneTrackInstanceInput> Inputs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneTrackInstanceInput> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TArray<FMovieSceneTrackInstanceInput>(base.NativePtr + (IntPtr)UMovieSceneTrackInstance.__PropertyOffset_Inputs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x06022DBE RID: 142782 RVA: 0x00338C1B File Offset: 0x00336E1B
		static UMovieSceneTrackInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneTrackInstance");
		}

		// Token: 0x06022DBF RID: 142783 RVA: 0x00338C29 File Offset: 0x00336E29
		protected UMovieSceneTrackInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129C5 RID: 76229
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackInstance";

		// Token: 0x040129C6 RID: 76230
		private static IntPtr _ClassPtr;

		// Token: 0x040129C7 RID: 76231
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129C8 RID: 76232
		internal static int __PropertyOffset_AnimatedObject;

		// Token: 0x040129C9 RID: 76233
		internal static int __PropertyOffset_bIsMasterTrackInstance;

		// Token: 0x040129CA RID: 76234
		internal static int __PropertyOffset_Linker;

		// Token: 0x040129CB RID: 76235
		internal static int __PropertyOffset_Inputs;

		// Token: 0x040129CC RID: 76236
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneTrackInstanceInput> _Inputs;
	}
}
