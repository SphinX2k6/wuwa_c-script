using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001873 RID: 6259
	[UnrealObjectPath("/Script/KuroGamePartition.GamePartitionObject")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FGamePartitionObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060170CC RID: 94412 RVA: 0x002196BA File Offset: 0x002178BA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGamePartitionObject._ScriptStructPtr != 0) ? FGamePartitionObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGamePartition.GamePartitionObject", ref FGamePartitionObject._ScriptStructPtr);
		}

		// Token: 0x17005CAE RID: 23726
		// (get) Token: 0x060170CD RID: 94413 RVA: 0x002196DE File Offset: 0x002178DE
		// (set) Token: 0x060170CE RID: 94414 RVA: 0x002196F2 File Offset: 0x002178F2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> Actor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_Actor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_Actor) = value;
			}
		}

		// Token: 0x17005CAF RID: 23727
		// (get) Token: 0x060170CF RID: 94415 RVA: 0x00219707 File Offset: 0x00217907
		// (set) Token: 0x060170D0 RID: 94416 RVA: 0x0021971B File Offset: 0x0021791B
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17005CB0 RID: 23728
		// (get) Token: 0x060170D1 RID: 94417 RVA: 0x00219730 File Offset: 0x00217930
		// (set) Token: 0x060170D2 RID: 94418 RVA: 0x00219744 File Offset: 0x00217944
		public unsafe FBox Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x17005CB1 RID: 23729
		// (get) Token: 0x060170D3 RID: 94419 RVA: 0x00219759 File Offset: 0x00217959
		// (set) Token: 0x060170D4 RID: 94420 RVA: 0x00219769 File Offset: 0x00217969
		public unsafe int ObjectID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_ObjectID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_ObjectID) = value;
			}
		}

		// Token: 0x17005CB2 RID: 23730
		// (get) Token: 0x060170D5 RID: 94421 RVA: 0x0021977A File Offset: 0x0021797A
		// (set) Token: 0x060170D6 RID: 94422 RVA: 0x0021978A File Offset: 0x0021798A
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17005CB3 RID: 23731
		// (get) Token: 0x060170D7 RID: 94423 RVA: 0x0021979B File Offset: 0x0021799B
		// (set) Token: 0x060170D8 RID: 94424 RVA: 0x002197AB File Offset: 0x002179AB
		public unsafe int SubType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_SubType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGamePartitionObject.__PropertyOffset_SubType) = value;
			}
		}

		// Token: 0x060170D9 RID: 94425 RVA: 0x002197BC File Offset: 0x002179BC
		public FGamePartitionObject()
		{
		}

		// Token: 0x060170DA RID: 94426 RVA: 0x002197C4 File Offset: 0x002179C4
		public FGamePartitionObject([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> Actor, FVectorDouble Location, FBox Bounds, int ObjectID, int Type, int SubType)
		{
			this.Actor = Actor;
			this.Location = Location;
			this.Bounds = Bounds;
			this.ObjectID = ObjectID;
			this.Type = Type;
			this.SubType = SubType;
		}

		// Token: 0x060170DB RID: 94427 RVA: 0x002197F9 File Offset: 0x002179F9
		protected override IntPtr GetUStructPtr()
		{
			return FGamePartitionObject.StaticStruct();
		}

		// Token: 0x060170DC RID: 94428 RVA: 0x00219805 File Offset: 0x00217A05
		[NullableContext(2)]
		public FGamePartitionObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060170DD RID: 94429 RVA: 0x0021980F File Offset: 0x00217A0F
		public FGamePartitionObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060170DE RID: 94430 RVA: 0x0021981A File Offset: 0x00217A1A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGamePartitionObject(Pointer, false, true);
		}

		// Token: 0x060170DF RID: 94431 RVA: 0x00219824 File Offset: 0x00217A24
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGamePartitionObject(Pointer, MemoryOwner);
		}

		// Token: 0x0400C81F RID: 51231
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGamePartition.GamePartitionObject";

		// Token: 0x0400C820 RID: 51232
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C821 RID: 51233
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400C822 RID: 51234
		internal static int __PropertyOffset_Location;

		// Token: 0x0400C823 RID: 51235
		internal static int __PropertyOffset_Bounds;

		// Token: 0x0400C824 RID: 51236
		internal static int __PropertyOffset_ObjectID;

		// Token: 0x0400C825 RID: 51237
		internal static int __PropertyOffset_Type;

		// Token: 0x0400C826 RID: 51238
		internal static int __PropertyOffset_SubType;
	}
}
