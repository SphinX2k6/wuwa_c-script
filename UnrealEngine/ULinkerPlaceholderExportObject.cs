using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012B RID: 299
	[UnrealObjectPath("/Script/CoreUObject.LinkerPlaceholderExportObject")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class ULinkerPlaceholderExportObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600122C RID: 4652 RVA: 0x0001CC4A File Offset: 0x0001AE4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULinkerPlaceholderExportObject._ClassPtr;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0001CC58 File Offset: 0x0001AE58
		public ULinkerPlaceholderExportObject() : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderExportObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0001CC80 File Offset: 0x0001AE80
		[NullableContext(1)]
		public ULinkerPlaceholderExportObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderExportObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0001CCB3 File Offset: 0x0001AEB3
		static ULinkerPlaceholderExportObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.LinkerPlaceholderExportObject");
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0001CCC1 File Offset: 0x0001AEC1
		protected ULinkerPlaceholderExportObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400057C RID: 1404
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.LinkerPlaceholderExportObject";

		// Token: 0x0400057D RID: 1405
		private static IntPtr _ClassPtr;

		// Token: 0x0400057E RID: 1406
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
