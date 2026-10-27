using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200293B RID: 10555
	[UnrealObjectPath("/Script/UMG.BoolBinding")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UBoolBinding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060270AD RID: 159917 RVA: 0x003B8C02 File Offset: 0x003B6E02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoolBinding._ClassPtr;
		}

		// Token: 0x060270AE RID: 159918 RVA: 0x003B8C10 File Offset: 0x003B6E10
		public UBoolBinding() : this(BuiltinUtils.AllocNativeUObject(UBoolBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060270AF RID: 159919 RVA: 0x003B8C38 File Offset: 0x003B6E38
		[NullableContext(1)]
		public UBoolBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoolBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060270B0 RID: 159920 RVA: 0x003B8C6B File Offset: 0x003B6E6B
		public bool GetValue()
		{
			return UBoolBinding.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x060270B1 RID: 159921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetValue_Internal(IntPtr @this);

		// Token: 0x060270B2 RID: 159922 RVA: 0x003B8C78 File Offset: 0x003B6E78
		static UBoolBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.BoolBinding");
		}

		// Token: 0x060270B3 RID: 159923 RVA: 0x003B8C86 File Offset: 0x003B6E86
		protected UBoolBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015740 RID: 87872
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.BoolBinding";

		// Token: 0x04015741 RID: 87873
		private static IntPtr _ClassPtr;

		// Token: 0x04015742 RID: 87874
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
