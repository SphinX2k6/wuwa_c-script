using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012BB RID: 4795
	[UnrealObjectPath("/Script/FieldSystemEngine.RadialVector")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class URadialVector : UFieldNodeVector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060118FA RID: 71930 RVA: 0x0019C349 File Offset: 0x0019A549
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URadialVector._ClassPtr;
		}

		// Token: 0x060118FB RID: 71931 RVA: 0x0019C358 File Offset: 0x0019A558
		public URadialVector() : this(BuiltinUtils.AllocNativeUObject(URadialVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060118FC RID: 71932 RVA: 0x0019C380 File Offset: 0x0019A580
		[NullableContext(1)]
		public URadialVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URadialVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004489 RID: 17545
		// (get) Token: 0x060118FD RID: 71933 RVA: 0x0019C3B3 File Offset: 0x0019A5B3
		// (set) Token: 0x060118FE RID: 71934 RVA: 0x0019C3C3 File Offset: 0x0019A5C3
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialVector.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialVector.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x1700448A RID: 17546
		// (get) Token: 0x060118FF RID: 71935 RVA: 0x0019C3D4 File Offset: 0x0019A5D4
		// (set) Token: 0x06011900 RID: 71936 RVA: 0x0019C3E8 File Offset: 0x0019A5E8
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialVector.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialVector.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x06011901 RID: 71937 RVA: 0x0019C3FD File Offset: 0x0019A5FD
		[NullableContext(2)]
		public URadialVector SetRadialVector(float Magnitude, FVector Position)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<URadialVector>(URadialVector.__SetRadialVector_Internal(base.NativePtr, Magnitude, Position));
		}

		// Token: 0x06011902 RID: 71938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetRadialVector_Internal(IntPtr @this, float Magnitude, FVector Position);

		// Token: 0x06011903 RID: 71939 RVA: 0x0019C411 File Offset: 0x0019A611
		static URadialVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.RadialVector");
		}

		// Token: 0x06011904 RID: 71940 RVA: 0x0019C41F File Offset: 0x0019A61F
		protected URadialVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009680 RID: 38528
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.RadialVector";

		// Token: 0x04009681 RID: 38529
		private static IntPtr _ClassPtr;

		// Token: 0x04009682 RID: 38530
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009683 RID: 38531
		internal static int __PropertyOffset_Magnitude;

		// Token: 0x04009684 RID: 38532
		internal static int __PropertyOffset_Position;
	}
}
