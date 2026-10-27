using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000764 RID: 1892
	[UnrealObjectPath("/Script/CoreUObject.SoftObjectProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class USoftObjectProperty : UObjectPropertyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600639A RID: 25498 RVA: 0x0008EFD6 File Offset: 0x0008D1D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoftObjectProperty._ClassPtr;
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x0008EFE4 File Offset: 0x0008D1E4
		public USoftObjectProperty() : this(BuiltinUtils.AllocNativeUObject(USoftObjectProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x0008F00C File Offset: 0x0008D20C
		[NullableContext(1)]
		public USoftObjectProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoftObjectProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x0008F03F File Offset: 0x0008D23F
		static USoftObjectProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.SoftObjectProperty");
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x0008F04D File Offset: 0x0008D24D
		protected USoftObjectProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FBC RID: 12220
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.SoftObjectProperty";

		// Token: 0x04002FBD RID: 12221
		private static IntPtr _ClassPtr;

		// Token: 0x04002FBE RID: 12222
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
