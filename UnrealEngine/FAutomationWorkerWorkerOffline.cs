using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000428 RID: 1064
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerWorkerOffline")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FAutomationWorkerWorkerOffline : IEqualityOperators<FAutomationWorkerWorkerOffline, FAutomationWorkerWorkerOffline, bool>, IEquatable<FAutomationWorkerWorkerOffline>, IUnrealScriptStruct
	{
		// Token: 0x06003939 RID: 14649 RVA: 0x00056E0C File Offset: 0x0005500C
		public unsafe static bool operator ==(FAutomationWorkerWorkerOffline left, FAutomationWorkerWorkerOffline right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x00056E38 File Offset: 0x00055038
		public static bool operator !=(FAutomationWorkerWorkerOffline left, FAutomationWorkerWorkerOffline right)
		{
			return !(left == right);
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x00056E44 File Offset: 0x00055044
		public bool Equals(FAutomationWorkerWorkerOffline other)
		{
			return this == other;
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00056E54 File Offset: 0x00055054
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FAutomationWorkerWorkerOffline)
			{
				FAutomationWorkerWorkerOffline other = (FAutomationWorkerWorkerOffline)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x00056E79 File Offset: 0x00055079
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerWorkerOffline._ScriptStructPtr != 0) ? FAutomationWorkerWorkerOffline._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerWorkerOffline", ref FAutomationWorkerWorkerOffline._ScriptStructPtr);
		}

		// Token: 0x040019F4 RID: 6644
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerWorkerOffline";

		// Token: 0x040019F5 RID: 6645
		private static IntPtr _ScriptStructPtr;
	}
}
