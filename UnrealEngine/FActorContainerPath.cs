using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007B9 RID: 1977
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.ActorContainerPath")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FActorContainerPath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060069C2 RID: 27074 RVA: 0x00097DDE File Offset: 0x00095FDE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorContainerPath._ScriptStructPtr != 0) ? FActorContainerPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorContainerPath", ref FActorContainerPath._ScriptStructPtr);
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x060069C3 RID: 27075 RVA: 0x00097E04 File Offset: 0x00096004
		// (set) Token: 0x060069C4 RID: 27076 RVA: 0x00097E47 File Offset: 0x00096047
		public TArray<FGuid> ContainerGuids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._ContainerGuids) == null)
				{
					result = (this._ContainerGuids = new TArray<FGuid>(base.NativePtr + (IntPtr)FActorContainerPath.__PropertyOffset_ContainerGuids, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ContainerGuids.CopyAssign(value);
			}
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x00097E55 File Offset: 0x00096055
		public FActorContainerPath()
		{
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x00097E5D File Offset: 0x0009605D
		public FActorContainerPath(TArray<FGuid> ContainerGuids)
		{
			this.ContainerGuids = ContainerGuids;
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x00097E6C File Offset: 0x0009606C
		protected override IntPtr GetUStructPtr()
		{
			return FActorContainerPath.StaticStruct();
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x00097E78 File Offset: 0x00096078
		[NullableContext(2)]
		public FActorContainerPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x00097E82 File Offset: 0x00096082
		public FActorContainerPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x00097E8D File Offset: 0x0009608D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorContainerPath(Pointer, false, true);
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x00097E97 File Offset: 0x00096097
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorContainerPath(Pointer, MemoryOwner);
		}

		// Token: 0x040032FC RID: 13052
		public const string __ObjectPath = "/Script/Engine.ActorContainerPath";

		// Token: 0x040032FD RID: 13053
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040032FE RID: 13054
		internal static int __PropertyOffset_ContainerGuids;

		// Token: 0x040032FF RID: 13055
		[Nullable(2)]
		private TArray<FGuid> _ContainerGuids;
	}
}
