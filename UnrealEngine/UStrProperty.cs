using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000766 RID: 1894
	[UnrealObjectPath("/Script/CoreUObject.StrProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UStrProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063A4 RID: 25508 RVA: 0x0008F0D6 File Offset: 0x0008D2D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStrProperty._ClassPtr;
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x0008F0E4 File Offset: 0x0008D2E4
		public UStrProperty() : this(BuiltinUtils.AllocNativeUObject(UStrProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x0008F10C File Offset: 0x0008D30C
		[NullableContext(1)]
		public UStrProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStrProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x0008F13F File Offset: 0x0008D33F
		static UStrProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.StrProperty");
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x0008F14D File Offset: 0x0008D34D
		protected UStrProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FC2 RID: 12226
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.StrProperty";

		// Token: 0x04002FC3 RID: 12227
		private static IntPtr _ClassPtr;

		// Token: 0x04002FC4 RID: 12228
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
