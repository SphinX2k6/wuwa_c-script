using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012C RID: 300
	[UnrealObjectPath("/Script/CoreUObject.LinkerPlaceholderFunction")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 680)]
	public class ULinkerPlaceholderFunction : UFunction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001231 RID: 4657 RVA: 0x0001CCCA File Offset: 0x0001AECA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULinkerPlaceholderFunction._ClassPtr;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		public ULinkerPlaceholderFunction() : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0001CD00 File Offset: 0x0001AF00
		[NullableContext(1)]
		public ULinkerPlaceholderFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0001CD33 File Offset: 0x0001AF33
		static ULinkerPlaceholderFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.LinkerPlaceholderFunction");
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0001CD41 File Offset: 0x0001AF41
		protected ULinkerPlaceholderFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400057F RID: 1407
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.LinkerPlaceholderFunction";

		// Token: 0x04000580 RID: 1408
		private static IntPtr _ClassPtr;

		// Token: 0x04000581 RID: 1409
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
