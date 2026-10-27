using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200165B RID: 5723
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimJsSubsystem")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UKuroAnimJsSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014BC1 RID: 84929 RVA: 0x001E7E9B File Offset: 0x001E609B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimJsSubsystem._ClassPtr;
		}

		// Token: 0x06014BC2 RID: 84930 RVA: 0x001E7EA8 File Offset: 0x001E60A8
		public UKuroAnimJsSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimJsSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014BC3 RID: 84931 RVA: 0x001E7ED0 File Offset: 0x001E60D0
		[NullableContext(1)]
		public UKuroAnimJsSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimJsSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014BC4 RID: 84932 RVA: 0x001E7F03 File Offset: 0x001E6103
		static UKuroAnimJsSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimJsSubsystem");
		}

		// Token: 0x06014BC5 RID: 84933 RVA: 0x001E7F11 File Offset: 0x001E6111
		protected UKuroAnimJsSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B4E7 RID: 46311
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimJsSubsystem";

		// Token: 0x0400B4E8 RID: 46312
		private static IntPtr _ClassPtr;

		// Token: 0x0400B4E9 RID: 46313
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
