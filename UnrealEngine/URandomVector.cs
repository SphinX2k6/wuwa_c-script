using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012BC RID: 4796
	[UnrealObjectPath("/Script/FieldSystemEngine.RandomVector")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class URandomVector : UFieldNodeVector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011905 RID: 71941 RVA: 0x0019C428 File Offset: 0x0019A628
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URandomVector._ClassPtr;
		}

		// Token: 0x06011906 RID: 71942 RVA: 0x0019C434 File Offset: 0x0019A634
		public URandomVector() : this(BuiltinUtils.AllocNativeUObject(URandomVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011907 RID: 71943 RVA: 0x0019C45C File Offset: 0x0019A65C
		[NullableContext(1)]
		public URandomVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URandomVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700448B RID: 17547
		// (get) Token: 0x06011908 RID: 71944 RVA: 0x0019C48F File Offset: 0x0019A68F
		// (set) Token: 0x06011909 RID: 71945 RVA: 0x0019C49F File Offset: 0x0019A69F
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URandomVector.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URandomVector.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x0601190A RID: 71946 RVA: 0x0019C4B0 File Offset: 0x0019A6B0
		[NullableContext(2)]
		public URandomVector SetRandomVector(float Magnitude)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<URandomVector>(URandomVector.__SetRandomVector_Internal(base.NativePtr, Magnitude));
		}

		// Token: 0x0601190B RID: 71947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetRandomVector_Internal(IntPtr @this, float Magnitude);

		// Token: 0x0601190C RID: 71948 RVA: 0x0019C4C3 File Offset: 0x0019A6C3
		static URandomVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.RandomVector");
		}

		// Token: 0x0601190D RID: 71949 RVA: 0x0019C4D1 File Offset: 0x0019A6D1
		protected URandomVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009685 RID: 38533
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.RandomVector";

		// Token: 0x04009686 RID: 38534
		private static IntPtr _ClassPtr;

		// Token: 0x04009687 RID: 38535
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009688 RID: 38536
		internal static int __PropertyOffset_Magnitude;
	}
}
