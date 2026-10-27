using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200099A RID: 2458
	[UnrealObjectPath("/Script/Engine.DataLayerLoadingPolicy")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UDataLayerLoadingPolicy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008ADB RID: 35547 RVA: 0x000C6E5B File Offset: 0x000C505B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataLayerLoadingPolicy._ClassPtr;
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x000C6E68 File Offset: 0x000C5068
		public UDataLayerLoadingPolicy() : this(BuiltinUtils.AllocNativeUObject(UDataLayerLoadingPolicy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x000C6E90 File Offset: 0x000C5090
		[NullableContext(1)]
		public UDataLayerLoadingPolicy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataLayerLoadingPolicy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x000C6EC3 File Offset: 0x000C50C3
		static UDataLayerLoadingPolicy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataLayerLoadingPolicy");
		}

		// Token: 0x06008ADF RID: 35551 RVA: 0x000C6ED1 File Offset: 0x000C50D1
		protected UDataLayerLoadingPolicy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041F1 RID: 16881
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataLayerLoadingPolicy";

		// Token: 0x040041F2 RID: 16882
		private static IntPtr _ClassPtr;

		// Token: 0x040041F3 RID: 16883
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
