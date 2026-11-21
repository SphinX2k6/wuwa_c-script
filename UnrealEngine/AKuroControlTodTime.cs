using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004BC RID: 1212
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroControlTodTime")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroControlTodTime : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006FA3 RID: 28579 RVA: 0x000A5062 File Offset: 0x000A3262
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroControlTodTime._ClassPtr;
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x000A5070 File Offset: 0x000A3270
		public AKuroControlTodTime() : this(BuiltinUtils.AllocNativeUObject(AKuroControlTodTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x000A5098 File Offset: 0x000A3298
		[NullableContext(1)]
		public AKuroControlTodTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroControlTodTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x000A50CB File Offset: 0x000A32CB
		public virtual void DoUpdate(float DeltaTime)
		{
			AKuroControlTodTime.__DoUpdate_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06006FA7 RID: 28583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoUpdate_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06006FA8 RID: 28584 RVA: 0x000A50D9 File Offset: 0x000A32D9
		static AKuroControlTodTime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroControlTodTime");
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x000A50E7 File Offset: 0x000A32E7
		protected AKuroControlTodTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003038 RID: 12344
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroControlTodTime";

		// Token: 0x04003039 RID: 12345
		private static IntPtr _ClassPtr;

		// Token: 0x0400303A RID: 12346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02000C05 RID: 3077
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DoUpdate_FunctionParams
		{
			// Token: 0x04005E3A RID: 24122
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
