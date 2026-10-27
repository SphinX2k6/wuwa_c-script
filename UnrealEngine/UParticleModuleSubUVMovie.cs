using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA9 RID: 4009
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleSubUVMovie")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UParticleModuleSubUVMovie : UParticleModuleSubUV, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D7A8 RID: 55208 RVA: 0x0013DFA5 File Offset: 0x0013C1A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSubUVMovie._ClassPtr;
		}

		// Token: 0x0600D7A9 RID: 55209 RVA: 0x0013DFB4 File Offset: 0x0013C1B4
		public UParticleModuleSubUVMovie() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSubUVMovie.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D7AA RID: 55210 RVA: 0x0013DFDC File Offset: 0x0013C1DC
		public UParticleModuleSubUVMovie(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSubUVMovie.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600D7AB RID: 55211 RVA: 0x0013E00F File Offset: 0x0013C20F
		// (set) Token: 0x0600D7AC RID: 55212 RVA: 0x0013E028 File Offset: 0x0013C228
		public unsafe bool bUseEmitterTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSubUVMovie.__PropertyOffset_bUseEmitterTime) & UParticleModuleSubUVMovie.__PropertyMask_bUseEmitterTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSubUVMovie.__PropertyOffset_bUseEmitterTime) = ((*(base.NativePtr + (IntPtr)UParticleModuleSubUVMovie.__PropertyOffset_bUseEmitterTime) & ~UParticleModuleSubUVMovie.__PropertyMask_bUseEmitterTime) | (value ? UParticleModuleSubUVMovie.__PropertyMask_bUseEmitterTime : 0));
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600D7AD RID: 55213 RVA: 0x0013E058 File Offset: 0x0013C258
		// (set) Token: 0x0600D7AE RID: 55214 RVA: 0x0013E091 File Offset: 0x0013C291
		public FRawDistributionFloat FrameRate
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._FrameRate) == null)
				{
					result = (this._FrameRate = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleSubUVMovie.__PropertyOffset_FrameRate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSubUVMovie.__PropertyOffset_FrameRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600D7AF RID: 55215 RVA: 0x0013E0B2 File Offset: 0x0013C2B2
		// (set) Token: 0x0600D7B0 RID: 55216 RVA: 0x0013E0C2 File Offset: 0x0013C2C2
		public unsafe int StartingFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleSubUVMovie.__PropertyOffset_StartingFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleSubUVMovie.__PropertyOffset_StartingFrame) = value;
			}
		}

		// Token: 0x0600D7B1 RID: 55217 RVA: 0x0013E0D3 File Offset: 0x0013C2D3
		static UParticleModuleSubUVMovie()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSubUVMovie");
		}

		// Token: 0x0600D7B2 RID: 55218 RVA: 0x0013E0E1 File Offset: 0x0013C2E1
		protected UParticleModuleSubUVMovie(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040074B6 RID: 29878
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSubUVMovie";

		// Token: 0x040074B7 RID: 29879
		private static IntPtr _ClassPtr;

		// Token: 0x040074B8 RID: 29880
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040074B9 RID: 29881
		internal static int __PropertyOffset_bUseEmitterTime;

		// Token: 0x040074BA RID: 29882
		internal static byte __PropertyMask_bUseEmitterTime;

		// Token: 0x040074BB RID: 29883
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x040074BC RID: 29884
		[Nullable(2)]
		private FRawDistributionFloat _FrameRate;

		// Token: 0x040074BD RID: 29885
		internal static int __PropertyOffset_StartingFrame;
	}
}
