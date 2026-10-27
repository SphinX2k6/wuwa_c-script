using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ADE RID: 6878
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDecalActor")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AKuroDecalActor : ADecalActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019A03 RID: 104963 RVA: 0x0025DF41 File Offset: 0x0025C141
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroDecalActor._ClassPtr;
		}

		// Token: 0x06019A04 RID: 104964 RVA: 0x0025DF50 File Offset: 0x0025C150
		public AKuroDecalActor() : this(BuiltinUtils.AllocNativeUObject(AKuroDecalActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019A05 RID: 104965 RVA: 0x0025DF78 File Offset: 0x0025C178
		[NullableContext(1)]
		public AKuroDecalActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroDecalActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019A06 RID: 104966 RVA: 0x0025DFAB File Offset: 0x0025C1AB
		static AKuroDecalActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDecalActor");
		}

		// Token: 0x06019A07 RID: 104967 RVA: 0x0025DFB9 File Offset: 0x0025C1B9
		protected AKuroDecalActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF1C RID: 57116
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDecalActor";

		// Token: 0x0400DF1D RID: 57117
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF1E RID: 57118
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
