using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B1 RID: 10417
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineSkeletonComponent")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class USpineSkeletonComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A16 RID: 158230 RVA: 0x003AF2CE File Offset: 0x003AD4CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineSkeletonComponent._ClassPtr;
		}

		// Token: 0x06026A17 RID: 158231 RVA: 0x003AF2DC File Offset: 0x003AD4DC
		public USpineSkeletonComponent() : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A18 RID: 158232 RVA: 0x003AF304 File Offset: 0x003AD504
		public USpineSkeletonComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170094EA RID: 38122
		// (get) Token: 0x06026A19 RID: 158233 RVA: 0x003AF337 File Offset: 0x003AD537
		// (set) Token: 0x06026A1A RID: 158234 RVA: 0x003AF34B File Offset: 0x003AD54B
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

		// Token: 0x170094EB RID: 38123
		// (get) Token: 0x06026A1B RID: 158235 RVA: 0x003AF360 File Offset: 0x003AD560
		// (set) Token: 0x06026A1C RID: 158236 RVA: 0x003AF374 File Offset: 0x003AD574
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

		// Token: 0x170094EC RID: 38124
		// (get) Token: 0x06026A1D RID: 158237 RVA: 0x003AF38C File Offset: 0x003AD58C
		// (set) Token: 0x06026A1E RID: 158238 RVA: 0x003AF3C5 File Offset: 0x003AD5C5
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

		// Token: 0x170094ED RID: 38125
		// (get) Token: 0x06026A1F RID: 158239 RVA: 0x003AF3E8 File Offset: 0x003AD5E8
		// (set) Token: 0x06026A20 RID: 158240 RVA: 0x003AF421 File Offset: 0x003AD621
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

		// Token: 0x06026A21 RID: 158241 RVA: 0x003AF442 File Offset: 0x003AD642
		public void UpdateWorldTransform()
		{
			USpineSkeletonComponent.__UpdateWorldTransform_Internal(base.NativePtr);
		}

		// Token: 0x06026A22 RID: 158242 RVA: 0x003AF44F File Offset: 0x003AD64F
		public void SetToSetupPose()
		{
			USpineSkeletonComponent.__SetToSetupPose_Internal(base.NativePtr);
		}

		// Token: 0x06026A23 RID: 158243 RVA: 0x003AF45C File Offset: 0x003AD65C
		public void SetSlotsToSetupPose()
		{
			USpineSkeletonComponent.__SetSlotsToSetupPose_Internal(base.NativePtr);
		}

		// Token: 0x06026A24 RID: 158244 RVA: 0x003AF46C File Offset: 0x003AD66C
		public unsafe void SetSlotColor(string SlotName, FColor color)
		{
			FString fstring = FString.AllocTemp(SlotName);
			USpineSkeletonComponent.__SetSlotColor_Internal(base.NativePtr, fstring, color);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026A25 RID: 158245 RVA: 0x003AF497 File Offset: 0x003AD697
		public bool SetSkins([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> SkinNames)
		{
			return USpineSkeletonComponent.__SetSkins_Internal(base.NativePtr, (SkinNames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026A26 RID: 158246 RVA: 0x003AF4B4 File Offset: 0x003AD6B4
		public unsafe bool SetSkin(string SkinName)
		{
			FString fstring = FString.AllocTemp(SkinName);
			bool result = USpineSkeletonComponent.__SetSkin_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026A27 RID: 158247 RVA: 0x003AF4DE File Offset: 0x003AD6DE
		public void SetScaleY(float scaleY)
		{
			USpineSkeletonComponent.__SetScaleY_Internal(base.NativePtr, scaleY);
		}

		// Token: 0x06026A28 RID: 158248 RVA: 0x003AF4EC File Offset: 0x003AD6EC
		public void SetScaleX(float scaleX)
		{
			USpineSkeletonComponent.__SetScaleX_Internal(base.NativePtr, scaleX);
		}

		// Token: 0x06026A29 RID: 158249 RVA: 0x003AF4FC File Offset: 0x003AD6FC
		public unsafe void SetBoneWorldPosition(string BoneName, in FVector position)
		{
			FString fstring = FString.AllocTemp(BoneName);
			USpineSkeletonComponent.__SetBoneWorldPosition_Internal(base.NativePtr, fstring, position);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026A2A RID: 158250 RVA: 0x003AF527 File Offset: 0x003AD727
		public void SetBonesToSetupPose()
		{
			USpineSkeletonComponent.__SetBonesToSetupPose_Internal(base.NativePtr);
		}

		// Token: 0x06026A2B RID: 158251 RVA: 0x003AF534 File Offset: 0x003AD734
		public unsafe bool SetAttachment(string slotName, string attachmentName)
		{
			FString fstring = FString.AllocTemp(slotName);
			FString fstring2 = FString.AllocTemp(attachmentName);
			bool result = USpineSkeletonComponent.__SetAttachment_Internal(base.NativePtr, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06026A2C RID: 158252 RVA: 0x003AF570 File Offset: 0x003AD770
		public unsafe bool HasSlot(string SlotName)
		{
			FString fstring = FString.AllocTemp(SlotName);
			bool result = USpineSkeletonComponent.__HasSlot_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026A2D RID: 158253 RVA: 0x003AF59C File Offset: 0x003AD79C
		public unsafe bool HasSkin(string SkinName)
		{
			FString fstring = FString.AllocTemp(SkinName);
			bool result = USpineSkeletonComponent.__HasSkin_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026A2E RID: 158254 RVA: 0x003AF5C8 File Offset: 0x003AD7C8
		public unsafe bool HasBone(string BoneName)
		{
			FString fstring = FString.AllocTemp(BoneName);
			bool result = USpineSkeletonComponent.__HasBone_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026A2F RID: 158255 RVA: 0x003AF5F4 File Offset: 0x003AD7F4
		public unsafe bool HasAnimation(string AnimationName)
		{
			FString fstring = FString.AllocTemp(AnimationName);
			bool result = USpineSkeletonComponent.__HasAnimation_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026A30 RID: 158256 RVA: 0x003AF61E File Offset: 0x003AD81E
		public void GetSlots([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Slots)
		{
			USpineSkeletonComponent.__GetSlots_Internal(base.NativePtr, (Slots ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026A31 RID: 158257 RVA: 0x003AF63B File Offset: 0x003AD83B
		public void GetSkins([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Skins)
		{
			USpineSkeletonComponent.__GetSkins_Internal(base.NativePtr, (Skins ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026A32 RID: 158258 RVA: 0x003AF658 File Offset: 0x003AD858
		public float GetScaleY()
		{
			return USpineSkeletonComponent.__GetScaleY_Internal(base.NativePtr);
		}

		// Token: 0x06026A33 RID: 158259 RVA: 0x003AF665 File Offset: 0x003AD865
		public float GetScaleX()
		{
			return USpineSkeletonComponent.__GetScaleX_Internal(base.NativePtr);
		}

		// Token: 0x06026A34 RID: 158260 RVA: 0x003AF674 File Offset: 0x003AD874
		public unsafe FTransform GetBoneWorldTransform(string BoneName)
		{
			FString fstring = FString.AllocTemp(BoneName);
			FTransform result = USpineSkeletonComponent.__GetBoneWorldTransform_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026A35 RID: 158261 RVA: 0x003AF69E File Offset: 0x003AD89E
		public void GetBones([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Bones)
		{
			USpineSkeletonComponent.__GetBones_Internal(base.NativePtr, (Bones ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026A36 RID: 158262 RVA: 0x003AF6BB File Offset: 0x003AD8BB
		public void GetAnimations([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Animations)
		{
			USpineSkeletonComponent.__GetAnimations_Internal(base.NativePtr, (Animations ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026A37 RID: 158263 RVA: 0x003AF6D8 File Offset: 0x003AD8D8
		public unsafe float GetAnimationDuration(string AnimationName)
		{
			FString fstring = FString.AllocTemp(AnimationName);
			float result = USpineSkeletonComponent.__GetAnimationDuration_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026A38 RID: 158264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWorldTransform_Internal(IntPtr @this);

		// Token: 0x06026A39 RID: 158265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToSetupPose_Internal(IntPtr @this);

		// Token: 0x06026A3A RID: 158266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSlotsToSetupPose_Internal(IntPtr @this);

		// Token: 0x06026A3B RID: 158267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSlotColor_Internal(IntPtr @this, in FString SlotName, FColor color);

		// Token: 0x06026A3C RID: 158268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSkins_Internal(IntPtr @this, IntPtr SkinNames);

		// Token: 0x06026A3D RID: 158269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSkin_Internal(IntPtr @this, in FString SkinName);

		// Token: 0x06026A3E RID: 158270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScaleY_Internal(IntPtr @this, float scaleY);

		// Token: 0x06026A3F RID: 158271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScaleX_Internal(IntPtr @this, float scaleX);

		// Token: 0x06026A40 RID: 158272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneWorldPosition_Internal(IntPtr @this, in FString BoneName, in FVector position);

		// Token: 0x06026A41 RID: 158273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBonesToSetupPose_Internal(IntPtr @this);

		// Token: 0x06026A42 RID: 158274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetAttachment_Internal(IntPtr @this, in FString slotName, in FString attachmentName);

		// Token: 0x06026A43 RID: 158275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSlot_Internal(IntPtr @this, in FString SlotName);

		// Token: 0x06026A44 RID: 158276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSkin_Internal(IntPtr @this, in FString SkinName);

		// Token: 0x06026A45 RID: 158277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBone_Internal(IntPtr @this, in FString BoneName);

		// Token: 0x06026A46 RID: 158278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnimation_Internal(IntPtr @this, in FString AnimationName);

		// Token: 0x06026A47 RID: 158279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSlots_Internal(IntPtr @this, IntPtr Slots);

		// Token: 0x06026A48 RID: 158280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSkins_Internal(IntPtr @this, IntPtr Skins);

		// Token: 0x06026A49 RID: 158281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaleY_Internal(IntPtr @this);

		// Token: 0x06026A4A RID: 158282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaleX_Internal(IntPtr @this);

		// Token: 0x06026A4B RID: 158283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetBoneWorldTransform_Internal(IntPtr @this, in FString BoneName);

		// Token: 0x06026A4C RID: 158284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetBones_Internal(IntPtr @this, IntPtr Bones);

		// Token: 0x06026A4D RID: 158285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimations_Internal(IntPtr @this, IntPtr Animations);

		// Token: 0x06026A4E RID: 158286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationDuration_Internal(IntPtr @this, in FString AnimationName);

		// Token: 0x06026A4F RID: 158287 RVA: 0x003AF702 File Offset: 0x003AD902
		static USpineSkeletonComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineSkeletonComponent");
		}

		// Token: 0x06026A50 RID: 158288 RVA: 0x003AF710 File Offset: 0x003AD910
		protected USpineSkeletonComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401536F RID: 86895
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineSkeletonComponent";

		// Token: 0x04015370 RID: 86896
		private static IntPtr _ClassPtr;

		// Token: 0x04015371 RID: 86897
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015372 RID: 86898
		internal static int __PropertyOffset_Atlas;

		// Token: 0x04015373 RID: 86899
		internal static int __PropertyOffset_SkeletonData;

		// Token: 0x04015374 RID: 86900
		internal static int __PropertyOffset_BeforeUpdateWorldTransform;

		// Token: 0x04015375 RID: 86901
		[Nullable(2)]
		private FSpineBeforeUpdateWorldTransformDelegate _BeforeUpdateWorldTransform;

		// Token: 0x04015376 RID: 86902
		internal static int __PropertyOffset_AfterUpdateWorldTransform;

		// Token: 0x04015377 RID: 86903
		[Nullable(2)]
		private FSpineAfterUpdateWorldTransformDelegate _AfterUpdateWorldTransform;
	}
}
