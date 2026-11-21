using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200010A RID: 266
	[UnrealObjectPath("/Script/CoreUObject.FloatProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UFloatProperty : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001120 RID: 4384 RVA: 0x0001B285 File Offset: 0x00019485
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFloatProperty._ClassPtr;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0001B294 File Offset: 0x00019494
		public UFloatProperty() : this(BuiltinUtils.AllocNativeUObject(UFloatProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0001B2BC File Offset: 0x000194BC
		[NullableContext(1)]
		public UFloatProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFloatProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0001B2EF File Offset: 0x000194EF
		static UFloatProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.FloatProperty");
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0001B2FD File Offset: 0x000194FD
		protected UFloatProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004DD RID: 1245
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.FloatProperty";

		// Token: 0x040004DE RID: 1246
		private static IntPtr _ClassPtr;

		// Token: 0x040004DF RID: 1247
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
