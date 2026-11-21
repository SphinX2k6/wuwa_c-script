using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200039F RID: 927
	[UnrealObjectPath("/Script/KuroGamePartition.GamePartitionObject")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FGamePartitionObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005BE2 RID: 23522 RVA: 0x00081719 File Offset: 0x0007F919
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGamePartitionObject._ScriptStructPtr != 0) ? FGamePartitionObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGamePartition.GamePartitionObject", ref FGamePartitionObject._ScriptStructPtr);
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06005BE3 RID: 23523 RVA: 0x0008173D File Offset: 0x0007F93D
		// (set) Token: 0x06005BE4 RID: 23524 RVA: 0x00081751 File Offset: 0x0007F951
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

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06005BE5 RID: 23525 RVA: 0x00081766 File Offset: 0x0007F966
		// (set) Token: 0x06005BE6 RID: 23526 RVA: 0x0008177A File Offset: 0x0007F97A
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

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x06005BE7 RID: 23527 RVA: 0x0008178F File Offset: 0x0007F98F
		// (set) Token: 0x06005BE8 RID: 23528 RVA: 0x000817A3 File Offset: 0x0007F9A3
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

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x06005BE9 RID: 23529 RVA: 0x000817B8 File Offset: 0x0007F9B8
		// (set) Token: 0x06005BEA RID: 23530 RVA: 0x000817C8 File Offset: 0x0007F9C8
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

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x06005BEB RID: 23531 RVA: 0x000817D9 File Offset: 0x0007F9D9
		// (set) Token: 0x06005BEC RID: 23532 RVA: 0x000817E9 File Offset: 0x0007F9E9
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

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06005BED RID: 23533 RVA: 0x000817FA File Offset: 0x0007F9FA
		// (set) Token: 0x06005BEE RID: 23534 RVA: 0x0008180A File Offset: 0x0007FA0A
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

		// Token: 0x06005BEF RID: 23535 RVA: 0x0008181B File Offset: 0x0007FA1B
		public FGamePartitionObject()
		{
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x00081823 File Offset: 0x0007FA23
		protected override IntPtr GetUStructPtr()
		{
			return FGamePartitionObject.StaticStruct();
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x0008182F File Offset: 0x0007FA2F
		[NullableContext(2)]
		public FGamePartitionObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x00081839 File Offset: 0x0007FA39
		public FGamePartitionObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x00081844 File Offset: 0x0007FA44
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGamePartitionObject(Pointer, false, true);
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x0008184E File Offset: 0x0007FA4E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGamePartitionObject(Pointer, MemoryOwner);
		}

		// Token: 0x0400263C RID: 9788
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGamePartition.GamePartitionObject";

		// Token: 0x0400263D RID: 9789
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400263E RID: 9790
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400263F RID: 9791
		internal static int __PropertyOffset_Location;

		// Token: 0x04002640 RID: 9792
		internal static int __PropertyOffset_Bounds;

		// Token: 0x04002641 RID: 9793
		internal static int __PropertyOffset_ObjectID;

		// Token: 0x04002642 RID: 9794
		internal static int __PropertyOffset_Type;

		// Token: 0x04002643 RID: 9795
		internal static int __PropertyOffset_SubType;
	}
}
