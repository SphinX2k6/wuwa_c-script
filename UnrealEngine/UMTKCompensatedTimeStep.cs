using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200246E RID: 9326
	[UnrealObjectPath("/Script/MTKCompensatedTimeStep.MTKCompensatedTimeStep")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UMTKCompensatedTimeStep : UEngineCustomTimeStep, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022EC7 RID: 143047 RVA: 0x0033A141 File Offset: 0x00338341
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMTKCompensatedTimeStep._ClassPtr;
		}

		// Token: 0x06022EC8 RID: 143048 RVA: 0x0033A150 File Offset: 0x00338350
		public UMTKCompensatedTimeStep() : this(BuiltinUtils.AllocNativeUObject(UMTKCompensatedTimeStep.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022EC9 RID: 143049 RVA: 0x0033A178 File Offset: 0x00338378
		[NullableContext(1)]
		public UMTKCompensatedTimeStep(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMTKCompensatedTimeStep.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022ECA RID: 143050 RVA: 0x0033A1AB File Offset: 0x003383AB
		static UMTKCompensatedTimeStep()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MTKCompensatedTimeStep.MTKCompensatedTimeStep");
		}

		// Token: 0x06022ECB RID: 143051 RVA: 0x0033A1B9 File Offset: 0x003383B9
		protected UMTKCompensatedTimeStep(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A3A RID: 76346
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MTKCompensatedTimeStep.MTKCompensatedTimeStep";

		// Token: 0x04012A3B RID: 76347
		private static IntPtr _ClassPtr;

		// Token: 0x04012A3C RID: 76348
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
