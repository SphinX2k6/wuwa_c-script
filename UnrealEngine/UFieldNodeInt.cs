using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012AE RID: 4782
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldNodeInt")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UFieldNodeInt : UFieldNodeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011859 RID: 71769 RVA: 0x0019B626 File Offset: 0x00199826
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFieldNodeInt._ClassPtr;
		}

		// Token: 0x0601185A RID: 71770 RVA: 0x0019B634 File Offset: 0x00199834
		public UFieldNodeInt() : this(BuiltinUtils.AllocNativeUObject(UFieldNodeInt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601185B RID: 71771 RVA: 0x0019B65C File Offset: 0x0019985C
		[NullableContext(1)]
		public UFieldNodeInt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFieldNodeInt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601185C RID: 71772 RVA: 0x0019B68F File Offset: 0x0019988F
		static UFieldNodeInt()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldNodeInt");
		}

		// Token: 0x0601185D RID: 71773 RVA: 0x0019B69D File Offset: 0x0019989D
		protected UFieldNodeInt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009638 RID: 38456
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldNodeInt";

		// Token: 0x04009639 RID: 38457
		private static IntPtr _ClassPtr;

		// Token: 0x0400963A RID: 38458
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
