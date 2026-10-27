using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200198D RID: 6541
	[UnrealObjectPath("/Script/KuroHttpTraffic.KuroHttpTrafficStatic")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroHttpTrafficStatic : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060184E8 RID: 99560 RVA: 0x0023D8A9 File Offset: 0x0023BAA9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHttpTrafficStatic._ClassPtr;
		}

		// Token: 0x060184E9 RID: 99561 RVA: 0x0023D8B8 File Offset: 0x0023BAB8
		public UKuroHttpTrafficStatic() : this(BuiltinUtils.AllocNativeUObject(UKuroHttpTrafficStatic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060184EA RID: 99562 RVA: 0x0023D8E0 File Offset: 0x0023BAE0
		[NullableContext(1)]
		public UKuroHttpTrafficStatic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHttpTrafficStatic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060184EB RID: 99563
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Shutdown();

		// Token: 0x060184EC RID: 99564
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Init();

		// Token: 0x060184ED RID: 99565 RVA: 0x0023D913 File Offset: 0x0023BB13
		static UKuroHttpTrafficStatic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHttpTraffic.KuroHttpTrafficStatic");
		}

		// Token: 0x060184EE RID: 99566 RVA: 0x0023D921 File Offset: 0x0023BB21
		protected UKuroHttpTrafficStatic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D262 RID: 53858
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroHttpTraffic.KuroHttpTrafficStatic";

		// Token: 0x0400D263 RID: 53859
		private static IntPtr _ClassPtr;

		// Token: 0x0400D264 RID: 53860
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
