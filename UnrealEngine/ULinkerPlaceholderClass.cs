using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012A RID: 298
	[UnrealObjectPath("/Script/CoreUObject.LinkerPlaceholderClass")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ULinkerPlaceholderClass : UClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001227 RID: 4647 RVA: 0x0001CBCA File Offset: 0x0001ADCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULinkerPlaceholderClass._ClassPtr;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
		public ULinkerPlaceholderClass() : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0001CC00 File Offset: 0x0001AE00
		[NullableContext(1)]
		public ULinkerPlaceholderClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0001CC33 File Offset: 0x0001AE33
		static ULinkerPlaceholderClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.LinkerPlaceholderClass");
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0001CC41 File Offset: 0x0001AE41
		protected ULinkerPlaceholderClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000579 RID: 1401
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.LinkerPlaceholderClass";

		// Token: 0x0400057A RID: 1402
		private static IntPtr _ClassPtr;

		// Token: 0x0400057B RID: 1403
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
