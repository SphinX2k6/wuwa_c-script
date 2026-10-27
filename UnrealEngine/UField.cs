using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000723 RID: 1827
	[UnrealObjectPath("/Script/CoreUObject.Field")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UField : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060061B5 RID: 25013 RVA: 0x0008C19D File Offset: 0x0008A39D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UField._ClassPtr;
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x0008C1A9 File Offset: 0x0008A3A9
		static UField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Field");
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x0008C1B8 File Offset: 0x0008A3B8
		protected UField() : this(BuiltinUtils.AllocNativeUObject(UField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x0008C1E0 File Offset: 0x0008A3E0
		protected UField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002EA4 RID: 11940
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Field";

		// Token: 0x04002EA5 RID: 11941
		private static IntPtr _ClassPtr;

		// Token: 0x04002EA6 RID: 11942
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
