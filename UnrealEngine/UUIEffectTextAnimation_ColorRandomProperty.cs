using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002152 RID: 8530
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_ColorRandomProperty")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UUIEffectTextAnimation_ColorRandomProperty : UUIEffectTextAnimation_PropertyWithEase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602029B RID: 131739 RVA: 0x002FCB92 File Offset: 0x002FAD92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_ColorRandomProperty._ClassPtr;
		}

		// Token: 0x0602029C RID: 131740 RVA: 0x002FCBA0 File Offset: 0x002FADA0
		public UUIEffectTextAnimation_ColorRandomProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ColorRandomProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602029D RID: 131741 RVA: 0x002FCBC8 File Offset: 0x002FADC8
		[NullableContext(1)]
		public UUIEffectTextAnimation_ColorRandomProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ColorRandomProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E39 RID: 32313
		// (get) Token: 0x0602029E RID: 131742 RVA: 0x002FCBFB File Offset: 0x002FADFB
		// (set) Token: 0x0602029F RID: 131743 RVA: 0x002FCC0B File Offset: 0x002FAE0B
		public unsafe int seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorRandomProperty.__PropertyOffset_seed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorRandomProperty.__PropertyOffset_seed) = value;
			}
		}

		// Token: 0x17007E3A RID: 32314
		// (get) Token: 0x060202A0 RID: 131744 RVA: 0x002FCC1C File Offset: 0x002FAE1C
		// (set) Token: 0x060202A1 RID: 131745 RVA: 0x002FCC30 File Offset: 0x002FAE30
		public unsafe FColor min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorRandomProperty.__PropertyOffset_min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorRandomProperty.__PropertyOffset_min) = value;
			}
		}

		// Token: 0x17007E3B RID: 32315
		// (get) Token: 0x060202A2 RID: 131746 RVA: 0x002FCC45 File Offset: 0x002FAE45
		// (set) Token: 0x060202A3 RID: 131747 RVA: 0x002FCC59 File Offset: 0x002FAE59
		public unsafe FColor max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorRandomProperty.__PropertyOffset_max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorRandomProperty.__PropertyOffset_max) = value;
			}
		}

		// Token: 0x17007E3C RID: 32316
		// (get) Token: 0x060202A4 RID: 131748 RVA: 0x002FCC6E File Offset: 0x002FAE6E
		// (set) Token: 0x060202A5 RID: 131749 RVA: 0x002FCC7E File Offset: 0x002FAE7E
		public unsafe bool useHSV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorRandomProperty.__PropertyOffset_useHSV) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorRandomProperty.__PropertyOffset_useHSV) = (value ? 1 : 0);
			}
		}

		// Token: 0x060202A6 RID: 131750 RVA: 0x002FCC8F File Offset: 0x002FAE8F
		public void SetUseHSV(bool value)
		{
			UUIEffectTextAnimation_ColorRandomProperty.__SetUseHSV_Internal(base.NativePtr, value);
		}

		// Token: 0x060202A7 RID: 131751 RVA: 0x002FCC9D File Offset: 0x002FAE9D
		public void SetSeed(int value)
		{
			UUIEffectTextAnimation_ColorRandomProperty.__SetSeed_Internal(base.NativePtr, value);
		}

		// Token: 0x060202A8 RID: 131752 RVA: 0x002FCCAB File Offset: 0x002FAEAB
		public void SetMin(FColor value)
		{
			UUIEffectTextAnimation_ColorRandomProperty.__SetMin_Internal(base.NativePtr, value);
		}

		// Token: 0x060202A9 RID: 131753 RVA: 0x002FCCB9 File Offset: 0x002FAEB9
		public void SetMax(FColor value)
		{
			UUIEffectTextAnimation_ColorRandomProperty.__SetMax_Internal(base.NativePtr, value);
		}

		// Token: 0x060202AA RID: 131754 RVA: 0x002FCCC7 File Offset: 0x002FAEC7
		public bool GetUseHSV()
		{
			return UUIEffectTextAnimation_ColorRandomProperty.__GetUseHSV_Internal(base.NativePtr);
		}

		// Token: 0x060202AB RID: 131755 RVA: 0x002FCCD4 File Offset: 0x002FAED4
		public int GetSeed()
		{
			return UUIEffectTextAnimation_ColorRandomProperty.__GetSeed_Internal(base.NativePtr);
		}

		// Token: 0x060202AC RID: 131756 RVA: 0x002FCCE1 File Offset: 0x002FAEE1
		public FColor GetMin()
		{
			return UUIEffectTextAnimation_ColorRandomProperty.__GetMin_Internal(base.NativePtr);
		}

		// Token: 0x060202AD RID: 131757 RVA: 0x002FCCEE File Offset: 0x002FAEEE
		public FColor GetMax()
		{
			return UUIEffectTextAnimation_ColorRandomProperty.__GetMax_Internal(base.NativePtr);
		}

		// Token: 0x060202AE RID: 131758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseHSV_Internal(IntPtr @this, bool value);

		// Token: 0x060202AF RID: 131759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSeed_Internal(IntPtr @this, int value);

		// Token: 0x060202B0 RID: 131760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMin_Internal(IntPtr @this, FColor value);

		// Token: 0x060202B1 RID: 131761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMax_Internal(IntPtr @this, FColor value);

		// Token: 0x060202B2 RID: 131762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUseHSV_Internal(IntPtr @this);

		// Token: 0x060202B3 RID: 131763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSeed_Internal(IntPtr @this);

		// Token: 0x060202B4 RID: 131764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetMin_Internal(IntPtr @this);

		// Token: 0x060202B5 RID: 131765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetMax_Internal(IntPtr @this);

		// Token: 0x060202B6 RID: 131766 RVA: 0x002FCCFB File Offset: 0x002FAEFB
		static UUIEffectTextAnimation_ColorRandomProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_ColorRandomProperty");
		}

		// Token: 0x060202B7 RID: 131767 RVA: 0x002FCD09 File Offset: 0x002FAF09
		protected UUIEffectTextAnimation_ColorRandomProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114BD RID: 70845
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_ColorRandomProperty";

		// Token: 0x040114BE RID: 70846
		private static IntPtr _ClassPtr;

		// Token: 0x040114BF RID: 70847
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114C0 RID: 70848
		internal static int __PropertyOffset_seed;

		// Token: 0x040114C1 RID: 70849
		internal static int __PropertyOffset_min;

		// Token: 0x040114C2 RID: 70850
		internal static int __PropertyOffset_max;

		// Token: 0x040114C3 RID: 70851
		internal static int __PropertyOffset_useHSV;
	}
}
