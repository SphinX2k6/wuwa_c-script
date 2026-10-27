using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D29 RID: 3369
	[UnrealObjectPath("/Script/Engine.LevelInstanceContainerInstance")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class ULevelInstanceContainerInstance : UActorDescContainerInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B4B5 RID: 46261 RVA: 0x00101BAE File Offset: 0x000FFDAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelInstanceContainerInstance._ClassPtr;
		}

		// Token: 0x0600B4B6 RID: 46262 RVA: 0x00101BBC File Offset: 0x000FFDBC
		public ULevelInstanceContainerInstance() : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceContainerInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B4B7 RID: 46263 RVA: 0x00101BE4 File Offset: 0x000FFDE4
		[NullableContext(1)]
		public ULevelInstanceContainerInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceContainerInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B4B8 RID: 46264 RVA: 0x00101C17 File Offset: 0x000FFE17
		static ULevelInstanceContainerInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelInstanceContainerInstance");
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x00101C25 File Offset: 0x000FFE25
		protected ULevelInstanceContainerInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F00 RID: 24320
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelInstanceContainerInstance";

		// Token: 0x04005F01 RID: 24321
		private static IntPtr _ClassPtr;

		// Token: 0x04005F02 RID: 24322
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
