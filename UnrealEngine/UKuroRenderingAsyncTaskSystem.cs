using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B9C RID: 7068
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingAsyncTaskSystem")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroRenderingAsyncTaskSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AE9C RID: 110236 RVA: 0x0027AC90 File Offset: 0x00278E90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRenderingAsyncTaskSystem._ClassPtr;
		}

		// Token: 0x0601AE9D RID: 110237 RVA: 0x0027AC9C File Offset: 0x00278E9C
		public UKuroRenderingAsyncTaskSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingAsyncTaskSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AE9E RID: 110238 RVA: 0x0027ACC4 File Offset: 0x00278EC4
		[NullableContext(1)]
		public UKuroRenderingAsyncTaskSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingAsyncTaskSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601AE9F RID: 110239 RVA: 0x0027ACF7 File Offset: 0x00278EF7
		static UKuroRenderingAsyncTaskSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingAsyncTaskSystem");
		}

		// Token: 0x0601AEA0 RID: 110240 RVA: 0x0027AD05 File Offset: 0x00278F05
		protected UKuroRenderingAsyncTaskSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E8F2 RID: 59634
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingAsyncTaskSystem";

		// Token: 0x0400E8F3 RID: 59635
		private static IntPtr _ClassPtr;

		// Token: 0x0400E8F4 RID: 59636
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
