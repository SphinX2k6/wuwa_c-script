using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011F8 RID: 4600
	[UnrealObjectPath("/Script/Engine.ToggleTrackKey")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FToggleTrackKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010F5D RID: 69469 RVA: 0x0018E514 File Offset: 0x0018C714
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FToggleTrackKey._ScriptStructPtr != 0) ? FToggleTrackKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ToggleTrackKey", ref FToggleTrackKey._ScriptStructPtr);
		}

		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x06010F5E RID: 69470 RVA: 0x0018E538 File Offset: 0x0018C738
		// (set) Token: 0x06010F5F RID: 69471 RVA: 0x0018E548 File Offset: 0x0018C748
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FToggleTrackKey.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FToggleTrackKey.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x06010F60 RID: 69472 RVA: 0x0018E559 File Offset: 0x0018C759
		// (set) Token: 0x06010F61 RID: 69473 RVA: 0x0018E56D File Offset: 0x0018C76D
		public unsafe TEnumAsByte<ETrackToggleAction> ToggleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FToggleTrackKey.__PropertyOffset_ToggleAction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FToggleTrackKey.__PropertyOffset_ToggleAction) = value;
			}
		}

		// Token: 0x06010F62 RID: 69474 RVA: 0x0018E582 File Offset: 0x0018C782
		public FToggleTrackKey()
		{
		}

		// Token: 0x06010F63 RID: 69475 RVA: 0x0018E58A File Offset: 0x0018C78A
		public FToggleTrackKey(float Time, TEnumAsByte<ETrackToggleAction> ToggleAction)
		{
			this.Time = Time;
			this.ToggleAction = ToggleAction;
		}

		// Token: 0x06010F64 RID: 69476 RVA: 0x0018E5A0 File Offset: 0x0018C7A0
		protected override IntPtr GetUStructPtr()
		{
			return FToggleTrackKey.StaticStruct();
		}

		// Token: 0x06010F65 RID: 69477 RVA: 0x0018E5AC File Offset: 0x0018C7AC
		[NullableContext(2)]
		public FToggleTrackKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010F66 RID: 69478 RVA: 0x0018E5B6 File Offset: 0x0018C7B6
		public FToggleTrackKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010F67 RID: 69479 RVA: 0x0018E5C1 File Offset: 0x0018C7C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FToggleTrackKey(Pointer, false, true);
		}

		// Token: 0x06010F68 RID: 69480 RVA: 0x0018E5CB File Offset: 0x0018C7CB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FToggleTrackKey(Pointer, MemoryOwner);
		}

		// Token: 0x04009158 RID: 37208
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ToggleTrackKey";

		// Token: 0x04009159 RID: 37209
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400915A RID: 37210
		internal static int __PropertyOffset_Time;

		// Token: 0x0400915B RID: 37211
		internal static int __PropertyOffset_ToggleAction;
	}
}
