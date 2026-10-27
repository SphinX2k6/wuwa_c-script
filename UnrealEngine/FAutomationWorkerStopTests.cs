using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000425 RID: 1061
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerStopTests")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FAutomationWorkerStopTests : IEqualityOperators<FAutomationWorkerStopTests, FAutomationWorkerStopTests, bool>, IEquatable<FAutomationWorkerStopTests>, IUnrealScriptStruct
	{
		// Token: 0x06003916 RID: 14614 RVA: 0x00056B60 File Offset: 0x00054D60
		public unsafe static bool operator ==(FAutomationWorkerStopTests left, FAutomationWorkerStopTests right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x00056B8C File Offset: 0x00054D8C
		public static bool operator !=(FAutomationWorkerStopTests left, FAutomationWorkerStopTests right)
		{
			return !(left == right);
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00056B98 File Offset: 0x00054D98
		public bool Equals(FAutomationWorkerStopTests other)
		{
			return this == other;
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00056BA8 File Offset: 0x00054DA8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FAutomationWorkerStopTests)
			{
				FAutomationWorkerStopTests other = (FAutomationWorkerStopTests)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00056BCD File Offset: 0x00054DCD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerStopTests._ScriptStructPtr != 0) ? FAutomationWorkerStopTests._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerStopTests", ref FAutomationWorkerStopTests._ScriptStructPtr);
		}

		// Token: 0x040019E7 RID: 6631
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerStopTests";

		// Token: 0x040019E8 RID: 6632
		private static IntPtr _ScriptStructPtr;
	}
}
