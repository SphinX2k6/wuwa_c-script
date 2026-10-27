using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002266 RID: 8806
	[UnrealObjectPath("/Script/MagtModule.MagtActor")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class AMagtActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021752 RID: 137042 RVA: 0x003167E9 File Offset: 0x003149E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AMagtActor._ClassPtr;
		}

		// Token: 0x06021753 RID: 137043 RVA: 0x003167F8 File Offset: 0x003149F8
		public AMagtActor() : this(BuiltinUtils.AllocNativeUObject(AMagtActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021754 RID: 137044 RVA: 0x00316820 File Offset: 0x00314A20
		[NullableContext(1)]
		public AMagtActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AMagtActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008216 RID: 33302
		// (get) Token: 0x06021755 RID: 137045 RVA: 0x00316853 File Offset: 0x00314A53
		// (set) Token: 0x06021756 RID: 137046 RVA: 0x00316863 File Offset: 0x00314A63
		public unsafe int CPUPerf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_CPUPerf);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_CPUPerf) = value;
			}
		}

		// Token: 0x17008217 RID: 33303
		// (get) Token: 0x06021757 RID: 137047 RVA: 0x00316874 File Offset: 0x00314A74
		// (set) Token: 0x06021758 RID: 137048 RVA: 0x00316884 File Offset: 0x00314A84
		public unsafe int CPULoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_CPULoad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_CPULoad) = value;
			}
		}

		// Token: 0x17008218 RID: 33304
		// (get) Token: 0x06021759 RID: 137049 RVA: 0x00316895 File Offset: 0x00314A95
		// (set) Token: 0x0602175A RID: 137050 RVA: 0x003168A5 File Offset: 0x00314AA5
		public unsafe int GPUPerf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_GPUPerf);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_GPUPerf) = value;
			}
		}

		// Token: 0x17008219 RID: 33305
		// (get) Token: 0x0602175B RID: 137051 RVA: 0x003168B6 File Offset: 0x00314AB6
		// (set) Token: 0x0602175C RID: 137052 RVA: 0x003168C6 File Offset: 0x00314AC6
		public unsafe int GPULoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_GPULoad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_GPULoad) = value;
			}
		}

		// Token: 0x1700821A RID: 33306
		// (get) Token: 0x0602175D RID: 137053 RVA: 0x003168D7 File Offset: 0x00314AD7
		// (set) Token: 0x0602175E RID: 137054 RVA: 0x003168E7 File Offset: 0x00314AE7
		public unsafe int Status
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_Status);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_Status) = value;
			}
		}

		// Token: 0x1700821B RID: 33307
		// (get) Token: 0x0602175F RID: 137055 RVA: 0x003168F8 File Offset: 0x00314AF8
		// (set) Token: 0x06021760 RID: 137056 RVA: 0x00316908 File Offset: 0x00314B08
		public unsafe int Temperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_Temperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_Temperature) = value;
			}
		}

		// Token: 0x1700821C RID: 33308
		// (get) Token: 0x06021761 RID: 137057 RVA: 0x00316919 File Offset: 0x00314B19
		// (set) Token: 0x06021762 RID: 137058 RVA: 0x00316929 File Offset: 0x00314B29
		public unsafe int Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_Power);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_Power) = value;
			}
		}

		// Token: 0x1700821D RID: 33309
		// (get) Token: 0x06021763 RID: 137059 RVA: 0x0031693A File Offset: 0x00314B3A
		// (set) Token: 0x06021764 RID: 137060 RVA: 0x0031694A File Offset: 0x00314B4A
		public unsafe int FPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_FPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_FPS) = value;
			}
		}

		// Token: 0x1700821E RID: 33310
		// (get) Token: 0x06021765 RID: 137061 RVA: 0x0031695B File Offset: 0x00314B5B
		// (set) Token: 0x06021766 RID: 137062 RVA: 0x0031696B File Offset: 0x00314B6B
		public unsafe int TargetFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_TargetFPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMagtActor.__PropertyOffset_TargetFPS) = value;
			}
		}

		// Token: 0x06021767 RID: 137063 RVA: 0x0031697C File Offset: 0x00314B7C
		static AMagtActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtActor");
		}

		// Token: 0x06021768 RID: 137064 RVA: 0x0031698A File Offset: 0x00314B8A
		protected AMagtActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011DC7 RID: 73159
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MagtModule.MagtActor";

		// Token: 0x04011DC8 RID: 73160
		private static IntPtr _ClassPtr;

		// Token: 0x04011DC9 RID: 73161
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011DCA RID: 73162
		internal static int __PropertyOffset_CPUPerf;

		// Token: 0x04011DCB RID: 73163
		internal static int __PropertyOffset_CPULoad;

		// Token: 0x04011DCC RID: 73164
		internal static int __PropertyOffset_GPUPerf;

		// Token: 0x04011DCD RID: 73165
		internal static int __PropertyOffset_GPULoad;

		// Token: 0x04011DCE RID: 73166
		internal static int __PropertyOffset_Status;

		// Token: 0x04011DCF RID: 73167
		internal static int __PropertyOffset_Temperature;

		// Token: 0x04011DD0 RID: 73168
		internal static int __PropertyOffset_Power;

		// Token: 0x04011DD1 RID: 73169
		internal static int __PropertyOffset_FPS;

		// Token: 0x04011DD2 RID: 73170
		internal static int __PropertyOffset_TargetFPS;
	}
}
