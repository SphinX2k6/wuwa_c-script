using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C00 RID: 7168
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialContainerSection")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UMovieSceneKuroMaterialContainerSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BAA3 RID: 113315 RVA: 0x0028B710 File Offset: 0x00289910
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneKuroMaterialContainerSection._ClassPtr;
		}

		// Token: 0x0601BAA4 RID: 113316 RVA: 0x0028B71C File Offset: 0x0028991C
		public UMovieSceneKuroMaterialContainerSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialContainerSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BAA5 RID: 113317 RVA: 0x0028B744 File Offset: 0x00289944
		public UMovieSceneKuroMaterialContainerSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialContainerSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006F95 RID: 28565
		// (get) Token: 0x0601BAA6 RID: 113318 RVA: 0x0028B777 File Offset: 0x00289977
		// (set) Token: 0x0601BAA7 RID: 113319 RVA: 0x0028B78B File Offset: 0x0028998B
		[Nullable(2)]
		public unsafe UKuroMaterialControllerDataAsset MaterialDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneKuroMaterialContainerSection.__PropertyOffset_MaterialDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneKuroMaterialContainerSection.__PropertyOffset_MaterialDataAsset, value);
			}
		}

		// Token: 0x17006F96 RID: 28566
		// (get) Token: 0x0601BAA8 RID: 113320 RVA: 0x0028B7A0 File Offset: 0x002899A0
		// (set) Token: 0x0601BAA9 RID: 113321 RVA: 0x0028B7D9 File Offset: 0x002899D9
		public TArray<UKuroMaterialControllerDataAsset> MaterialDataAssetExtra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroMaterialControllerDataAsset> result;
				if ((result = this._MaterialDataAssetExtra) == null)
				{
					result = (this._MaterialDataAssetExtra = new TArray<UKuroMaterialControllerDataAsset>(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerSection.__PropertyOffset_MaterialDataAssetExtra, this));
				}
				return result;
			}
			set
			{
				this.MaterialDataAssetExtra.CopyAssign(value);
			}
		}

		// Token: 0x17006F97 RID: 28567
		// (get) Token: 0x0601BAAA RID: 113322 RVA: 0x0028B7E7 File Offset: 0x002899E7
		// (set) Token: 0x0601BAAB RID: 113323 RVA: 0x0028B7F7 File Offset: 0x002899F7
		public unsafe bool bLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerSection.__PropertyOffset_bLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerSection.__PropertyOffset_bLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F98 RID: 28568
		// (get) Token: 0x0601BAAC RID: 113324 RVA: 0x0028B808 File Offset: 0x00289A08
		// (set) Token: 0x0601BAAD RID: 113325 RVA: 0x0028B818 File Offset: 0x00289A18
		public unsafe bool bEndImmediate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerSection.__PropertyOffset_bEndImmediate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerSection.__PropertyOffset_bEndImmediate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F99 RID: 28569
		// (get) Token: 0x0601BAAE RID: 113326 RVA: 0x0028B829 File Offset: 0x00289A29
		// (set) Token: 0x0601BAAF RID: 113327 RVA: 0x0028B839 File Offset: 0x00289A39
		public unsafe bool bSkipToEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerSection.__PropertyOffset_bSkipToEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerSection.__PropertyOffset_bSkipToEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F9A RID: 28570
		// (get) Token: 0x0601BAB0 RID: 113328 RVA: 0x0028B84A File Offset: 0x00289A4A
		// (set) Token: 0x0601BAB1 RID: 113329 RVA: 0x0028B85A File Offset: 0x00289A5A
		public unsafe bool bApplyOnChildActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerSection.__PropertyOffset_bApplyOnChildActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerSection.__PropertyOffset_bApplyOnChildActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601BAB2 RID: 113330 RVA: 0x0028B86B File Offset: 0x00289A6B
		static UMovieSceneKuroMaterialContainerSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialContainerSection");
		}

		// Token: 0x0601BAB3 RID: 113331 RVA: 0x0028B879 File Offset: 0x00289A79
		protected UMovieSceneKuroMaterialContainerSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE0B RID: 60939
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialContainerSection";

		// Token: 0x0400EE0C RID: 60940
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE0D RID: 60941
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE0E RID: 60942
		internal static int __PropertyOffset_MaterialDataAsset;

		// Token: 0x0400EE0F RID: 60943
		internal static int __PropertyOffset_MaterialDataAssetExtra;

		// Token: 0x0400EE10 RID: 60944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroMaterialControllerDataAsset> _MaterialDataAssetExtra;

		// Token: 0x0400EE11 RID: 60945
		internal static int __PropertyOffset_bLoop;

		// Token: 0x0400EE12 RID: 60946
		internal static int __PropertyOffset_bEndImmediate;

		// Token: 0x0400EE13 RID: 60947
		internal static int __PropertyOffset_bSkipToEnd;

		// Token: 0x0400EE14 RID: 60948
		internal static int __PropertyOffset_bApplyOnChildActor;
	}
}
