using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017CA RID: 6090
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSSimpleCollisionAxis")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class AKuroCSSimpleCollisionAxis : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601651E RID: 91422 RVA: 0x0020A54C File Offset: 0x0020874C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSSimpleCollisionAxis._ClassPtr;
		}

		// Token: 0x0601651F RID: 91423 RVA: 0x0020A558 File Offset: 0x00208758
		public AKuroCSSimpleCollisionAxis() : this(BuiltinUtils.AllocNativeUObject(AKuroCSSimpleCollisionAxis.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016520 RID: 91424 RVA: 0x0020A580 File Offset: 0x00208780
		[NullableContext(1)]
		public AKuroCSSimpleCollisionAxis(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSSimpleCollisionAxis.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170059A9 RID: 22953
		// (get) Token: 0x06016521 RID: 91425 RVA: 0x0020A5B3 File Offset: 0x002087B3
		// (set) Token: 0x06016522 RID: 91426 RVA: 0x0020A5C7 File Offset: 0x002087C7
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x170059AA RID: 22954
		// (get) Token: 0x06016523 RID: 91427 RVA: 0x0020A5DC File Offset: 0x002087DC
		// (set) Token: 0x06016524 RID: 91428 RVA: 0x0020A5EC File Offset: 0x002087EC
		public unsafe bool bEnableRendering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_bEnableRendering) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_bEnableRendering) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059AB RID: 22955
		// (get) Token: 0x06016525 RID: 91429 RVA: 0x0020A5FD File Offset: 0x002087FD
		// (set) Token: 0x06016526 RID: 91430 RVA: 0x0020A611 File Offset: 0x00208811
		public unsafe UTexture2D InputTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_InputTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_InputTexture, value);
			}
		}

		// Token: 0x170059AC RID: 22956
		// (get) Token: 0x06016527 RID: 91431 RVA: 0x0020A626 File Offset: 0x00208826
		// (set) Token: 0x06016528 RID: 91432 RVA: 0x0020A63A File Offset: 0x0020883A
		public unsafe UTextureRenderTarget2D OutputRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_OutputRenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_OutputRenderTarget, value);
			}
		}

		// Token: 0x170059AD RID: 22957
		// (get) Token: 0x06016529 RID: 91433 RVA: 0x0020A64F File Offset: 0x0020884F
		// (set) Token: 0x0601652A RID: 91434 RVA: 0x0020A663 File Offset: 0x00208863
		public unsafe UTextureRenderTarget2D AxisOutputRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_AxisOutputRenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_AxisOutputRenderTarget, value);
			}
		}

		// Token: 0x170059AE RID: 22958
		// (get) Token: 0x0601652B RID: 91435 RVA: 0x0020A678 File Offset: 0x00208878
		// (set) Token: 0x0601652C RID: 91436 RVA: 0x0020A68C File Offset: 0x0020888C
		public unsafe UTextureRenderTarget2D BottomVelocityRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomVelocityRenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomVelocityRenderTarget, value);
			}
		}

		// Token: 0x170059AF RID: 22959
		// (get) Token: 0x0601652D RID: 91437 RVA: 0x0020A6A1 File Offset: 0x002088A1
		// (set) Token: 0x0601652E RID: 91438 RVA: 0x0020A6B5 File Offset: 0x002088B5
		public unsafe UTextureRenderTarget2D TopVelocityRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_TopVelocityRenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_TopVelocityRenderTarget, value);
			}
		}

		// Token: 0x170059B0 RID: 22960
		// (get) Token: 0x0601652F RID: 91439 RVA: 0x0020A6CA File Offset: 0x002088CA
		// (set) Token: 0x06016530 RID: 91440 RVA: 0x0020A6DE File Offset: 0x002088DE
		public unsafe FVector PlayerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_PlayerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_PlayerPos) = value;
			}
		}

		// Token: 0x170059B1 RID: 22961
		// (get) Token: 0x06016531 RID: 91441 RVA: 0x0020A6F3 File Offset: 0x002088F3
		// (set) Token: 0x06016532 RID: 91442 RVA: 0x0020A707 File Offset: 0x00208907
		public unsafe UStaticMeshComponent TargetMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_TargetMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_TargetMesh, value);
			}
		}

		// Token: 0x170059B2 RID: 22962
		// (get) Token: 0x06016533 RID: 91443 RVA: 0x0020A71C File Offset: 0x0020891C
		// (set) Token: 0x06016534 RID: 91444 RVA: 0x0020A730 File Offset: 0x00208930
		public unsafe FVector PivotPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_PivotPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_PivotPos) = value;
			}
		}

		// Token: 0x170059B3 RID: 22963
		// (get) Token: 0x06016535 RID: 91445 RVA: 0x0020A745 File Offset: 0x00208945
		// (set) Token: 0x06016536 RID: 91446 RVA: 0x0020A755 File Offset: 0x00208955
		public unsafe float CollisionRadiusScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_CollisionRadiusScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_CollisionRadiusScale) = value;
			}
		}

		// Token: 0x170059B4 RID: 22964
		// (get) Token: 0x06016537 RID: 91447 RVA: 0x0020A766 File Offset: 0x00208966
		// (set) Token: 0x06016538 RID: 91448 RVA: 0x0020A776 File Offset: 0x00208976
		public unsafe float PlayerPushRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_PlayerPushRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_PlayerPushRadius) = value;
			}
		}

		// Token: 0x170059B5 RID: 22965
		// (get) Token: 0x06016539 RID: 91449 RVA: 0x0020A787 File Offset: 0x00208987
		// (set) Token: 0x0601653A RID: 91450 RVA: 0x0020A797 File Offset: 0x00208997
		public unsafe float ParticleMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_ParticleMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_ParticleMass) = value;
			}
		}

		// Token: 0x170059B6 RID: 22966
		// (get) Token: 0x0601653B RID: 91451 RVA: 0x0020A7A8 File Offset: 0x002089A8
		// (set) Token: 0x0601653C RID: 91452 RVA: 0x0020A7B8 File Offset: 0x002089B8
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x170059B7 RID: 22967
		// (get) Token: 0x0601653D RID: 91453 RVA: 0x0020A7C9 File Offset: 0x002089C9
		// (set) Token: 0x0601653E RID: 91454 RVA: 0x0020A7D9 File Offset: 0x002089D9
		public unsafe float PlayerForceStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_PlayerForceStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_PlayerForceStrength) = value;
			}
		}

		// Token: 0x170059B8 RID: 22968
		// (get) Token: 0x0601653F RID: 91455 RVA: 0x0020A7EA File Offset: 0x002089EA
		// (set) Token: 0x06016540 RID: 91456 RVA: 0x0020A7FA File Offset: 0x002089FA
		public unsafe float CollisionForceStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_CollisionForceStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_CollisionForceStrength) = value;
			}
		}

		// Token: 0x170059B9 RID: 22969
		// (get) Token: 0x06016541 RID: 91457 RVA: 0x0020A80B File Offset: 0x00208A0B
		// (set) Token: 0x06016542 RID: 91458 RVA: 0x0020A81B File Offset: 0x00208A1B
		public unsafe float SpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_SpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_SpringStiffness) = value;
			}
		}

		// Token: 0x170059BA RID: 22970
		// (get) Token: 0x06016543 RID: 91459 RVA: 0x0020A82C File Offset: 0x00208A2C
		// (set) Token: 0x06016544 RID: 91460 RVA: 0x0020A83C File Offset: 0x00208A3C
		public unsafe float MaxVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_MaxVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_MaxVelocity) = value;
			}
		}

		// Token: 0x170059BB RID: 22971
		// (get) Token: 0x06016545 RID: 91461 RVA: 0x0020A84D File Offset: 0x00208A4D
		// (set) Token: 0x06016546 RID: 91462 RVA: 0x0020A85D File Offset: 0x00208A5D
		public unsafe float BuoyancyStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BuoyancyStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BuoyancyStrength) = value;
			}
		}

		// Token: 0x170059BC RID: 22972
		// (get) Token: 0x06016547 RID: 91463 RVA: 0x0020A86E File Offset: 0x00208A6E
		// (set) Token: 0x06016548 RID: 91464 RVA: 0x0020A87E File Offset: 0x00208A7E
		public unsafe float BuoyancyDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BuoyancyDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BuoyancyDamping) = value;
			}
		}

		// Token: 0x170059BD RID: 22973
		// (get) Token: 0x06016549 RID: 91465 RVA: 0x0020A88F File Offset: 0x00208A8F
		// (set) Token: 0x0601654A RID: 91466 RVA: 0x0020A89F File Offset: 0x00208A9F
		public unsafe float WaveStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WaveStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WaveStrength) = value;
			}
		}

		// Token: 0x170059BE RID: 22974
		// (get) Token: 0x0601654B RID: 91467 RVA: 0x0020A8B0 File Offset: 0x00208AB0
		// (set) Token: 0x0601654C RID: 91468 RVA: 0x0020A8C0 File Offset: 0x00208AC0
		public unsafe float WaveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WaveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WaveSpeed) = value;
			}
		}

		// Token: 0x170059BF RID: 22975
		// (get) Token: 0x0601654D RID: 91469 RVA: 0x0020A8D1 File Offset: 0x00208AD1
		// (set) Token: 0x0601654E RID: 91470 RVA: 0x0020A8E1 File Offset: 0x00208AE1
		public unsafe float GravityStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_GravityStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_GravityStrength) = value;
			}
		}

		// Token: 0x170059C0 RID: 22976
		// (get) Token: 0x0601654F RID: 91471 RVA: 0x0020A8F2 File Offset: 0x00208AF2
		// (set) Token: 0x06016550 RID: 91472 RVA: 0x0020A902 File Offset: 0x00208B02
		public unsafe float AngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_AngularDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_AngularDamping) = value;
			}
		}

		// Token: 0x170059C1 RID: 22977
		// (get) Token: 0x06016551 RID: 91473 RVA: 0x0020A913 File Offset: 0x00208B13
		// (set) Token: 0x06016552 RID: 91474 RVA: 0x0020A923 File Offset: 0x00208B23
		public unsafe float MomentOfInertia
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_MomentOfInertia);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_MomentOfInertia) = value;
			}
		}

		// Token: 0x170059C2 RID: 22978
		// (get) Token: 0x06016553 RID: 91475 RVA: 0x0020A934 File Offset: 0x00208B34
		// (set) Token: 0x06016554 RID: 91476 RVA: 0x0020A944 File Offset: 0x00208B44
		public unsafe float MaxAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_MaxAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_MaxAngularVelocity) = value;
			}
		}

		// Token: 0x170059C3 RID: 22979
		// (get) Token: 0x06016555 RID: 91477 RVA: 0x0020A955 File Offset: 0x00208B55
		// (set) Token: 0x06016556 RID: 91478 RVA: 0x0020A965 File Offset: 0x00208B65
		public unsafe float MaxRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_MaxRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_MaxRotation) = value;
			}
		}

		// Token: 0x170059C4 RID: 22980
		// (get) Token: 0x06016557 RID: 91479 RVA: 0x0020A976 File Offset: 0x00208B76
		// (set) Token: 0x06016558 RID: 91480 RVA: 0x0020A986 File Offset: 0x00208B86
		public unsafe float CentrifugalForceStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_CentrifugalForceStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_CentrifugalForceStrength) = value;
			}
		}

		// Token: 0x170059C5 RID: 22981
		// (get) Token: 0x06016559 RID: 91481 RVA: 0x0020A997 File Offset: 0x00208B97
		// (set) Token: 0x0601655A RID: 91482 RVA: 0x0020A9AB File Offset: 0x00208BAB
		public unsafe FVector BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BoxExtent) = value;
			}
		}

		// Token: 0x170059C6 RID: 22982
		// (get) Token: 0x0601655B RID: 91483 RVA: 0x0020A9C0 File Offset: 0x00208BC0
		// (set) Token: 0x0601655C RID: 91484 RVA: 0x0020A9D0 File Offset: 0x00208BD0
		public unsafe float RodLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_RodLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_RodLength) = value;
			}
		}

		// Token: 0x170059C7 RID: 22983
		// (get) Token: 0x0601655D RID: 91485 RVA: 0x0020A9E1 File Offset: 0x00208BE1
		// (set) Token: 0x0601655E RID: 91486 RVA: 0x0020A9F1 File Offset: 0x00208BF1
		public unsafe float TopMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopMass) = value;
			}
		}

		// Token: 0x170059C8 RID: 22984
		// (get) Token: 0x0601655F RID: 91487 RVA: 0x0020AA02 File Offset: 0x00208C02
		// (set) Token: 0x06016560 RID: 91488 RVA: 0x0020AA12 File Offset: 0x00208C12
		public unsafe float TopDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopDamping) = value;
			}
		}

		// Token: 0x170059C9 RID: 22985
		// (get) Token: 0x06016561 RID: 91489 RVA: 0x0020AA23 File Offset: 0x00208C23
		// (set) Token: 0x06016562 RID: 91490 RVA: 0x0020AA33 File Offset: 0x00208C33
		public unsafe float UprightStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_UprightStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_UprightStiffness) = value;
			}
		}

		// Token: 0x170059CA RID: 22986
		// (get) Token: 0x06016563 RID: 91491 RVA: 0x0020AA44 File Offset: 0x00208C44
		// (set) Token: 0x06016564 RID: 91492 RVA: 0x0020AA54 File Offset: 0x00208C54
		public unsafe float BottomPlayerPushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomPlayerPushScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomPlayerPushScale) = value;
			}
		}

		// Token: 0x170059CB RID: 22987
		// (get) Token: 0x06016565 RID: 91493 RVA: 0x0020AA65 File Offset: 0x00208C65
		// (set) Token: 0x06016566 RID: 91494 RVA: 0x0020AA75 File Offset: 0x00208C75
		public unsafe float TopPlayerPushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopPlayerPushScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopPlayerPushScale) = value;
			}
		}

		// Token: 0x170059CC RID: 22988
		// (get) Token: 0x06016567 RID: 91495 RVA: 0x0020AA86 File Offset: 0x00208C86
		// (set) Token: 0x06016568 RID: 91496 RVA: 0x0020AA9A File Offset: 0x00208C9A
		public unsafe UTextureRenderTarget2D WindField
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_WindField);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxis.__PropertyOffset_WindField, value);
			}
		}

		// Token: 0x170059CD RID: 22989
		// (get) Token: 0x06016569 RID: 91497 RVA: 0x0020AAAF File Offset: 0x00208CAF
		// (set) Token: 0x0601656A RID: 91498 RVA: 0x0020AAC3 File Offset: 0x00208CC3
		public unsafe FVector WindFieldPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WindFieldPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WindFieldPos) = value;
			}
		}

		// Token: 0x170059CE RID: 22990
		// (get) Token: 0x0601656B RID: 91499 RVA: 0x0020AAD8 File Offset: 0x00208CD8
		// (set) Token: 0x0601656C RID: 91500 RVA: 0x0020AAEC File Offset: 0x00208CEC
		public unsafe FVector WindFieldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WindFieldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WindFieldSize) = value;
			}
		}

		// Token: 0x170059CF RID: 22991
		// (get) Token: 0x0601656D RID: 91501 RVA: 0x0020AB01 File Offset: 0x00208D01
		// (set) Token: 0x0601656E RID: 91502 RVA: 0x0020AB11 File Offset: 0x00208D11
		public unsafe float WindResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WindResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_WindResolution) = value;
			}
		}

		// Token: 0x170059D0 RID: 22992
		// (get) Token: 0x0601656F RID: 91503 RVA: 0x0020AB22 File Offset: 0x00208D22
		// (set) Token: 0x06016570 RID: 91504 RVA: 0x0020AB32 File Offset: 0x00208D32
		public unsafe float BottomWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomWindStrength) = value;
			}
		}

		// Token: 0x170059D1 RID: 22993
		// (get) Token: 0x06016571 RID: 91505 RVA: 0x0020AB43 File Offset: 0x00208D43
		// (set) Token: 0x06016572 RID: 91506 RVA: 0x0020AB53 File Offset: 0x00208D53
		public unsafe float TopWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopWindStrength) = value;
			}
		}

		// Token: 0x170059D2 RID: 22994
		// (get) Token: 0x06016573 RID: 91507 RVA: 0x0020AB64 File Offset: 0x00208D64
		// (set) Token: 0x06016574 RID: 91508 RVA: 0x0020AB74 File Offset: 0x00208D74
		public unsafe float BottomGDFStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomGDFStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomGDFStrength) = value;
			}
		}

		// Token: 0x170059D3 RID: 22995
		// (get) Token: 0x06016575 RID: 91509 RVA: 0x0020AB85 File Offset: 0x00208D85
		// (set) Token: 0x06016576 RID: 91510 RVA: 0x0020AB95 File Offset: 0x00208D95
		public unsafe float TopGDFStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopGDFStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopGDFStrength) = value;
			}
		}

		// Token: 0x170059D4 RID: 22996
		// (get) Token: 0x06016577 RID: 91511 RVA: 0x0020ABA6 File Offset: 0x00208DA6
		// (set) Token: 0x06016578 RID: 91512 RVA: 0x0020ABB6 File Offset: 0x00208DB6
		public unsafe float BottomGDFSafeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomGDFSafeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_BottomGDFSafeDistance) = value;
			}
		}

		// Token: 0x170059D5 RID: 22997
		// (get) Token: 0x06016579 RID: 91513 RVA: 0x0020ABC7 File Offset: 0x00208DC7
		// (set) Token: 0x0601657A RID: 91514 RVA: 0x0020ABD7 File Offset: 0x00208DD7
		public unsafe float TopGDFSafeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopGDFSafeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_TopGDFSafeDistance) = value;
			}
		}

		// Token: 0x170059D6 RID: 22998
		// (get) Token: 0x0601657B RID: 91515 RVA: 0x0020ABE8 File Offset: 0x00208DE8
		// (set) Token: 0x0601657C RID: 91516 RVA: 0x0020ABF8 File Offset: 0x00208DF8
		public unsafe bool bDebugLogGDFStatus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_bDebugLogGDFStatus) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_bDebugLogGDFStatus) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059D7 RID: 22999
		// (get) Token: 0x0601657D RID: 91517 RVA: 0x0020AC09 File Offset: 0x00208E09
		// (set) Token: 0x0601657E RID: 91518 RVA: 0x0020AC19 File Offset: 0x00208E19
		public unsafe float DebugSDFLogInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_DebugSDFLogInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxis.__PropertyOffset_DebugSDFLogInterval) = value;
			}
		}

		// Token: 0x0601657F RID: 91519 RVA: 0x0020AC2A File Offset: 0x00208E2A
		public void StopSimulation()
		{
			AKuroCSSimpleCollisionAxis.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06016580 RID: 91520 RVA: 0x0020AC37 File Offset: 0x00208E37
		public void StartSimulation()
		{
			AKuroCSSimpleCollisionAxis.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06016581 RID: 91521 RVA: 0x0020AC44 File Offset: 0x00208E44
		public void ReleaseShaderManager()
		{
			AKuroCSSimpleCollisionAxis.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06016582 RID: 91522 RVA: 0x0020AC51 File Offset: 0x00208E51
		public void InitShaderManager()
		{
			AKuroCSSimpleCollisionAxis.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06016583 RID: 91523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06016584 RID: 91524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06016585 RID: 91525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06016586 RID: 91526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x06016587 RID: 91527 RVA: 0x0020AC5E File Offset: 0x00208E5E
		static AKuroCSSimpleCollisionAxis()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSSimpleCollisionAxis");
		}

		// Token: 0x06016588 RID: 91528 RVA: 0x0020AC6C File Offset: 0x00208E6C
		protected AKuroCSSimpleCollisionAxis(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C22D RID: 49709
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSSimpleCollisionAxis";

		// Token: 0x0400C22E RID: 49710
		private static IntPtr _ClassPtr;

		// Token: 0x0400C22F RID: 49711
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C230 RID: 49712
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C231 RID: 49713
		internal static int __PropertyOffset_bEnableRendering;

		// Token: 0x0400C232 RID: 49714
		internal static int __PropertyOffset_InputTexture;

		// Token: 0x0400C233 RID: 49715
		internal static int __PropertyOffset_OutputRenderTarget;

		// Token: 0x0400C234 RID: 49716
		internal static int __PropertyOffset_AxisOutputRenderTarget;

		// Token: 0x0400C235 RID: 49717
		internal static int __PropertyOffset_BottomVelocityRenderTarget;

		// Token: 0x0400C236 RID: 49718
		internal static int __PropertyOffset_TopVelocityRenderTarget;

		// Token: 0x0400C237 RID: 49719
		internal static int __PropertyOffset_PlayerPos;

		// Token: 0x0400C238 RID: 49720
		internal static int __PropertyOffset_TargetMesh;

		// Token: 0x0400C239 RID: 49721
		internal static int __PropertyOffset_PivotPos;

		// Token: 0x0400C23A RID: 49722
		internal static int __PropertyOffset_CollisionRadiusScale;

		// Token: 0x0400C23B RID: 49723
		internal static int __PropertyOffset_PlayerPushRadius;

		// Token: 0x0400C23C RID: 49724
		internal static int __PropertyOffset_ParticleMass;

		// Token: 0x0400C23D RID: 49725
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400C23E RID: 49726
		internal static int __PropertyOffset_PlayerForceStrength;

		// Token: 0x0400C23F RID: 49727
		internal static int __PropertyOffset_CollisionForceStrength;

		// Token: 0x0400C240 RID: 49728
		internal static int __PropertyOffset_SpringStiffness;

		// Token: 0x0400C241 RID: 49729
		internal static int __PropertyOffset_MaxVelocity;

		// Token: 0x0400C242 RID: 49730
		internal static int __PropertyOffset_BuoyancyStrength;

		// Token: 0x0400C243 RID: 49731
		internal static int __PropertyOffset_BuoyancyDamping;

		// Token: 0x0400C244 RID: 49732
		internal static int __PropertyOffset_WaveStrength;

		// Token: 0x0400C245 RID: 49733
		internal static int __PropertyOffset_WaveSpeed;

		// Token: 0x0400C246 RID: 49734
		internal static int __PropertyOffset_GravityStrength;

		// Token: 0x0400C247 RID: 49735
		internal static int __PropertyOffset_AngularDamping;

		// Token: 0x0400C248 RID: 49736
		internal static int __PropertyOffset_MomentOfInertia;

		// Token: 0x0400C249 RID: 49737
		internal static int __PropertyOffset_MaxAngularVelocity;

		// Token: 0x0400C24A RID: 49738
		internal static int __PropertyOffset_MaxRotation;

		// Token: 0x0400C24B RID: 49739
		internal static int __PropertyOffset_CentrifugalForceStrength;

		// Token: 0x0400C24C RID: 49740
		internal static int __PropertyOffset_BoxExtent;

		// Token: 0x0400C24D RID: 49741
		internal static int __PropertyOffset_RodLength;

		// Token: 0x0400C24E RID: 49742
		internal static int __PropertyOffset_TopMass;

		// Token: 0x0400C24F RID: 49743
		internal static int __PropertyOffset_TopDamping;

		// Token: 0x0400C250 RID: 49744
		internal static int __PropertyOffset_UprightStiffness;

		// Token: 0x0400C251 RID: 49745
		internal static int __PropertyOffset_BottomPlayerPushScale;

		// Token: 0x0400C252 RID: 49746
		internal static int __PropertyOffset_TopPlayerPushScale;

		// Token: 0x0400C253 RID: 49747
		internal static int __PropertyOffset_WindField;

		// Token: 0x0400C254 RID: 49748
		internal static int __PropertyOffset_WindFieldPos;

		// Token: 0x0400C255 RID: 49749
		internal static int __PropertyOffset_WindFieldSize;

		// Token: 0x0400C256 RID: 49750
		internal static int __PropertyOffset_WindResolution;

		// Token: 0x0400C257 RID: 49751
		internal static int __PropertyOffset_BottomWindStrength;

		// Token: 0x0400C258 RID: 49752
		internal static int __PropertyOffset_TopWindStrength;

		// Token: 0x0400C259 RID: 49753
		internal static int __PropertyOffset_BottomGDFStrength;

		// Token: 0x0400C25A RID: 49754
		internal static int __PropertyOffset_TopGDFStrength;

		// Token: 0x0400C25B RID: 49755
		internal static int __PropertyOffset_BottomGDFSafeDistance;

		// Token: 0x0400C25C RID: 49756
		internal static int __PropertyOffset_TopGDFSafeDistance;

		// Token: 0x0400C25D RID: 49757
		internal static int __PropertyOffset_bDebugLogGDFStatus;

		// Token: 0x0400C25E RID: 49758
		internal static int __PropertyOffset_DebugSDFLogInterval;
	}
}
