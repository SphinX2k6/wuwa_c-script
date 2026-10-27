using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A5A RID: 10842
	[UnrealObjectPath("/Script/VolumeGIRender.ProbeVolumeActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AProbeVolumeActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028095 RID: 163989 RVA: 0x003CF12A File Offset: 0x003CD32A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AProbeVolumeActor._ClassPtr;
		}

		// Token: 0x06028096 RID: 163990 RVA: 0x003CF138 File Offset: 0x003CD338
		public AProbeVolumeActor() : this(BuiltinUtils.AllocNativeUObject(AProbeVolumeActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028097 RID: 163991 RVA: 0x003CF160 File Offset: 0x003CD360
		[NullableContext(1)]
		public AProbeVolumeActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AProbeVolumeActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098EC RID: 39148
		// (get) Token: 0x06028098 RID: 163992 RVA: 0x003CF193 File Offset: 0x003CD393
		// (set) Token: 0x06028099 RID: 163993 RVA: 0x003CF1A7 File Offset: 0x003CD3A7
		[Nullable(2)]
		public unsafe UGIVolumeComponent GIVolumeComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGIVolumeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AProbeVolumeActor.__PropertyOffset_GIVolumeComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AProbeVolumeActor.__PropertyOffset_GIVolumeComp, value);
			}
		}

		// Token: 0x0602809A RID: 163994 RVA: 0x003CF1BC File Offset: 0x003CD3BC
		static AProbeVolumeActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/VolumeGIRender.ProbeVolumeActor");
		}

		// Token: 0x0602809B RID: 163995 RVA: 0x003CF1CA File Offset: 0x003CD3CA
		protected AProbeVolumeActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F57 RID: 89943
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/VolumeGIRender.ProbeVolumeActor";

		// Token: 0x04015F58 RID: 89944
		private static IntPtr _ClassPtr;

		// Token: 0x04015F59 RID: 89945
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F5A RID: 89946
		internal static int __PropertyOffset_GIVolumeComp;
	}
}
