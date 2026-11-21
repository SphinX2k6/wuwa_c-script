using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200049B RID: 1179
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 52)]
	[UnrealObjectPath("/Script/KuroPerformance.KuroPerformanceReport")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 52)]
	public struct FKuroPerformanceReport : IEqualityOperators<FKuroPerformanceReport, FKuroPerformanceReport, bool>, IEquatable<FKuroPerformanceReport>, IUnrealScriptStruct
	{
		// Token: 0x06006E0B RID: 28171 RVA: 0x000A1B64 File Offset: 0x0009FD64
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

		// Token: 0x06006E0C RID: 28172 RVA: 0x000A1BE0 File Offset: 0x0009FDE0
		public static bool operator ==(FKuroPerformanceReport left, FKuroPerformanceReport right)
		{
			return left.CPULoadStatus == right.CPULoadStatus && left.GPULoadStatus == right.GPULoadStatus && left.TargetFPS == right.TargetFPS && left.CPUPerfIndex == right.CPUPerfIndex && left.CPULoadIndex == right.CPULoadIndex && left.GPUPerfIndex == right.GPUPerfIndex && left.GPULoadIndex == right.GPULoadIndex && left.FrameID == right.FrameID && left.CPUFrameTime == right.CPUFrameTime && left.GPUFrameTime == right.GPUFrameTime && left.CurTemperature == right.CurTemperature && left.ThermalStatus == right.ThermalStatus && left.ThermalTempBudget == right.ThermalTempBudget && left.PerformanceAdvice == right.PerformanceAdvice;
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x000A1CD4 File Offset: 0x0009FED4
		public static bool operator !=(FKuroPerformanceReport left, FKuroPerformanceReport right)
		{
			return !(left == right);
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x000A1CE0 File Offset: 0x0009FEE0
		public bool Equals(FKuroPerformanceReport other)
		{
			return this == other;
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x000A1CF0 File Offset: 0x0009FEF0
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

		// Token: 0x06006E10 RID: 28176 RVA: 0x000A1D18 File Offset: 0x0009FF18
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

		// Token: 0x06006E11 RID: 28177 RVA: 0x000A1DEA File Offset: 0x0009FFEA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPerformanceReport._ScriptStructPtr != 0) ? FKuroPerformanceReport._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPerformance.KuroPerformanceReport", ref FKuroPerformanceReport._ScriptStructPtr);
		}

		// Token: 0x04002F13 RID: 12051
		[FieldOffset(0)]
		public readonly TEnumAsByte<EKuroProcessorLoad> CPULoadStatus;

		// Token: 0x04002F14 RID: 12052
		[FieldOffset(1)]
		public readonly TEnumAsByte<EKuroProcessorLoad> GPULoadStatus;

		// Token: 0x04002F15 RID: 12053
		[FieldOffset(4)]
		public readonly int TargetFPS;

		// Token: 0x04002F16 RID: 12054
		[FieldOffset(8)]
		public readonly int CPUPerfIndex;

		// Token: 0x04002F17 RID: 12055
		[FieldOffset(12)]
		public readonly int CPULoadIndex;

		// Token: 0x04002F18 RID: 12056
		[FieldOffset(16)]
		public readonly int GPUPerfIndex;

		// Token: 0x04002F19 RID: 12057
		[FieldOffset(20)]
		public readonly int GPULoadIndex;

		// Token: 0x04002F1A RID: 12058
		[FieldOffset(24)]
		public readonly int FrameID;

		// Token: 0x04002F1B RID: 12059
		[FieldOffset(28)]
		public readonly float CPUFrameTime;

		// Token: 0x04002F1C RID: 12060
		[FieldOffset(32)]
		public readonly float GPUFrameTime;

		// Token: 0x04002F1D RID: 12061
		[FieldOffset(36)]
		public readonly float CurTemperature;

		// Token: 0x04002F1E RID: 12062
		[FieldOffset(40)]
		public readonly TEnumAsByte<EKuroThermalStatus> ThermalStatus;

		// Token: 0x04002F1F RID: 12063
		[FieldOffset(44)]
		public readonly float ThermalTempBudget;

		// Token: 0x04002F20 RID: 12064
		[FieldOffset(48)]
		public readonly TEnumAsByte<EKuroPerformanceAdvice> PerformanceAdvice;

		// Token: 0x04002F21 RID: 12065
		public const string __ObjectPath = "/Script/KuroPerformance.KuroPerformanceReport";

		// Token: 0x04002F22 RID: 12066
		private static IntPtr _ScriptStructPtr;
	}
}
