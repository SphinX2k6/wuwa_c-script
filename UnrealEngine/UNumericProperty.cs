using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074F RID: 1871
	[UnrealObjectPath("/Script/CoreUObject.NumericProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UNumericProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006301 RID: 25345 RVA: 0x0008E196 File Offset: 0x0008C396
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNumericProperty._ClassPtr;
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x0008E1A2 File Offset: 0x0008C3A2
		static UNumericProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.NumericProperty");
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x0008E1B0 File Offset: 0x0008C3B0
		protected UNumericProperty() : this(BuiltinUtils.AllocNativeUObject(UNumericProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x0008E1D8 File Offset: 0x0008C3D8
		protected UNumericProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F64 RID: 12132
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.NumericProperty";

		// Token: 0x04002F65 RID: 12133
		private static IntPtr _ClassPtr;

		// Token: 0x04002F66 RID: 12134
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
