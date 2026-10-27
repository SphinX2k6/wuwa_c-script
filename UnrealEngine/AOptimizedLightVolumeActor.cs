using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F36 RID: 3894
	[UnrealObjectPath("/Script/Engine.OptimizedLightVolumeActor")]
	[UnrealStructLayout(1304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1304)]
	public class AOptimizedLightVolumeActor : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D1FE RID: 53758 RVA: 0x00133C56 File Offset: 0x00131E56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AOptimizedLightVolumeActor._ClassPtr;
		}

		// Token: 0x0600D1FF RID: 53759 RVA: 0x00133C64 File Offset: 0x00131E64
		public AOptimizedLightVolumeActor() : this(BuiltinUtils.AllocNativeUObject(AOptimizedLightVolumeActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D200 RID: 53760 RVA: 0x00133C8C File Offset: 0x00131E8C
		[NullableContext(1)]
		public AOptimizedLightVolumeActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AOptimizedLightVolumeActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x0600D201 RID: 53761 RVA: 0x00133CBF File Offset: 0x00131EBF
		// (set) Token: 0x0600D202 RID: 53762 RVA: 0x00133CD8 File Offset: 0x00131ED8
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AOptimizedLightVolumeActor.__PropertyOffset_bEnabled) & AOptimizedLightVolumeActor.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AOptimizedLightVolumeActor.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)AOptimizedLightVolumeActor.__PropertyOffset_bEnabled) & ~AOptimizedLightVolumeActor.__PropertyMask_bEnabled) | (value ? AOptimizedLightVolumeActor.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x0600D203 RID: 53763 RVA: 0x00133D08 File Offset: 0x00131F08
		public bool IsOptimizedLightVolumeEnabled()
		{
			return AOptimizedLightVolumeActor.__IsOptimizedLightVolumeEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600D204 RID: 53764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOptimizedLightVolumeEnabled_Internal(IntPtr @this);

		// Token: 0x0600D205 RID: 53765 RVA: 0x00133D15 File Offset: 0x00131F15
		static AOptimizedLightVolumeActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.OptimizedLightVolumeActor");
		}

		// Token: 0x0600D206 RID: 53766 RVA: 0x00133D23 File Offset: 0x00131F23
		protected AOptimizedLightVolumeActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040070B3 RID: 28851
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.OptimizedLightVolumeActor";

		// Token: 0x040070B4 RID: 28852
		private static IntPtr _ClassPtr;

		// Token: 0x040070B5 RID: 28853
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040070B6 RID: 28854
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040070B7 RID: 28855
		internal static byte __PropertyMask_bEnabled;
	}
}
