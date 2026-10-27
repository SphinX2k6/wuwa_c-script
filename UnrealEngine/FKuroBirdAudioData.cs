using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AAD RID: 6829
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdAudioData")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroBirdAudioData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019481 RID: 103553 RVA: 0x002561A2 File Offset: 0x002543A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBirdAudioData._ScriptStructPtr != 0) ? FKuroBirdAudioData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdAudioData", ref FKuroBirdAudioData._ScriptStructPtr);
		}

		// Token: 0x170064BC RID: 25788
		// (get) Token: 0x06019482 RID: 103554 RVA: 0x002561C6 File Offset: 0x002543C6
		// (set) Token: 0x06019483 RID: 103555 RVA: 0x002561DA File Offset: 0x002543DA
		public unsafe FVector WorldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBirdAudioData.__PropertyOffset_WorldPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdAudioData.__PropertyOffset_WorldPosition) = value;
			}
		}

		// Token: 0x170064BD RID: 25789
		// (get) Token: 0x06019484 RID: 103556 RVA: 0x002561EF File Offset: 0x002543EF
		// (set) Token: 0x06019485 RID: 103557 RVA: 0x002561FF File Offset: 0x002543FF
		public unsafe int CurrAnimId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBirdAudioData.__PropertyOffset_CurrAnimId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdAudioData.__PropertyOffset_CurrAnimId) = value;
			}
		}

		// Token: 0x170064BE RID: 25790
		// (get) Token: 0x06019486 RID: 103558 RVA: 0x00256210 File Offset: 0x00254410
		// (set) Token: 0x06019487 RID: 103559 RVA: 0x00256220 File Offset: 0x00254420
		public unsafe int TargetAnimId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBirdAudioData.__PropertyOffset_TargetAnimId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdAudioData.__PropertyOffset_TargetAnimId) = value;
			}
		}

		// Token: 0x170064BF RID: 25791
		// (get) Token: 0x06019488 RID: 103560 RVA: 0x00256231 File Offset: 0x00254431
		// (set) Token: 0x06019489 RID: 103561 RVA: 0x00256241 File Offset: 0x00254441
		public unsafe int InTransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBirdAudioData.__PropertyOffset_InTransition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdAudioData.__PropertyOffset_InTransition) = value;
			}
		}

		// Token: 0x0601948A RID: 103562 RVA: 0x00256252 File Offset: 0x00254452
		public FKuroBirdAudioData()
		{
		}

		// Token: 0x0601948B RID: 103563 RVA: 0x0025625A File Offset: 0x0025445A
		public FKuroBirdAudioData(FVector WorldPosition, int CurrAnimId, int TargetAnimId, int InTransition)
		{
			this.WorldPosition = WorldPosition;
			this.CurrAnimId = CurrAnimId;
			this.TargetAnimId = TargetAnimId;
			this.InTransition = InTransition;
		}

		// Token: 0x0601948C RID: 103564 RVA: 0x0025627F File Offset: 0x0025447F
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBirdAudioData.StaticStruct();
		}

		// Token: 0x0601948D RID: 103565 RVA: 0x0025628B File Offset: 0x0025448B
		[NullableContext(2)]
		public FKuroBirdAudioData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601948E RID: 103566 RVA: 0x00256295 File Offset: 0x00254495
		public FKuroBirdAudioData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601948F RID: 103567 RVA: 0x002562A0 File Offset: 0x002544A0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBirdAudioData(Pointer, false, true);
		}

		// Token: 0x06019490 RID: 103568 RVA: 0x002562AA File Offset: 0x002544AA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBirdAudioData(Pointer, MemoryOwner);
		}

		// Token: 0x0400DC88 RID: 56456
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdAudioData";

		// Token: 0x0400DC89 RID: 56457
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DC8A RID: 56458
		internal static int __PropertyOffset_WorldPosition;

		// Token: 0x0400DC8B RID: 56459
		internal static int __PropertyOffset_CurrAnimId;

		// Token: 0x0400DC8C RID: 56460
		internal static int __PropertyOffset_TargetAnimId;

		// Token: 0x0400DC8D RID: 56461
		internal static int __PropertyOffset_InTransition;
	}
}
