using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002161 RID: 8545
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_ScaleWaveProperty")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UUIEffectTextAnimation_ScaleWaveProperty : UUIEffectTextAnimation_PropertyWithWave, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060203AB RID: 132011 RVA: 0x002FDB56 File Offset: 0x002FBD56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_ScaleWaveProperty._ClassPtr;
		}

		// Token: 0x060203AC RID: 132012 RVA: 0x002FDB64 File Offset: 0x002FBD64
		public UUIEffectTextAnimation_ScaleWaveProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ScaleWaveProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060203AD RID: 132013 RVA: 0x002FDB8C File Offset: 0x002FBD8C
		[NullableContext(1)]
		public UUIEffectTextAnimation_ScaleWaveProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ScaleWaveProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E5F RID: 32351
		// (get) Token: 0x060203AE RID: 132014 RVA: 0x002FDBBF File Offset: 0x002FBDBF
		// (set) Token: 0x060203AF RID: 132015 RVA: 0x002FDBD3 File Offset: 0x002FBDD3
		public unsafe FVector scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleWaveProperty.__PropertyOffset_scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleWaveProperty.__PropertyOffset_scale) = value;
			}
		}

		// Token: 0x060203B0 RID: 132016 RVA: 0x002FDBE8 File Offset: 0x002FBDE8
		public void SetScale(FVector value)
		{
			UUIEffectTextAnimation_ScaleWaveProperty.__SetScale_Internal(base.NativePtr, value);
		}

		// Token: 0x060203B1 RID: 132017 RVA: 0x002FDBF6 File Offset: 0x002FBDF6
		public FVector GetScale()
		{
			return UUIEffectTextAnimation_ScaleWaveProperty.__GetScale_Internal(base.NativePtr);
		}

		// Token: 0x060203B2 RID: 132018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScale_Internal(IntPtr @this, FVector value);

		// Token: 0x060203B3 RID: 132019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScale_Internal(IntPtr @this);

		// Token: 0x060203B4 RID: 132020 RVA: 0x002FDC03 File Offset: 0x002FBE03
		static UUIEffectTextAnimation_ScaleWaveProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_ScaleWaveProperty");
		}

		// Token: 0x060203B5 RID: 132021 RVA: 0x002FDC11 File Offset: 0x002FBE11
		protected UUIEffectTextAnimation_ScaleWaveProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011510 RID: 70928
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_ScaleWaveProperty";

		// Token: 0x04011511 RID: 70929
		private static IntPtr _ClassPtr;

		// Token: 0x04011512 RID: 70930
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011513 RID: 70931
		internal static int __PropertyOffset_scale;
	}
}
