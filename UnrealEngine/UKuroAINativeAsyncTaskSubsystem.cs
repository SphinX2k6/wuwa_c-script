using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018BD RID: 6333
	[UnrealObjectPath("/Script/KuroGameplay.KuroAINativeAsyncTaskSubsystem")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroAINativeAsyncTaskSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017684 RID: 95876 RVA: 0x002239D2 File Offset: 0x00221BD2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAINativeAsyncTaskSubsystem._ClassPtr;
		}

		// Token: 0x06017685 RID: 95877 RVA: 0x002239E0 File Offset: 0x00221BE0
		public UKuroAINativeAsyncTaskSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroAINativeAsyncTaskSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017686 RID: 95878 RVA: 0x00223A08 File Offset: 0x00221C08
		[NullableContext(1)]
		public UKuroAINativeAsyncTaskSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAINativeAsyncTaskSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017687 RID: 95879 RVA: 0x00223A3B File Offset: 0x00221C3B
		static UKuroAINativeAsyncTaskSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroAINativeAsyncTaskSubsystem");
		}

		// Token: 0x06017688 RID: 95880 RVA: 0x00223A49 File Offset: 0x00221C49
		protected UKuroAINativeAsyncTaskSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CBB4 RID: 52148
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroAINativeAsyncTaskSubsystem";

		// Token: 0x0400CBB5 RID: 52149
		private static IntPtr _ClassPtr;

		// Token: 0x0400CBB6 RID: 52150
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
