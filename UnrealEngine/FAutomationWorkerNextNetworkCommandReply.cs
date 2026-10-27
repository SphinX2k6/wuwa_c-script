using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000418 RID: 1048
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerNextNetworkCommandReply")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FAutomationWorkerNextNetworkCommandReply : IEqualityOperators<FAutomationWorkerNextNetworkCommandReply, FAutomationWorkerNextNetworkCommandReply, bool>, IEquatable<FAutomationWorkerNextNetworkCommandReply>, IUnrealScriptStruct
	{
		// Token: 0x06003872 RID: 14450 RVA: 0x00055E00 File Offset: 0x00054000
		public unsafe static bool operator ==(FAutomationWorkerNextNetworkCommandReply left, FAutomationWorkerNextNetworkCommandReply right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x00055E2C File Offset: 0x0005402C
		public static bool operator !=(FAutomationWorkerNextNetworkCommandReply left, FAutomationWorkerNextNetworkCommandReply right)
		{
			return !(left == right);
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x00055E38 File Offset: 0x00054038
		public bool Equals(FAutomationWorkerNextNetworkCommandReply other)
		{
			return this == other;
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x00055E48 File Offset: 0x00054048
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FAutomationWorkerNextNetworkCommandReply)
			{
				FAutomationWorkerNextNetworkCommandReply other = (FAutomationWorkerNextNetworkCommandReply)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x00055E6D File Offset: 0x0005406D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerNextNetworkCommandReply._ScriptStructPtr != 0) ? FAutomationWorkerNextNetworkCommandReply._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerNextNetworkCommandReply", ref FAutomationWorkerNextNetworkCommandReply._ScriptStructPtr);
		}

		// Token: 0x040019A3 RID: 6563
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerNextNetworkCommandReply";

		// Token: 0x040019A4 RID: 6564
		private static IntPtr _ScriptStructPtr;
	}
}
