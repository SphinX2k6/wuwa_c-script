using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B7 RID: 2231
	[UnrealObjectPath("/Script/Engine.BlockingVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ABlockingVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060079EC RID: 31212 RVA: 0x000AE62F File Offset: 0x000AC82F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABlockingVolume._ClassPtr;
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x000AE63C File Offset: 0x000AC83C
		public ABlockingVolume() : this(BuiltinUtils.AllocNativeUObject(ABlockingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x000AE664 File Offset: 0x000AC864
		[NullableContext(1)]
		public ABlockingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABlockingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x000AE697 File Offset: 0x000AC897
		static ABlockingVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlockingVolume");
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x000AE6A5 File Offset: 0x000AC8A5
		protected ABlockingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A9A RID: 15002
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlockingVolume";

		// Token: 0x04003A9B RID: 15003
		private static IntPtr _ClassPtr;

		// Token: 0x04003A9C RID: 15004
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
