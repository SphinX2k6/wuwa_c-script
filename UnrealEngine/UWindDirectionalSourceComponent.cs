using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001248 RID: 4680
	[UnrealObjectPath("/Script/Engine.WindDirectionalSourceComponent")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UWindDirectionalSourceComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011321 RID: 70433 RVA: 0x00193A9F File Offset: 0x00191C9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWindDirectionalSourceComponent._ClassPtr;
		}

		// Token: 0x06011322 RID: 70434 RVA: 0x00193AAC File Offset: 0x00191CAC
		public UWindDirectionalSourceComponent() : this(BuiltinUtils.AllocNativeUObject(UWindDirectionalSourceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011323 RID: 70435 RVA: 0x00193AD4 File Offset: 0x00191CD4
		[NullableContext(1)]
		public UWindDirectionalSourceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWindDirectionalSourceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004303 RID: 17155
		// (get) Token: 0x06011324 RID: 70436 RVA: 0x00193B07 File Offset: 0x00191D07
		// (set) Token: 0x06011325 RID: 70437 RVA: 0x00193B17 File Offset: 0x00191D17
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x17004304 RID: 17156
		// (get) Token: 0x06011326 RID: 70438 RVA: 0x00193B28 File Offset: 0x00191D28
		// (set) Token: 0x06011327 RID: 70439 RVA: 0x00193B38 File Offset: 0x00191D38
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x17004305 RID: 17157
		// (get) Token: 0x06011328 RID: 70440 RVA: 0x00193B49 File Offset: 0x00191D49
		// (set) Token: 0x06011329 RID: 70441 RVA: 0x00193B59 File Offset: 0x00191D59
		public unsafe float MinGustAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_MinGustAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_MinGustAmount) = value;
			}
		}

		// Token: 0x17004306 RID: 17158
		// (get) Token: 0x0601132A RID: 70442 RVA: 0x00193B6A File Offset: 0x00191D6A
		// (set) Token: 0x0601132B RID: 70443 RVA: 0x00193B7A File Offset: 0x00191D7A
		public unsafe float MaxGustAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_MaxGustAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_MaxGustAmount) = value;
			}
		}

		// Token: 0x17004307 RID: 17159
		// (get) Token: 0x0601132C RID: 70444 RVA: 0x00193B8B File Offset: 0x00191D8B
		// (set) Token: 0x0601132D RID: 70445 RVA: 0x00193B9B File Offset: 0x00191D9B
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004308 RID: 17160
		// (get) Token: 0x0601132E RID: 70446 RVA: 0x00193BAC File Offset: 0x00191DAC
		// (set) Token: 0x0601132F RID: 70447 RVA: 0x00193BC5 File Offset: 0x00191DC5
		public unsafe bool bPointWind
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_bPointWind) & UWindDirectionalSourceComponent.__PropertyMask_bPointWind) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_bPointWind) = ((*(base.NativePtr + (IntPtr)UWindDirectionalSourceComponent.__PropertyOffset_bPointWind) & ~UWindDirectionalSourceComponent.__PropertyMask_bPointWind) | (value ? UWindDirectionalSourceComponent.__PropertyMask_bPointWind : 0));
			}
		}

		// Token: 0x06011330 RID: 70448 RVA: 0x00193BF5 File Offset: 0x00191DF5
		public void UpdateWindParam(float NewStrength, float NewSpeed, float NewMInGust, float NewMaxGust)
		{
			UWindDirectionalSourceComponent.__UpdateWindParam_Internal(base.NativePtr, NewStrength, NewSpeed, NewMInGust, NewMaxGust);
		}

		// Token: 0x06011331 RID: 70449 RVA: 0x00193C07 File Offset: 0x00191E07
		public void SetWindType(EWindSourceType InNewType)
		{
			UWindDirectionalSourceComponent.__SetWindType_Internal(base.NativePtr, InNewType);
		}

		// Token: 0x06011332 RID: 70450 RVA: 0x00193C15 File Offset: 0x00191E15
		public void SetStrength(float InNewStrength)
		{
			UWindDirectionalSourceComponent.__SetStrength_Internal(base.NativePtr, InNewStrength);
		}

		// Token: 0x06011333 RID: 70451 RVA: 0x00193C23 File Offset: 0x00191E23
		public void SetSpeed(float InNewSpeed)
		{
			UWindDirectionalSourceComponent.__SetSpeed_Internal(base.NativePtr, InNewSpeed);
		}

		// Token: 0x06011334 RID: 70452 RVA: 0x00193C31 File Offset: 0x00191E31
		public void SetRadius(float InNewRadius)
		{
			UWindDirectionalSourceComponent.__SetRadius_Internal(base.NativePtr, InNewRadius);
		}

		// Token: 0x06011335 RID: 70453 RVA: 0x00193C3F File Offset: 0x00191E3F
		public void SetMinimumGustAmount(float InNewMinGust)
		{
			UWindDirectionalSourceComponent.__SetMinimumGustAmount_Internal(base.NativePtr, InNewMinGust);
		}

		// Token: 0x06011336 RID: 70454 RVA: 0x00193C4D File Offset: 0x00191E4D
		public void SetMaximumGustAmount(float InNewMaxGust)
		{
			UWindDirectionalSourceComponent.__SetMaximumGustAmount_Internal(base.NativePtr, InNewMaxGust);
		}

		// Token: 0x06011337 RID: 70455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWindParam_Internal(IntPtr @this, float NewStrength, float NewSpeed, float NewMInGust, float NewMaxGust);

		// Token: 0x06011338 RID: 70456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindType_Internal(IntPtr @this, EWindSourceType InNewType);

		// Token: 0x06011339 RID: 70457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStrength_Internal(IntPtr @this, float InNewStrength);

		// Token: 0x0601133A RID: 70458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpeed_Internal(IntPtr @this, float InNewSpeed);

		// Token: 0x0601133B RID: 70459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRadius_Internal(IntPtr @this, float InNewRadius);

		// Token: 0x0601133C RID: 70460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinimumGustAmount_Internal(IntPtr @this, float InNewMinGust);

		// Token: 0x0601133D RID: 70461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaximumGustAmount_Internal(IntPtr @this, float InNewMaxGust);

		// Token: 0x0601133E RID: 70462 RVA: 0x00193C5B File Offset: 0x00191E5B
		static UWindDirectionalSourceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WindDirectionalSourceComponent");
		}

		// Token: 0x0601133F RID: 70463 RVA: 0x00193C69 File Offset: 0x00191E69
		protected UWindDirectionalSourceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009320 RID: 37664
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WindDirectionalSourceComponent";

		// Token: 0x04009321 RID: 37665
		private static IntPtr _ClassPtr;

		// Token: 0x04009322 RID: 37666
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009323 RID: 37667
		internal static int __PropertyOffset_Strength;

		// Token: 0x04009324 RID: 37668
		internal static int __PropertyOffset_Speed;

		// Token: 0x04009325 RID: 37669
		internal static int __PropertyOffset_MinGustAmount;

		// Token: 0x04009326 RID: 37670
		internal static int __PropertyOffset_MaxGustAmount;

		// Token: 0x04009327 RID: 37671
		internal static int __PropertyOffset_Radius;

		// Token: 0x04009328 RID: 37672
		internal static int __PropertyOffset_bPointWind;

		// Token: 0x04009329 RID: 37673
		internal static byte __PropertyMask_bPointWind;
	}
}
