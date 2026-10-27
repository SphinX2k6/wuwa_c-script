using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000724 RID: 1828
	[UnrealObjectPath("/Script/CoreUObject.FloatProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UFloatProperty : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060061B9 RID: 25017 RVA: 0x0008C1E9 File Offset: 0x0008A3E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFloatProperty._ClassPtr;
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x0008C1F8 File Offset: 0x0008A3F8
		public UFloatProperty() : this(BuiltinUtils.AllocNativeUObject(UFloatProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x0008C220 File Offset: 0x0008A420
		[NullableContext(1)]
		public UFloatProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFloatProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x0008C253 File Offset: 0x0008A453
		static UFloatProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.FloatProperty");
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x0008C261 File Offset: 0x0008A461
		protected UFloatProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002EA7 RID: 11943
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.FloatProperty";

		// Token: 0x04002EA8 RID: 11944
		private static IntPtr _ClassPtr;

		// Token: 0x04002EA9 RID: 11945
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
