using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200247A RID: 9338
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_KuroCaveStreamingType")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_KuroCaveStreamingType : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F35 RID: 143157 RVA: 0x0033AC7A File Offset: 0x00338E7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_KuroCaveStreamingType._ClassPtr;
		}

		// Token: 0x06022F36 RID: 143158 RVA: 0x0033AC88 File Offset: 0x00338E88
		public UNavArea_KuroCaveStreamingType() : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroCaveStreamingType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F37 RID: 143159 RVA: 0x0033ACB0 File Offset: 0x00338EB0
		[NullableContext(1)]
		public UNavArea_KuroCaveStreamingType(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroCaveStreamingType.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F38 RID: 143160 RVA: 0x0033ACE3 File Offset: 0x00338EE3
		static UNavArea_KuroCaveStreamingType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_KuroCaveStreamingType");
		}

		// Token: 0x06022F39 RID: 143161 RVA: 0x0033ACF1 File Offset: 0x00338EF1
		protected UNavArea_KuroCaveStreamingType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A9D RID: 76445
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_KuroCaveStreamingType";

		// Token: 0x04012A9E RID: 76446
		private static IntPtr _ClassPtr;

		// Token: 0x04012A9F RID: 76447
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
