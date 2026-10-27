using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200091F RID: 2335
	[UnrealObjectPath("/Script/Engine.CascadeLightingFilterVolumeActor")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class ACascadeLightingFilterVolumeActor : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060080CA RID: 32970 RVA: 0x000B8A52 File Offset: 0x000B6C52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACascadeLightingFilterVolumeActor._ClassPtr;
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x000B8A60 File Offset: 0x000B6C60
		public ACascadeLightingFilterVolumeActor() : this(BuiltinUtils.AllocNativeUObject(ACascadeLightingFilterVolumeActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x000B8A88 File Offset: 0x000B6C88
		[NullableContext(1)]
		public ACascadeLightingFilterVolumeActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACascadeLightingFilterVolumeActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x060080CD RID: 32973 RVA: 0x000B8ABB File Offset: 0x000B6CBB
		// (set) Token: 0x060080CE RID: 32974 RVA: 0x000B8ACB File Offset: 0x000B6CCB
		public unsafe bool bEliminateOutsideProbes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingFilterVolumeActor.__PropertyOffset_bEliminateOutsideProbes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingFilterVolumeActor.__PropertyOffset_bEliminateOutsideProbes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x060080CF RID: 32975 RVA: 0x000B8ADC File Offset: 0x000B6CDC
		// (set) Token: 0x060080D0 RID: 32976 RVA: 0x000B8AEC File Offset: 0x000B6CEC
		public unsafe bool bEliminateInsideProbes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingFilterVolumeActor.__PropertyOffset_bEliminateInsideProbes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingFilterVolumeActor.__PropertyOffset_bEliminateInsideProbes) = (value ? 1 : 0);
			}
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x000B8AFD File Offset: 0x000B6CFD
		static ACascadeLightingFilterVolumeActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CascadeLightingFilterVolumeActor");
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x000B8B0B File Offset: 0x000B6D0B
		protected ACascadeLightingFilterVolumeActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D9B RID: 15771
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CascadeLightingFilterVolumeActor";

		// Token: 0x04003D9C RID: 15772
		private static IntPtr _ClassPtr;

		// Token: 0x04003D9D RID: 15773
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D9E RID: 15774
		internal static int __PropertyOffset_bEliminateOutsideProbes;

		// Token: 0x04003D9F RID: 15775
		internal static int __PropertyOffset_bEliminateInsideProbes;
	}
}
