using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000974 RID: 2420
	[UnrealObjectPath("/Script/Engine.ControlChannel")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UControlChannel : UChannel, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060088C0 RID: 35008 RVA: 0x000C4054 File Offset: 0x000C2254
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlChannel._ClassPtr;
		}

		// Token: 0x060088C1 RID: 35009 RVA: 0x000C4060 File Offset: 0x000C2260
		public UControlChannel() : this(BuiltinUtils.AllocNativeUObject(UControlChannel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060088C2 RID: 35010 RVA: 0x000C4088 File Offset: 0x000C2288
		[NullableContext(1)]
		public UControlChannel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlChannel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060088C3 RID: 35011 RVA: 0x000C40BB File Offset: 0x000C22BB
		static UControlChannel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ControlChannel");
		}

		// Token: 0x060088C4 RID: 35012 RVA: 0x000C40C9 File Offset: 0x000C22C9
		protected UControlChannel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400410A RID: 16650
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ControlChannel";

		// Token: 0x0400410B RID: 16651
		private static IntPtr _ClassPtr;

		// Token: 0x0400410C RID: 16652
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
