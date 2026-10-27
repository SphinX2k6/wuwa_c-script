using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001149 RID: 4425
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeModulatorContinuous")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class USoundNodeModulatorContinuous : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060102B0 RID: 66224 RVA: 0x0017D2DE File Offset: 0x0017B4DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeModulatorContinuous._ClassPtr;
		}

		// Token: 0x060102B1 RID: 66225 RVA: 0x0017D2EC File Offset: 0x0017B4EC
		public USoundNodeModulatorContinuous() : this(BuiltinUtils.AllocNativeUObject(USoundNodeModulatorContinuous.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060102B2 RID: 66226 RVA: 0x0017D314 File Offset: 0x0017B514
		public USoundNodeModulatorContinuous(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeModulatorContinuous.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x060102B3 RID: 66227 RVA: 0x0017D348 File Offset: 0x0017B548
		// (set) Token: 0x060102B4 RID: 66228 RVA: 0x0017D381 File Offset: 0x0017B581
		public FModulatorContinuousParams PitchModulationParams
		{
			get
			{
				base.FastCheckIsValid();
				FModulatorContinuousParams result;
				if ((result = this._PitchModulationParams) == null)
				{
					result = (this._PitchModulationParams = new FModulatorContinuousParams(base.NativePtr + (IntPtr)USoundNodeModulatorContinuous.__PropertyOffset_PitchModulationParams, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FModulatorContinuousParams.StaticStruct(), base.NativePtr + (IntPtr)USoundNodeModulatorContinuous.__PropertyOffset_PitchModulationParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x060102B5 RID: 66229 RVA: 0x0017D3A4 File Offset: 0x0017B5A4
		// (set) Token: 0x060102B6 RID: 66230 RVA: 0x0017D3DD File Offset: 0x0017B5DD
		public FModulatorContinuousParams VolumeModulationParams
		{
			get
			{
				base.FastCheckIsValid();
				FModulatorContinuousParams result;
				if ((result = this._VolumeModulationParams) == null)
				{
					result = (this._VolumeModulationParams = new FModulatorContinuousParams(base.NativePtr + (IntPtr)USoundNodeModulatorContinuous.__PropertyOffset_VolumeModulationParams, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FModulatorContinuousParams.StaticStruct(), base.NativePtr + (IntPtr)USoundNodeModulatorContinuous.__PropertyOffset_VolumeModulationParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060102B7 RID: 66231 RVA: 0x0017D3FE File Offset: 0x0017B5FE
		static USoundNodeModulatorContinuous()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeModulatorContinuous");
		}

		// Token: 0x060102B8 RID: 66232 RVA: 0x0017D40C File Offset: 0x0017B60C
		protected USoundNodeModulatorContinuous(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B2D RID: 35629
		public new const string __ObjectPath = "/Script/Engine.SoundNodeModulatorContinuous";

		// Token: 0x04008B2E RID: 35630
		private static IntPtr _ClassPtr;

		// Token: 0x04008B2F RID: 35631
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B30 RID: 35632
		internal static int __PropertyOffset_PitchModulationParams;

		// Token: 0x04008B31 RID: 35633
		[Nullable(2)]
		private FModulatorContinuousParams _PitchModulationParams;

		// Token: 0x04008B32 RID: 35634
		internal static int __PropertyOffset_VolumeModulationParams;

		// Token: 0x04008B33 RID: 35635
		[Nullable(2)]
		private FModulatorContinuousParams _VolumeModulationParams;
	}
}
