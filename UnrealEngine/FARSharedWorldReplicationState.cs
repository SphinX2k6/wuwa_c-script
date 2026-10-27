using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003C8 RID: 968
	[UnrealObjectPath("/Script/AugmentedReality.ARSharedWorldReplicationState")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FARSharedWorldReplicationState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600363D RID: 13885 RVA: 0x000525AA File Offset: 0x000507AA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARSharedWorldReplicationState._ScriptStructPtr != 0) ? FARSharedWorldReplicationState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARSharedWorldReplicationState", ref FARSharedWorldReplicationState._ScriptStructPtr);
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600363E RID: 13886 RVA: 0x000525CE File Offset: 0x000507CE
		// (set) Token: 0x0600363F RID: 13887 RVA: 0x000525DE File Offset: 0x000507DE
		public unsafe int PreviewImageOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARSharedWorldReplicationState.__PropertyOffset_PreviewImageOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARSharedWorldReplicationState.__PropertyOffset_PreviewImageOffset) = value;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06003640 RID: 13888 RVA: 0x000525EF File Offset: 0x000507EF
		// (set) Token: 0x06003641 RID: 13889 RVA: 0x000525FF File Offset: 0x000507FF
		public unsafe int ARWorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARSharedWorldReplicationState.__PropertyOffset_ARWorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARSharedWorldReplicationState.__PropertyOffset_ARWorldOffset) = value;
			}
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00052610 File Offset: 0x00050810
		public FARSharedWorldReplicationState()
		{
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00052618 File Offset: 0x00050818
		public FARSharedWorldReplicationState(int PreviewImageOffset, int ARWorldOffset)
		{
			this.PreviewImageOffset = PreviewImageOffset;
			this.ARWorldOffset = ARWorldOffset;
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x0005262E File Offset: 0x0005082E
		protected override IntPtr GetUStructPtr()
		{
			return FARSharedWorldReplicationState.StaticStruct();
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x0005263A File Offset: 0x0005083A
		[NullableContext(2)]
		public FARSharedWorldReplicationState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00052644 File Offset: 0x00050844
		public FARSharedWorldReplicationState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0005264F File Offset: 0x0005084F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARSharedWorldReplicationState(Pointer, false, true);
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00052659 File Offset: 0x00050859
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARSharedWorldReplicationState(Pointer, MemoryOwner);
		}

		// Token: 0x04001772 RID: 6002
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARSharedWorldReplicationState";

		// Token: 0x04001773 RID: 6003
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001774 RID: 6004
		internal static int __PropertyOffset_PreviewImageOffset;

		// Token: 0x04001775 RID: 6005
		internal static int __PropertyOffset_ARWorldOffset;
	}
}
