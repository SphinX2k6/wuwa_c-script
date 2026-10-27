using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001A9 RID: 425
	[UnrealObjectPath("/Script/AIModule.EnvQueryResult")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FEnvQueryResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060019FD RID: 6653 RVA: 0x0002688A File Offset: 0x00024A8A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEnvQueryResult._ScriptStructPtr != 0) ? FEnvQueryResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.EnvQueryResult", ref FEnvQueryResult._ScriptStructPtr);
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x000268AE File Offset: 0x00024AAE
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x000268C2 File Offset: 0x00024AC2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryItemType> ItemType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvQueryResult.__PropertyOffset_ItemType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FEnvQueryResult.__PropertyOffset_ItemType) = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x000268D7 File Offset: 0x00024AD7
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x000268E7 File Offset: 0x00024AE7
		public unsafe int OptionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvQueryResult.__PropertyOffset_OptionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvQueryResult.__PropertyOffset_OptionIndex) = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x000268F8 File Offset: 0x00024AF8
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x00026908 File Offset: 0x00024B08
		public unsafe int QueryID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvQueryResult.__PropertyOffset_QueryID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvQueryResult.__PropertyOffset_QueryID) = value;
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00026919 File Offset: 0x00024B19
		public FEnvQueryResult()
		{
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00026921 File Offset: 0x00024B21
		public FEnvQueryResult([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UEnvQueryItemType> ItemType, int OptionIndex, int QueryID)
		{
			this.ItemType = ItemType;
			this.OptionIndex = OptionIndex;
			this.QueryID = QueryID;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0002693E File Offset: 0x00024B3E
		protected override IntPtr GetUStructPtr()
		{
			return FEnvQueryResult.StaticStruct();
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0002694A File Offset: 0x00024B4A
		[NullableContext(2)]
		public FEnvQueryResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00026954 File Offset: 0x00024B54
		public FEnvQueryResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0002695F File Offset: 0x00024B5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEnvQueryResult(Pointer, false, true);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00026969 File Offset: 0x00024B69
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEnvQueryResult(Pointer, MemoryOwner);
		}

		// Token: 0x040007B6 RID: 1974
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.EnvQueryResult";

		// Token: 0x040007B7 RID: 1975
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040007B8 RID: 1976
		internal static int __PropertyOffset_ItemType;

		// Token: 0x040007B9 RID: 1977
		internal static int __PropertyOffset_OptionIndex;

		// Token: 0x040007BA RID: 1978
		internal static int __PropertyOffset_QueryID;
	}
}
