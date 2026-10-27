using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200041C RID: 1052
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerPong")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FAutomationWorkerPong : IEqualityOperators<FAutomationWorkerPong, FAutomationWorkerPong, bool>, IEquatable<FAutomationWorkerPong>, IUnrealScriptStruct
	{
		// Token: 0x06003898 RID: 14488 RVA: 0x00056138 File Offset: 0x00054338
		public unsafe static bool operator ==(FAutomationWorkerPong left, FAutomationWorkerPong right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x00056164 File Offset: 0x00054364
		public static bool operator !=(FAutomationWorkerPong left, FAutomationWorkerPong right)
		{
			return !(left == right);
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x00056170 File Offset: 0x00054370
		public bool Equals(FAutomationWorkerPong other)
		{
			return this == other;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00056180 File Offset: 0x00054380
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FAutomationWorkerPong)
			{
				FAutomationWorkerPong other = (FAutomationWorkerPong)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x000561A5 File Offset: 0x000543A5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerPong._ScriptStructPtr != 0) ? FAutomationWorkerPong._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerPong", ref FAutomationWorkerPong._ScriptStructPtr);
		}

		// Token: 0x040019B2 RID: 6578
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerPong";

		// Token: 0x040019B3 RID: 6579
		private static IntPtr _ScriptStructPtr;
	}
}
