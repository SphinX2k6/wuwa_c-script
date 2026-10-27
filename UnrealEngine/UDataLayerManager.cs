using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200099B RID: 2459
	[UnrealObjectPath("/Script/Engine.DataLayerManager")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UDataLayerManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008AE0 RID: 35552 RVA: 0x000C6EDA File Offset: 0x000C50DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataLayerManager._ClassPtr;
		}

		// Token: 0x06008AE1 RID: 35553 RVA: 0x000C6EE8 File Offset: 0x000C50E8
		public UDataLayerManager() : this(BuiltinUtils.AllocNativeUObject(UDataLayerManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x000C6F10 File Offset: 0x000C5110
		[NullableContext(1)]
		public UDataLayerManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataLayerManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x000C6F43 File Offset: 0x000C5143
		static UDataLayerManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataLayerManager");
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x000C6F51 File Offset: 0x000C5151
		protected UDataLayerManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041F4 RID: 16884
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataLayerManager";

		// Token: 0x040041F5 RID: 16885
		private static IntPtr _ClassPtr;

		// Token: 0x040041F6 RID: 16886
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
