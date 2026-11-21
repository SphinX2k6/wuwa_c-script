using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C4 RID: 964
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelGpuParticle")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class UEffectModelGpuParticle : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005E2A RID: 24106 RVA: 0x00085282 File Offset: 0x00083482
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelGpuParticle._ClassPtr;
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x00085290 File Offset: 0x00083490
		public UEffectModelGpuParticle() : this(BuiltinUtils.AllocNativeUObject(UEffectModelGpuParticle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x000852B8 File Offset: 0x000834B8
		public UEffectModelGpuParticle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelGpuParticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06005E2D RID: 24109 RVA: 0x000852EC File Offset: 0x000834EC
		// (set) Token: 0x06005E2E RID: 24110 RVA: 0x00085325 File Offset: 0x00083525
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06005E2F RID: 24111 RVA: 0x00085348 File Offset: 0x00083548
		// (set) Token: 0x06005E30 RID: 24112 RVA: 0x00085381 File Offset: 0x00083581
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06005E31 RID: 24113 RVA: 0x000853A4 File Offset: 0x000835A4
		// (set) Token: 0x06005E32 RID: 24114 RVA: 0x000853DD File Offset: 0x000835DD
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_Scale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06005E33 RID: 24115 RVA: 0x00085400 File Offset: 0x00083600
		// (set) Token: 0x06005E34 RID: 24116 RVA: 0x00085439 File Offset: 0x00083639
		public FKuroCurveFloat TimeScaler
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._TimeScaler) == null)
				{
					result = (this._TimeScaler = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_TimeScaler, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_TimeScaler, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06005E35 RID: 24117 RVA: 0x0008545A File Offset: 0x0008365A
		// (set) Token: 0x06005E36 RID: 24118 RVA: 0x0008546A File Offset: 0x0008366A
		public unsafe bool Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_Loop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_Loop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06005E37 RID: 24119 RVA: 0x0008547B File Offset: 0x0008367B
		// (set) Token: 0x06005E38 RID: 24120 RVA: 0x0008548B File Offset: 0x0008368B
		public unsafe bool EnablePingPong
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_EnablePingPong) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_EnablePingPong) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06005E39 RID: 24121 RVA: 0x0008549C File Offset: 0x0008369C
		// (set) Token: 0x06005E3A RID: 24122 RVA: 0x000854AC File Offset: 0x000836AC
		public unsafe float PingPongTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_PingPongTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_PingPongTime) = value;
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06005E3B RID: 24123 RVA: 0x000854BD File Offset: 0x000836BD
		// (set) Token: 0x06005E3C RID: 24124 RVA: 0x000854CD File Offset: 0x000836CD
		public unsafe bool ReversePlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_ReversePlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelGpuParticle.__PropertyOffset_ReversePlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x000854DE File Offset: 0x000836DE
		static UEffectModelGpuParticle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelGpuParticle");
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x000854EC File Offset: 0x000836EC
		protected UEffectModelGpuParticle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002754 RID: 10068
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelGpuParticle";

		// Token: 0x04002755 RID: 10069
		private static IntPtr _ClassPtr;

		// Token: 0x04002756 RID: 10070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002757 RID: 10071
		internal static int __PropertyOffset_Location;

		// Token: 0x04002758 RID: 10072
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x04002759 RID: 10073
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400275A RID: 10074
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0400275B RID: 10075
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400275C RID: 10076
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0400275D RID: 10077
		internal static int __PropertyOffset_TimeScaler;

		// Token: 0x0400275E RID: 10078
		[Nullable(2)]
		private FKuroCurveFloat _TimeScaler;

		// Token: 0x0400275F RID: 10079
		internal static int __PropertyOffset_Loop;

		// Token: 0x04002760 RID: 10080
		internal static int __PropertyOffset_EnablePingPong;

		// Token: 0x04002761 RID: 10081
		internal static int __PropertyOffset_PingPongTime;

		// Token: 0x04002762 RID: 10082
		internal static int __PropertyOffset_ReversePlay;
	}
}
