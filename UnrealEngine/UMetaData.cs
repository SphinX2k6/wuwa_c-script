using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012E RID: 302
	[UnrealObjectPath("/Script/CoreUObject.MetaData")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UMetaData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600123B RID: 4667 RVA: 0x0001CDCA File Offset: 0x0001AFCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMetaData._ClassPtr;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0001CDD8 File Offset: 0x0001AFD8
		public UMetaData() : this(BuiltinUtils.AllocNativeUObject(UMetaData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0001CE00 File Offset: 0x0001B000
		[NullableContext(1)]
		public UMetaData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMetaData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0001CE33 File Offset: 0x0001B033
		static UMetaData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MetaData");
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0001CE41 File Offset: 0x0001B041
		protected UMetaData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000585 RID: 1413
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MetaData";

		// Token: 0x04000586 RID: 1414
		private static IntPtr _ClassPtr;

		// Token: 0x04000587 RID: 1415
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
