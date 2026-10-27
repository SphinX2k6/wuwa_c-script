using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012C1 RID: 4801
	[UnrealObjectPath("/Script/FieldSystemEngine.UniformScalar")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UUniformScalar : UFieldNodeFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011930 RID: 71984 RVA: 0x0019C7B6 File Offset: 0x0019A9B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUniformScalar._ClassPtr;
		}

		// Token: 0x06011931 RID: 71985 RVA: 0x0019C7C4 File Offset: 0x0019A9C4
		public UUniformScalar() : this(BuiltinUtils.AllocNativeUObject(UUniformScalar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011932 RID: 71986 RVA: 0x0019C7EC File Offset: 0x0019A9EC
		[NullableContext(1)]
		public UUniformScalar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUniformScalar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700448F RID: 17551
		// (get) Token: 0x06011933 RID: 71987 RVA: 0x0019C81F File Offset: 0x0019AA1F
		// (set) Token: 0x06011934 RID: 71988 RVA: 0x0019C82F File Offset: 0x0019AA2F
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformScalar.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformScalar.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x06011935 RID: 71989 RVA: 0x0019C840 File Offset: 0x0019AA40
		[NullableContext(2)]
		public UUniformScalar SetUniformScalar(float Magnitude)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUniformScalar>(UUniformScalar.__SetUniformScalar_Internal(base.NativePtr, Magnitude));
		}

		// Token: 0x06011936 RID: 71990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetUniformScalar_Internal(IntPtr @this, float Magnitude);

		// Token: 0x06011937 RID: 71991 RVA: 0x0019C853 File Offset: 0x0019AA53
		static UUniformScalar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.UniformScalar");
		}

		// Token: 0x06011938 RID: 71992 RVA: 0x0019C861 File Offset: 0x0019AA61
		protected UUniformScalar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009698 RID: 38552
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.UniformScalar";

		// Token: 0x04009699 RID: 38553
		private static IntPtr _ClassPtr;

		// Token: 0x0400969A RID: 38554
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400969B RID: 38555
		internal static int __PropertyOffset_Magnitude;
	}
}
