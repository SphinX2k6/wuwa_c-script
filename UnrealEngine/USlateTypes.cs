using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200282E RID: 10286
	[UnrealObjectPath("/Script/SlateCore.SlateTypes")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USlateTypes : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602639F RID: 156575 RVA: 0x003A04D8 File Offset: 0x0039E6D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USlateTypes._ClassPtr;
		}

		// Token: 0x060263A0 RID: 156576 RVA: 0x003A04E4 File Offset: 0x0039E6E4
		public USlateTypes() : this(BuiltinUtils.AllocNativeUObject(USlateTypes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263A1 RID: 156577 RVA: 0x003A050C File Offset: 0x0039E70C
		[NullableContext(1)]
		public USlateTypes(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USlateTypes.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060263A2 RID: 156578 RVA: 0x003A053F File Offset: 0x0039E73F
		static USlateTypes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SlateCore.SlateTypes");
		}

		// Token: 0x060263A3 RID: 156579 RVA: 0x003A054D File Offset: 0x0039E74D
		protected USlateTypes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014EC1 RID: 85697
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.SlateTypes";

		// Token: 0x04014EC2 RID: 85698
		private static IntPtr _ClassPtr;

		// Token: 0x04014EC3 RID: 85699
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
