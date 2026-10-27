using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000420 RID: 1056
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerResetTests")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FAutomationWorkerResetTests : IEqualityOperators<FAutomationWorkerResetTests, FAutomationWorkerResetTests, bool>, IEquatable<FAutomationWorkerResetTests>, IUnrealScriptStruct
	{
		// Token: 0x060038BD RID: 14525 RVA: 0x000563D4 File Offset: 0x000545D4
		public unsafe static bool operator ==(FAutomationWorkerResetTests left, FAutomationWorkerResetTests right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x00056400 File Offset: 0x00054600
		public static bool operator !=(FAutomationWorkerResetTests left, FAutomationWorkerResetTests right)
		{
			return !(left == right);
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x0005640C File Offset: 0x0005460C
		public bool Equals(FAutomationWorkerResetTests other)
		{
			return this == other;
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x0005641C File Offset: 0x0005461C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FAutomationWorkerResetTests)
			{
				FAutomationWorkerResetTests other = (FAutomationWorkerResetTests)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00056441 File Offset: 0x00054641
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerResetTests._ScriptStructPtr != 0) ? FAutomationWorkerResetTests._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerResetTests", ref FAutomationWorkerResetTests._ScriptStructPtr);
		}

		// Token: 0x040019BF RID: 6591
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerResetTests";

		// Token: 0x040019C0 RID: 6592
		private static IntPtr _ScriptStructPtr;
	}
}
