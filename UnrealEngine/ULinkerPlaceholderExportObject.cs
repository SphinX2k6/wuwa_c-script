using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000745 RID: 1861
	[UnrealObjectPath("/Script/CoreUObject.LinkerPlaceholderExportObject")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class ULinkerPlaceholderExportObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062D0 RID: 25296 RVA: 0x0008DCCA File Offset: 0x0008BECA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULinkerPlaceholderExportObject._ClassPtr;
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x0008DCD8 File Offset: 0x0008BED8
		public ULinkerPlaceholderExportObject() : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderExportObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x0008DD00 File Offset: 0x0008BF00
		[NullableContext(1)]
		public ULinkerPlaceholderExportObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderExportObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x0008DD33 File Offset: 0x0008BF33
		static ULinkerPlaceholderExportObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.LinkerPlaceholderExportObject");
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x0008DD41 File Offset: 0x0008BF41
		protected ULinkerPlaceholderExportObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F46 RID: 12102
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.LinkerPlaceholderExportObject";

		// Token: 0x04002F47 RID: 12103
		private static IntPtr _ClassPtr;

		// Token: 0x04002F48 RID: 12104
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
