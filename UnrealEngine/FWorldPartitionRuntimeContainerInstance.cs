using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001279 RID: 4729
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeContainerInstance")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FWorldPartitionRuntimeContainerInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601154F RID: 70991 RVA: 0x00197070 File Offset: 0x00195270
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeContainerInstance._ScriptStructPtr != 0) ? FWorldPartitionRuntimeContainerInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeContainerInstance", ref FWorldPartitionRuntimeContainerInstance._ScriptStructPtr);
		}

		// Token: 0x1700438A RID: 17290
		// (get) Token: 0x06011550 RID: 70992 RVA: 0x00197094 File Offset: 0x00195294
		// (set) Token: 0x06011551 RID: 70993 RVA: 0x001970A8 File Offset: 0x001952A8
		public unsafe FGuid ActorGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeContainerInstance.__PropertyOffset_ActorGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeContainerInstance.__PropertyOffset_ActorGuid) = value;
			}
		}

		// Token: 0x1700438B RID: 17291
		// (get) Token: 0x06011552 RID: 70994 RVA: 0x001970BD File Offset: 0x001952BD
		// (set) Token: 0x06011553 RID: 70995 RVA: 0x001970D1 File Offset: 0x001952D1
		public unsafe FName ContainerPackage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeContainerInstance.__PropertyOffset_ContainerPackage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeContainerInstance.__PropertyOffset_ContainerPackage) = value;
			}
		}

		// Token: 0x06011554 RID: 70996 RVA: 0x001970E6 File Offset: 0x001952E6
		public FWorldPartitionRuntimeContainerInstance()
		{
		}

		// Token: 0x06011555 RID: 70997 RVA: 0x001970EE File Offset: 0x001952EE
		public FWorldPartitionRuntimeContainerInstance(FGuid ActorGuid, FName ContainerPackage)
		{
			this.ActorGuid = ActorGuid;
			this.ContainerPackage = ContainerPackage;
		}

		// Token: 0x06011556 RID: 70998 RVA: 0x00197104 File Offset: 0x00195304
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeContainerInstance.StaticStruct();
		}

		// Token: 0x06011557 RID: 70999 RVA: 0x00197110 File Offset: 0x00195310
		[NullableContext(2)]
		public FWorldPartitionRuntimeContainerInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011558 RID: 71000 RVA: 0x0019711A File Offset: 0x0019531A
		public FWorldPartitionRuntimeContainerInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011559 RID: 71001 RVA: 0x00197125 File Offset: 0x00195325
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeContainerInstance(Pointer, false, true);
		}

		// Token: 0x0601155A RID: 71002 RVA: 0x0019712F File Offset: 0x0019532F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeContainerInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04009461 RID: 37985
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeContainerInstance";

		// Token: 0x04009462 RID: 37986
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009463 RID: 37987
		internal static int __PropertyOffset_ActorGuid;

		// Token: 0x04009464 RID: 37988
		internal static int __PropertyOffset_ContainerPackage;
	}
}
