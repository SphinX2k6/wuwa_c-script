using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001278 RID: 4728
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeContainer")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FWorldPartitionRuntimeContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011545 RID: 70981 RVA: 0x00196FAE File Offset: 0x001951AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeContainer._ScriptStructPtr != 0) ? FWorldPartitionRuntimeContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeContainer", ref FWorldPartitionRuntimeContainer._ScriptStructPtr);
		}

		// Token: 0x17004389 RID: 17289
		// (get) Token: 0x06011546 RID: 70982 RVA: 0x00196FD4 File Offset: 0x001951D4
		// (set) Token: 0x06011547 RID: 70983 RVA: 0x00197017 File Offset: 0x00195217
		public TMap<FName, FWorldPartitionRuntimeContainerInstance> ContainerInstances
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FWorldPartitionRuntimeContainerInstance> result;
				if ((result = this._ContainerInstances) == null)
				{
					result = (this._ContainerInstances = new TMap<FName, FWorldPartitionRuntimeContainerInstance>(base.NativePtr + (IntPtr)FWorldPartitionRuntimeContainer.__PropertyOffset_ContainerInstances, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ContainerInstances.CopyAssign(value);
			}
		}

		// Token: 0x06011548 RID: 70984 RVA: 0x00197025 File Offset: 0x00195225
		public FWorldPartitionRuntimeContainer()
		{
		}

		// Token: 0x06011549 RID: 70985 RVA: 0x0019702D File Offset: 0x0019522D
		public FWorldPartitionRuntimeContainer(TMap<FName, FWorldPartitionRuntimeContainerInstance> ContainerInstances)
		{
			this.ContainerInstances = ContainerInstances;
		}

		// Token: 0x0601154A RID: 70986 RVA: 0x0019703C File Offset: 0x0019523C
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeContainer.StaticStruct();
		}

		// Token: 0x0601154B RID: 70987 RVA: 0x00197048 File Offset: 0x00195248
		[NullableContext(2)]
		public FWorldPartitionRuntimeContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601154C RID: 70988 RVA: 0x00197052 File Offset: 0x00195252
		public FWorldPartitionRuntimeContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601154D RID: 70989 RVA: 0x0019705D File Offset: 0x0019525D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeContainer(Pointer, false, true);
		}

		// Token: 0x0601154E RID: 70990 RVA: 0x00197067 File Offset: 0x00195267
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeContainer(Pointer, MemoryOwner);
		}

		// Token: 0x0400945D RID: 37981
		public const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeContainer";

		// Token: 0x0400945E RID: 37982
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400945F RID: 37983
		internal static int __PropertyOffset_ContainerInstances;

		// Token: 0x04009460 RID: 37984
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FWorldPartitionRuntimeContainerInstance> _ContainerInstances;
	}
}
