using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D8 RID: 984
	[UnrealObjectPath("/Script/AugmentedReality.ARTypesDummyClass")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UARTypesDummyClass : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003725 RID: 14117 RVA: 0x00053B1C File Offset: 0x00051D1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTypesDummyClass._ClassPtr;
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x00053B28 File Offset: 0x00051D28
		public UARTypesDummyClass() : this(BuiltinUtils.AllocNativeUObject(UARTypesDummyClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00053B50 File Offset: 0x00051D50
		[NullableContext(1)]
		public UARTypesDummyClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTypesDummyClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00053B83 File Offset: 0x00051D83
		static UARTypesDummyClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTypesDummyClass");
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00053B91 File Offset: 0x00051D91
		protected UARTypesDummyClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040017EB RID: 6123
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTypesDummyClass";

		// Token: 0x040017EC RID: 6124
		private static IntPtr _ClassPtr;

		// Token: 0x040017ED RID: 6125
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
