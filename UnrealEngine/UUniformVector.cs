using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012C2 RID: 4802
	[UnrealObjectPath("/Script/FieldSystemEngine.UniformVector")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UUniformVector : UFieldNodeVector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011939 RID: 71993 RVA: 0x0019C86A File Offset: 0x0019AA6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUniformVector._ClassPtr;
		}

		// Token: 0x0601193A RID: 71994 RVA: 0x0019C878 File Offset: 0x0019AA78
		public UUniformVector() : this(BuiltinUtils.AllocNativeUObject(UUniformVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601193B RID: 71995 RVA: 0x0019C8A0 File Offset: 0x0019AAA0
		[NullableContext(1)]
		public UUniformVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUniformVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004490 RID: 17552
		// (get) Token: 0x0601193C RID: 71996 RVA: 0x0019C8D3 File Offset: 0x0019AAD3
		// (set) Token: 0x0601193D RID: 71997 RVA: 0x0019C8E3 File Offset: 0x0019AAE3
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformVector.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformVector.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x17004491 RID: 17553
		// (get) Token: 0x0601193E RID: 71998 RVA: 0x0019C8F4 File Offset: 0x0019AAF4
		// (set) Token: 0x0601193F RID: 71999 RVA: 0x0019C908 File Offset: 0x0019AB08
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformVector.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformVector.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x06011940 RID: 72000 RVA: 0x0019C91D File Offset: 0x0019AB1D
		[NullableContext(2)]
		public UUniformVector SetUniformVector(float Magnitude, FVector Direction)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUniformVector>(UUniformVector.__SetUniformVector_Internal(base.NativePtr, Magnitude, Direction));
		}

		// Token: 0x06011941 RID: 72001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetUniformVector_Internal(IntPtr @this, float Magnitude, FVector Direction);

		// Token: 0x06011942 RID: 72002 RVA: 0x0019C931 File Offset: 0x0019AB31
		static UUniformVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.UniformVector");
		}

		// Token: 0x06011943 RID: 72003 RVA: 0x0019C93F File Offset: 0x0019AB3F
		protected UUniformVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400969C RID: 38556
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.UniformVector";

		// Token: 0x0400969D RID: 38557
		private static IntPtr _ClassPtr;

		// Token: 0x0400969E RID: 38558
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400969F RID: 38559
		internal static int __PropertyOffset_Magnitude;

		// Token: 0x040096A0 RID: 38560
		internal static int __PropertyOffset_Direction;
	}
}
