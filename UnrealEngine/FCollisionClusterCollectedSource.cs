using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001743 RID: 5955
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCollision.CollisionClusterCollectedSource")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCollisionClusterCollectedSource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060156CE RID: 87758 RVA: 0x001F7C4C File Offset: 0x001F5E4C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionClusterCollectedSource._ScriptStructPtr != 0) ? FCollisionClusterCollectedSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCollision.CollisionClusterCollectedSource", ref FCollisionClusterCollectedSource._ScriptStructPtr);
		}

		// Token: 0x1700549A RID: 21658
		// (get) Token: 0x060156CF RID: 87759 RVA: 0x001F7C70 File Offset: 0x001F5E70
		// (set) Token: 0x060156D0 RID: 87760 RVA: 0x001F7C84 File Offset: 0x001F5E84
		public unsafe string ActorLabel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCollisionClusterCollectedSource.__PropertyOffset_ActorLabel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCollisionClusterCollectedSource.__PropertyOffset_ActorLabel)), value);
			}
		}

		// Token: 0x1700549B RID: 21659
		// (get) Token: 0x060156D1 RID: 87761 RVA: 0x001F7C99 File Offset: 0x001F5E99
		// (set) Token: 0x060156D2 RID: 87762 RVA: 0x001F7CAD File Offset: 0x001F5EAD
		public unsafe FName ActorName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionClusterCollectedSource.__PropertyOffset_ActorName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionClusterCollectedSource.__PropertyOffset_ActorName) = value;
			}
		}

		// Token: 0x060156D3 RID: 87763 RVA: 0x001F7CC2 File Offset: 0x001F5EC2
		public FCollisionClusterCollectedSource()
		{
		}

		// Token: 0x060156D4 RID: 87764 RVA: 0x001F7CCA File Offset: 0x001F5ECA
		public FCollisionClusterCollectedSource(string ActorLabel, FName ActorName)
		{
			this.ActorLabel = ActorLabel;
			this.ActorName = ActorName;
		}

		// Token: 0x060156D5 RID: 87765 RVA: 0x001F7CE0 File Offset: 0x001F5EE0
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionClusterCollectedSource.StaticStruct();
		}

		// Token: 0x060156D6 RID: 87766 RVA: 0x001F7CEC File Offset: 0x001F5EEC
		[NullableContext(2)]
		public FCollisionClusterCollectedSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060156D7 RID: 87767 RVA: 0x001F7CF6 File Offset: 0x001F5EF6
		public FCollisionClusterCollectedSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060156D8 RID: 87768 RVA: 0x001F7D01 File Offset: 0x001F5F01
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionClusterCollectedSource(Pointer, false, true);
		}

		// Token: 0x060156D9 RID: 87769 RVA: 0x001F7D0B File Offset: 0x001F5F0B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionClusterCollectedSource(Pointer, MemoryOwner);
		}

		// Token: 0x0400BAE4 RID: 47844
		public const string __ObjectPath = "/Script/KuroCollision.CollisionClusterCollectedSource";

		// Token: 0x0400BAE5 RID: 47845
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BAE6 RID: 47846
		internal static int __PropertyOffset_ActorLabel;

		// Token: 0x0400BAE7 RID: 47847
		internal static int __PropertyOffset_ActorName;
	}
}
