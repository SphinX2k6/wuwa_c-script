using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A20 RID: 6688
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 52)]
	[UnrealObjectPath("/Script/KuroPerformance.KuroPerformanceReport")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 52)]
	public struct FKuroPerformanceReport : IEqualityOperators<FKuroPerformanceReport, FKuroPerformanceReport, bool>, IEquatable<FKuroPerformanceReport>, IUnrealScriptStruct
	{
		// Token: 0x06018BEE RID: 101358 RVA: 0x00248FB0 File Offset: 0x002471B0
		public FKuroPerformanceReport(TEnumAsByte<EKuroProcessorLoad> CPULoadStatus, TEnumAsByte<EKuroProcessorLoad> GPULoadStatus, int TargetFPS, int CPUPerfIndex, int CPULoadIndex, int GPUPerfIndex, int GPULoadIndex, int FrameID, float CPUFrameTime, float GPUFrameTime, float CurTemperature, TEnumAsByte<EKuroThermalStatus> ThermalStatus, float ThermalTempBudget, TEnumAsByte<EKuroPerformanceAdvice> PerformanceAdvice)
		{
			this.CPULoadStatus = CPULoadStatus;
			this.GPULoadStatus = GPULoadStatus;
			this.TargetFPS = TargetFPS;
			this.CPUPerfIndex = CPUPerfIndex;
			this.CPULoadIndex = CPULoadIndex;
			this.GPUPerfIndex = GPUPerfIndex;
			this.GPULoadIndex = GPULoadIndex;
			this.FrameID = FrameID;
			this.CPUFrameTime = CPUFrameTime;
			this.GPUFrameTime = GPUFrameTime;
			this.CurTemperature = CurTemperature;
			this.ThermalStatus = ThermalStatus;
			this.ThermalTempBudget = ThermalTempBudget;
			this.PerformanceAdvice = PerformanceAdvice;
		}

		// Token: 0x06018BEF RID: 101359 RVA: 0x0024902C File Offset: 0x0024722C
		public static bool operator ==(FKuroPerformanceReport left, FKuroPerformanceReport right)
		{
			return left.CPULoadStatus == right.CPULoadStatus && left.GPULoadStatus == right.GPULoadStatus && left.TargetFPS == right.TargetFPS && left.CPUPerfIndex == right.CPUPerfIndex && left.CPULoadIndex == right.CPULoadIndex && left.GPUPerfIndex == right.GPUPerfIndex && left.GPULoadIndex == right.GPULoadIndex && left.FrameID == right.FrameID && left.CPUFrameTime == right.CPUFrameTime && left.GPUFrameTime == right.GPUFrameTime && left.CurTemperature == right.CurTemperature && left.ThermalStatus == right.ThermalStatus && left.ThermalTempBudget == right.ThermalTempBudget && left.PerformanceAdvice == right.PerformanceAdvice;
		}

		// Token: 0x06018BF0 RID: 101360 RVA: 0x00249120 File Offset: 0x00247320
		public static bool operator !=(FKuroPerformanceReport left, FKuroPerformanceReport right)
		{
			return !(left == right);
		}

		// Token: 0x06018BF1 RID: 101361 RVA: 0x0024912C File Offset: 0x0024732C
		public bool Equals(FKuroPerformanceReport other)
		{
			return this == other;
		}

		// Token: 0x06018BF2 RID: 101362 RVA: 0x0024913C File Offset: 0x0024733C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroPerformanceReport)
			{
				FKuroPerformanceReport other = (FKuroPerformanceReport)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06018BF3 RID: 101363 RVA: 0x00249164 File Offset: 0x00247364
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<TEnumAsByte<EKuroProcessorLoad>>(this.CPULoadStatus);
			hashCode.Add<TEnumAsByte<EKuroProcessorLoad>>(this.GPULoadStatus);
			hashCode.Add<int>(this.TargetFPS);
			hashCode.Add<int>(this.CPUPerfIndex);
			hashCode.Add<int>(this.CPULoadIndex);
			hashCode.Add<int>(this.GPUPerfIndex);
			hashCode.Add<int>(this.GPULoadIndex);
			hashCode.Add<int>(this.FrameID);
			hashCode.Add<float>(this.CPUFrameTime);
			hashCode.Add<float>(this.GPUFrameTime);
			hashCode.Add<float>(this.CurTemperature);
			hashCode.Add<TEnumAsByte<EKuroThermalStatus>>(this.ThermalStatus);
			hashCode.Add<float>(this.ThermalTempBudget);
			hashCode.Add<TEnumAsByte<EKuroPerformanceAdvice>>(this.PerformanceAdvice);
			return hashCode.ToHashCode();
		}

		// Token: 0x06018BF4 RID: 101364 RVA: 0x00249236 File Offset: 0x00247436
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPerformanceReport._ScriptStructPtr != 0) ? FKuroPerformanceReport._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPerformance.KuroPerformanceReport", ref FKuroPerformanceReport._ScriptStructPtr);
		}

		// Token: 0x0400D606 RID: 54790
		[FieldOffset(0)]
		public readonly TEnumAsByte<EKuroProcessorLoad> CPULoadStatus;

		// Token: 0x0400D607 RID: 54791
		[FieldOffset(1)]
		public readonly TEnumAsByte<EKuroProcessorLoad> GPULoadStatus;

		// Token: 0x0400D608 RID: 54792
		[FieldOffset(4)]
		public readonly int TargetFPS;

		// Token: 0x0400D609 RID: 54793
		[FieldOffset(8)]
		public readonly int CPUPerfIndex;

		// Token: 0x0400D60A RID: 54794
		[FieldOffset(12)]
		public readonly int CPULoadIndex;

		// Token: 0x0400D60B RID: 54795
		[FieldOffset(16)]
		public readonly int GPUPerfIndex;

		// Token: 0x0400D60C RID: 54796
		[FieldOffset(20)]
		public readonly int GPULoadIndex;

		// Token: 0x0400D60D RID: 54797
		[FieldOffset(24)]
		public readonly int FrameID;

		// Token: 0x0400D60E RID: 54798
		[FieldOffset(28)]
		public readonly float CPUFrameTime;

		// Token: 0x0400D60F RID: 54799
		[FieldOffset(32)]
		public readonly float GPUFrameTime;

		// Token: 0x0400D610 RID: 54800
		[FieldOffset(36)]
		public readonly float CurTemperature;

		// Token: 0x0400D611 RID: 54801
		[FieldOffset(40)]
		public readonly TEnumAsByte<EKuroThermalStatus> ThermalStatus;

		// Token: 0x0400D612 RID: 54802
		[FieldOffset(44)]
		public readonly float ThermalTempBudget;

		// Token: 0x0400D613 RID: 54803
		[FieldOffset(48)]
		public readonly TEnumAsByte<EKuroPerformanceAdvice> PerformanceAdvice;

		// Token: 0x0400D614 RID: 54804
		public const string __ObjectPath = "/Script/KuroPerformance.KuroPerformanceReport";

		// Token: 0x0400D615 RID: 54805
		private static IntPtr _ScriptStructPtr;
	}
}
