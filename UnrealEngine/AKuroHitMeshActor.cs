using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B24 RID: 6948
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroHitMeshActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AKuroHitMeshActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A2D5 RID: 107221 RVA: 0x0026A80D File Offset: 0x00268A0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroHitMeshActor._ClassPtr;
		}

		// Token: 0x0601A2D6 RID: 107222 RVA: 0x0026A81C File Offset: 0x00268A1C
		public AKuroHitMeshActor() : this(BuiltinUtils.AllocNativeUObject(AKuroHitMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A2D7 RID: 107223 RVA: 0x0026A844 File Offset: 0x00268A44
		[NullableContext(1)]
		public AKuroHitMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroHitMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006937 RID: 26935
		// (get) Token: 0x0601A2D8 RID: 107224 RVA: 0x0026A877 File Offset: 0x00268A77
		// (set) Token: 0x0601A2D9 RID: 107225 RVA: 0x0026A88B File Offset: 0x00268A8B
		public unsafe USceneComponent SceneComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHitMeshActor.__PropertyOffset_SceneComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHitMeshActor.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x17006938 RID: 26936
		// (get) Token: 0x0601A2DA RID: 107226 RVA: 0x0026A8A0 File Offset: 0x00268AA0
		// (set) Token: 0x0601A2DB RID: 107227 RVA: 0x0026A8B4 File Offset: 0x00268AB4
		public unsafe USkeletalMeshComponent SkeletalMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHitMeshActor.__PropertyOffset_SkeletalMeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHitMeshActor.__PropertyOffset_SkeletalMeshComponent, value);
			}
		}

		// Token: 0x0601A2DC RID: 107228 RVA: 0x0026A8C9 File Offset: 0x00268AC9
		static AKuroHitMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroHitMeshActor");
		}

		// Token: 0x0601A2DD RID: 107229 RVA: 0x0026A8D7 File Offset: 0x00268AD7
		protected AKuroHitMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E387 RID: 58247
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroHitMeshActor";

		// Token: 0x0400E388 RID: 58248
		private static IntPtr _ClassPtr;

		// Token: 0x0400E389 RID: 58249
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E38A RID: 58250
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x0400E38B RID: 58251
		internal static int __PropertyOffset_SkeletalMeshComponent;
	}
}
