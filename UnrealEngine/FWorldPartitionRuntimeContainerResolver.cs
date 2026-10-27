using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200127A RID: 4730
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeContainerResolver")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FWorldPartitionRuntimeContainerResolver : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601155B RID: 71003 RVA: 0x00197138 File Offset: 0x00195338
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeContainerResolver._ScriptStructPtr != 0) ? FWorldPartitionRuntimeContainerResolver._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeContainerResolver", ref FWorldPartitionRuntimeContainerResolver._ScriptStructPtr);
		}

		// Token: 0x1700438C RID: 17292
		// (get) Token: 0x0601155C RID: 71004 RVA: 0x0019715C File Offset: 0x0019535C
		// (set) Token: 0x0601155D RID: 71005 RVA: 0x0019719F File Offset: 0x0019539F
		public TMap<FName, FWorldPartitionRuntimeContainer> Containers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FWorldPartitionRuntimeContainer> result;
				if ((result = this._Containers) == null)
				{
					result = (this._Containers = new TMap<FName, FWorldPartitionRuntimeContainer>(base.NativePtr + (IntPtr)FWorldPartitionRuntimeContainerResolver.__PropertyOffset_Containers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Containers.CopyAssign(value);
			}
		}

		// Token: 0x1700438D RID: 17293
		// (get) Token: 0x0601155E RID: 71006 RVA: 0x001971AD File Offset: 0x001953AD
		// (set) Token: 0x0601155F RID: 71007 RVA: 0x001971C1 File Offset: 0x001953C1
		public unsafe FName MainContainerPackage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeContainerResolver.__PropertyOffset_MainContainerPackage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeContainerResolver.__PropertyOffset_MainContainerPackage) = value;
			}
		}

		// Token: 0x06011560 RID: 71008 RVA: 0x001971D6 File Offset: 0x001953D6
		public FWorldPartitionRuntimeContainerResolver()
		{
		}

		// Token: 0x06011561 RID: 71009 RVA: 0x001971DE File Offset: 0x001953DE
		public FWorldPartitionRuntimeContainerResolver(TMap<FName, FWorldPartitionRuntimeContainer> Containers, FName MainContainerPackage, TMap<FActorContainerID, string> ContainerIDToEditorPath)
		{
			this.Containers = Containers;
			this.MainContainerPackage = MainContainerPackage;
		}

		// Token: 0x06011562 RID: 71010 RVA: 0x001971F4 File Offset: 0x001953F4
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeContainerResolver.StaticStruct();
		}

		// Token: 0x06011563 RID: 71011 RVA: 0x00197200 File Offset: 0x00195400
		[NullableContext(2)]
		public FWorldPartitionRuntimeContainerResolver(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011564 RID: 71012 RVA: 0x0019720A File Offset: 0x0019540A
		public FWorldPartitionRuntimeContainerResolver(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011565 RID: 71013 RVA: 0x00197215 File Offset: 0x00195415
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeContainerResolver(Pointer, false, true);
		}

		// Token: 0x06011566 RID: 71014 RVA: 0x0019721F File Offset: 0x0019541F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeContainerResolver(Pointer, MemoryOwner);
		}

		// Token: 0x04009465 RID: 37989
		public const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeContainerResolver";

		// Token: 0x04009466 RID: 37990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009467 RID: 37991
		internal static int __PropertyOffset_Containers;

		// Token: 0x04009468 RID: 37992
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FWorldPartitionRuntimeContainer> _Containers;

		// Token: 0x04009469 RID: 37993
		internal static int __PropertyOffset_MainContainerPackage;
	}
}
