using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B4 RID: 10420
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineWidget")]
	[UnrealStructLayout(2072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2072)]
	public class USpineWidget : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A91 RID: 158353 RVA: 0x003AFE3B File Offset: 0x003AE03B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineWidget._ClassPtr;
		}

		// Token: 0x06026A92 RID: 158354 RVA: 0x003AFE48 File Offset: 0x003AE048
		public USpineWidget() : this(BuiltinUtils.AllocNativeUObject(USpineWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A93 RID: 158355 RVA: 0x003AFE70 File Offset: 0x003AE070
		public USpineWidget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineWidget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009509 RID: 38153
		// (get) Token: 0x06026A94 RID: 158356 RVA: 0x003AFEA3 File Offset: 0x003AE0A3
		// (set) Token: 0x06026A95 RID: 158357 RVA: 0x003AFEB7 File Offset: 0x003AE0B7
		public unsafe string InitialSkin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USpineWidget.__PropertyOffset_InitialSkin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USpineWidget.__PropertyOffset_InitialSkin)), value);
			}
		}

		// Token: 0x1700950A RID: 38154
		// (get) Token: 0x06026A96 RID: 158358 RVA: 0x003AFECC File Offset: 0x003AE0CC
		// (set) Token: 0x06026A97 RID: 158359 RVA: 0x003AFEE0 File Offset: 0x003AE0E0
		[Nullable(2)]
		public unsafe USpineAtlasAsset Atlas
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineAtlasAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_Atlas);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_Atlas, value);
			}
		}

		// Token: 0x1700950B RID: 38155
		// (get) Token: 0x06026A98 RID: 158360 RVA: 0x003AFEF5 File Offset: 0x003AE0F5
		// (set) Token: 0x06026A99 RID: 158361 RVA: 0x003AFF09 File Offset: 0x003AE109
		[Nullable(2)]
		public unsafe USpineSkeletonDataAsset SkeletonData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineSkeletonDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_SkeletonData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_SkeletonData, value);
			}
		}

		// Token: 0x1700950C RID: 38156
		// (get) Token: 0x06026A9A RID: 158362 RVA: 0x003AFF1E File Offset: 0x003AE11E
		// (set) Token: 0x06026A9B RID: 158363 RVA: 0x003AFF32 File Offset: 0x003AE132
		[Nullable(2)]
		public unsafe UMaterialInterface NormalBlendMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_NormalBlendMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_NormalBlendMaterial, value);
			}
		}

		// Token: 0x1700950D RID: 38157
		// (get) Token: 0x06026A9C RID: 158364 RVA: 0x003AFF47 File Offset: 0x003AE147
		// (set) Token: 0x06026A9D RID: 158365 RVA: 0x003AFF5B File Offset: 0x003AE15B
		[Nullable(2)]
		public unsafe UMaterialInterface AdditiveBlendMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_AdditiveBlendMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_AdditiveBlendMaterial, value);
			}
		}

		// Token: 0x1700950E RID: 38158
		// (get) Token: 0x06026A9E RID: 158366 RVA: 0x003AFF70 File Offset: 0x003AE170
		// (set) Token: 0x06026A9F RID: 158367 RVA: 0x003AFF84 File Offset: 0x003AE184
		[Nullable(2)]
		public unsafe UMaterialInterface MultiplyBlendMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_MultiplyBlendMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_MultiplyBlendMaterial, value);
			}
		}

		// Token: 0x1700950F RID: 38159
		// (get) Token: 0x06026AA0 RID: 158368 RVA: 0x003AFF99 File Offset: 0x003AE199
		// (set) Token: 0x06026AA1 RID: 158369 RVA: 0x003AFFAD File Offset: 0x003AE1AD
		[Nullable(2)]
		public unsafe UMaterialInterface ScreenBlendMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_ScreenBlendMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineWidget.__PropertyOffset_ScreenBlendMaterial, value);
			}
		}

		// Token: 0x17009510 RID: 38160
		// (get) Token: 0x06026AA2 RID: 158370 RVA: 0x003AFFC2 File Offset: 0x003AE1C2
		// (set) Token: 0x06026AA3 RID: 158371 RVA: 0x003AFFD6 File Offset: 0x003AE1D6
		public unsafe FName TextureParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_TextureParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_TextureParameterName) = value;
			}
		}

		// Token: 0x17009511 RID: 38161
		// (get) Token: 0x06026AA4 RID: 158372 RVA: 0x003AFFEB File Offset: 0x003AE1EB
		// (set) Token: 0x06026AA5 RID: 158373 RVA: 0x003AFFFB File Offset: 0x003AE1FB
		public unsafe float DepthOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_DepthOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_DepthOffset) = value;
			}
		}

		// Token: 0x17009512 RID: 38162
		// (get) Token: 0x06026AA6 RID: 158374 RVA: 0x003B000C File Offset: 0x003AE20C
		// (set) Token: 0x06026AA7 RID: 158375 RVA: 0x003B0020 File Offset: 0x003AE220
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17009513 RID: 38163
		// (get) Token: 0x06026AA8 RID: 158376 RVA: 0x003B0038 File Offset: 0x003AE238
		// (set) Token: 0x06026AA9 RID: 158377 RVA: 0x003B0071 File Offset: 0x003AE271
		public FSlateBrush Brush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Brush) == null)
				{
					result = (this._Brush = new FSlateBrush(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_Brush, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_Brush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009514 RID: 38164
		// (get) Token: 0x06026AAA RID: 158378 RVA: 0x003B0094 File Offset: 0x003AE294
		// (set) Token: 0x06026AAB RID: 158379 RVA: 0x003B00CD File Offset: 0x003AE2CD
		public FSpineWidgetBeforeUpdateWorldTransformDelegate BeforeUpdateWorldTransform
		{
			get
			{
				base.FastCheckIsValid();
				FSpineWidgetBeforeUpdateWorldTransformDelegate result;
				if ((result = this._BeforeUpdateWorldTransform) == null)
				{
					result = (this._BeforeUpdateWorldTransform = new FSpineWidgetBeforeUpdateWorldTransformDelegate(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_BeforeUpdateWorldTransform, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_BeforeUpdateWorldTransform, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009515 RID: 38165
		// (get) Token: 0x06026AAC RID: 158380 RVA: 0x003B00F0 File Offset: 0x003AE2F0
		// (set) Token: 0x06026AAD RID: 158381 RVA: 0x003B0129 File Offset: 0x003AE329
		public FSpineWidgetAfterUpdateWorldTransformDelegate AfterUpdateWorldTransform
		{
			get
			{
				base.FastCheckIsValid();
				FSpineWidgetAfterUpdateWorldTransformDelegate result;
				if ((result = this._AfterUpdateWorldTransform) == null)
				{
					result = (this._AfterUpdateWorldTransform = new FSpineWidgetAfterUpdateWorldTransformDelegate(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AfterUpdateWorldTransform, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AfterUpdateWorldTransform, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009516 RID: 38166
		// (get) Token: 0x06026AAE RID: 158382 RVA: 0x003B014C File Offset: 0x003AE34C
		// (set) Token: 0x06026AAF RID: 158383 RVA: 0x003B0185 File Offset: 0x003AE385
		public FSpineAnimationStartDelegate AnimationStart
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationStartDelegate result;
				if ((result = this._AnimationStart) == null)
				{
					result = (this._AnimationStart = new FSpineAnimationStartDelegate(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationStart, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationStart, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009517 RID: 38167
		// (get) Token: 0x06026AB0 RID: 158384 RVA: 0x003B01A8 File Offset: 0x003AE3A8
		// (set) Token: 0x06026AB1 RID: 158385 RVA: 0x003B01E1 File Offset: 0x003AE3E1
		public FSpineAnimationInterruptDelegate AnimationInterrupt
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationInterruptDelegate result;
				if ((result = this._AnimationInterrupt) == null)
				{
					result = (this._AnimationInterrupt = new FSpineAnimationInterruptDelegate(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationInterrupt, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationInterrupt, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009518 RID: 38168
		// (get) Token: 0x06026AB2 RID: 158386 RVA: 0x003B0204 File Offset: 0x003AE404
		// (set) Token: 0x06026AB3 RID: 158387 RVA: 0x003B023D File Offset: 0x003AE43D
		public FSpineAnimationEventDelegate AnimationEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationEventDelegate result;
				if ((result = this._AnimationEvent) == null)
				{
					result = (this._AnimationEvent = new FSpineAnimationEventDelegate(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009519 RID: 38169
		// (get) Token: 0x06026AB4 RID: 158388 RVA: 0x003B0260 File Offset: 0x003AE460
		// (set) Token: 0x06026AB5 RID: 158389 RVA: 0x003B0299 File Offset: 0x003AE499
		public FSpineAnimationCompleteDelegate AnimationComplete
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationCompleteDelegate result;
				if ((result = this._AnimationComplete) == null)
				{
					result = (this._AnimationComplete = new FSpineAnimationCompleteDelegate(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationComplete, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationComplete, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700951A RID: 38170
		// (get) Token: 0x06026AB6 RID: 158390 RVA: 0x003B02BC File Offset: 0x003AE4BC
		// (set) Token: 0x06026AB7 RID: 158391 RVA: 0x003B02F5 File Offset: 0x003AE4F5
		public FSpineAnimationEndDelegate AnimationEnd
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationEndDelegate result;
				if ((result = this._AnimationEnd) == null)
				{
					result = (this._AnimationEnd = new FSpineAnimationEndDelegate(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationEnd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700951B RID: 38171
		// (get) Token: 0x06026AB8 RID: 158392 RVA: 0x003B0318 File Offset: 0x003AE518
		// (set) Token: 0x06026AB9 RID: 158393 RVA: 0x003B0351 File Offset: 0x003AE551
		public FSpineAnimationDisposeDelegate AnimationDispose
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationDisposeDelegate result;
				if ((result = this._AnimationDispose) == null)
				{
					result = (this._AnimationDispose = new FSpineAnimationDisposeDelegate(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationDispose, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_AnimationDispose, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700951C RID: 38172
		// (get) Token: 0x06026ABA RID: 158394 RVA: 0x003B0374 File Offset: 0x003AE574
		// (set) Token: 0x06026ABB RID: 158395 RVA: 0x003B03AD File Offset: 0x003AE5AD
		public TArray<UMaterialInstanceDynamic> atlasNormalBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._atlasNormalBlendMaterials) == null)
				{
					result = (this._atlasNormalBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_atlasNormalBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.atlasNormalBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700951D RID: 38173
		// (get) Token: 0x06026ABC RID: 158396 RVA: 0x003B03BC File Offset: 0x003AE5BC
		// (set) Token: 0x06026ABD RID: 158397 RVA: 0x003B03F5 File Offset: 0x003AE5F5
		public TArray<UMaterialInstanceDynamic> atlasAdditiveBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._atlasAdditiveBlendMaterials) == null)
				{
					result = (this._atlasAdditiveBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_atlasAdditiveBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.atlasAdditiveBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700951E RID: 38174
		// (get) Token: 0x06026ABE RID: 158398 RVA: 0x003B0404 File Offset: 0x003AE604
		// (set) Token: 0x06026ABF RID: 158399 RVA: 0x003B043D File Offset: 0x003AE63D
		public TArray<UMaterialInstanceDynamic> atlasMultiplyBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._atlasMultiplyBlendMaterials) == null)
				{
					result = (this._atlasMultiplyBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_atlasMultiplyBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.atlasMultiplyBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700951F RID: 38175
		// (get) Token: 0x06026AC0 RID: 158400 RVA: 0x003B044C File Offset: 0x003AE64C
		// (set) Token: 0x06026AC1 RID: 158401 RVA: 0x003B0485 File Offset: 0x003AE685
		public TArray<UMaterialInstanceDynamic> atlasScreenBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._atlasScreenBlendMaterials) == null)
				{
					result = (this._atlasScreenBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_atlasScreenBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.atlasScreenBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17009520 RID: 38176
		// (get) Token: 0x06026AC2 RID: 158402 RVA: 0x003B0494 File Offset: 0x003AE694
		// (set) Token: 0x06026AC3 RID: 158403 RVA: 0x003B04CD File Offset: 0x003AE6CD
		public TSet<UTrackEntry> trackEntries
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UTrackEntry> result;
				if ((result = this._trackEntries) == null)
				{
					result = (this._trackEntries = new TSet<UTrackEntry>(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_trackEntries, this));
				}
				return result;
			}
			set
			{
				this.trackEntries.CopyAssign(value);
			}
		}

		// Token: 0x17009521 RID: 38177
		// (get) Token: 0x06026AC4 RID: 158404 RVA: 0x003B04DB File Offset: 0x003AE6DB
		// (set) Token: 0x06026AC5 RID: 158405 RVA: 0x003B04EB File Offset: 0x003AE6EB
		public unsafe bool bAutoPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_bAutoPlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineWidget.__PropertyOffset_bAutoPlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026AC6 RID: 158406 RVA: 0x003B04FC File Offset: 0x003AE6FC
		public void UpdateWorldTransform()
		{
			USpineWidget.__UpdateWorldTransform_Internal(base.NativePtr);
		}

		// Token: 0x06026AC7 RID: 158407 RVA: 0x003B0509 File Offset: 0x003AE709
		public void Tick(float DeltaTime, bool CallDelegates = true)
		{
			USpineWidget.__Tick_Internal(base.NativePtr, DeltaTime, CallDelegates);
		}

		// Token: 0x06026AC8 RID: 158408 RVA: 0x003B0518 File Offset: 0x003AE718
		public void SetToSetupPose()
		{
			USpineWidget.__SetToSetupPose_Internal(base.NativePtr);
		}

		// Token: 0x06026AC9 RID: 158409 RVA: 0x003B0525 File Offset: 0x003AE725
		public void SetTimeScale(float timeScale)
		{
			USpineWidget.__SetTimeScale_Internal(base.NativePtr, timeScale);
		}

		// Token: 0x06026ACA RID: 158410 RVA: 0x003B0533 File Offset: 0x003AE733
		public void SetSlotsToSetupPose()
		{
			USpineWidget.__SetSlotsToSetupPose_Internal(base.NativePtr);
		}

		// Token: 0x06026ACB RID: 158411 RVA: 0x003B0540 File Offset: 0x003AE740
		public bool SetSkins([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> SkinNames)
		{
			return USpineWidget.__SetSkins_Internal(base.NativePtr, (SkinNames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026ACC RID: 158412 RVA: 0x003B0560 File Offset: 0x003AE760
		public unsafe bool SetSkin(string SkinName)
		{
			FString fstring = FString.AllocTemp(SkinName);
			bool result = USpineWidget.__SetSkin_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026ACD RID: 158413 RVA: 0x003B058A File Offset: 0x003AE78A
		public void SetScaleY(float scaleY)
		{
			USpineWidget.__SetScaleY_Internal(base.NativePtr, scaleY);
		}

		// Token: 0x06026ACE RID: 158414 RVA: 0x003B0598 File Offset: 0x003AE798
		public void SetScaleX(float scaleX)
		{
			USpineWidget.__SetScaleX_Internal(base.NativePtr, scaleX);
		}

		// Token: 0x06026ACF RID: 158415 RVA: 0x003B05A6 File Offset: 0x003AE7A6
		public void SetPlaybackTime(float InPlaybackTime, bool bCallDelegates = true)
		{
			USpineWidget.__SetPlaybackTime_Internal(base.NativePtr, InPlaybackTime, bCallDelegates);
		}

		// Token: 0x06026AD0 RID: 158416 RVA: 0x003B05B5 File Offset: 0x003AE7B5
		[NullableContext(2)]
		public UTrackEntry SetEmptyAnimation(int trackIndex, float mixDuration)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineWidget.__SetEmptyAnimation_Internal(base.NativePtr, trackIndex, mixDuration));
		}

		// Token: 0x06026AD1 RID: 158417 RVA: 0x003B05C9 File Offset: 0x003AE7C9
		public void SetBonesToSetupPose()
		{
			USpineWidget.__SetBonesToSetupPose_Internal(base.NativePtr);
		}

		// Token: 0x06026AD2 RID: 158418 RVA: 0x003B05D6 File Offset: 0x003AE7D6
		public void SetAutoPlay(bool bInAutoPlays)
		{
			USpineWidget.__SetAutoPlay_Internal(base.NativePtr, bInAutoPlays);
		}

		// Token: 0x06026AD3 RID: 158419 RVA: 0x003B05E4 File Offset: 0x003AE7E4
		public unsafe bool SetAttachment(string slotName, string attachmentName)
		{
			FString fstring = FString.AllocTemp(slotName);
			FString fstring2 = FString.AllocTemp(attachmentName);
			bool result = USpineWidget.__SetAttachment_Internal(base.NativePtr, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06026AD4 RID: 158420 RVA: 0x003B0620 File Offset: 0x003AE820
		[return: Nullable(2)]
		public unsafe UTrackEntry SetAnimation(int trackIndex, string animationName, bool loop)
		{
			FString fstring = FString.AllocTemp(animationName);
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineWidget.__SetAnimation_Internal(base.NativePtr, trackIndex, fstring, loop));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06026AD5 RID: 158421 RVA: 0x003B0654 File Offset: 0x003AE854
		public unsafe bool HasSlot(string SlotName)
		{
			FString fstring = FString.AllocTemp(SlotName);
			bool result = USpineWidget.__HasSlot_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026AD6 RID: 158422 RVA: 0x003B0680 File Offset: 0x003AE880
		public unsafe bool HasSkin(string SkinName)
		{
			FString fstring = FString.AllocTemp(SkinName);
			bool result = USpineWidget.__HasSkin_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026AD7 RID: 158423 RVA: 0x003B06AC File Offset: 0x003AE8AC
		public unsafe bool HasBone(string BoneName)
		{
			FString fstring = FString.AllocTemp(BoneName);
			bool result = USpineWidget.__HasBone_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026AD8 RID: 158424 RVA: 0x003B06D8 File Offset: 0x003AE8D8
		public unsafe bool HasAnimation(string AnimationName)
		{
			FString fstring = FString.AllocTemp(AnimationName);
			bool result = USpineWidget.__HasAnimation_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026AD9 RID: 158425 RVA: 0x003B0702 File Offset: 0x003AE902
		public float GetTimeScale()
		{
			return USpineWidget.__GetTimeScale_Internal(base.NativePtr);
		}

		// Token: 0x06026ADA RID: 158426 RVA: 0x003B070F File Offset: 0x003AE90F
		public void GetSlots([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Slots)
		{
			USpineWidget.__GetSlots_Internal(base.NativePtr, (Slots ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026ADB RID: 158427 RVA: 0x003B072C File Offset: 0x003AE92C
		public void GetSkins([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Skins)
		{
			USpineWidget.__GetSkins_Internal(base.NativePtr, (Skins ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026ADC RID: 158428 RVA: 0x003B0749 File Offset: 0x003AE949
		public float GetScaleY()
		{
			return USpineWidget.__GetScaleY_Internal(base.NativePtr);
		}

		// Token: 0x06026ADD RID: 158429 RVA: 0x003B0756 File Offset: 0x003AE956
		public float GetScaleX()
		{
			return USpineWidget.__GetScaleX_Internal(base.NativePtr);
		}

		// Token: 0x06026ADE RID: 158430 RVA: 0x003B0763 File Offset: 0x003AE963
		[NullableContext(2)]
		public UTrackEntry GetCurrent(int trackIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineWidget.__GetCurrent_Internal(base.NativePtr, trackIndex));
		}

		// Token: 0x06026ADF RID: 158431 RVA: 0x003B0778 File Offset: 0x003AE978
		public unsafe FTransform GetBoneTransform(string BoneName)
		{
			FString fstring = FString.AllocTemp(BoneName);
			FTransform result = USpineWidget.__GetBoneTransform_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026AE0 RID: 158432 RVA: 0x003B07A2 File Offset: 0x003AE9A2
		public void GetBones([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Bones)
		{
			USpineWidget.__GetBones_Internal(base.NativePtr, (Bones ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026AE1 RID: 158433 RVA: 0x003B07BF File Offset: 0x003AE9BF
		public void GetAnimations([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Animations)
		{
			USpineWidget.__GetAnimations_Internal(base.NativePtr, (Animations ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06026AE2 RID: 158434 RVA: 0x003B07DC File Offset: 0x003AE9DC
		public unsafe float GetAnimationDuration(string AnimationName)
		{
			FString fstring = FString.AllocTemp(AnimationName);
			float result = USpineWidget.__GetAnimationDuration_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06026AE3 RID: 158435 RVA: 0x003B0806 File Offset: 0x003AEA06
		public void ClearTracks()
		{
			USpineWidget.__ClearTracks_Internal(base.NativePtr);
		}

		// Token: 0x06026AE4 RID: 158436 RVA: 0x003B0813 File Offset: 0x003AEA13
		public void ClearTrack(int trackIndex)
		{
			USpineWidget.__ClearTrack_Internal(base.NativePtr, trackIndex);
		}

		// Token: 0x06026AE5 RID: 158437 RVA: 0x003B0821 File Offset: 0x003AEA21
		[NullableContext(2)]
		public UTrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineWidget.__AddEmptyAnimation_Internal(base.NativePtr, trackIndex, mixDuration, delay));
		}

		// Token: 0x06026AE6 RID: 158438 RVA: 0x003B0838 File Offset: 0x003AEA38
		[return: Nullable(2)]
		public unsafe UTrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay)
		{
			FString fstring = FString.AllocTemp(animationName);
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineWidget.__AddAnimation_Internal(base.NativePtr, trackIndex, fstring, loop, delay));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06026AE7 RID: 158439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWorldTransform_Internal(IntPtr @this);

		// Token: 0x06026AE8 RID: 158440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Tick_Internal(IntPtr @this, float DeltaTime, bool CallDelegates);

		// Token: 0x06026AE9 RID: 158441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToSetupPose_Internal(IntPtr @this);

		// Token: 0x06026AEA RID: 158442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeScale_Internal(IntPtr @this, float timeScale);

		// Token: 0x06026AEB RID: 158443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSlotsToSetupPose_Internal(IntPtr @this);

		// Token: 0x06026AEC RID: 158444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSkins_Internal(IntPtr @this, IntPtr SkinNames);

		// Token: 0x06026AED RID: 158445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSkin_Internal(IntPtr @this, in FString SkinName);

		// Token: 0x06026AEE RID: 158446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScaleY_Internal(IntPtr @this, float scaleY);

		// Token: 0x06026AEF RID: 158447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScaleX_Internal(IntPtr @this, float scaleX);

		// Token: 0x06026AF0 RID: 158448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackTime_Internal(IntPtr @this, float InPlaybackTime, bool bCallDelegates);

		// Token: 0x06026AF1 RID: 158449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetEmptyAnimation_Internal(IntPtr @this, int trackIndex, float mixDuration);

		// Token: 0x06026AF2 RID: 158450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBonesToSetupPose_Internal(IntPtr @this);

		// Token: 0x06026AF3 RID: 158451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoPlay_Internal(IntPtr @this, bool bInAutoPlays);

		// Token: 0x06026AF4 RID: 158452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetAttachment_Internal(IntPtr @this, in FString slotName, in FString attachmentName);

		// Token: 0x06026AF5 RID: 158453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetAnimation_Internal(IntPtr @this, int trackIndex, in FString animationName, bool loop);

		// Token: 0x06026AF6 RID: 158454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSlot_Internal(IntPtr @this, in FString SlotName);

		// Token: 0x06026AF7 RID: 158455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSkin_Internal(IntPtr @this, in FString SkinName);

		// Token: 0x06026AF8 RID: 158456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBone_Internal(IntPtr @this, in FString BoneName);

		// Token: 0x06026AF9 RID: 158457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnimation_Internal(IntPtr @this, in FString AnimationName);

		// Token: 0x06026AFA RID: 158458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeScale_Internal(IntPtr @this);

		// Token: 0x06026AFB RID: 158459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSlots_Internal(IntPtr @this, IntPtr Slots);

		// Token: 0x06026AFC RID: 158460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSkins_Internal(IntPtr @this, IntPtr Skins);

		// Token: 0x06026AFD RID: 158461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaleY_Internal(IntPtr @this);

		// Token: 0x06026AFE RID: 158462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaleX_Internal(IntPtr @this);

		// Token: 0x06026AFF RID: 158463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrent_Internal(IntPtr @this, int trackIndex);

		// Token: 0x06026B00 RID: 158464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetBoneTransform_Internal(IntPtr @this, in FString BoneName);

		// Token: 0x06026B01 RID: 158465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetBones_Internal(IntPtr @this, IntPtr Bones);

		// Token: 0x06026B02 RID: 158466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimations_Internal(IntPtr @this, IntPtr Animations);

		// Token: 0x06026B03 RID: 158467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationDuration_Internal(IntPtr @this, in FString AnimationName);

		// Token: 0x06026B04 RID: 158468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTracks_Internal(IntPtr @this);

		// Token: 0x06026B05 RID: 158469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTrack_Internal(IntPtr @this, int trackIndex);

		// Token: 0x06026B06 RID: 158470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddEmptyAnimation_Internal(IntPtr @this, int trackIndex, float mixDuration, float delay);

		// Token: 0x06026B07 RID: 158471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddAnimation_Internal(IntPtr @this, int trackIndex, in FString animationName, bool loop, float delay);

		// Token: 0x06026B08 RID: 158472 RVA: 0x003B086B File Offset: 0x003AEA6B
		static USpineWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineWidget");
		}

		// Token: 0x06026B09 RID: 158473 RVA: 0x003B0879 File Offset: 0x003AEA79
		protected USpineWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040153A9 RID: 86953
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineWidget";

		// Token: 0x040153AA RID: 86954
		private static IntPtr _ClassPtr;

		// Token: 0x040153AB RID: 86955
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040153AC RID: 86956
		internal static int __PropertyOffset_InitialSkin;

		// Token: 0x040153AD RID: 86957
		internal static int __PropertyOffset_Atlas;

		// Token: 0x040153AE RID: 86958
		internal static int __PropertyOffset_SkeletonData;

		// Token: 0x040153AF RID: 86959
		internal static int __PropertyOffset_NormalBlendMaterial;

		// Token: 0x040153B0 RID: 86960
		internal static int __PropertyOffset_AdditiveBlendMaterial;

		// Token: 0x040153B1 RID: 86961
		internal static int __PropertyOffset_MultiplyBlendMaterial;

		// Token: 0x040153B2 RID: 86962
		internal static int __PropertyOffset_ScreenBlendMaterial;

		// Token: 0x040153B3 RID: 86963
		internal static int __PropertyOffset_TextureParameterName;

		// Token: 0x040153B4 RID: 86964
		internal static int __PropertyOffset_DepthOffset;

		// Token: 0x040153B5 RID: 86965
		internal static int __PropertyOffset_Color;

		// Token: 0x040153B6 RID: 86966
		internal static int __PropertyOffset_Brush;

		// Token: 0x040153B7 RID: 86967
		[Nullable(2)]
		private FSlateBrush _Brush;

		// Token: 0x040153B8 RID: 86968
		internal static int __PropertyOffset_BeforeUpdateWorldTransform;

		// Token: 0x040153B9 RID: 86969
		[Nullable(2)]
		private FSpineWidgetBeforeUpdateWorldTransformDelegate _BeforeUpdateWorldTransform;

		// Token: 0x040153BA RID: 86970
		internal static int __PropertyOffset_AfterUpdateWorldTransform;

		// Token: 0x040153BB RID: 86971
		[Nullable(2)]
		private FSpineWidgetAfterUpdateWorldTransformDelegate _AfterUpdateWorldTransform;

		// Token: 0x040153BC RID: 86972
		internal static int __PropertyOffset_AnimationStart;

		// Token: 0x040153BD RID: 86973
		[Nullable(2)]
		private FSpineAnimationStartDelegate _AnimationStart;

		// Token: 0x040153BE RID: 86974
		internal static int __PropertyOffset_AnimationInterrupt;

		// Token: 0x040153BF RID: 86975
		[Nullable(2)]
		private FSpineAnimationInterruptDelegate _AnimationInterrupt;

		// Token: 0x040153C0 RID: 86976
		internal static int __PropertyOffset_AnimationEvent;

		// Token: 0x040153C1 RID: 86977
		[Nullable(2)]
		private FSpineAnimationEventDelegate _AnimationEvent;

		// Token: 0x040153C2 RID: 86978
		internal static int __PropertyOffset_AnimationComplete;

		// Token: 0x040153C3 RID: 86979
		[Nullable(2)]
		private FSpineAnimationCompleteDelegate _AnimationComplete;

		// Token: 0x040153C4 RID: 86980
		internal static int __PropertyOffset_AnimationEnd;

		// Token: 0x040153C5 RID: 86981
		[Nullable(2)]
		private FSpineAnimationEndDelegate _AnimationEnd;

		// Token: 0x040153C6 RID: 86982
		internal static int __PropertyOffset_AnimationDispose;

		// Token: 0x040153C7 RID: 86983
		[Nullable(2)]
		private FSpineAnimationDisposeDelegate _AnimationDispose;

		// Token: 0x040153C8 RID: 86984
		internal static int __PropertyOffset_atlasNormalBlendMaterials;

		// Token: 0x040153C9 RID: 86985
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasNormalBlendMaterials;

		// Token: 0x040153CA RID: 86986
		internal static int __PropertyOffset_atlasAdditiveBlendMaterials;

		// Token: 0x040153CB RID: 86987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasAdditiveBlendMaterials;

		// Token: 0x040153CC RID: 86988
		internal static int __PropertyOffset_atlasMultiplyBlendMaterials;

		// Token: 0x040153CD RID: 86989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasMultiplyBlendMaterials;

		// Token: 0x040153CE RID: 86990
		internal static int __PropertyOffset_atlasScreenBlendMaterials;

		// Token: 0x040153CF RID: 86991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasScreenBlendMaterials;

		// Token: 0x040153D0 RID: 86992
		internal static int __PropertyOffset_trackEntries;

		// Token: 0x040153D1 RID: 86993
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UTrackEntry> _trackEntries;

		// Token: 0x040153D2 RID: 86994
		internal static int __PropertyOffset_bAutoPlaying;
	}
}
