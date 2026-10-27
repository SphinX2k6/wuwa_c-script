using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FD6 RID: 4054
	[UnrealObjectPath("/Script/Engine.PerCookLevelInt")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FPerCookLevelInt : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DAFE RID: 56062 RVA: 0x00142CF7 File Offset: 0x00140EF7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerCookLevelInt._ScriptStructPtr != 0) ? FPerCookLevelInt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PerCookLevelInt", ref FPerCookLevelInt._ScriptStructPtr);
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600DAFF RID: 56063 RVA: 0x00142D1B File Offset: 0x00140F1B
		// (set) Token: 0x0600DB00 RID: 56064 RVA: 0x00142D2B File Offset: 0x00140F2B
		public unsafe int Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerCookLevelInt.__PropertyOffset_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerCookLevelInt.__PropertyOffset_Default) = value;
			}
		}

		// Token: 0x0600DB01 RID: 56065 RVA: 0x00142D3C File Offset: 0x00140F3C
		public FPerCookLevelInt()
		{
		}

		// Token: 0x0600DB02 RID: 56066 RVA: 0x00142D44 File Offset: 0x00140F44
		[NullableContext(1)]
		public FPerCookLevelInt(int Default, TMap<int, int> PerCook)
		{
			this.Default = Default;
		}

		// Token: 0x0600DB03 RID: 56067 RVA: 0x00142D53 File Offset: 0x00140F53
		protected override IntPtr GetUStructPtr()
		{
			return FPerCookLevelInt.StaticStruct();
		}

		// Token: 0x0600DB04 RID: 56068 RVA: 0x00142D5F File Offset: 0x00140F5F
		[NullableContext(2)]
		public FPerCookLevelInt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DB05 RID: 56069 RVA: 0x00142D69 File Offset: 0x00140F69
		public FPerCookLevelInt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DB06 RID: 56070 RVA: 0x00142D74 File Offset: 0x00140F74
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerCookLevelInt(Pointer, false, true);
		}

		// Token: 0x0600DB07 RID: 56071 RVA: 0x00142D7E File Offset: 0x00140F7E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerCookLevelInt(Pointer, MemoryOwner);
		}

		// Token: 0x0400768D RID: 30349
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PerCookLevelInt";

		// Token: 0x0400768E RID: 30350
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400768F RID: 30351
		internal static int __PropertyOffset_Default;
	}
}
