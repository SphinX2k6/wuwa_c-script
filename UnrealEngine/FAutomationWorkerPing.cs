using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200041B RID: 1051
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerPing")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FAutomationWorkerPing : IEqualityOperators<FAutomationWorkerPing, FAutomationWorkerPing, bool>, IEquatable<FAutomationWorkerPing>, IUnrealScriptStruct
	{
		// Token: 0x06003893 RID: 14483 RVA: 0x000560A4 File Offset: 0x000542A4
		public unsafe static bool operator ==(FAutomationWorkerPing left, FAutomationWorkerPing right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x000560D0 File Offset: 0x000542D0
		public static bool operator !=(FAutomationWorkerPing left, FAutomationWorkerPing right)
		{
			return !(left == right);
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x000560DC File Offset: 0x000542DC
		public bool Equals(FAutomationWorkerPing other)
		{
			return this == other;
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x000560EC File Offset: 0x000542EC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FAutomationWorkerPing)
			{
				FAutomationWorkerPing other = (FAutomationWorkerPing)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00056111 File Offset: 0x00054311
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerPing._ScriptStructPtr != 0) ? FAutomationWorkerPing._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerPing", ref FAutomationWorkerPing._ScriptStructPtr);
		}

		// Token: 0x040019B0 RID: 6576
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerPing";

		// Token: 0x040019B1 RID: 6577
		private static IntPtr _ScriptStructPtr;
	}
}
