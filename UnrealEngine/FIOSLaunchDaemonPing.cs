using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FA7 RID: 8103
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/LaunchDaemonMessages.IOSLaunchDaemonPing")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FIOSLaunchDaemonPing : IEqualityOperators<FIOSLaunchDaemonPing, FIOSLaunchDaemonPing, bool>, IEquatable<FIOSLaunchDaemonPing>, IUnrealScriptStruct
	{
		// Token: 0x0601EBF1 RID: 125937 RVA: 0x002DB5AC File Offset: 0x002D97AC
		public unsafe static bool operator ==(FIOSLaunchDaemonPing left, FIOSLaunchDaemonPing right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x0601EBF2 RID: 125938 RVA: 0x002DB5D8 File Offset: 0x002D97D8
		public static bool operator !=(FIOSLaunchDaemonPing left, FIOSLaunchDaemonPing right)
		{
			return !(left == right);
		}

		// Token: 0x0601EBF3 RID: 125939 RVA: 0x002DB5E4 File Offset: 0x002D97E4
		public bool Equals(FIOSLaunchDaemonPing other)
		{
			return this == other;
		}

		// Token: 0x0601EBF4 RID: 125940 RVA: 0x002DB5F4 File Offset: 0x002D97F4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FIOSLaunchDaemonPing)
			{
				FIOSLaunchDaemonPing other = (FIOSLaunchDaemonPing)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601EBF5 RID: 125941 RVA: 0x002DB619 File Offset: 0x002D9819
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIOSLaunchDaemonPing._ScriptStructPtr != 0) ? FIOSLaunchDaemonPing._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LaunchDaemonMessages.IOSLaunchDaemonPing", ref FIOSLaunchDaemonPing._ScriptStructPtr);
		}

		// Token: 0x040109FD RID: 68093
		public const string __ObjectPath = "/Script/LaunchDaemonMessages.IOSLaunchDaemonPing";

		// Token: 0x040109FE RID: 68094
		private static IntPtr _ScriptStructPtr;
	}
}
