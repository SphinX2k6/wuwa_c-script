using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002154 RID: 8532
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_PositionRandomProperty")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UUIEffectTextAnimation_PositionRandomProperty : UUIEffectTextAnimation_PropertyWithEase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202C7 RID: 131783 RVA: 0x002FCE20 File Offset: 0x002FB020
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_PositionRandomProperty._ClassPtr;
		}

		// Token: 0x060202C8 RID: 131784 RVA: 0x002FCE2C File Offset: 0x002FB02C
		public UUIEffectTextAnimation_PositionRandomProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_PositionRandomProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060202C9 RID: 131785 RVA: 0x002FCE54 File Offset: 0x002FB054
		[NullableContext(1)]
		public UUIEffectTextAnimation_PositionRandomProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_PositionRandomProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E40 RID: 32320
		// (get) Token: 0x060202CA RID: 131786 RVA: 0x002FCE87 File Offset: 0x002FB087
		// (set) Token: 0x060202CB RID: 131787 RVA: 0x002FCE97 File Offset: 0x002FB097
		public unsafe int seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionRandomProperty.__PropertyOffset_seed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionRandomProperty.__PropertyOffset_seed) = value;
			}
		}

		// Token: 0x17007E41 RID: 32321
		// (get) Token: 0x060202CC RID: 131788 RVA: 0x002FCEA8 File Offset: 0x002FB0A8
		// (set) Token: 0x060202CD RID: 131789 RVA: 0x002FCEBC File Offset: 0x002FB0BC
		public unsafe FVector min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionRandomProperty.__PropertyOffset_min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionRandomProperty.__PropertyOffset_min) = value;
			}
		}

		// Token: 0x17007E42 RID: 32322
		// (get) Token: 0x060202CE RID: 131790 RVA: 0x002FCED1 File Offset: 0x002FB0D1
		// (set) Token: 0x060202CF RID: 131791 RVA: 0x002FCEE5 File Offset: 0x002FB0E5
		public unsafe FVector max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionRandomProperty.__PropertyOffset_max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionRandomProperty.__PropertyOffset_max) = value;
			}
		}

		// Token: 0x060202D0 RID: 131792 RVA: 0x002FCEFA File Offset: 0x002FB0FA
		public void SetSeed(int value)
		{
			UUIEffectTextAnimation_PositionRandomProperty.__SetSeed_Internal(base.NativePtr, value);
		}

		// Token: 0x060202D1 RID: 131793 RVA: 0x002FCF08 File Offset: 0x002FB108
		public void SetMin(FVector value)
		{
			UUIEffectTextAnimation_PositionRandomProperty.__SetMin_Internal(base.NativePtr, value);
		}

		// Token: 0x060202D2 RID: 131794 RVA: 0x002FCF16 File Offset: 0x002FB116
		public void SetMax(FVector value)
		{
			UUIEffectTextAnimation_PositionRandomProperty.__SetMax_Internal(base.NativePtr, value);
		}

		// Token: 0x060202D3 RID: 131795 RVA: 0x002FCF24 File Offset: 0x002FB124
		public int GetSeed()
		{
			return UUIEffectTextAnimation_PositionRandomProperty.__GetSeed_Internal(base.NativePtr);
		}

		// Token: 0x060202D4 RID: 131796 RVA: 0x002FCF31 File Offset: 0x002FB131
		public FVector GetMin()
		{
			return UUIEffectTextAnimation_PositionRandomProperty.__GetMin_Internal(base.NativePtr);
		}

		// Token: 0x060202D5 RID: 131797 RVA: 0x002FCF3E File Offset: 0x002FB13E
		public FVector GetMax()
		{
			return UUIEffectTextAnimation_PositionRandomProperty.__GetMax_Internal(base.NativePtr);
		}

		// Token: 0x060202D6 RID: 131798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSeed_Internal(IntPtr @this, int value);

		// Token: 0x060202D7 RID: 131799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMin_Internal(IntPtr @this, FVector value);

		// Token: 0x060202D8 RID: 131800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMax_Internal(IntPtr @this, FVector value);

		// Token: 0x060202D9 RID: 131801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSeed_Internal(IntPtr @this);

		// Token: 0x060202DA RID: 131802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetMin_Internal(IntPtr @this);

		// Token: 0x060202DB RID: 131803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetMax_Internal(IntPtr @this);

		// Token: 0x060202DC RID: 131804 RVA: 0x002FCF4B File Offset: 0x002FB14B
		static UUIEffectTextAnimation_PositionRandomProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_PositionRandomProperty");
		}

		// Token: 0x060202DD RID: 131805 RVA: 0x002FCF59 File Offset: 0x002FB159
		protected UUIEffectTextAnimation_PositionRandomProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114CA RID: 70858
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_PositionRandomProperty";

		// Token: 0x040114CB RID: 70859
		private static IntPtr _ClassPtr;

		// Token: 0x040114CC RID: 70860
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114CD RID: 70861
		internal static int __PropertyOffset_seed;

		// Token: 0x040114CE RID: 70862
		internal static int __PropertyOffset_min;

		// Token: 0x040114CF RID: 70863
		internal static int __PropertyOffset_max;
	}
}
