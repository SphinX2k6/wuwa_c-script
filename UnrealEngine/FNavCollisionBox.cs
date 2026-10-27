using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002486 RID: 9350
	[UnrealObjectPath("/Script/NavigationSystem.NavCollisionBox")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNavCollisionBox : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022F82 RID: 143234 RVA: 0x0033B405 File Offset: 0x00339605
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavCollisionBox._ScriptStructPtr != 0) ? FNavCollisionBox._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.NavCollisionBox", ref FNavCollisionBox._ScriptStructPtr);
		}

		// Token: 0x17008653 RID: 34387
		// (get) Token: 0x06022F83 RID: 143235 RVA: 0x0033B429 File Offset: 0x00339629
		// (set) Token: 0x06022F84 RID: 143236 RVA: 0x0033B43D File Offset: 0x0033963D
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavCollisionBox.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavCollisionBox.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17008654 RID: 34388
		// (get) Token: 0x06022F85 RID: 143237 RVA: 0x0033B452 File Offset: 0x00339652
		// (set) Token: 0x06022F86 RID: 143238 RVA: 0x0033B466 File Offset: 0x00339666
		public unsafe FVector Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavCollisionBox.__PropertyOffset_Extent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavCollisionBox.__PropertyOffset_Extent) = value;
			}
		}

		// Token: 0x06022F87 RID: 143239 RVA: 0x0033B47B File Offset: 0x0033967B
		public FNavCollisionBox()
		{
		}

		// Token: 0x06022F88 RID: 143240 RVA: 0x0033B483 File Offset: 0x00339683
		public FNavCollisionBox(FVector Offset, FVector Extent)
		{
			this.Offset = Offset;
			this.Extent = Extent;
		}

		// Token: 0x06022F89 RID: 143241 RVA: 0x0033B499 File Offset: 0x00339699
		protected override IntPtr GetUStructPtr()
		{
			return FNavCollisionBox.StaticStruct();
		}

		// Token: 0x06022F8A RID: 143242 RVA: 0x0033B4A5 File Offset: 0x003396A5
		[NullableContext(2)]
		public FNavCollisionBox(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022F8B RID: 143243 RVA: 0x0033B4AF File Offset: 0x003396AF
		public FNavCollisionBox(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022F8C RID: 143244 RVA: 0x0033B4BA File Offset: 0x003396BA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavCollisionBox(Pointer, false, true);
		}

		// Token: 0x06022F8D RID: 143245 RVA: 0x0033B4C4 File Offset: 0x003396C4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavCollisionBox(Pointer, MemoryOwner);
		}

		// Token: 0x04012ACB RID: 76491
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavCollisionBox";

		// Token: 0x04012ACC RID: 76492
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012ACD RID: 76493
		internal static int __PropertyOffset_Offset;

		// Token: 0x04012ACE RID: 76494
		internal static int __PropertyOffset_Extent;
	}
}
