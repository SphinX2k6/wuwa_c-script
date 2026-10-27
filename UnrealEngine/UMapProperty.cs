using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000747 RID: 1863
	[UnrealObjectPath("/Script/CoreUObject.MapProperty")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UMapProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062DA RID: 25306 RVA: 0x0008DDCA File Offset: 0x0008BFCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMapProperty._ClassPtr;
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x0008DDD8 File Offset: 0x0008BFD8
		public UMapProperty() : this(BuiltinUtils.AllocNativeUObject(UMapProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x0008DE00 File Offset: 0x0008C000
		[NullableContext(1)]
		public UMapProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMapProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x0008DE33 File Offset: 0x0008C033
		static UMapProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MapProperty");
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x0008DE41 File Offset: 0x0008C041
		protected UMapProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F4C RID: 12108
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MapProperty";

		// Token: 0x04002F4D RID: 12109
		private static IntPtr _ClassPtr;

		// Token: 0x04002F4E RID: 12110
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
