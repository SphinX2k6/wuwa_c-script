using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D18 RID: 3352
	[UnrealObjectPath("/Script/Engine.KuroWorldPartitionStruct")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroWorldPartitionStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B3B5 RID: 46005 RVA: 0x00100581 File Offset: 0x000FE781
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroWorldPartitionStruct._ScriptStructPtr != 0) ? FKuroWorldPartitionStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroWorldPartitionStruct", ref FKuroWorldPartitionStruct._ScriptStructPtr);
		}

		// Token: 0x0600B3B6 RID: 46006 RVA: 0x001005A5 File Offset: 0x000FE7A5
		public FKuroWorldPartitionStruct()
		{
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x001005AD File Offset: 0x000FE7AD
		protected override IntPtr GetUStructPtr()
		{
			return FKuroWorldPartitionStruct.StaticStruct();
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x001005B9 File Offset: 0x000FE7B9
		[NullableContext(2)]
		public FKuroWorldPartitionStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x001005C3 File Offset: 0x000FE7C3
		public FKuroWorldPartitionStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B3BA RID: 46010 RVA: 0x001005CE File Offset: 0x000FE7CE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroWorldPartitionStruct(Pointer, false, true);
		}

		// Token: 0x0600B3BB RID: 46011 RVA: 0x001005D8 File Offset: 0x000FE7D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroWorldPartitionStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04005E7C RID: 24188
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroWorldPartitionStruct";

		// Token: 0x04005E7D RID: 24189
		private static IntPtr _ScriptStructPtr;
	}
}
