using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000810 RID: 2064
	[UnrealObjectPath("/Script/Engine.AnimMetaData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UAnimMetaData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006ECB RID: 28363 RVA: 0x0009EDEC File Offset: 0x0009CFEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimMetaData._ClassPtr;
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x0009EDF8 File Offset: 0x0009CFF8
		static UAnimMetaData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimMetaData");
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x0009EE08 File Offset: 0x0009D008
		protected UAnimMetaData() : this(BuiltinUtils.AllocNativeUObject(UAnimMetaData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x0009EE30 File Offset: 0x0009D030
		protected UAnimMetaData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003530 RID: 13616
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimMetaData";

		// Token: 0x04003531 RID: 13617
		private static IntPtr _ClassPtr;

		// Token: 0x04003532 RID: 13618
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
