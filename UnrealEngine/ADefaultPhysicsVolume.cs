using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009AF RID: 2479
	[UnrealObjectPath("/Script/Engine.DefaultPhysicsVolume")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class ADefaultPhysicsVolume : APhysicsVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C43 RID: 35907 RVA: 0x000C8BF2 File Offset: 0x000C6DF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADefaultPhysicsVolume._ClassPtr;
		}

		// Token: 0x06008C44 RID: 35908 RVA: 0x000C8C00 File Offset: 0x000C6E00
		public ADefaultPhysicsVolume() : this(BuiltinUtils.AllocNativeUObject(ADefaultPhysicsVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C45 RID: 35909 RVA: 0x000C8C28 File Offset: 0x000C6E28
		[NullableContext(1)]
		public ADefaultPhysicsVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADefaultPhysicsVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008C46 RID: 35910 RVA: 0x000C8C5B File Offset: 0x000C6E5B
		static ADefaultPhysicsVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DefaultPhysicsVolume");
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x000C8C69 File Offset: 0x000C6E69
		protected ADefaultPhysicsVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004292 RID: 17042
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DefaultPhysicsVolume";

		// Token: 0x04004293 RID: 17043
		private static IntPtr _ClassPtr;

		// Token: 0x04004294 RID: 17044
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
