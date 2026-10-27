using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B6 RID: 4790
	[UnrealObjectPath("/Script/FieldSystemEngine.NoiseField")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UNoiseField : UFieldNodeFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060118A1 RID: 71841 RVA: 0x0019BC17 File Offset: 0x00199E17
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNoiseField._ClassPtr;
		}

		// Token: 0x060118A2 RID: 71842 RVA: 0x0019BC24 File Offset: 0x00199E24
		public UNoiseField() : this(BuiltinUtils.AllocNativeUObject(UNoiseField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060118A3 RID: 71843 RVA: 0x0019BC4C File Offset: 0x00199E4C
		[NullableContext(1)]
		public UNoiseField(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNoiseField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700446E RID: 17518
		// (get) Token: 0x060118A4 RID: 71844 RVA: 0x0019BC7F File Offset: 0x00199E7F
		// (set) Token: 0x060118A5 RID: 71845 RVA: 0x0019BC8F File Offset: 0x00199E8F
		public unsafe float MinRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNoiseField.__PropertyOffset_MinRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNoiseField.__PropertyOffset_MinRange) = value;
			}
		}

		// Token: 0x1700446F RID: 17519
		// (get) Token: 0x060118A6 RID: 71846 RVA: 0x0019BCA0 File Offset: 0x00199EA0
		// (set) Token: 0x060118A7 RID: 71847 RVA: 0x0019BCB0 File Offset: 0x00199EB0
		public unsafe float MaxRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNoiseField.__PropertyOffset_MaxRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNoiseField.__PropertyOffset_MaxRange) = value;
			}
		}

		// Token: 0x17004470 RID: 17520
		// (get) Token: 0x060118A8 RID: 71848 RVA: 0x0019BCC1 File Offset: 0x00199EC1
		// (set) Token: 0x060118A9 RID: 71849 RVA: 0x0019BCD5 File Offset: 0x00199ED5
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNoiseField.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNoiseField.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x060118AA RID: 71850 RVA: 0x0019BCEC File Offset: 0x00199EEC
		[NullableContext(2)]
		public unsafe UNoiseField SetNoiseField(float MinRange, float MaxRange, FTransform Transform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNoiseField>(UNoiseField.__SetNoiseField_Internal(base.NativePtr, MinRange, MaxRange, ptr));
		}

		// Token: 0x060118AB RID: 71851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetNoiseField_Internal(IntPtr @this, float MinRange, float MaxRange, in FTransform Transform);

		// Token: 0x060118AC RID: 71852 RVA: 0x0019BD23 File Offset: 0x00199F23
		static UNoiseField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.NoiseField");
		}

		// Token: 0x060118AD RID: 71853 RVA: 0x0019BD31 File Offset: 0x00199F31
		protected UNoiseField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009656 RID: 38486
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.NoiseField";

		// Token: 0x04009657 RID: 38487
		private static IntPtr _ClassPtr;

		// Token: 0x04009658 RID: 38488
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009659 RID: 38489
		internal static int __PropertyOffset_MinRange;

		// Token: 0x0400965A RID: 38490
		internal static int __PropertyOffset_MaxRange;

		// Token: 0x0400965B RID: 38491
		internal static int __PropertyOffset_Transform;
	}
}
