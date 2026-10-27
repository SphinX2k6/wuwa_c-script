using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D05 RID: 3333
	[UnrealObjectPath("/Script/Engine.KuroPxMemoryReleaseListenerSubSystem")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UKuroPxMemoryReleaseListenerSubSystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B175 RID: 45429 RVA: 0x000FBE23 File Offset: 0x000FA023
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPxMemoryReleaseListenerSubSystem._ClassPtr;
		}

		// Token: 0x0600B176 RID: 45430 RVA: 0x000FBE30 File Offset: 0x000FA030
		public UKuroPxMemoryReleaseListenerSubSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroPxMemoryReleaseListenerSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B177 RID: 45431 RVA: 0x000FBE58 File Offset: 0x000FA058
		[NullableContext(1)]
		public UKuroPxMemoryReleaseListenerSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPxMemoryReleaseListenerSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x000FBE8B File Offset: 0x000FA08B
		static UKuroPxMemoryReleaseListenerSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroPxMemoryReleaseListenerSubSystem");
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x000FBE99 File Offset: 0x000FA099
		protected UKuroPxMemoryReleaseListenerSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005CEB RID: 23787
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroPxMemoryReleaseListenerSubSystem";

		// Token: 0x04005CEC RID: 23788
		private static IntPtr _ClassPtr;

		// Token: 0x04005CED RID: 23789
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
