using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018A1 RID: 6305
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelGpuParticle")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class UEffectModelGpuParticle : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017383 RID: 95107 RVA: 0x0021DE56 File Offset: 0x0021C056
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelGpuParticle._ClassPtr;
		}

		// Token: 0x06017384 RID: 95108 RVA: 0x0021DE64 File Offset: 0x0021C064
		public UEffectModelGpuParticle() : this(BuiltinUtils.AllocNativeUObject(UEffectModelGpuParticle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017385 RID: 95109 RVA: 0x0021DE8C File Offset: 0x0021C08C
		public UEffectModelGpuParticle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelGpuParticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D5F RID: 23903
		// (get) Token: 0x06017386 RID: 95110 RVA: 0x0021DEC0 File Offset: 0x0021C0C0
		// (set) Token: 0x06017387 RID: 95111 RVA: 0x0021DEF9 File Offset: 0x0021C0F9
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

		// Token: 0x17005D60 RID: 23904
		// (get) Token: 0x06017388 RID: 95112 RVA: 0x0021DF1C File Offset: 0x0021C11C
		// (set) Token: 0x06017389 RID: 95113 RVA: 0x0021DF55 File Offset: 0x0021C155
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

		// Token: 0x17005D61 RID: 23905
		// (get) Token: 0x0601738A RID: 95114 RVA: 0x0021DF78 File Offset: 0x0021C178
		// (set) Token: 0x0601738B RID: 95115 RVA: 0x0021DFB1 File Offset: 0x0021C1B1
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

		// Token: 0x17005D62 RID: 23906
		// (get) Token: 0x0601738C RID: 95116 RVA: 0x0021DFD2 File Offset: 0x0021C1D2
		// (set) Token: 0x0601738D RID: 95117 RVA: 0x0021DFE6 File Offset: 0x0021C1E6
		[Nullable(2)]
		public unsafe UKuroGPUParticleDA Data
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGPUParticleDA>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelGpuParticle.__PropertyOffset_Data);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelGpuParticle.__PropertyOffset_Data, value);
			}
		}

		// Token: 0x17005D63 RID: 23907
		// (get) Token: 0x0601738E RID: 95118 RVA: 0x0021DFFC File Offset: 0x0021C1FC
		// (set) Token: 0x0601738F RID: 95119 RVA: 0x0021E035 File Offset: 0x0021C235
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

		// Token: 0x17005D64 RID: 23908
		// (get) Token: 0x06017390 RID: 95120 RVA: 0x0021E056 File Offset: 0x0021C256
		// (set) Token: 0x06017391 RID: 95121 RVA: 0x0021E066 File Offset: 0x0021C266
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

		// Token: 0x17005D65 RID: 23909
		// (get) Token: 0x06017392 RID: 95122 RVA: 0x0021E077 File Offset: 0x0021C277
		// (set) Token: 0x06017393 RID: 95123 RVA: 0x0021E087 File Offset: 0x0021C287
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

		// Token: 0x17005D66 RID: 23910
		// (get) Token: 0x06017394 RID: 95124 RVA: 0x0021E098 File Offset: 0x0021C298
		// (set) Token: 0x06017395 RID: 95125 RVA: 0x0021E0A8 File Offset: 0x0021C2A8
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

		// Token: 0x17005D67 RID: 23911
		// (get) Token: 0x06017396 RID: 95126 RVA: 0x0021E0B9 File Offset: 0x0021C2B9
		// (set) Token: 0x06017397 RID: 95127 RVA: 0x0021E0C9 File Offset: 0x0021C2C9
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

		// Token: 0x06017398 RID: 95128 RVA: 0x0021E0DA File Offset: 0x0021C2DA
		static UEffectModelGpuParticle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelGpuParticle");
		}

		// Token: 0x06017399 RID: 95129 RVA: 0x0021E0E8 File Offset: 0x0021C2E8
		protected UEffectModelGpuParticle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C988 RID: 51592
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelGpuParticle";

		// Token: 0x0400C989 RID: 51593
		private static IntPtr _ClassPtr;

		// Token: 0x0400C98A RID: 51594
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C98B RID: 51595
		internal static int __PropertyOffset_Location;

		// Token: 0x0400C98C RID: 51596
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x0400C98D RID: 51597
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400C98E RID: 51598
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0400C98F RID: 51599
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400C990 RID: 51600
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0400C991 RID: 51601
		internal static int __PropertyOffset_Data;

		// Token: 0x0400C992 RID: 51602
		internal static int __PropertyOffset_TimeScaler;

		// Token: 0x0400C993 RID: 51603
		[Nullable(2)]
		private FKuroCurveFloat _TimeScaler;

		// Token: 0x0400C994 RID: 51604
		internal static int __PropertyOffset_Loop;

		// Token: 0x0400C995 RID: 51605
		internal static int __PropertyOffset_EnablePingPong;

		// Token: 0x0400C996 RID: 51606
		internal static int __PropertyOffset_PingPongTime;

		// Token: 0x0400C997 RID: 51607
		internal static int __PropertyOffset_ReversePlay;
	}
}
