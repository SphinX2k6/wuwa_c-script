using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001089 RID: 4233
	[UnrealObjectPath("/Script/Engine.ReporterBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UReporterBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F1F5 RID: 61941 RVA: 0x001670B8 File Offset: 0x001652B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReporterBase._ClassPtr;
		}

		// Token: 0x0600F1F6 RID: 61942 RVA: 0x001670C4 File Offset: 0x001652C4
		static UReporterBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ReporterBase");
		}

		// Token: 0x0600F1F7 RID: 61943 RVA: 0x001670D4 File Offset: 0x001652D4
		protected UReporterBase() : this(BuiltinUtils.AllocNativeUObject(UReporterBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F1F8 RID: 61944 RVA: 0x001670FC File Offset: 0x001652FC
		protected UReporterBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008331 RID: 33585
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ReporterBase";

		// Token: 0x04008332 RID: 33586
		private static IntPtr _ClassPtr;

		// Token: 0x04008333 RID: 33587
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
