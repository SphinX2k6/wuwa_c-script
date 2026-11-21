using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014D RID: 333
	[UnrealObjectPath("/Script/CoreUObject.Struct")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UStruct : UField, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x0001E04A File Offset: 0x0001C24A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStruct._ClassPtr;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0001E058 File Offset: 0x0001C258
		public UStruct() : this(BuiltinUtils.AllocNativeUObject(UStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0001E080 File Offset: 0x0001C280
		[NullableContext(1)]
		public UStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0001E0B3 File Offset: 0x0001C2B3
		static UStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Struct");
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0001E0C1 File Offset: 0x0001C2C1
		protected UStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005FB RID: 1531
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Struct";

		// Token: 0x040005FC RID: 1532
		private static IntPtr _ClassPtr;

		// Token: 0x040005FD RID: 1533
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
