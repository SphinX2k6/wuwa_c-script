using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000144 RID: 324
	[UnrealObjectPath("/Script/CoreUObject.Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UProperty : UField, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012CF RID: 4815 RVA: 0x0001DB8E File Offset: 0x0001BD8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProperty._ClassPtr;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0001DB9A File Offset: 0x0001BD9A
		static UProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Property");
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
		protected UProperty() : this(BuiltinUtils.AllocNativeUObject(UProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
		protected UProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005DE RID: 1502
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Property";

		// Token: 0x040005DF RID: 1503
		private static IntPtr _ClassPtr;

		// Token: 0x040005E0 RID: 1504
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
