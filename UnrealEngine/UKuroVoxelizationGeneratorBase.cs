using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D17 RID: 3351
	[UnrealObjectPath("/Script/Engine.KuroVoxelizationGeneratorBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UKuroVoxelizationGeneratorBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B3B1 RID: 46001 RVA: 0x00100533 File Offset: 0x000FE733
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVoxelizationGeneratorBase._ClassPtr;
		}

		// Token: 0x0600B3B2 RID: 46002 RVA: 0x0010053F File Offset: 0x000FE73F
		static UKuroVoxelizationGeneratorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroVoxelizationGeneratorBase");
		}

		// Token: 0x0600B3B3 RID: 46003 RVA: 0x00100550 File Offset: 0x000FE750
		protected UKuroVoxelizationGeneratorBase() : this(BuiltinUtils.AllocNativeUObject(UKuroVoxelizationGeneratorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B3B4 RID: 46004 RVA: 0x00100578 File Offset: 0x000FE778
		protected UKuroVoxelizationGeneratorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005E79 RID: 24185
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroVoxelizationGeneratorBase";

		// Token: 0x04005E7A RID: 24186
		private static IntPtr _ClassPtr;

		// Token: 0x04005E7B RID: 24187
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
