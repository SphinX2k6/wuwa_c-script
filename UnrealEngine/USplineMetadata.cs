using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200117E RID: 4478
	[UnrealObjectPath("/Script/Engine.SplineMetadata")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class USplineMetadata : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601074A RID: 67402 RVA: 0x00182A58 File Offset: 0x00180C58
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USplineMetadata._ClassPtr;
		}

		// Token: 0x0601074B RID: 67403 RVA: 0x00182A64 File Offset: 0x00180C64
		static USplineMetadata()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SplineMetadata");
		}

		// Token: 0x0601074C RID: 67404 RVA: 0x00182A74 File Offset: 0x00180C74
		protected USplineMetadata() : this(BuiltinUtils.AllocNativeUObject(USplineMetadata.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601074D RID: 67405 RVA: 0x00182A9C File Offset: 0x00180C9C
		protected USplineMetadata(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008CD3 RID: 36051
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SplineMetadata";

		// Token: 0x04008CD4 RID: 36052
		private static IntPtr _ClassPtr;

		// Token: 0x04008CD5 RID: 36053
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
