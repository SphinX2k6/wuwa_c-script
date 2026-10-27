using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000748 RID: 1864
	[UnrealObjectPath("/Script/CoreUObject.MetaData")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UMetaData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062DF RID: 25311 RVA: 0x0008DE4A File Offset: 0x0008C04A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMetaData._ClassPtr;
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x0008DE58 File Offset: 0x0008C058
		public UMetaData() : this(BuiltinUtils.AllocNativeUObject(UMetaData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x0008DE80 File Offset: 0x0008C080
		[NullableContext(1)]
		public UMetaData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMetaData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x0008DEB3 File Offset: 0x0008C0B3
		static UMetaData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MetaData");
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x0008DEC1 File Offset: 0x0008C0C1
		protected UMetaData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F4F RID: 12111
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MetaData";

		// Token: 0x04002F50 RID: 12112
		private static IntPtr _ClassPtr;

		// Token: 0x04002F51 RID: 12113
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
