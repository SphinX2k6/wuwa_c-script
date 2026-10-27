using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000925 RID: 2341
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CharacterFOVVolume")]
	[UnrealStructLayout(1248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1248)]
	public class ACharacterFOVVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008204 RID: 33284 RVA: 0x000BA179 File Offset: 0x000B8379
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACharacterFOVVolume._ClassPtr;
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x000BA188 File Offset: 0x000B8388
		public ACharacterFOVVolume() : this(BuiltinUtils.AllocNativeUObject(ACharacterFOVVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x000BA1B0 File Offset: 0x000B83B0
		public ACharacterFOVVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACharacterFOVVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06008207 RID: 33287 RVA: 0x000BA1E3 File Offset: 0x000B83E3
		// (set) Token: 0x06008208 RID: 33288 RVA: 0x000BA1F7 File Offset: 0x000B83F7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> CharacterFOVTargetBlueprintClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_CharacterFOVTargetBlueprintClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_CharacterFOVTargetBlueprintClass) = value;
			}
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06008209 RID: 33289 RVA: 0x000BA20C File Offset: 0x000B840C
		// (set) Token: 0x0600820A RID: 33290 RVA: 0x000BA220 File Offset: 0x000B8420
		[Nullable(2)]
		public unsafe USkeletalMesh CharacterFOVTargetSkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + ACharacterFOVVolume.__PropertyOffset_CharacterFOVTargetSkeletalMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACharacterFOVVolume.__PropertyOffset_CharacterFOVTargetSkeletalMesh, value);
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x0600820B RID: 33291 RVA: 0x000BA235 File Offset: 0x000B8435
		// (set) Token: 0x0600820C RID: 33292 RVA: 0x000BA24A File Offset: 0x000B844A
		public TSoftObjectPtr<AActor> CharacterFOVParameterTargetSceneActor
		{
			get
			{
				return new TSoftObjectPtr<AActor>(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_CharacterFOVParameterTargetSceneActor, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_CharacterFOVParameterTargetSceneActor, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x0600820D RID: 33293 RVA: 0x000BA26F File Offset: 0x000B846F
		// (set) Token: 0x0600820E RID: 33294 RVA: 0x000BA283 File Offset: 0x000B8483
		[Nullable(2)]
		public unsafe AActor CharacterFOVParameterTargetActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + ACharacterFOVVolume.__PropertyOffset_CharacterFOVParameterTargetActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACharacterFOVVolume.__PropertyOffset_CharacterFOVParameterTargetActor, value);
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x0600820F RID: 33295 RVA: 0x000BA298 File Offset: 0x000B8498
		// (set) Token: 0x06008210 RID: 33296 RVA: 0x000BA2AC File Offset: 0x000B84AC
		public unsafe string TargetMaterialInstanceDirectory
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ACharacterFOVVolume.__PropertyOffset_TargetMaterialInstanceDirectory)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ACharacterFOVVolume.__PropertyOffset_TargetMaterialInstanceDirectory)), value);
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06008211 RID: 33297 RVA: 0x000BA2C1 File Offset: 0x000B84C1
		// (set) Token: 0x06008212 RID: 33298 RVA: 0x000BA2D5 File Offset: 0x000B84D5
		public unsafe string TargetParentMaterialDirectory
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ACharacterFOVVolume.__PropertyOffset_TargetParentMaterialDirectory)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ACharacterFOVVolume.__PropertyOffset_TargetParentMaterialDirectory)), value);
			}
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06008213 RID: 33299 RVA: 0x000BA2EA File Offset: 0x000B84EA
		// (set) Token: 0x06008214 RID: 33300 RVA: 0x000BA2FE File Offset: 0x000B84FE
		public unsafe string CharacterFOVSuffix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ACharacterFOVVolume.__PropertyOffset_CharacterFOVSuffix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ACharacterFOVVolume.__PropertyOffset_CharacterFOVSuffix)), value);
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06008215 RID: 33301 RVA: 0x000BA313 File Offset: 0x000B8513
		// (set) Token: 0x06008216 RID: 33302 RVA: 0x000BA323 File Offset: 0x000B8523
		public unsafe float FOVVolumeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_FOVVolumeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_FOVVolumeRadius) = value;
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06008217 RID: 33303 RVA: 0x000BA334 File Offset: 0x000B8534
		// (set) Token: 0x06008218 RID: 33304 RVA: 0x000BA344 File Offset: 0x000B8544
		public unsafe float FOVVolumeFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_FOVVolumeFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_FOVVolumeFalloff) = value;
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06008219 RID: 33305 RVA: 0x000BA355 File Offset: 0x000B8555
		// (set) Token: 0x0600821A RID: 33306 RVA: 0x000BA365 File Offset: 0x000B8565
		public unsafe float FOVVolumeTargetFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_FOVVolumeTargetFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_FOVVolumeTargetFOV) = value;
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x0600821B RID: 33307 RVA: 0x000BA376 File Offset: 0x000B8576
		// (set) Token: 0x0600821C RID: 33308 RVA: 0x000BA38A File Offset: 0x000B858A
		public unsafe FVector FOVVolumeCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_FOVVolumeCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacterFOVVolume.__PropertyOffset_FOVVolumeCenter) = value;
			}
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x000BA39F File Offset: 0x000B859F
		public void GenerateCharacterFOV()
		{
			ACharacterFOVVolume.__GenerateCharacterFOV_Internal(base.NativePtr);
		}

		// Token: 0x0600821E RID: 33310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GenerateCharacterFOV_Internal(IntPtr @this);

		// Token: 0x0600821F RID: 33311 RVA: 0x000BA3AC File Offset: 0x000B85AC
		static ACharacterFOVVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CharacterFOVVolume");
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x000BA3BA File Offset: 0x000B85BA
		protected ACharacterFOVVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E0F RID: 15887
		public new const string __ObjectPath = "/Script/Engine.CharacterFOVVolume";

		// Token: 0x04003E10 RID: 15888
		private static IntPtr _ClassPtr;

		// Token: 0x04003E11 RID: 15889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003E12 RID: 15890
		internal static int __PropertyOffset_CharacterFOVTargetBlueprintClass;

		// Token: 0x04003E13 RID: 15891
		internal static int __PropertyOffset_CharacterFOVTargetSkeletalMesh;

		// Token: 0x04003E14 RID: 15892
		internal static int __PropertyOffset_CharacterFOVParameterTargetSceneActor;

		// Token: 0x04003E15 RID: 15893
		internal static int __PropertyOffset_CharacterFOVParameterTargetActor;

		// Token: 0x04003E16 RID: 15894
		internal static int __PropertyOffset_TargetMaterialInstanceDirectory;

		// Token: 0x04003E17 RID: 15895
		internal static int __PropertyOffset_TargetParentMaterialDirectory;

		// Token: 0x04003E18 RID: 15896
		internal static int __PropertyOffset_CharacterFOVSuffix;

		// Token: 0x04003E19 RID: 15897
		internal static int __PropertyOffset_FOVVolumeRadius;

		// Token: 0x04003E1A RID: 15898
		internal static int __PropertyOffset_FOVVolumeFalloff;

		// Token: 0x04003E1B RID: 15899
		internal static int __PropertyOffset_FOVVolumeTargetFOV;

		// Token: 0x04003E1C RID: 15900
		internal static int __PropertyOffset_FOVVolumeCenter;
	}
}
