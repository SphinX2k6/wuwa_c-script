using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C3D RID: 3133
	[UnrealObjectPath("/Script/Engine.HLODRebuildPolicyData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UHLODRebuildPolicyData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009EBC RID: 40636 RVA: 0x000E19A9 File Offset: 0x000DFBA9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODRebuildPolicyData._ClassPtr;
		}

		// Token: 0x06009EBD RID: 40637 RVA: 0x000E19B5 File Offset: 0x000DFBB5
		static UHLODRebuildPolicyData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODRebuildPolicyData");
		}

		// Token: 0x06009EBE RID: 40638 RVA: 0x000E19C4 File Offset: 0x000DFBC4
		protected UHLODRebuildPolicyData() : this(BuiltinUtils.AllocNativeUObject(UHLODRebuildPolicyData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009EBF RID: 40639 RVA: 0x000E19EC File Offset: 0x000DFBEC
		protected UHLODRebuildPolicyData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005780 RID: 22400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODRebuildPolicyData";

		// Token: 0x04005781 RID: 22401
		private static IntPtr _ClassPtr;

		// Token: 0x04005782 RID: 22402
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
