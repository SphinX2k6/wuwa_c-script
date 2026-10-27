using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000744 RID: 1860
	[UnrealObjectPath("/Script/CoreUObject.LinkerPlaceholderClass")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ULinkerPlaceholderClass : UClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062CB RID: 25291 RVA: 0x0008DC4A File Offset: 0x0008BE4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULinkerPlaceholderClass._ClassPtr;
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x0008DC58 File Offset: 0x0008BE58
		public ULinkerPlaceholderClass() : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x0008DC80 File Offset: 0x0008BE80
		[NullableContext(1)]
		public ULinkerPlaceholderClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062CE RID: 25294 RVA: 0x0008DCB3 File Offset: 0x0008BEB3
		static ULinkerPlaceholderClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.LinkerPlaceholderClass");
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x0008DCC1 File Offset: 0x0008BEC1
		protected ULinkerPlaceholderClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F43 RID: 12099
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.LinkerPlaceholderClass";

		// Token: 0x04002F44 RID: 12100
		private static IntPtr _ClassPtr;

		// Token: 0x04002F45 RID: 12101
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
