using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000ED RID: 237
	[UnrealObjectPath("/Script/CoreUObject.ArrayProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UArrayProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001099 RID: 4249 RVA: 0x0001A6B4 File Offset: 0x000188B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UArrayProperty._ClassPtr;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0001A6C0 File Offset: 0x000188C0
		public UArrayProperty() : this(BuiltinUtils.AllocNativeUObject(UArrayProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0001A6E8 File Offset: 0x000188E8
		[NullableContext(1)]
		public UArrayProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UArrayProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0001A71B File Offset: 0x0001891B
		static UArrayProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ArrayProperty");
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0001A729 File Offset: 0x00018929
		protected UArrayProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000402 RID: 1026
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ArrayProperty";

		// Token: 0x04000403 RID: 1027
		private static IntPtr _ClassPtr;

		// Token: 0x04000404 RID: 1028
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
