using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000840 RID: 2112
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineSkeletonComponent")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class USpineSkeletonComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B804 RID: 47108 RVA: 0x0012702A File Offset: 0x0012522A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineSkeletonComponent._ClassPtr;
		}

		// Token: 0x0600B805 RID: 47109 RVA: 0x00127038 File Offset: 0x00125238
		public USpineSkeletonComponent() : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B806 RID: 47110 RVA: 0x00127060 File Offset: 0x00125260
		public USpineSkeletonComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x0600B807 RID: 47111 RVA: 0x00127093 File Offset: 0x00125293
		// (set) Token: 0x0600B808 RID: 47112 RVA: 0x001270A7 File Offset: 0x001252A7
		[Nullable(2)]
		public unsafe USpineAtlasAsset Atlas
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineAtlasAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonComponent.__PropertyOffset_Atlas);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonComponent.__PropertyOffset_Atlas, value);
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x0600B809 RID: 47113 RVA: 0x001270BC File Offset: 0x001252BC
		// (set) Token: 0x0600B80A RID: 47114 RVA: 0x001270D0 File Offset: 0x001252D0
		[Nullable(2)]
		public unsafe USpineSkeletonDataAsset SkeletonData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineSkeletonDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonComponent.__PropertyOffset_SkeletonData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonComponent.__PropertyOffset_SkeletonData, value);
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x0600B80B RID: 47115 RVA: 0x001270E8 File Offset: 0x001252E8
		// (set) Token: 0x0600B80C RID: 47116 RVA: 0x00127121 File Offset: 0x00125321
		public FSpineBeforeUpdateWorldTransformDelegate BeforeUpdateWorldTransform
		{
			get
			{
				base.FastCheckIsValid();
				FSpineBeforeUpdateWorldTransformDelegate result;
				if ((result = this._BeforeUpdateWorldTransform) == null)
				{
					result = (this._BeforeUpdateWorldTransform = new FSpineBeforeUpdateWorldTransformDelegate(base.NativePtr + (IntPtr)USpineSkeletonComponent.__PropertyOffset_BeforeUpdateWorldTransform, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineSkeletonComponent.__PropertyOffset_BeforeUpdateWorldTransform, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x0600B80D RID: 47117 RVA: 0x00127144 File Offset: 0x00125344
		// (set) Token: 0x0600B80E RID: 47118 RVA: 0x0012717D File Offset: 0x0012537D
		public FSpineAfterUpdateWorldTransformDelegate AfterUpdateWorldTransform
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAfterUpdateWorldTransformDelegate result;
				if ((result = this._AfterUpdateWorldTransform) == null)
				{
					result = (this._AfterUpdateWorldTransform = new FSpineAfterUpdateWorldTransformDelegate(base.NativePtr + (IntPtr)USpineSkeletonComponent.__PropertyOffset_AfterUpdateWorldTransform, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineSkeletonComponent.__PropertyOffset_AfterUpdateWorldTransform, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x0012719E File Offset: 0x0012539E
		public void UpdateWorldTransform()
		{
			USpineSkeletonComponent.__UpdateWorldTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600B810 RID: 47120 RVA: 0x001271AB File Offset: 0x001253AB
		public void SetToSetupPose()
		{
			USpineSkeletonComponent.__SetToSetupPose_Internal(base.NativePtr);
		}

		// Token: 0x0600B811 RID: 47121 RVA: 0x001271B8 File Offset: 0x001253B8
		public void SetSlotsToSetupPose()
		{
			USpineSkeletonComponent.__SetSlotsToSetupPose_Internal(base.NativePtr);
		}

		// Token: 0x0600B812 RID: 47122 RVA: 0x001271C8 File Offset: 0x001253C8
		public unsafe void SetSlotColor(string SlotName, FColor color)
		{
			FString fstring = FString.AllocTemp(SlotName);
			USpineSkeletonComponent.__SetSlotColor_Internal(base.NativePtr, fstring, color);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x001271F3 File Offset: 0x001253F3
		public bool SetSkins([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> SkinNames)
		{
			return USpineSkeletonComponent.__SetSkins_Internal(base.NativePtr, (SkinNames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x00127210 File Offset: 0x00125410
		public unsafe bool SetSkin(string SkinName)
		{
			FString fstring = FString.AllocTemp(SkinName);
			bool result = USpineSkeletonComponent.__SetSkin_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600B815 RID: 47125 RVA: 0x0012723A File Offset: 0x0012543A
		public void SetScaleY(float scaleY)
		{
			USpineSkeletonComponent.__SetScaleY_Internal(base.NativePtr, scaleY);
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x00127248 File Offset: 0x00125448
		public void SetScaleX(float scaleX)
		{
			USpineSkeletonComponent.__SetScaleX_Internal(base.NativePtr, scaleX);
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x00127258 File Offset: 0x00125458
		public unsafe void SetBoneWorldPosition(string BoneName, in FVector position)
		{
			FString fstring = FString.AllocTemp(BoneName);
			USpineSkeletonComponent.__SetBoneWorldPosition_Internal(base.NativePtr, fstring, position);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x00127283 File Offset: 0x00125483
		public void SetBonesToSetupPose()
		{
			USpineSkeletonComponent.__SetBonesToSetupPose_Internal(base.NativePtr);
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x00127290 File Offset: 0x00125490
		public unsafe bool SetAttachment(string slotName, string attachmentName)
		{
			FString fstring = FString.AllocTemp(slotName);
			FString fstring2 = FString.AllocTemp(attachmentName);
			bool result = USpineSkeletonComponent.__SetAttachment_Internal(base.NativePtr, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x001272CC File Offset: 0x001254CC
		public unsafe bool HasSlot(string SlotName)
		{
			FString fstring = FString.AllocTemp(SlotName);
			bool result = USpineSkeletonComponent.__HasSlot_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x001272F8 File Offset: 0x001254F8
		public unsafe bool HasSkin(string SkinName)
		{
			FString fstring = FString.AllocTemp(SkinName);
			bool result = USpineSkeletonComponent.__HasSkin_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600B81C RID: 47132 RVA: 0x00127324 File Offset: 0x00125524
		public unsafe bool HasBone(string BoneName)
		{
			FString fstring = FString.AllocTemp(BoneName);
			bool result = USpineSkeletonComponent.__HasBone_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600B81D RID: 47133 RVA: 0x00127350 File Offset: 0x00125550
		public unsafe bool HasAnimation(string AnimationName)
		{
			FString fstring = FString.AllocTemp(AnimationName);
			bool result = USpineSkeletonComponent.__HasAnimation_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600B81E RID: 47134 RVA: 0x0012737A File Offset: 0x0012557A
		public void GetSlots([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Slots)
		{
			USpineSkeletonComponent.__GetSlots_Internal(base.NativePtr, (Slots ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0600B81F RID: 47135 RVA: 0x00127397 File Offset: 0x00125597
		public void GetSkins([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Skins)
		{
			USpineSkeletonComponent.__GetSkins_Internal(base.NativePtr, (Skins ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0600B820 RID: 47136 RVA: 0x001273B4 File Offset: 0x001255B4
		public float GetScaleY()
		{
			return USpineSkeletonComponent.__GetScaleY_Internal(base.NativePtr);
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x001273C1 File Offset: 0x001255C1
		public float GetScaleX()
		{
			return USpineSkeletonComponent.__GetScaleX_Internal(base.NativePtr);
		}

		// Token: 0x0600B822 RID: 47138 RVA: 0x001273D0 File Offset: 0x001255D0
		public unsafe FTransform GetBoneWorldTransform(string BoneName)
		{
			FString fstring = FString.AllocTemp(BoneName);
			FTransform result = USpineSkeletonComponent.__GetBoneWorldTransform_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600B823 RID: 47139 RVA: 0x001273FA File Offset: 0x001255FA
		public void GetBones([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Bones)
		{
			USpineSkeletonComponent.__GetBones_Internal(base.NativePtr, (Bones ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0600B824 RID: 47140 RVA: 0x00127417 File Offset: 0x00125617
		public void GetAnimations([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Animations)
		{
			USpineSkeletonComponent.__GetAnimations_Internal(base.NativePtr, (Animations ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x00127434 File Offset: 0x00125634
		public unsafe float GetAnimationDuration(string AnimationName)
		{
			FString fstring = FString.AllocTemp(AnimationName);
			float result = USpineSkeletonComponent.__GetAnimationDuration_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600B826 RID: 47142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWorldTransform_Internal(IntPtr @this);

		// Token: 0x0600B827 RID: 47143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToSetupPose_Internal(IntPtr @this);

		// Token: 0x0600B828 RID: 47144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSlotsToSetupPose_Internal(IntPtr @this);

		// Token: 0x0600B829 RID: 47145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSlotColor_Internal(IntPtr @this, in FString SlotName, FColor color);

		// Token: 0x0600B82A RID: 47146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSkins_Internal(IntPtr @this, IntPtr SkinNames);

		// Token: 0x0600B82B RID: 47147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSkin_Internal(IntPtr @this, in FString SkinName);

		// Token: 0x0600B82C RID: 47148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScaleY_Internal(IntPtr @this, float scaleY);

		// Token: 0x0600B82D RID: 47149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScaleX_Internal(IntPtr @this, float scaleX);

		// Token: 0x0600B82E RID: 47150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneWorldPosition_Internal(IntPtr @this, in FString BoneName, in FVector position);

		// Token: 0x0600B82F RID: 47151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBonesToSetupPose_Internal(IntPtr @this);

		// Token: 0x0600B830 RID: 47152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetAttachment_Internal(IntPtr @this, in FString slotName, in FString attachmentName);

		// Token: 0x0600B831 RID: 47153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSlot_Internal(IntPtr @this, in FString SlotName);

		// Token: 0x0600B832 RID: 47154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSkin_Internal(IntPtr @this, in FString SkinName);

		// Token: 0x0600B833 RID: 47155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBone_Internal(IntPtr @this, in FString BoneName);

		// Token: 0x0600B834 RID: 47156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnimation_Internal(IntPtr @this, in FString AnimationName);

		// Token: 0x0600B835 RID: 47157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSlots_Internal(IntPtr @this, IntPtr Slots);

		// Token: 0x0600B836 RID: 47158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSkins_Internal(IntPtr @this, IntPtr Skins);

		// Token: 0x0600B837 RID: 47159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaleY_Internal(IntPtr @this);

		// Token: 0x0600B838 RID: 47160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaleX_Internal(IntPtr @this);

		// Token: 0x0600B839 RID: 47161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetBoneWorldTransform_Internal(IntPtr @this, in FString BoneName);

		// Token: 0x0600B83A RID: 47162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetBones_Internal(IntPtr @this, IntPtr Bones);

		// Token: 0x0600B83B RID: 47163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimations_Internal(IntPtr @this, IntPtr Animations);

		// Token: 0x0600B83C RID: 47164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationDuration_Internal(IntPtr @this, in FString AnimationName);

		// Token: 0x0600B83D RID: 47165 RVA: 0x0012745E File Offset: 0x0012565E
		static USpineSkeletonComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineSkeletonComponent");
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x0012746C File Offset: 0x0012566C
		protected USpineSkeletonComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005399 RID: 21401
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineSkeletonComponent";

		// Token: 0x0400539A RID: 21402
		private static IntPtr _ClassPtr;

		// Token: 0x0400539B RID: 21403
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400539C RID: 21404
		internal static int __PropertyOffset_Atlas;

		// Token: 0x0400539D RID: 21405
		internal static int __PropertyOffset_SkeletonData;

		// Token: 0x0400539E RID: 21406
		internal static int __PropertyOffset_BeforeUpdateWorldTransform;

		// Token: 0x0400539F RID: 21407
		[Nullable(2)]
		private FSpineBeforeUpdateWorldTransformDelegate _BeforeUpdateWorldTransform;

		// Token: 0x040053A0 RID: 21408
		internal static int __PropertyOffset_AfterUpdateWorldTransform;

		// Token: 0x040053A1 RID: 21409
		[Nullable(2)]
		private FSpineAfterUpdateWorldTransformDelegate _AfterUpdateWorldTransform;
	}
}
