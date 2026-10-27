using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008FF RID: 2303
	[UnrealObjectPath("/Script/Engine.CachedAnimAssetPlayerData")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCachedAnimAssetPlayerData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E6D RID: 32365 RVA: 0x000B57B5 File Offset: 0x000B39B5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedAnimAssetPlayerData._ScriptStructPtr != 0) ? FCachedAnimAssetPlayerData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CachedAnimAssetPlayerData", ref FCachedAnimAssetPlayerData._ScriptStructPtr);
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06007E6E RID: 32366 RVA: 0x000B57D9 File Offset: 0x000B39D9
		// (set) Token: 0x06007E6F RID: 32367 RVA: 0x000B57ED File Offset: 0x000B39ED
		public unsafe FName StateMachineName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedAnimAssetPlayerData.__PropertyOffset_StateMachineName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedAnimAssetPlayerData.__PropertyOffset_StateMachineName) = value;
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06007E70 RID: 32368 RVA: 0x000B5802 File Offset: 0x000B3A02
		// (set) Token: 0x06007E71 RID: 32369 RVA: 0x000B5816 File Offset: 0x000B3A16
		public unsafe FName StateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedAnimAssetPlayerData.__PropertyOffset_StateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedAnimAssetPlayerData.__PropertyOffset_StateName) = value;
			}
		}

		// Token: 0x06007E72 RID: 32370 RVA: 0x000B582B File Offset: 0x000B3A2B
		public FCachedAnimAssetPlayerData()
		{
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x000B5833 File Offset: 0x000B3A33
		public FCachedAnimAssetPlayerData(FName StateMachineName, FName StateName)
		{
			this.StateMachineName = StateMachineName;
			this.StateName = StateName;
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x000B5849 File Offset: 0x000B3A49
		protected override IntPtr GetUStructPtr()
		{
			return FCachedAnimAssetPlayerData.StaticStruct();
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x000B5855 File Offset: 0x000B3A55
		[NullableContext(2)]
		public FCachedAnimAssetPlayerData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x000B585F File Offset: 0x000B3A5F
		public FCachedAnimAssetPlayerData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x000B586A File Offset: 0x000B3A6A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedAnimAssetPlayerData(Pointer, false, true);
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x000B5874 File Offset: 0x000B3A74
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedAnimAssetPlayerData(Pointer, MemoryOwner);
		}

		// Token: 0x04003CB0 RID: 15536
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CachedAnimAssetPlayerData";

		// Token: 0x04003CB1 RID: 15537
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CB2 RID: 15538
		internal static int __PropertyOffset_StateMachineName;

		// Token: 0x04003CB3 RID: 15539
		internal static int __PropertyOffset_StateName;
	}
}
