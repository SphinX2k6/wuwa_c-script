using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200075F RID: 1887
	[UnrealObjectPath("/Script/CoreUObject.PropertyWrapper")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UPropertyWrapper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600637A RID: 25466 RVA: 0x0008ECD1 File Offset: 0x0008CED1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPropertyWrapper._ClassPtr;
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x0008ECE0 File Offset: 0x0008CEE0
		public UPropertyWrapper() : this(BuiltinUtils.AllocNativeUObject(UPropertyWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x0008ED08 File Offset: 0x0008CF08
		[NullableContext(1)]
		public UPropertyWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPropertyWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x0008ED3B File Offset: 0x0008CF3B
		static UPropertyWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.PropertyWrapper");
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x0008ED49 File Offset: 0x0008CF49
		protected UPropertyWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FAB RID: 12203
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.PropertyWrapper";

		// Token: 0x04002FAC RID: 12204
		private static IntPtr _ClassPtr;

		// Token: 0x04002FAD RID: 12205
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
