using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013A RID: 314
	[UnrealObjectPath("/Script/CoreUObject.ObjectPropertyBase")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public abstract class UObjectPropertyBase : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600127D RID: 4733 RVA: 0x0001D476 File Offset: 0x0001B676
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectPropertyBase._ClassPtr;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0001D482 File Offset: 0x0001B682
		static UObjectPropertyBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ObjectPropertyBase");
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0001D490 File Offset: 0x0001B690
		protected UObjectPropertyBase() : this(BuiltinUtils.AllocNativeUObject(UObjectPropertyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		protected UObjectPropertyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005B1 RID: 1457
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ObjectPropertyBase";

		// Token: 0x040005B2 RID: 1458
		private static IntPtr _ClassPtr;

		// Token: 0x040005B3 RID: 1459
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
