using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000900 RID: 2304
	[UnrealObjectPath("/Script/Engine.CachedAnimRelevancyData")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FCachedAnimRelevancyData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E79 RID: 32377 RVA: 0x000B587D File Offset: 0x000B3A7D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedAnimRelevancyData._ScriptStructPtr != 0) ? FCachedAnimRelevancyData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CachedAnimRelevancyData", ref FCachedAnimRelevancyData._ScriptStructPtr);
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06007E7A RID: 32378 RVA: 0x000B58A1 File Offset: 0x000B3AA1
		// (set) Token: 0x06007E7B RID: 32379 RVA: 0x000B58B5 File Offset: 0x000B3AB5
		public unsafe FName StateMachineName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedAnimRelevancyData.__PropertyOffset_StateMachineName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedAnimRelevancyData.__PropertyOffset_StateMachineName) = value;
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06007E7C RID: 32380 RVA: 0x000B58CA File Offset: 0x000B3ACA
		// (set) Token: 0x06007E7D RID: 32381 RVA: 0x000B58DE File Offset: 0x000B3ADE
		public unsafe FName StateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedAnimRelevancyData.__PropertyOffset_StateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedAnimRelevancyData.__PropertyOffset_StateName) = value;
			}
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x000B58F3 File Offset: 0x000B3AF3
		public FCachedAnimRelevancyData()
		{
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x000B58FB File Offset: 0x000B3AFB
		public FCachedAnimRelevancyData(FName StateMachineName, FName StateName)
		{
			this.StateMachineName = StateMachineName;
			this.StateName = StateName;
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x000B5911 File Offset: 0x000B3B11
		protected override IntPtr GetUStructPtr()
		{
			return FCachedAnimRelevancyData.StaticStruct();
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x000B591D File Offset: 0x000B3B1D
		[NullableContext(2)]
		public FCachedAnimRelevancyData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x000B5927 File Offset: 0x000B3B27
		public FCachedAnimRelevancyData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x000B5932 File Offset: 0x000B3B32
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedAnimRelevancyData(Pointer, false, true);
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x000B593C File Offset: 0x000B3B3C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedAnimRelevancyData(Pointer, MemoryOwner);
		}

		// Token: 0x04003CB4 RID: 15540
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CachedAnimRelevancyData";

		// Token: 0x04003CB5 RID: 15541
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CB6 RID: 15542
		internal static int __PropertyOffset_StateMachineName;

		// Token: 0x04003CB7 RID: 15543
		internal static int __PropertyOffset_StateName;
	}
}
