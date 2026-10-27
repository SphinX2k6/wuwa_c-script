using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE3 RID: 7139
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWeaponEnvInteraction")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class AKuroWeaponEnvInteraction : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B6F0 RID: 112368 RVA: 0x0028686A File Offset: 0x00284A6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWeaponEnvInteraction._ClassPtr;
		}

		// Token: 0x0601B6F1 RID: 112369 RVA: 0x00286878 File Offset: 0x00284A78
		public AKuroWeaponEnvInteraction() : this(BuiltinUtils.AllocNativeUObject(AKuroWeaponEnvInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B6F2 RID: 112370 RVA: 0x002868A0 File Offset: 0x00284AA0
		[NullableContext(1)]
		public AKuroWeaponEnvInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWeaponEnvInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E49 RID: 28233
		// (get) Token: 0x0601B6F3 RID: 112371 RVA: 0x002868D3 File Offset: 0x00284AD3
		// (set) Token: 0x0601B6F4 RID: 112372 RVA: 0x002868E7 File Offset: 0x00284AE7
		public unsafe UTextureRenderTarget2D RT_PosA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_RT_PosA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_RT_PosA, value);
			}
		}

		// Token: 0x17006E4A RID: 28234
		// (get) Token: 0x0601B6F5 RID: 112373 RVA: 0x002868FC File Offset: 0x00284AFC
		// (set) Token: 0x0601B6F6 RID: 112374 RVA: 0x00286910 File Offset: 0x00284B10
		public unsafe UTextureRenderTarget2D RT_PosB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_RT_PosB);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_RT_PosB, value);
			}
		}

		// Token: 0x17006E4B RID: 28235
		// (get) Token: 0x0601B6F7 RID: 112375 RVA: 0x00286925 File Offset: 0x00284B25
		// (set) Token: 0x0601B6F8 RID: 112376 RVA: 0x00286939 File Offset: 0x00284B39
		public unsafe UTextureRenderTarget2D RT_WeaponPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_RT_WeaponPos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_RT_WeaponPos, value);
			}
		}

		// Token: 0x17006E4C RID: 28236
		// (get) Token: 0x0601B6F9 RID: 112377 RVA: 0x0028694E File Offset: 0x00284B4E
		// (set) Token: 0x0601B6FA RID: 112378 RVA: 0x00286962 File Offset: 0x00284B62
		public unsafe UMaterialParameterCollection Scene_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_Scene_MPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_Scene_MPC, value);
			}
		}

		// Token: 0x17006E4D RID: 28237
		// (get) Token: 0x0601B6FB RID: 112379 RVA: 0x00286977 File Offset: 0x00284B77
		// (set) Token: 0x0601B6FC RID: 112380 RVA: 0x00286987 File Offset: 0x00284B87
		public unsafe float InteractionSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_InteractionSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_InteractionSize) = value;
			}
		}

		// Token: 0x17006E4E RID: 28238
		// (get) Token: 0x0601B6FD RID: 112381 RVA: 0x00286998 File Offset: 0x00284B98
		// (set) Token: 0x0601B6FE RID: 112382 RVA: 0x002869A8 File Offset: 0x00284BA8
		public unsafe float Attenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_Attenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_Attenuation) = value;
			}
		}

		// Token: 0x17006E4F RID: 28239
		// (get) Token: 0x0601B6FF RID: 112383 RVA: 0x002869B9 File Offset: 0x00284BB9
		// (set) Token: 0x0601B700 RID: 112384 RVA: 0x002869CD File Offset: 0x00284BCD
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x17006E50 RID: 28240
		// (get) Token: 0x0601B701 RID: 112385 RVA: 0x002869E2 File Offset: 0x00284BE2
		// (set) Token: 0x0601B702 RID: 112386 RVA: 0x002869F2 File Offset: 0x00284BF2
		public unsafe float WeaponInteractRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_WeaponInteractRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_WeaponInteractRadius) = value;
			}
		}

		// Token: 0x17006E51 RID: 28241
		// (get) Token: 0x0601B703 RID: 112387 RVA: 0x00286A03 File Offset: 0x00284C03
		// (set) Token: 0x0601B704 RID: 112388 RVA: 0x00286A13 File Offset: 0x00284C13
		public unsafe float StepValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_StepValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_StepValue) = value;
			}
		}

		// Token: 0x17006E52 RID: 28242
		// (get) Token: 0x0601B705 RID: 112389 RVA: 0x00286A24 File Offset: 0x00284C24
		// (set) Token: 0x0601B706 RID: 112390 RVA: 0x00286A34 File Offset: 0x00284C34
		public unsafe float OverwriteValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_OverwriteValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_OverwriteValue) = value;
			}
		}

		// Token: 0x17006E53 RID: 28243
		// (get) Token: 0x0601B707 RID: 112391 RVA: 0x00286A45 File Offset: 0x00284C45
		// (set) Token: 0x0601B708 RID: 112392 RVA: 0x00286A55 File Offset: 0x00284C55
		public unsafe bool bMotorcycleGrassInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_bMotorcycleGrassInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_bMotorcycleGrassInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E54 RID: 28244
		// (get) Token: 0x0601B709 RID: 112393 RVA: 0x00286A66 File Offset: 0x00284C66
		// (set) Token: 0x0601B70A RID: 112394 RVA: 0x00286A76 File Offset: 0x00284C76
		public unsafe float InteractionSize_Mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_InteractionSize_Mobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_InteractionSize_Mobile) = value;
			}
		}

		// Token: 0x17006E55 RID: 28245
		// (get) Token: 0x0601B70B RID: 112395 RVA: 0x00286A87 File Offset: 0x00284C87
		// (set) Token: 0x0601B70C RID: 112396 RVA: 0x00286A97 File Offset: 0x00284C97
		public unsafe float InteractionSize_PC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_InteractionSize_PC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_InteractionSize_PC) = value;
			}
		}

		// Token: 0x17006E56 RID: 28246
		// (get) Token: 0x0601B70D RID: 112397 RVA: 0x00286AA8 File Offset: 0x00284CA8
		// (set) Token: 0x0601B70E RID: 112398 RVA: 0x00286AB8 File Offset: 0x00284CB8
		public unsafe float GrassFreezeRecoveryValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_GrassFreezeRecoveryValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_GrassFreezeRecoveryValue) = value;
			}
		}

		// Token: 0x17006E57 RID: 28247
		// (get) Token: 0x0601B70F RID: 112399 RVA: 0x00286AC9 File Offset: 0x00284CC9
		// (set) Token: 0x0601B710 RID: 112400 RVA: 0x00286ADD File Offset: 0x00284CDD
		public unsafe UMaterialInstanceDynamic MID_StampPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_MID_StampPos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_MID_StampPos, value);
			}
		}

		// Token: 0x17006E58 RID: 28248
		// (get) Token: 0x0601B711 RID: 112401 RVA: 0x00286AF2 File Offset: 0x00284CF2
		// (set) Token: 0x0601B712 RID: 112402 RVA: 0x00286B06 File Offset: 0x00284D06
		public unsafe UMaterialInstanceDynamic MID_UpdatePos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_MID_UpdatePos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_MID_UpdatePos, value);
			}
		}

		// Token: 0x17006E59 RID: 28249
		// (get) Token: 0x0601B713 RID: 112403 RVA: 0x00286B1B File Offset: 0x00284D1B
		// (set) Token: 0x0601B714 RID: 112404 RVA: 0x00286B2F File Offset: 0x00284D2F
		public unsafe UMaterialInstanceDynamic MID_AddWeaponPoint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_MID_AddWeaponPoint);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_MID_AddWeaponPoint, value);
			}
		}

		// Token: 0x17006E5A RID: 28250
		// (get) Token: 0x0601B715 RID: 112405 RVA: 0x00286B44 File Offset: 0x00284D44
		// (set) Token: 0x0601B716 RID: 112406 RVA: 0x00286B58 File Offset: 0x00284D58
		public unsafe UMaterialInterface M_DrawWithOffset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_M_DrawWithOffset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeaponEnvInteraction.__PropertyOffset_M_DrawWithOffset, value);
			}
		}

		// Token: 0x17006E5B RID: 28251
		// (get) Token: 0x0601B717 RID: 112407 RVA: 0x00286B6D File Offset: 0x00284D6D
		// (set) Token: 0x0601B718 RID: 112408 RVA: 0x00286B81 File Offset: 0x00284D81
		public unsafe FVectorDouble PlayerPixelPos_Curr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_PlayerPixelPos_Curr);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_PlayerPixelPos_Curr) = value;
			}
		}

		// Token: 0x17006E5C RID: 28252
		// (get) Token: 0x0601B719 RID: 112409 RVA: 0x00286B96 File Offset: 0x00284D96
		// (set) Token: 0x0601B71A RID: 112410 RVA: 0x00286BAA File Offset: 0x00284DAA
		public unsafe FVectorDouble PlayerPixelPos_Prev
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_PlayerPixelPos_Prev);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_PlayerPixelPos_Prev) = value;
			}
		}

		// Token: 0x17006E5D RID: 28253
		// (get) Token: 0x0601B71B RID: 112411 RVA: 0x00286BBF File Offset: 0x00284DBF
		// (set) Token: 0x0601B71C RID: 112412 RVA: 0x00286BD3 File Offset: 0x00284DD3
		public unsafe FVectorDouble WeaponPos_Curr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_WeaponPos_Curr);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_WeaponPos_Curr) = value;
			}
		}

		// Token: 0x17006E5E RID: 28254
		// (get) Token: 0x0601B71D RID: 112413 RVA: 0x00286BE8 File Offset: 0x00284DE8
		// (set) Token: 0x0601B71E RID: 112414 RVA: 0x00286BFC File Offset: 0x00284DFC
		public unsafe FVectorDouble WeaponPos_Prev
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_WeaponPos_Prev);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_WeaponPos_Prev) = value;
			}
		}

		// Token: 0x17006E5F RID: 28255
		// (get) Token: 0x0601B71F RID: 112415 RVA: 0x00286C11 File Offset: 0x00284E11
		// (set) Token: 0x0601B720 RID: 112416 RVA: 0x00286C21 File Offset: 0x00284E21
		public unsafe float ReadBackValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_ReadBackValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_ReadBackValue) = value;
			}
		}

		// Token: 0x17006E60 RID: 28256
		// (get) Token: 0x0601B721 RID: 112417 RVA: 0x00286C32 File Offset: 0x00284E32
		// (set) Token: 0x0601B722 RID: 112418 RVA: 0x00286C42 File Offset: 0x00284E42
		public unsafe float CountDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_CountDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeaponEnvInteraction.__PropertyOffset_CountDown) = value;
			}
		}

		// Token: 0x0601B723 RID: 112419 RVA: 0x00286C53 File Offset: 0x00284E53
		public void WeaponEnvInteractionTick(FGameplayTag MotorcycleState, FGameplayTag InAirState)
		{
			AKuroWeaponEnvInteraction.__WeaponEnvInteractionTick_Internal(base.NativePtr, MotorcycleState, InAirState);
		}

		// Token: 0x0601B724 RID: 112420 RVA: 0x00286C64 File Offset: 0x00284E64
		public unsafe void OnWeaponInteract(FVectorDouble InteractPos, float CollisionRadius, float MinConnectDist, float MaxConnectDist, float WeaponRadius, ref int PixelX, ref int PixelY)
		{
			fixed (int* ptr = &PixelX)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &PixelY)
				{
					void* ptr4 = (void*)ptr3;
					AKuroWeaponEnvInteraction.__OnWeaponInteract_Internal(base.NativePtr, InteractPos, CollisionRadius, MinConnectDist, MaxConnectDist, WeaponRadius, ref PixelX, ref PixelY);
					ptr = null;
				}
			}
		}

		// Token: 0x0601B725 RID: 112421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WeaponEnvInteractionTick_Internal(IntPtr @this, FGameplayTag MotorcycleState, FGameplayTag InAirState);

		// Token: 0x0601B726 RID: 112422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnWeaponInteract_Internal(IntPtr @this, FVectorDouble InteractPos, float CollisionRadius, float MinConnectDist, float MaxConnectDist, float WeaponRadius, ref int PixelX, ref int PixelY);

		// Token: 0x0601B727 RID: 112423 RVA: 0x00286C99 File Offset: 0x00284E99
		static AKuroWeaponEnvInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWeaponEnvInteraction");
		}

		// Token: 0x0601B728 RID: 112424 RVA: 0x00286CA7 File Offset: 0x00284EA7
		protected AKuroWeaponEnvInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EC34 RID: 60468
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWeaponEnvInteraction";

		// Token: 0x0400EC35 RID: 60469
		private static IntPtr _ClassPtr;

		// Token: 0x0400EC36 RID: 60470
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EC37 RID: 60471
		internal static int __PropertyOffset_RT_PosA;

		// Token: 0x0400EC38 RID: 60472
		internal static int __PropertyOffset_RT_PosB;

		// Token: 0x0400EC39 RID: 60473
		internal static int __PropertyOffset_RT_WeaponPos;

		// Token: 0x0400EC3A RID: 60474
		internal static int __PropertyOffset_Scene_MPC;

		// Token: 0x0400EC3B RID: 60475
		internal static int __PropertyOffset_InteractionSize;

		// Token: 0x0400EC3C RID: 60476
		internal static int __PropertyOffset_Attenuation;

		// Token: 0x0400EC3D RID: 60477
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x0400EC3E RID: 60478
		internal static int __PropertyOffset_WeaponInteractRadius;

		// Token: 0x0400EC3F RID: 60479
		internal static int __PropertyOffset_StepValue;

		// Token: 0x0400EC40 RID: 60480
		internal static int __PropertyOffset_OverwriteValue;

		// Token: 0x0400EC41 RID: 60481
		internal static int __PropertyOffset_bMotorcycleGrassInteraction;

		// Token: 0x0400EC42 RID: 60482
		internal static int __PropertyOffset_InteractionSize_Mobile;

		// Token: 0x0400EC43 RID: 60483
		internal static int __PropertyOffset_InteractionSize_PC;

		// Token: 0x0400EC44 RID: 60484
		internal static int __PropertyOffset_GrassFreezeRecoveryValue;

		// Token: 0x0400EC45 RID: 60485
		internal static int __PropertyOffset_MID_StampPos;

		// Token: 0x0400EC46 RID: 60486
		internal static int __PropertyOffset_MID_UpdatePos;

		// Token: 0x0400EC47 RID: 60487
		internal static int __PropertyOffset_MID_AddWeaponPoint;

		// Token: 0x0400EC48 RID: 60488
		internal static int __PropertyOffset_M_DrawWithOffset;

		// Token: 0x0400EC49 RID: 60489
		internal static int __PropertyOffset_PlayerPixelPos_Curr;

		// Token: 0x0400EC4A RID: 60490
		internal static int __PropertyOffset_PlayerPixelPos_Prev;

		// Token: 0x0400EC4B RID: 60491
		internal static int __PropertyOffset_WeaponPos_Curr;

		// Token: 0x0400EC4C RID: 60492
		internal static int __PropertyOffset_WeaponPos_Prev;

		// Token: 0x0400EC4D RID: 60493
		internal static int __PropertyOffset_ReadBackValue;

		// Token: 0x0400EC4E RID: 60494
		internal static int __PropertyOffset_CountDown;
	}
}
