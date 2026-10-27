using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000741 RID: 1857
	[UnrealObjectPath("/Script/CoreUObject.IntProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UIntProperty : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062BA RID: 25274 RVA: 0x0008DA08 File Offset: 0x0008BC08
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UIntProperty._ClassPtr;
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x0008DA14 File Offset: 0x0008BC14
		public UIntProperty() : this(BuiltinUtils.AllocNativeUObject(UIntProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x0008DA3C File Offset: 0x0008BC3C
		[NullableContext(1)]
		public UIntProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UIntProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x0008DA6F File Offset: 0x0008BC6F
		static UIntProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.IntProperty");
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x0008DA7D File Offset: 0x0008BC7D
		protected UIntProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F34 RID: 12084
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.IntProperty";

		// Token: 0x04002F35 RID: 12085
		private static IntPtr _ClassPtr;

		// Token: 0x04002F36 RID: 12086
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
