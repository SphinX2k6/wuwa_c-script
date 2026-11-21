using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004BB RID: 1211
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudsActor")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class AKuroCloudsActor : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F9C RID: 28572 RVA: 0x000A4F92 File Offset: 0x000A3192
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCloudsActor._ClassPtr;
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x000A4FA0 File Offset: 0x000A31A0
		public AKuroCloudsActor() : this(BuiltinUtils.AllocNativeUObject(AKuroCloudsActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x000A4FC8 File Offset: 0x000A31C8
		[NullableContext(1)]
		public AKuroCloudsActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCloudsActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x000A4FFC File Offset: 0x000A31FC
		[NullableContext(2)]
		public void GetGIParams(bool bCounting, UChildActorComponent Child01, UChildActorComponent Child02, UMaterialParameterCollection CloudCardCollection, FName ParameterName, float CurrentTime)
		{
			AKuroCloudsActor.__GetGIParams_Internal(base.NativePtr, bCounting, (Child01 != null) ? Child01.NativePtr : IntPtr.Zero, (Child02 != null) ? Child02.NativePtr : IntPtr.Zero, (CloudCardCollection != null) ? CloudCardCollection.NativePtr : IntPtr.Zero, ParameterName, CurrentTime);
		}

		// Token: 0x06006FA0 RID: 28576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetGIParams_Internal(IntPtr @this, bool bCounting, IntPtr Child01, IntPtr Child02, IntPtr CloudCardCollection, FName ParameterName, float CurrentTime);

		// Token: 0x06006FA1 RID: 28577 RVA: 0x000A504B File Offset: 0x000A324B
		static AKuroCloudsActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudsActor");
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x000A5059 File Offset: 0x000A3259
		protected AKuroCloudsActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003035 RID: 12341
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudsActor";

		// Token: 0x04003036 RID: 12342
		private static IntPtr _ClassPtr;

		// Token: 0x04003037 RID: 12343
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
