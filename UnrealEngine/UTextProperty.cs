using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200076A RID: 1898
	[UnrealObjectPath("/Script/CoreUObject.TextProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UTextProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063B8 RID: 25528 RVA: 0x0008F2D6 File Offset: 0x0008D4D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextProperty._ClassPtr;
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x0008F2E4 File Offset: 0x0008D4E4
		public UTextProperty() : this(BuiltinUtils.AllocNativeUObject(UTextProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x0008F30C File Offset: 0x0008D50C
		[NullableContext(1)]
		public UTextProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x0008F33F File Offset: 0x0008D53F
		static UTextProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.TextProperty");
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x0008F34D File Offset: 0x0008D54D
		protected UTextProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FCE RID: 12238
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.TextProperty";

		// Token: 0x04002FCF RID: 12239
		private static IntPtr _ClassPtr;

		// Token: 0x04002FD0 RID: 12240
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
