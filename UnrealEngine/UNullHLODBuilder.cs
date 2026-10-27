using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EF8 RID: 3832
	[UnrealObjectPath("/Script/Engine.NullHLODBuilder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UNullHLODBuilder : UHLODBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CFAE RID: 53166 RVA: 0x0012EE3E File Offset: 0x0012D03E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNullHLODBuilder._ClassPtr;
		}

		// Token: 0x0600CFAF RID: 53167 RVA: 0x0012EE4C File Offset: 0x0012D04C
		public UNullHLODBuilder() : this(BuiltinUtils.AllocNativeUObject(UNullHLODBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CFB0 RID: 53168 RVA: 0x0012EE74 File Offset: 0x0012D074
		[NullableContext(1)]
		public UNullHLODBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNullHLODBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CFB1 RID: 53169 RVA: 0x0012EEA7 File Offset: 0x0012D0A7
		static UNullHLODBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NullHLODBuilder");
		}

		// Token: 0x0600CFB2 RID: 53170 RVA: 0x0012EEB5 File Offset: 0x0012D0B5
		protected UNullHLODBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006FF4 RID: 28660
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NullHLODBuilder";

		// Token: 0x04006FF5 RID: 28661
		private static IntPtr _ClassPtr;

		// Token: 0x04006FF6 RID: 28662
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
