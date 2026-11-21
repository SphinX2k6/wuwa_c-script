using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002AF RID: 687
	[UnrealObjectPath("/Script/Engine.WindDirectionalSourceComponent")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UWindDirectionalSourceComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004A47 RID: 19015 RVA: 0x0006801D File Offset: 0x0006621D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWindDirectionalSourceComponent._ClassPtr;
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x0006802C File Offset: 0x0006622C
		public UWindDirectionalSourceComponent() : this(BuiltinUtils.AllocNativeUObject(UWindDirectionalSourceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x00068054 File Offset: 0x00066254
		[NullableContext(1)]
		public UWindDirectionalSourceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWindDirectionalSourceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06004A4A RID: 19018 RVA: 0x00068087 File Offset: 0x00066287
		// (set) Token: 0x06004A4B RID: 19019 RVA: 0x00068097 File Offset: 0x00066297
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

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x000680A8 File Offset: 0x000662A8
		// (set) Token: 0x06004A4D RID: 19021 RVA: 0x000680B8 File Offset: 0x000662B8
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

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x000680C9 File Offset: 0x000662C9
		// (set) Token: 0x06004A4F RID: 19023 RVA: 0x000680D9 File Offset: 0x000662D9
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

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06004A50 RID: 19024 RVA: 0x000680EA File Offset: 0x000662EA
		// (set) Token: 0x06004A51 RID: 19025 RVA: 0x000680FA File Offset: 0x000662FA
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

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x0006810B File Offset: 0x0006630B
		// (set) Token: 0x06004A53 RID: 19027 RVA: 0x0006811B File Offset: 0x0006631B
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

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06004A54 RID: 19028 RVA: 0x0006812C File Offset: 0x0006632C
		// (set) Token: 0x06004A55 RID: 19029 RVA: 0x00068145 File Offset: 0x00066345
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

		// Token: 0x06004A56 RID: 19030 RVA: 0x00068175 File Offset: 0x00066375
		public void UpdateWindParam(float NewStrength, float NewSpeed, float NewMInGust, float NewMaxGust)
		{
			UWindDirectionalSourceComponent.__UpdateWindParam_Internal(base.NativePtr, NewStrength, NewSpeed, NewMInGust, NewMaxGust);
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x00068187 File Offset: 0x00066387
		public void SetWindType(EWindSourceType InNewType)
		{
			UWindDirectionalSourceComponent.__SetWindType_Internal(base.NativePtr, InNewType);
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x00068195 File Offset: 0x00066395
		public void SetStrength(float InNewStrength)
		{
			UWindDirectionalSourceComponent.__SetStrength_Internal(base.NativePtr, InNewStrength);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x000681A3 File Offset: 0x000663A3
		public void SetSpeed(float InNewSpeed)
		{
			UWindDirectionalSourceComponent.__SetSpeed_Internal(base.NativePtr, InNewSpeed);
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x000681B1 File Offset: 0x000663B1
		public void SetRadius(float InNewRadius)
		{
			UWindDirectionalSourceComponent.__SetRadius_Internal(base.NativePtr, InNewRadius);
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x000681BF File Offset: 0x000663BF
		public void SetMinimumGustAmount(float InNewMinGust)
		{
			UWindDirectionalSourceComponent.__SetMinimumGustAmount_Internal(base.NativePtr, InNewMinGust);
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x000681CD File Offset: 0x000663CD
		public void SetMaximumGustAmount(float InNewMaxGust)
		{
			UWindDirectionalSourceComponent.__SetMaximumGustAmount_Internal(base.NativePtr, InNewMaxGust);
		}

		// Token: 0x06004A5D RID: 19037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWindParam_Internal(IntPtr @this, float NewStrength, float NewSpeed, float NewMInGust, float NewMaxGust);

		// Token: 0x06004A5E RID: 19038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindType_Internal(IntPtr @this, EWindSourceType InNewType);

		// Token: 0x06004A5F RID: 19039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStrength_Internal(IntPtr @this, float InNewStrength);

		// Token: 0x06004A60 RID: 19040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpeed_Internal(IntPtr @this, float InNewSpeed);

		// Token: 0x06004A61 RID: 19041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRadius_Internal(IntPtr @this, float InNewRadius);

		// Token: 0x06004A62 RID: 19042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinimumGustAmount_Internal(IntPtr @this, float InNewMinGust);

		// Token: 0x06004A63 RID: 19043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaximumGustAmount_Internal(IntPtr @this, float InNewMaxGust);

		// Token: 0x06004A64 RID: 19044 RVA: 0x000681DB File Offset: 0x000663DB
		static UWindDirectionalSourceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WindDirectionalSourceComponent");
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x000681E9 File Offset: 0x000663E9
		protected UWindDirectionalSourceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D48 RID: 7496
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WindDirectionalSourceComponent";

		// Token: 0x04001D49 RID: 7497
		private static IntPtr _ClassPtr;

		// Token: 0x04001D4A RID: 7498
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D4B RID: 7499
		internal static int __PropertyOffset_Strength;

		// Token: 0x04001D4C RID: 7500
		internal static int __PropertyOffset_Speed;

		// Token: 0x04001D4D RID: 7501
		internal static int __PropertyOffset_MinGustAmount;

		// Token: 0x04001D4E RID: 7502
		internal static int __PropertyOffset_MaxGustAmount;

		// Token: 0x04001D4F RID: 7503
		internal static int __PropertyOffset_Radius;

		// Token: 0x04001D50 RID: 7504
		internal static int __PropertyOffset_bPointWind;

		// Token: 0x04001D51 RID: 7505
		internal static byte __PropertyMask_bPointWind;
	}
}
