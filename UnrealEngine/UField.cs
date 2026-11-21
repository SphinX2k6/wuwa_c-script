using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000109 RID: 265
	[UnrealObjectPath("/Script/CoreUObject.Field")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UField : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600111C RID: 4380 RVA: 0x0001B239 File Offset: 0x00019439
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UField._ClassPtr;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0001B245 File Offset: 0x00019445
		static UField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Field");
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0001B254 File Offset: 0x00019454
		protected UField() : this(BuiltinUtils.AllocNativeUObject(UField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0001B27C File Offset: 0x0001947C
		protected UField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004DA RID: 1242
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Field";

		// Token: 0x040004DB RID: 1243
		private static IntPtr _ClassPtr;

		// Token: 0x040004DC RID: 1244
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
