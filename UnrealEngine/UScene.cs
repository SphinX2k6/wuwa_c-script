using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010D0 RID: 4304
	[UnrealObjectPath("/Script/Engine.Scene")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UScene : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F58F RID: 62863 RVA: 0x0016BE97 File Offset: 0x0016A097
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScene._ClassPtr;
		}

		// Token: 0x0600F590 RID: 62864 RVA: 0x0016BEA4 File Offset: 0x0016A0A4
		public UScene() : this(BuiltinUtils.AllocNativeUObject(UScene.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F591 RID: 62865 RVA: 0x0016BECC File Offset: 0x0016A0CC
		[NullableContext(1)]
		public UScene(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScene.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F592 RID: 62866 RVA: 0x0016BEFF File Offset: 0x0016A0FF
		static UScene()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Scene");
		}

		// Token: 0x0600F593 RID: 62867 RVA: 0x0016BF0D File Offset: 0x0016A10D
		protected UScene(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008506 RID: 34054
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Scene";

		// Token: 0x04008507 RID: 34055
		private static IntPtr _ClassPtr;

		// Token: 0x04008508 RID: 34056
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
