using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002FE RID: 766
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroRecordCharacter")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1144)]
	public class AKuroRecordCharacter : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060052A1 RID: 21153 RVA: 0x000738C9 File Offset: 0x00071AC9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRecordCharacter._ClassPtr;
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x000738D8 File Offset: 0x00071AD8
		public AKuroRecordCharacter() : this(BuiltinUtils.AllocNativeUObject(AKuroRecordCharacter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00073900 File Offset: 0x00071B00
		[NullableContext(1)]
		public AKuroRecordCharacter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRecordCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x060052A4 RID: 21156 RVA: 0x00073933 File Offset: 0x00071B33
		// (set) Token: 0x060052A5 RID: 21157 RVA: 0x00073947 File Offset: 0x00071B47
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

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060052A6 RID: 21158 RVA: 0x0007395C File Offset: 0x00071B5C
		// (set) Token: 0x060052A7 RID: 21159 RVA: 0x00073970 File Offset: 0x00071B70
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

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060052A8 RID: 21160 RVA: 0x00073985 File Offset: 0x00071B85
		// (set) Token: 0x060052A9 RID: 21161 RVA: 0x00073999 File Offset: 0x00071B99
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

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x060052AA RID: 21162 RVA: 0x000739AE File Offset: 0x00071BAE
		// (set) Token: 0x060052AB RID: 21163 RVA: 0x000739C2 File Offset: 0x00071BC2
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

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x000739D7 File Offset: 0x00071BD7
		// (set) Token: 0x060052AD RID: 21165 RVA: 0x000739EB File Offset: 0x00071BEB
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

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x060052AE RID: 21166 RVA: 0x00073A00 File Offset: 0x00071C00
		// (set) Token: 0x060052AF RID: 21167 RVA: 0x00073A14 File Offset: 0x00071C14
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

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x060052B0 RID: 21168 RVA: 0x00073A29 File Offset: 0x00071C29
		// (set) Token: 0x060052B1 RID: 21169 RVA: 0x00073A3D File Offset: 0x00071C3D
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

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x060052B2 RID: 21170 RVA: 0x00073A52 File Offset: 0x00071C52
		// (set) Token: 0x060052B3 RID: 21171 RVA: 0x00073A66 File Offset: 0x00071C66
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

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060052B4 RID: 21172 RVA: 0x00073A7B File Offset: 0x00071C7B
		// (set) Token: 0x060052B5 RID: 21173 RVA: 0x00073A8F File Offset: 0x00071C8F
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

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060052B6 RID: 21174 RVA: 0x00073AA4 File Offset: 0x00071CA4
		// (set) Token: 0x060052B7 RID: 21175 RVA: 0x00073AB8 File Offset: 0x00071CB8
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

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x060052B8 RID: 21176 RVA: 0x00073ACD File Offset: 0x00071CCD
		// (set) Token: 0x060052B9 RID: 21177 RVA: 0x00073AE1 File Offset: 0x00071CE1
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

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x060052BA RID: 21178 RVA: 0x00073AF6 File Offset: 0x00071CF6
		// (set) Token: 0x060052BB RID: 21179 RVA: 0x00073B0A File Offset: 0x00071D0A
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

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x060052BC RID: 21180 RVA: 0x00073B1F File Offset: 0x00071D1F
		// (set) Token: 0x060052BD RID: 21181 RVA: 0x00073B33 File Offset: 0x00071D33
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

		// Token: 0x060052BE RID: 21182 RVA: 0x00073B48 File Offset: 0x00071D48
		static AKuroRecordCharacter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroRecordCharacter");
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00073B56 File Offset: 0x00071D56
		protected AKuroRecordCharacter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040021B1 RID: 8625
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroRecordCharacter";

		// Token: 0x040021B2 RID: 8626
		private static IntPtr _ClassPtr;

		// Token: 0x040021B3 RID: 8627
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040021B4 RID: 8628
		internal static int __PropertyOffset_MainScene;

		// Token: 0x040021B5 RID: 8629
		internal static int __PropertyOffset_SubMesh0;

		// Token: 0x040021B6 RID: 8630
		internal static int __PropertyOffset_SubMesh1;

		// Token: 0x040021B7 RID: 8631
		internal static int __PropertyOffset_SubMesh2;

		// Token: 0x040021B8 RID: 8632
		internal static int __PropertyOffset_SubMesh3;

		// Token: 0x040021B9 RID: 8633
		internal static int __PropertyOffset_SubMesh4;

		// Token: 0x040021BA RID: 8634
		internal static int __PropertyOffset_SubMesh5;

		// Token: 0x040021BB RID: 8635
		internal static int __PropertyOffset_SubMesh6;

		// Token: 0x040021BC RID: 8636
		internal static int __PropertyOffset_SubMesh7;

		// Token: 0x040021BD RID: 8637
		internal static int __PropertyOffset_SubMesh8;

		// Token: 0x040021BE RID: 8638
		internal static int __PropertyOffset_SubMesh9;

		// Token: 0x040021BF RID: 8639
		internal static int __PropertyOffset_SubMesh10;

		// Token: 0x040021C0 RID: 8640
		internal static int __PropertyOffset_SubMesh11;
	}
}
