using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BD2 RID: 3026
	[UnrealObjectPath("/Script/Engine.FastArraySerializerItem")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FFastArraySerializerItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060094C4 RID: 38084 RVA: 0x000D4534 File Offset: 0x000D2734
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFastArraySerializerItem._ScriptStructPtr != 0) ? FFastArraySerializerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FastArraySerializerItem", ref FFastArraySerializerItem._ScriptStructPtr);
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x060094C5 RID: 38085 RVA: 0x000D4558 File Offset: 0x000D2758
		// (set) Token: 0x060094C6 RID: 38086 RVA: 0x000D4568 File Offset: 0x000D2768
		public unsafe int ReplicationID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFastArraySerializerItem.__PropertyOffset_ReplicationID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFastArraySerializerItem.__PropertyOffset_ReplicationID) = value;
			}
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x060094C7 RID: 38087 RVA: 0x000D4579 File Offset: 0x000D2779
		// (set) Token: 0x060094C8 RID: 38088 RVA: 0x000D4589 File Offset: 0x000D2789
		public unsafe int ReplicationKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFastArraySerializerItem.__PropertyOffset_ReplicationKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFastArraySerializerItem.__PropertyOffset_ReplicationKey) = value;
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x060094C9 RID: 38089 RVA: 0x000D459A File Offset: 0x000D279A
		// (set) Token: 0x060094CA RID: 38090 RVA: 0x000D45AA File Offset: 0x000D27AA
		public unsafe int MostRecentArrayReplicationKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFastArraySerializerItem.__PropertyOffset_MostRecentArrayReplicationKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFastArraySerializerItem.__PropertyOffset_MostRecentArrayReplicationKey) = value;
			}
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x000D45BB File Offset: 0x000D27BB
		public FFastArraySerializerItem()
		{
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x000D45C3 File Offset: 0x000D27C3
		public FFastArraySerializerItem(int ReplicationID, int ReplicationKey, int MostRecentArrayReplicationKey)
		{
			this.ReplicationID = ReplicationID;
			this.ReplicationKey = ReplicationKey;
			this.MostRecentArrayReplicationKey = MostRecentArrayReplicationKey;
		}

		// Token: 0x060094CD RID: 38093 RVA: 0x000D45E0 File Offset: 0x000D27E0
		protected override IntPtr GetUStructPtr()
		{
			return FFastArraySerializerItem.StaticStruct();
		}

		// Token: 0x060094CE RID: 38094 RVA: 0x000D45EC File Offset: 0x000D27EC
		[NullableContext(2)]
		public FFastArraySerializerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x000D45F6 File Offset: 0x000D27F6
		public FFastArraySerializerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094D0 RID: 38096 RVA: 0x000D4601 File Offset: 0x000D2801
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFastArraySerializerItem(Pointer, false, true);
		}

		// Token: 0x060094D1 RID: 38097 RVA: 0x000D460B File Offset: 0x000D280B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFastArraySerializerItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400538C RID: 21388
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FastArraySerializerItem";

		// Token: 0x0400538D RID: 21389
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400538E RID: 21390
		internal static int __PropertyOffset_ReplicationID;

		// Token: 0x0400538F RID: 21391
		internal static int __PropertyOffset_ReplicationKey;

		// Token: 0x04005390 RID: 21392
		internal static int __PropertyOffset_MostRecentArrayReplicationKey;
	}
}
