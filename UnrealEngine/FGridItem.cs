using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017E7 RID: 6119
	[UnrealObjectPath("/Script/KuroCrowdAi.GridItem")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGridItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016958 RID: 92504 RVA: 0x0020F5BB File Offset: 0x0020D7BB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGridItem._ScriptStructPtr != 0) ? FGridItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCrowdAi.GridItem", ref FGridItem._ScriptStructPtr);
		}

		// Token: 0x17005B40 RID: 23360
		// (get) Token: 0x06016959 RID: 92505 RVA: 0x0020F5DF File Offset: 0x0020D7DF
		// (set) Token: 0x0601695A RID: 92506 RVA: 0x0020F5EF File Offset: 0x0020D7EF
		public unsafe int Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGridItem.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGridItem.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x17005B41 RID: 23361
		// (get) Token: 0x0601695B RID: 92507 RVA: 0x0020F600 File Offset: 0x0020D800
		// (set) Token: 0x0601695C RID: 92508 RVA: 0x0020F614 File Offset: 0x0020D814
		public unsafe FBox BoundBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGridItem.__PropertyOffset_BoundBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGridItem.__PropertyOffset_BoundBox) = value;
			}
		}

		// Token: 0x0601695D RID: 92509 RVA: 0x0020F629 File Offset: 0x0020D829
		public FGridItem()
		{
		}

		// Token: 0x0601695E RID: 92510 RVA: 0x0020F631 File Offset: 0x0020D831
		public FGridItem(int Key, FBox BoundBox)
		{
			this.Key = Key;
			this.BoundBox = BoundBox;
		}

		// Token: 0x0601695F RID: 92511 RVA: 0x0020F647 File Offset: 0x0020D847
		protected override IntPtr GetUStructPtr()
		{
			return FGridItem.StaticStruct();
		}

		// Token: 0x06016960 RID: 92512 RVA: 0x0020F653 File Offset: 0x0020D853
		[NullableContext(2)]
		public FGridItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016961 RID: 92513 RVA: 0x0020F65D File Offset: 0x0020D85D
		public FGridItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016962 RID: 92514 RVA: 0x0020F668 File Offset: 0x0020D868
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGridItem(Pointer, false, true);
		}

		// Token: 0x06016963 RID: 92515 RVA: 0x0020F672 File Offset: 0x0020D872
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGridItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400C44B RID: 50251
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCrowdAi.GridItem";

		// Token: 0x0400C44C RID: 50252
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C44D RID: 50253
		internal static int __PropertyOffset_Key;

		// Token: 0x0400C44E RID: 50254
		internal static int __PropertyOffset_BoundBox;
	}
}
