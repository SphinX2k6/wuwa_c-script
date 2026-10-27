using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000903 RID: 2307
	[UnrealObjectPath("/Script/Engine.CachedAnimTransitionData")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCachedAnimTransitionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E9B RID: 32411 RVA: 0x000B5AD0 File Offset: 0x000B3CD0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedAnimTransitionData._ScriptStructPtr != 0) ? FCachedAnimTransitionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CachedAnimTransitionData", ref FCachedAnimTransitionData._ScriptStructPtr);
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06007E9C RID: 32412 RVA: 0x000B5AF4 File Offset: 0x000B3CF4
		// (set) Token: 0x06007E9D RID: 32413 RVA: 0x000B5B08 File Offset: 0x000B3D08
		public unsafe FName StateMachineName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedAnimTransitionData.__PropertyOffset_StateMachineName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedAnimTransitionData.__PropertyOffset_StateMachineName) = value;
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x06007E9E RID: 32414 RVA: 0x000B5B1D File Offset: 0x000B3D1D
		// (set) Token: 0x06007E9F RID: 32415 RVA: 0x000B5B31 File Offset: 0x000B3D31
		public unsafe FName FromStateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedAnimTransitionData.__PropertyOffset_FromStateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedAnimTransitionData.__PropertyOffset_FromStateName) = value;
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06007EA0 RID: 32416 RVA: 0x000B5B46 File Offset: 0x000B3D46
		// (set) Token: 0x06007EA1 RID: 32417 RVA: 0x000B5B5A File Offset: 0x000B3D5A
		public unsafe FName ToStateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedAnimTransitionData.__PropertyOffset_ToStateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedAnimTransitionData.__PropertyOffset_ToStateName) = value;
			}
		}

		// Token: 0x06007EA2 RID: 32418 RVA: 0x000B5B6F File Offset: 0x000B3D6F
		public FCachedAnimTransitionData()
		{
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x000B5B77 File Offset: 0x000B3D77
		public FCachedAnimTransitionData(FName StateMachineName, FName FromStateName, FName ToStateName)
		{
			this.StateMachineName = StateMachineName;
			this.FromStateName = FromStateName;
			this.ToStateName = ToStateName;
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x000B5B94 File Offset: 0x000B3D94
		protected override IntPtr GetUStructPtr()
		{
			return FCachedAnimTransitionData.StaticStruct();
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x000B5BA0 File Offset: 0x000B3DA0
		[NullableContext(2)]
		public FCachedAnimTransitionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x000B5BAA File Offset: 0x000B3DAA
		public FCachedAnimTransitionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x000B5BB5 File Offset: 0x000B3DB5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedAnimTransitionData(Pointer, false, true);
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x000B5BBF File Offset: 0x000B3DBF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedAnimTransitionData(Pointer, MemoryOwner);
		}

		// Token: 0x04003CC0 RID: 15552
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CachedAnimTransitionData";

		// Token: 0x04003CC1 RID: 15553
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CC2 RID: 15554
		internal static int __PropertyOffset_StateMachineName;

		// Token: 0x04003CC3 RID: 15555
		internal static int __PropertyOffset_FromStateName;

		// Token: 0x04003CC4 RID: 15556
		internal static int __PropertyOffset_ToStateName;
	}
}
