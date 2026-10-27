using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000915 RID: 2325
	[UnrealObjectPath("/Script/Engine.CameraShakeSourceComponent")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class UCameraShakeSourceComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007FED RID: 32749 RVA: 0x000B7527 File Offset: 0x000B5727
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraShakeSourceComponent._ClassPtr;
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x000B7534 File Offset: 0x000B5734
		public UCameraShakeSourceComponent() : this(BuiltinUtils.AllocNativeUObject(UCameraShakeSourceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x000B755C File Offset: 0x000B575C
		[NullableContext(1)]
		public UCameraShakeSourceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraShakeSourceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x06007FF0 RID: 32752 RVA: 0x000B758F File Offset: 0x000B578F
		// (set) Token: 0x06007FF1 RID: 32753 RVA: 0x000B759F File Offset: 0x000B579F
		public unsafe ECameraShakeAttenuation Attenuation
		{
			get
			{
				return (ECameraShakeAttenuation)(*(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_Attenuation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_Attenuation) = (byte)value;
			}
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x06007FF2 RID: 32754 RVA: 0x000B75B0 File Offset: 0x000B57B0
		// (set) Token: 0x06007FF3 RID: 32755 RVA: 0x000B75C0 File Offset: 0x000B57C0
		public unsafe float InnerAttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_InnerAttenuationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_InnerAttenuationRadius) = value;
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x06007FF4 RID: 32756 RVA: 0x000B75D1 File Offset: 0x000B57D1
		// (set) Token: 0x06007FF5 RID: 32757 RVA: 0x000B75E1 File Offset: 0x000B57E1
		public unsafe float OuterAttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_OuterAttenuationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_OuterAttenuationRadius) = value;
			}
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x06007FF6 RID: 32758 RVA: 0x000B75F2 File Offset: 0x000B57F2
		// (set) Token: 0x06007FF7 RID: 32759 RVA: 0x000B7606 File Offset: 0x000B5806
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UCameraShakeBase> CameraShake
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_CameraShake);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_CameraShake) = value;
			}
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x06007FF8 RID: 32760 RVA: 0x000B761B File Offset: 0x000B581B
		// (set) Token: 0x06007FF9 RID: 32761 RVA: 0x000B762B File Offset: 0x000B582B
		public unsafe bool bAutoStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_bAutoStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraShakeSourceComponent.__PropertyOffset_bAutoStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x000B763C File Offset: 0x000B583C
		public void StopAllCameraShakesOfType([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> InCameraShake, bool bImmediately = true)
		{
			UCameraShakeSourceComponent.__StopAllCameraShakesOfType_Internal(base.NativePtr, InCameraShake._NativePtr, bImmediately);
		}

		// Token: 0x06007FFB RID: 32763 RVA: 0x000B7650 File Offset: 0x000B5850
		public void StopAllCameraShakes(bool bImmediately = true)
		{
			UCameraShakeSourceComponent.__StopAllCameraShakes_Internal(base.NativePtr, bImmediately);
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x000B765E File Offset: 0x000B585E
		public void StartCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> InCameraShake, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator))
		{
			UCameraShakeSourceComponent.__StartCameraShake_Internal(base.NativePtr, InCameraShake._NativePtr, Scale, PlaySpace, UserPlaySpaceRot);
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x000B7675 File Offset: 0x000B5875
		public void Start()
		{
			UCameraShakeSourceComponent.__Start_Internal(base.NativePtr);
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x000B7682 File Offset: 0x000B5882
		public float GetAttenuationFactor(in FVector Location)
		{
			return UCameraShakeSourceComponent.__GetAttenuationFactor_Internal(base.NativePtr, Location);
		}

		// Token: 0x06007FFF RID: 32767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllCameraShakesOfType_Internal(IntPtr @this, IntPtr InCameraShake, bool bImmediately);

		// Token: 0x06008000 RID: 32768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllCameraShakes_Internal(IntPtr @this, bool bImmediately);

		// Token: 0x06008001 RID: 32769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartCameraShake_Internal(IntPtr @this, IntPtr InCameraShake, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot);

		// Token: 0x06008002 RID: 32770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this);

		// Token: 0x06008003 RID: 32771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAttenuationFactor_Internal(IntPtr @this, in FVector Location);

		// Token: 0x06008004 RID: 32772 RVA: 0x000B7690 File Offset: 0x000B5890
		static UCameraShakeSourceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraShakeSourceComponent");
		}

		// Token: 0x06008005 RID: 32773 RVA: 0x000B769E File Offset: 0x000B589E
		protected UCameraShakeSourceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D53 RID: 15699
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraShakeSourceComponent";

		// Token: 0x04003D54 RID: 15700
		private static IntPtr _ClassPtr;

		// Token: 0x04003D55 RID: 15701
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D56 RID: 15702
		internal static int __PropertyOffset_Attenuation;

		// Token: 0x04003D57 RID: 15703
		internal static int __PropertyOffset_InnerAttenuationRadius;

		// Token: 0x04003D58 RID: 15704
		internal static int __PropertyOffset_OuterAttenuationRadius;

		// Token: 0x04003D59 RID: 15705
		internal static int __PropertyOffset_CameraShake;

		// Token: 0x04003D5A RID: 15706
		internal static int __PropertyOffset_bAutoStart;
	}
}
