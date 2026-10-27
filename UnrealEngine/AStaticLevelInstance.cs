using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200118D RID: 4493
	[UnrealObjectPath("/Script/Engine.StaticLevelInstance")]
	[UnrealStructLayout(1400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1400)]
	public class AStaticLevelInstance : ALevelInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601081A RID: 67610 RVA: 0x00183C9C File Offset: 0x00181E9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AStaticLevelInstance._ClassPtr;
		}

		// Token: 0x0601081B RID: 67611 RVA: 0x00183CA8 File Offset: 0x00181EA8
		public AStaticLevelInstance() : this(BuiltinUtils.AllocNativeUObject(AStaticLevelInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601081C RID: 67612 RVA: 0x00183CD0 File Offset: 0x00181ED0
		[NullableContext(1)]
		public AStaticLevelInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AStaticLevelInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601081D RID: 67613 RVA: 0x00183D03 File Offset: 0x00181F03
		static AStaticLevelInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticLevelInstance");
		}

		// Token: 0x0601081E RID: 67614 RVA: 0x00183D11 File Offset: 0x00181F11
		protected AStaticLevelInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008D40 RID: 36160
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StaticLevelInstance";

		// Token: 0x04008D41 RID: 36161
		private static IntPtr _ClassPtr;

		// Token: 0x04008D42 RID: 36162
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
