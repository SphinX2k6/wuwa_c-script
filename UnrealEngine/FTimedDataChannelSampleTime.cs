using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002916 RID: 10518
	[UnrealObjectPath("/Script/TimeManagement.TimedDataChannelSampleTime")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTimedDataChannelSampleTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026FA2 RID: 159650 RVA: 0x003B7225 File Offset: 0x003B5425
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimedDataChannelSampleTime._ScriptStructPtr != 0) ? FTimedDataChannelSampleTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TimeManagement.TimedDataChannelSampleTime", ref FTimedDataChannelSampleTime._ScriptStructPtr);
		}

		// Token: 0x06026FA3 RID: 159651 RVA: 0x003B7249 File Offset: 0x003B5449
		public FTimedDataChannelSampleTime()
		{
		}

		// Token: 0x06026FA4 RID: 159652 RVA: 0x003B7251 File Offset: 0x003B5451
		protected override IntPtr GetUStructPtr()
		{
			return FTimedDataChannelSampleTime.StaticStruct();
		}

		// Token: 0x06026FA5 RID: 159653 RVA: 0x003B725D File Offset: 0x003B545D
		[NullableContext(2)]
		public FTimedDataChannelSampleTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026FA6 RID: 159654 RVA: 0x003B7267 File Offset: 0x003B5467
		public FTimedDataChannelSampleTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026FA7 RID: 159655 RVA: 0x003B7272 File Offset: 0x003B5472
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimedDataChannelSampleTime(Pointer, false, true);
		}

		// Token: 0x06026FA8 RID: 159656 RVA: 0x003B727C File Offset: 0x003B547C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimedDataChannelSampleTime(Pointer, MemoryOwner);
		}

		// Token: 0x0401565E RID: 87646
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TimeManagement.TimedDataChannelSampleTime";

		// Token: 0x0401565F RID: 87647
		private static IntPtr _ScriptStructPtr;
	}
}
