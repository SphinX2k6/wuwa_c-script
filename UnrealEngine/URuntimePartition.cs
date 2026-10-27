using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B1 RID: 4273
	[UnrealObjectPath("/Script/Engine.RuntimePartition")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public abstract class URuntimePartition : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F42C RID: 62508 RVA: 0x0016A241 File Offset: 0x00168441
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartition._ClassPtr;
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x0600F42D RID: 62509 RVA: 0x0016A24D File Offset: 0x0016844D
		// (set) Token: 0x0600F42E RID: 62510 RVA: 0x0016A261 File Offset: 0x00168461
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x0600F42F RID: 62511 RVA: 0x0016A276 File Offset: 0x00168476
		// (set) Token: 0x0600F430 RID: 62512 RVA: 0x0016A286 File Offset: 0x00168486
		public unsafe bool bBlockOnSlowStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_bBlockOnSlowStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_bBlockOnSlowStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x0600F431 RID: 62513 RVA: 0x0016A297 File Offset: 0x00168497
		// (set) Token: 0x0600F432 RID: 62514 RVA: 0x0016A2A7 File Offset: 0x001684A7
		public unsafe bool bClientOnlyVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_bClientOnlyVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_bClientOnlyVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x0600F433 RID: 62515 RVA: 0x0016A2B8 File Offset: 0x001684B8
		// (set) Token: 0x0600F434 RID: 62516 RVA: 0x0016A2C8 File Offset: 0x001684C8
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x0600F435 RID: 62517 RVA: 0x0016A2D9 File Offset: 0x001684D9
		// (set) Token: 0x0600F436 RID: 62518 RVA: 0x0016A2E9 File Offset: 0x001684E9
		public unsafe ERuntimePartitionCellBoundsMethod BoundsMethod
		{
			get
			{
				return (ERuntimePartitionCellBoundsMethod)(*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_BoundsMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_BoundsMethod) = (byte)value;
			}
		}

		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x0600F437 RID: 62519 RVA: 0x0016A2FA File Offset: 0x001684FA
		// (set) Token: 0x0600F438 RID: 62520 RVA: 0x0016A30A File Offset: 0x0016850A
		public unsafe int LoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_LoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_LoadingRange) = value;
			}
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x0600F439 RID: 62521 RVA: 0x0016A31B File Offset: 0x0016851B
		// (set) Token: 0x0600F43A RID: 62522 RVA: 0x0016A32F File Offset: 0x0016852F
		public unsafe FLinearColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x0600F43B RID: 62523 RVA: 0x0016A344 File Offset: 0x00168544
		// (set) Token: 0x0600F43C RID: 62524 RVA: 0x0016A354 File Offset: 0x00168554
		public unsafe int HLODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_HLODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_HLODIndex) = value;
			}
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x0600F43D RID: 62525 RVA: 0x0016A365 File Offset: 0x00168565
		// (set) Token: 0x0600F43E RID: 62526 RVA: 0x0016A375 File Offset: 0x00168575
		public unsafe float LoadingRangeScaleFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_LoadingRangeScaleFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimePartition.__PropertyOffset_LoadingRangeScaleFactor) = value;
			}
		}

		// Token: 0x0600F43F RID: 62527 RVA: 0x0016A386 File Offset: 0x00168586
		static URuntimePartition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartition");
		}

		// Token: 0x0600F440 RID: 62528 RVA: 0x0016A394 File Offset: 0x00168594
		protected URuntimePartition() : this(BuiltinUtils.AllocNativeUObject(URuntimePartition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F441 RID: 62529 RVA: 0x0016A3BC File Offset: 0x001685BC
		protected URuntimePartition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008459 RID: 33881
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartition";

		// Token: 0x0400845A RID: 33882
		private static IntPtr _ClassPtr;

		// Token: 0x0400845B RID: 33883
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400845C RID: 33884
		internal static int __PropertyOffset_Name;

		// Token: 0x0400845D RID: 33885
		internal static int __PropertyOffset_bBlockOnSlowStreaming;

		// Token: 0x0400845E RID: 33886
		internal static int __PropertyOffset_bClientOnlyVisible;

		// Token: 0x0400845F RID: 33887
		internal static int __PropertyOffset_Priority;

		// Token: 0x04008460 RID: 33888
		internal static int __PropertyOffset_BoundsMethod;

		// Token: 0x04008461 RID: 33889
		internal static int __PropertyOffset_LoadingRange;

		// Token: 0x04008462 RID: 33890
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x04008463 RID: 33891
		internal static int __PropertyOffset_HLODIndex;

		// Token: 0x04008464 RID: 33892
		internal static int __PropertyOffset_LoadingRangeScaleFactor;
	}
}
