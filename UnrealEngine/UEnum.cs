using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000101 RID: 257
	[UnrealObjectPath("/Script/CoreUObject.Enum")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UEnum : UField, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600110D RID: 4365 RVA: 0x0001B0A6 File Offset: 0x000192A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnum._ClassPtr;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0001B0B4 File Offset: 0x000192B4
		public UEnum() : this(BuiltinUtils.AllocNativeUObject(UEnum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0001B0DC File Offset: 0x000192DC
		[NullableContext(1)]
		public UEnum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0001B10F File Offset: 0x0001930F
		static UEnum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Enum");
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0001B11D File Offset: 0x0001931D
		protected UEnum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000474 RID: 1140
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Enum";

		// Token: 0x04000475 RID: 1141
		private static IntPtr _ClassPtr;

		// Token: 0x04000476 RID: 1142
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
