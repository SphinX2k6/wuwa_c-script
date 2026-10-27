using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B4 RID: 4788
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldSystemMetaDataIteration")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UFieldSystemMetaDataIteration : UFieldSystemMetaData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601188F RID: 71823 RVA: 0x0019BAA2 File Offset: 0x00199CA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFieldSystemMetaDataIteration._ClassPtr;
		}

		// Token: 0x06011890 RID: 71824 RVA: 0x0019BAB0 File Offset: 0x00199CB0
		public UFieldSystemMetaDataIteration() : this(BuiltinUtils.AllocNativeUObject(UFieldSystemMetaDataIteration.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011891 RID: 71825 RVA: 0x0019BAD8 File Offset: 0x00199CD8
		[NullableContext(1)]
		public UFieldSystemMetaDataIteration(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFieldSystemMetaDataIteration.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700446C RID: 17516
		// (get) Token: 0x06011892 RID: 71826 RVA: 0x0019BB0B File Offset: 0x00199D0B
		// (set) Token: 0x06011893 RID: 71827 RVA: 0x0019BB1B File Offset: 0x00199D1B
		public unsafe int Iterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFieldSystemMetaDataIteration.__PropertyOffset_Iterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFieldSystemMetaDataIteration.__PropertyOffset_Iterations) = value;
			}
		}

		// Token: 0x06011894 RID: 71828 RVA: 0x0019BB2C File Offset: 0x00199D2C
		[NullableContext(2)]
		public UFieldSystemMetaDataIteration SetMetaDataIteration(int Iterations)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UFieldSystemMetaDataIteration>(UFieldSystemMetaDataIteration.__SetMetaDataIteration_Internal(base.NativePtr, Iterations));
		}

		// Token: 0x06011895 RID: 71829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetMetaDataIteration_Internal(IntPtr @this, int Iterations);

		// Token: 0x06011896 RID: 71830 RVA: 0x0019BB3F File Offset: 0x00199D3F
		static UFieldSystemMetaDataIteration()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldSystemMetaDataIteration");
		}

		// Token: 0x06011897 RID: 71831 RVA: 0x0019BB4D File Offset: 0x00199D4D
		protected UFieldSystemMetaDataIteration(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400964E RID: 38478
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldSystemMetaDataIteration";

		// Token: 0x0400964F RID: 38479
		private static IntPtr _ClassPtr;

		// Token: 0x04009650 RID: 38480
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009651 RID: 38481
		internal static int __PropertyOffset_Iterations;
	}
}
