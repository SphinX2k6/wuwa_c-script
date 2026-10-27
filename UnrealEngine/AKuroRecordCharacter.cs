using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001671 RID: 5745
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroRecordCharacter")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1144)]
	public class AKuroRecordCharacter : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014D73 RID: 85363 RVA: 0x001EA510 File Offset: 0x001E8710
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRecordCharacter._ClassPtr;
		}

		// Token: 0x06014D74 RID: 85364 RVA: 0x001EA51C File Offset: 0x001E871C
		public AKuroRecordCharacter() : this(BuiltinUtils.AllocNativeUObject(AKuroRecordCharacter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014D75 RID: 85365 RVA: 0x001EA544 File Offset: 0x001E8744
		[NullableContext(1)]
		public AKuroRecordCharacter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRecordCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700528E RID: 21134
		// (get) Token: 0x06014D76 RID: 85366 RVA: 0x001EA577 File Offset: 0x001E8777
		// (set) Token: 0x06014D77 RID: 85367 RVA: 0x001EA58B File Offset: 0x001E878B
		public unsafe USceneComponent MainScene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_MainScene);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_MainScene, value);
			}
		}

		// Token: 0x1700528F RID: 21135
		// (get) Token: 0x06014D78 RID: 85368 RVA: 0x001EA5A0 File Offset: 0x001E87A0
		// (set) Token: 0x06014D79 RID: 85369 RVA: 0x001EA5B4 File Offset: 0x001E87B4
		public unsafe USkeletalMeshComponent SubMesh0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh0, value);
			}
		}

		// Token: 0x17005290 RID: 21136
		// (get) Token: 0x06014D7A RID: 85370 RVA: 0x001EA5C9 File Offset: 0x001E87C9
		// (set) Token: 0x06014D7B RID: 85371 RVA: 0x001EA5DD File Offset: 0x001E87DD
		public unsafe USkeletalMeshComponent SubMesh1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh1, value);
			}
		}

		// Token: 0x17005291 RID: 21137
		// (get) Token: 0x06014D7C RID: 85372 RVA: 0x001EA5F2 File Offset: 0x001E87F2
		// (set) Token: 0x06014D7D RID: 85373 RVA: 0x001EA606 File Offset: 0x001E8806
		public unsafe USkeletalMeshComponent SubMesh2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh2, value);
			}
		}

		// Token: 0x17005292 RID: 21138
		// (get) Token: 0x06014D7E RID: 85374 RVA: 0x001EA61B File Offset: 0x001E881B
		// (set) Token: 0x06014D7F RID: 85375 RVA: 0x001EA62F File Offset: 0x001E882F
		public unsafe USkeletalMeshComponent SubMesh3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh3, value);
			}
		}

		// Token: 0x17005293 RID: 21139
		// (get) Token: 0x06014D80 RID: 85376 RVA: 0x001EA644 File Offset: 0x001E8844
		// (set) Token: 0x06014D81 RID: 85377 RVA: 0x001EA658 File Offset: 0x001E8858
		public unsafe USkeletalMeshComponent SubMesh4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh4, value);
			}
		}

		// Token: 0x17005294 RID: 21140
		// (get) Token: 0x06014D82 RID: 85378 RVA: 0x001EA66D File Offset: 0x001E886D
		// (set) Token: 0x06014D83 RID: 85379 RVA: 0x001EA681 File Offset: 0x001E8881
		public unsafe USkeletalMeshComponent SubMesh5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh5, value);
			}
		}

		// Token: 0x17005295 RID: 21141
		// (get) Token: 0x06014D84 RID: 85380 RVA: 0x001EA696 File Offset: 0x001E8896
		// (set) Token: 0x06014D85 RID: 85381 RVA: 0x001EA6AA File Offset: 0x001E88AA
		public unsafe USkeletalMeshComponent SubMesh6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh6, value);
			}
		}

		// Token: 0x17005296 RID: 21142
		// (get) Token: 0x06014D86 RID: 85382 RVA: 0x001EA6BF File Offset: 0x001E88BF
		// (set) Token: 0x06014D87 RID: 85383 RVA: 0x001EA6D3 File Offset: 0x001E88D3
		public unsafe USkeletalMeshComponent SubMesh7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh7, value);
			}
		}

		// Token: 0x17005297 RID: 21143
		// (get) Token: 0x06014D88 RID: 85384 RVA: 0x001EA6E8 File Offset: 0x001E88E8
		// (set) Token: 0x06014D89 RID: 85385 RVA: 0x001EA6FC File Offset: 0x001E88FC
		public unsafe USkeletalMeshComponent SubMesh8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh8, value);
			}
		}

		// Token: 0x17005298 RID: 21144
		// (get) Token: 0x06014D8A RID: 85386 RVA: 0x001EA711 File Offset: 0x001E8911
		// (set) Token: 0x06014D8B RID: 85387 RVA: 0x001EA725 File Offset: 0x001E8925
		public unsafe USkeletalMeshComponent SubMesh9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh9, value);
			}
		}

		// Token: 0x17005299 RID: 21145
		// (get) Token: 0x06014D8C RID: 85388 RVA: 0x001EA73A File Offset: 0x001E893A
		// (set) Token: 0x06014D8D RID: 85389 RVA: 0x001EA74E File Offset: 0x001E894E
		public unsafe USkeletalMeshComponent SubMesh10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh10, value);
			}
		}

		// Token: 0x1700529A RID: 21146
		// (get) Token: 0x06014D8E RID: 85390 RVA: 0x001EA763 File Offset: 0x001E8963
		// (set) Token: 0x06014D8F RID: 85391 RVA: 0x001EA777 File Offset: 0x001E8977
		public unsafe USkeletalMeshComponent SubMesh11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRecordCharacter.__PropertyOffset_SubMesh11, value);
			}
		}

		// Token: 0x06014D90 RID: 85392 RVA: 0x001EA78C File Offset: 0x001E898C
		static AKuroRecordCharacter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroRecordCharacter");
		}

		// Token: 0x06014D91 RID: 85393 RVA: 0x001EA79A File Offset: 0x001E899A
		protected AKuroRecordCharacter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B5C1 RID: 46529
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroRecordCharacter";

		// Token: 0x0400B5C2 RID: 46530
		private static IntPtr _ClassPtr;

		// Token: 0x0400B5C3 RID: 46531
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B5C4 RID: 46532
		internal static int __PropertyOffset_MainScene;

		// Token: 0x0400B5C5 RID: 46533
		internal static int __PropertyOffset_SubMesh0;

		// Token: 0x0400B5C6 RID: 46534
		internal static int __PropertyOffset_SubMesh1;

		// Token: 0x0400B5C7 RID: 46535
		internal static int __PropertyOffset_SubMesh2;

		// Token: 0x0400B5C8 RID: 46536
		internal static int __PropertyOffset_SubMesh3;

		// Token: 0x0400B5C9 RID: 46537
		internal static int __PropertyOffset_SubMesh4;

		// Token: 0x0400B5CA RID: 46538
		internal static int __PropertyOffset_SubMesh5;

		// Token: 0x0400B5CB RID: 46539
		internal static int __PropertyOffset_SubMesh6;

		// Token: 0x0400B5CC RID: 46540
		internal static int __PropertyOffset_SubMesh7;

		// Token: 0x0400B5CD RID: 46541
		internal static int __PropertyOffset_SubMesh8;

		// Token: 0x0400B5CE RID: 46542
		internal static int __PropertyOffset_SubMesh9;

		// Token: 0x0400B5CF RID: 46543
		internal static int __PropertyOffset_SubMesh10;

		// Token: 0x0400B5D0 RID: 46544
		internal static int __PropertyOffset_SubMesh11;
	}
}
