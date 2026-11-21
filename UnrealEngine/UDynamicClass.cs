using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000FA RID: 250
	[UnrealObjectPath("/Script/CoreUObject.DynamicClass")]
	[UnrealStructLayout(760, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 760)]
	public class UDynamicClass : UClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001108 RID: 4360 RVA: 0x0001B026 File Offset: 0x00019226
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDynamicClass._ClassPtr;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0001B034 File Offset: 0x00019234
		public UDynamicClass() : this(BuiltinUtils.AllocNativeUObject(UDynamicClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0001B05C File Offset: 0x0001925C
		[NullableContext(1)]
		public UDynamicClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDynamicClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0001B08F File Offset: 0x0001928F
		static UDynamicClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.DynamicClass");
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0001B09D File Offset: 0x0001929D
		protected UDynamicClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000439 RID: 1081
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.DynamicClass";

		// Token: 0x0400043A RID: 1082
		private static IntPtr _ClassPtr;

		// Token: 0x0400043B RID: 1083
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
