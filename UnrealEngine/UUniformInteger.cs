using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012C0 RID: 4800
	[UnrealObjectPath("/Script/FieldSystemEngine.UniformInteger")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UUniformInteger : UFieldNodeInt, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011927 RID: 71975 RVA: 0x0019C701 File Offset: 0x0019A901
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUniformInteger._ClassPtr;
		}

		// Token: 0x06011928 RID: 71976 RVA: 0x0019C710 File Offset: 0x0019A910
		public UUniformInteger() : this(BuiltinUtils.AllocNativeUObject(UUniformInteger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011929 RID: 71977 RVA: 0x0019C738 File Offset: 0x0019A938
		[NullableContext(1)]
		public UUniformInteger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUniformInteger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700448E RID: 17550
		// (get) Token: 0x0601192A RID: 71978 RVA: 0x0019C76B File Offset: 0x0019A96B
		// (set) Token: 0x0601192B RID: 71979 RVA: 0x0019C77B File Offset: 0x0019A97B
		public unsafe int Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformInteger.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformInteger.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x0601192C RID: 71980 RVA: 0x0019C78C File Offset: 0x0019A98C
		[NullableContext(2)]
		public UUniformInteger SetUniformInteger(int Magnitude)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUniformInteger>(UUniformInteger.__SetUniformInteger_Internal(base.NativePtr, Magnitude));
		}

		// Token: 0x0601192D RID: 71981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetUniformInteger_Internal(IntPtr @this, int Magnitude);

		// Token: 0x0601192E RID: 71982 RVA: 0x0019C79F File Offset: 0x0019A99F
		static UUniformInteger()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.UniformInteger");
		}

		// Token: 0x0601192F RID: 71983 RVA: 0x0019C7AD File Offset: 0x0019A9AD
		protected UUniformInteger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009694 RID: 38548
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.UniformInteger";

		// Token: 0x04009695 RID: 38549
		private static IntPtr _ClassPtr;

		// Token: 0x04009696 RID: 38550
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009697 RID: 38551
		internal static int __PropertyOffset_Magnitude;
	}
}
