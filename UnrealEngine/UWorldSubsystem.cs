using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B7 RID: 695
	[UnrealObjectPath("/Script/Engine.WorldSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UWorldSubsystem : USubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004B8A RID: 19338 RVA: 0x00069C1C File Offset: 0x00067E1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldSubsystem._ClassPtr;
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x00069C28 File Offset: 0x00067E28
		static UWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldSubsystem");
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x00069C38 File Offset: 0x00067E38
		protected UWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x00069C60 File Offset: 0x00067E60
		protected UWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001DF2 RID: 7666
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldSubsystem";

		// Token: 0x04001DF3 RID: 7667
		private static IntPtr _ClassPtr;

		// Token: 0x04001DF4 RID: 7668
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
