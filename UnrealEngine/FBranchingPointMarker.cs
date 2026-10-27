using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008F1 RID: 2289
	[UnrealObjectPath("/Script/Engine.BranchingPointMarker")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FBranchingPointMarker : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D93 RID: 32147 RVA: 0x000B3F64 File Offset: 0x000B2164
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBranchingPointMarker._ScriptStructPtr != 0) ? FBranchingPointMarker._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BranchingPointMarker", ref FBranchingPointMarker._ScriptStructPtr);
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06007D94 RID: 32148 RVA: 0x000B3F88 File Offset: 0x000B2188
		// (set) Token: 0x06007D95 RID: 32149 RVA: 0x000B3F98 File Offset: 0x000B2198
		public unsafe int NotifyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBranchingPointMarker.__PropertyOffset_NotifyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBranchingPointMarker.__PropertyOffset_NotifyIndex) = value;
			}
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06007D96 RID: 32150 RVA: 0x000B3FA9 File Offset: 0x000B21A9
		// (set) Token: 0x06007D97 RID: 32151 RVA: 0x000B3FB9 File Offset: 0x000B21B9
		public unsafe float TriggerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBranchingPointMarker.__PropertyOffset_TriggerTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBranchingPointMarker.__PropertyOffset_TriggerTime) = value;
			}
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06007D98 RID: 32152 RVA: 0x000B3FCA File Offset: 0x000B21CA
		// (set) Token: 0x06007D99 RID: 32153 RVA: 0x000B3FDE File Offset: 0x000B21DE
		public unsafe TEnumAsByte<EAnimNotifyEventType> NotifyEventType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBranchingPointMarker.__PropertyOffset_NotifyEventType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBranchingPointMarker.__PropertyOffset_NotifyEventType) = value;
			}
		}

		// Token: 0x06007D9A RID: 32154 RVA: 0x000B3FF3 File Offset: 0x000B21F3
		public FBranchingPointMarker()
		{
		}

		// Token: 0x06007D9B RID: 32155 RVA: 0x000B3FFB File Offset: 0x000B21FB
		public FBranchingPointMarker(int NotifyIndex, float TriggerTime, TEnumAsByte<EAnimNotifyEventType> NotifyEventType)
		{
			this.NotifyIndex = NotifyIndex;
			this.TriggerTime = TriggerTime;
			this.NotifyEventType = NotifyEventType;
		}

		// Token: 0x06007D9C RID: 32156 RVA: 0x000B4018 File Offset: 0x000B2218
		protected override IntPtr GetUStructPtr()
		{
			return FBranchingPointMarker.StaticStruct();
		}

		// Token: 0x06007D9D RID: 32157 RVA: 0x000B4024 File Offset: 0x000B2224
		[NullableContext(2)]
		public FBranchingPointMarker(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D9E RID: 32158 RVA: 0x000B402E File Offset: 0x000B222E
		public FBranchingPointMarker(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D9F RID: 32159 RVA: 0x000B4039 File Offset: 0x000B2239
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBranchingPointMarker(Pointer, false, true);
		}

		// Token: 0x06007DA0 RID: 32160 RVA: 0x000B4043 File Offset: 0x000B2243
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBranchingPointMarker(Pointer, MemoryOwner);
		}

		// Token: 0x04003C28 RID: 15400
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BranchingPointMarker";

		// Token: 0x04003C29 RID: 15401
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C2A RID: 15402
		internal static int __PropertyOffset_NotifyIndex;

		// Token: 0x04003C2B RID: 15403
		internal static int __PropertyOffset_TriggerTime;

		// Token: 0x04003C2C RID: 15404
		internal static int __PropertyOffset_NotifyEventType;
	}
}
