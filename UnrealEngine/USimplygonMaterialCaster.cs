using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027DA RID: 10202
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonMaterialCaster")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class USimplygonMaterialCaster : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260C4 RID: 155844 RVA: 0x0039B5E1 File Offset: 0x003997E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonMaterialCaster._ClassPtr;
		}

		// Token: 0x060260C5 RID: 155845 RVA: 0x0039B5ED File Offset: 0x003997ED
		static USimplygonMaterialCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonMaterialCaster");
		}

		// Token: 0x060260C6 RID: 155846 RVA: 0x0039B5FC File Offset: 0x003997FC
		protected USimplygonMaterialCaster() : this(BuiltinUtils.AllocNativeUObject(USimplygonMaterialCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260C7 RID: 155847 RVA: 0x0039B624 File Offset: 0x00399824
		protected USimplygonMaterialCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C6B RID: 85099
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonMaterialCaster";

		// Token: 0x04014C6C RID: 85100
		private static IntPtr _ClassPtr;

		// Token: 0x04014C6D RID: 85101
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
